using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Win
{
    public class WinView : MonoBehaviour,IWinView
    {
        public Button NextLevelButton => _nextLevelButton;
        
        [SerializeField]
        private Canvas _canvas;
        [SerializeField]
        private Button _nextLevelButton;

        public void SetActive(bool activeState)
        {
            _canvas.enabled = activeState;
        }
    }
}