using LogiBotClone.Runtime.UI.Command;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public class CommandViewFactory : MonoBehaviour
    {
        public ICommandView Create(GameObject gameObject, Transform parent)
        {
            var createdObject = Instantiate(gameObject, parent);

            return createdObject.GetComponent<ICommandView>();
        }
    }
}