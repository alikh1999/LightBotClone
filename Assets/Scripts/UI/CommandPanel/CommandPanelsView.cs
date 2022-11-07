using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public class CommandPanelsView : MonoBehaviour, ICommandPanelsView
    {
        public IReadOnlyList<Button> AddCommandButtons { get; }
        public void AddCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}