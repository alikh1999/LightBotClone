using LogiBotClone.Runtime.Core.Data;
using LogiBotClone.Runtime.Core.Util;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.World
{
    public class Level
    {
        private int _levelCount;
        private int _levelNumber;
        
        public Level(int levelCount)
        {
            _levelCount = levelCount;
            
            _levelNumber = PlayerPrefs.HasKey(PlayerPrefKeys.LevelNumber) ? PlayerPrefs.GetInt(PlayerPrefKeys.LevelNumber) : 1;
        }
        
        public void ChangeLevel()
        {
            _levelNumber++;
            var nextSceneName = _levelNumber.ToString();

            if (_levelNumber >= _levelCount)
            {
                return;
            }
            
            PlayerPrefs.SetInt(PlayerPrefKeys.LevelNumber, _levelNumber);
            PlayerPrefs.Save();
            
            SceneLoader.Load(nextSceneName);
        }
    }
}