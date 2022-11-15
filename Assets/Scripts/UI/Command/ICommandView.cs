using System;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Command
{
    public interface ICommandView
    {
        event Action ButtonClicked;
        
        GameObject GameObject
        {
            get;
        }
    }
}