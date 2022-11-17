using UnityEngine;

namespace LogiBotClone.Runtime.Core.World
{
    public class TileRender : MonoBehaviour
    {
        private TileGoal _TileGoal;
        
        [SerializeField]
        private SpriteRenderer _spriteRenderer;
        [SerializeField] 
        private Color _hightLightColor;

        private void Awake()
        {
            _TileGoal = GetComponent<TileGoal>();
        }

        private void Start()
        {
            _TileGoal.TileHighLighted += () => ChangeColor(_hightLightColor);
        }

        private void OnDestroy()
        {
            _TileGoal.TileHighLighted -= () => ChangeColor(_hightLightColor);
        }

        private void ChangeColor(Color color)
        {
            _spriteRenderer.color = color;
        }
    }
}