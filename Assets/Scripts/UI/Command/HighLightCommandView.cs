using LogiBotClone.Runtime.Commands;

namespace LogiBotClone.Runtime.UI.Command
{
    public class HighLightCommandView : CommandView
    {
        protected override Commands.ICommand command => new HighLight();
    }
}