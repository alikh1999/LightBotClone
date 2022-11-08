using LogiBotClone.Runtime.Commands;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Command
{
    public class CommandView : MonoBehaviour, ICommand
    {
        public Button Button => _Button;
        public GameObject GameObject => gameObject;
        public Commands.ICommand Command => command;

        [SerializeField]
        private Button _Button;
        
        protected virtual Commands.ICommand command => new Move();
    }
}