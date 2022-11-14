using UnityEngine;

namespace LogiBotClone.Runtime.Core.Data
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Statics", fileName ="Statics" )]
    public class Statics : ScriptableObject
    {
        public int LevelsCount => _levelsCount;

        [SerializeField] 
        private int _levelsCount;
    }
}