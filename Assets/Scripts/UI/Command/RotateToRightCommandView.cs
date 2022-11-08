using LogiBotClone.Runtime.Commands;

namespace LogiBotClone.Runtime.UI.Command
{
    public class RotateToRightCommandView : CommandView
    {
        protected override Commands.ICommand command => new RotateToRight();
    }
}