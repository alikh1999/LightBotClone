using LogiBotClone.Runtime.Core.Commands;

namespace LogiBotClone.Runtime.UI.Command
{
    public class RotateToRightCommandView : CommandView
    {
        protected override global::LogiBotClone.Runtime.Core.Commands.ICommand command => new RotateToRight();
    }
}