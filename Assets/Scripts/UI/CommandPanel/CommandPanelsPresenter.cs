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

        private ICommandPanelsView _view;
        private int _commandPanelIndex;

        private void Awake()
        {
            _view = GetComponentInChildren<ICommandPanelsView>(true);
        }

        private void OnEnable()
        {
            foreach (var panelView in _view.PanelViews)
            {
                panelView.Button.onClick.AddListener(() => OnPanelClicked(panelView.CommandPanelIndex));
            }

            _CommandChooserPresenter.CommandChose += OnCommandChose;
        }

        private void OnDisable()
        {
            foreach (var panelView in _view.PanelViews)
            {
                panelView.Button.onClick.RemoveAllListeners();
            }
            
            _CommandChooserPresenter.CommandChose -= OnCommandChose;
        }

        private void OnPanelClicked(int panelIndex)
        {
            _commandPanelIndex = panelIndex;
        }

        private void OnCommandChose(ICommandView commandView)
        {
            var commandView1 = _factory.Create(commandView.GameObject);
            _view.AddCommand(commandView1, _commandPanelIndex);
            
            commandView1.Button.onClick.AddListener(() => OnCommandRemove(commandView));
        }

        private void OnCommandRemove(ICommandView commandView)
        {
            commandView.Button.onClick.RemoveAllListeners();
            
            Destroy(commandView.GameObject);
        }
    }
}