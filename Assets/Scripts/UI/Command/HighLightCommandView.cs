using LogiBotClone.Runtime.Core.Commands;

namespace LogiBotClone.Runtime.UI.Command
{
    public class HighLightCommandView : CommandView
    {
        protected override global::LogiBotClone.Runtime.Core.Commands.ICommand command => new HighLight();
    }
}