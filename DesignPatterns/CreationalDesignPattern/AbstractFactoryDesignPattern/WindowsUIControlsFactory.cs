public class WindowsUIControlsFactory : IUIControlsFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox(); ;
    }
}