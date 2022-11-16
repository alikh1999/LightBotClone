using System;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Win
{
    public class WinView : MonoBehaviour,IWinView
    {
        public event Action NextLevelButtonPressed;

        [SerializeField]
        private Canvas _canvas;
        [SerializeField]
        private Button _nextLevelButton;

        public void SetActive(bool activeState)
        {
            _canvas.enabled = activeState;
        }

        private void OnEnable()
        {
            _nextLevelButton.onClick.AddListener(OnNextButtonPressed);
        }

        private void OnDisable()
        {
            _nextLevelButton.onClick.RemoveListener(OnNextButtonPressed);
        }

        private void OnNextButtonPressed()
        {
            NextLevelButtonPressed?.Invoke();
        }
    }
}