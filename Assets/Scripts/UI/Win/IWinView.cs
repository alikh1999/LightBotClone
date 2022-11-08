using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Win
{
    public interface IWinView
    {
        Button NextLevelButton
        {
            get;
        }
        void SetActive(bool activeState);
    }
}