using LogiBotClone.Runtime.Player;
using LogiBotClone.Runtime.UI.Command;
using LogiBotClone.Runtime.UI.CommandChooser;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public class CommandPanelsPresenter : MonoBehaviour
    {
        [SerializeField] 
        private CommandChooserPresenter _CommandChooserPresenter;
        [SerializeField] 
        private CommandViewFactory _factory;
        [SerializeField] 
        private Executor _executor;

        private ICommandPanelsView _view;
        private int _commandPanelIndex;
        
        private void OnEnable()
        {
            _view ??= GetComponentInChildren<ICommandPanelsView>(true);
            
            
            foreach (var panelView in _view.PanelViews)
            {
                panelView.Button.onClick.AddListener(() => OnPanelClicked(panelView.CommandPanelIndex));
            }

            _CommandChooserPresenter.CommandChose += OnCommandChose;
            _CommandChooserPresenter.ExecuteAllCommandsButtonClicked += OnExecuteAllCommandsButtonClicked;
        }

        private void OnDisable()
        {
            foreach (var panelView in _view.PanelViews)
            {
                panelView.Button.onClick.RemoveAllListeners();
            }
            
            _CommandChooserPresenter.CommandChose -= OnCommandChose;
            _CommandChooserPresenter.ExecuteAllCommandsButtonClicked -= OnExecuteAllCommandsButtonClicked;
        }

        private void OnPanelClicked(int panelIndex)
        {
            _commandPanelIndex = panelIndex;
        }

        private void OnCommandChose(ICommandView commandView)
        {
            var commandView1 = _factory.Create(commandView.GameObject);
            _view.AddCommand(commandView1, _commandPanelIndex);
            
            commandView1.Button.onClick.AddListener(() => OnCommandRemove(commandView1));
        }

        private void OnExecuteAllCommandsButtonClicked()
        {
            foreach (var commandView in _view.PanelViews[0].CommandViews)
            {
                ProcessCommandView(commandView);
            }
        }

        private void ProcessCommandView(ICommandView commandView)
        {
            switch (commandView)
            {
                case LogiBotClone.Runtime.UI.Command.ICommand commandView1:
                    _executor.Execute(commandView1.Command);
                    break;
                case ICommandList commandsContainer:
                {
                    foreach (var command in commandsContainer.Commands)
                    {
                        _executor.Execute(command.Command);
                    }

                    break;
                }
            }
        }

        private void OnCommandRemove(ICommandView commandView)
        {
            commandView.Button.onClick.RemoveAllListeners();
            
            Destroy(commandView.GameObject);
        }
    }
}