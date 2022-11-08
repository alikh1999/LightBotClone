using System;
using LogiBotClone.Runtime.World;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI
{
    public class HeightTileText : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _Text;
        [SerializeField] 
        private Tile _Tile;

        private void Start()
        {
            _Text.text = _Tile.Height.ToString();
        }
    }
}