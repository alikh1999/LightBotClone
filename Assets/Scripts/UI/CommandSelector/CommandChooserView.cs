using System.Collections.Generic;
using System.Linq;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandSelector
{
    public class CommandChooserView : MonoBehaviour, ICommandChooserView
    {
        public IReadOnlyList<ICommandView> Views => views;
        
        private List<ICommandView> views = new List<ICommandView>();

        private void Awake()
        {
            views = GetComponentsInChildren<ICommandView>(true).ToList();
        }
    }
}