using LogiBotClone.Runtime.UI.Command;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public class CommandViewFactory : MonoBehaviour
    {
        public ICommandView Create(GameObject gameObject)
        {
            var createdObject = Instantiate(gameObject);

            return createdObject.GetComponent<ICommandView>();
        }
    }
}