public class MacUIControlsFactory : IUIControlsFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox(); ;
    }
}