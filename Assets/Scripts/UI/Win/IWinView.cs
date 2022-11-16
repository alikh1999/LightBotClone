using System;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Win
{
    public interface IWinView
    {
        event Action NextLevelButtonPressed;
        void SetActive(bool activeState);
    }
}