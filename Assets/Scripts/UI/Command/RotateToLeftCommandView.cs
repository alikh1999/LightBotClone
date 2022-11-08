namespace LogiBotClone.Runtime.UI.Command
{
    public class RotateToLeftCommandView : CommandView
    {
        protected override Commands.ICommand command => new Commands.RotateToLeft();
    }
}