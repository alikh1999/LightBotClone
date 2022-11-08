using LogiBotClone.Runtime.Commands;

namespace LogiBotClone.Runtime.UI.Command
{
    public class JumpCommandView : CommandView
    {
        protected override Commands.ICommand command => new Jump();
    }
}