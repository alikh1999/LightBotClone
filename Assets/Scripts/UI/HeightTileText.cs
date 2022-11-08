using System;
using LogiBotClone.Runtime.World;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI
{
    public class HeightTileText : MonoBehaviour
    {
        [SerializeField]
        private Text _Text;
        [SerializeField] 
        private Tile _Tile;

        private void Start()
        {
            _Text.text = _Tile.Height.ToString();
        }
    }
}