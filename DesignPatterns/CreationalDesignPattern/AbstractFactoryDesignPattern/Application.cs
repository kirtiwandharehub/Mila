public class Application
{
    private IUIControlsFactory factory;
    private IButton button;
    private ICheckbox checkbox;

    public Application(IUIControlsFactory factory)
    {
        this.factory = factory;
        this.button = factory.CreateButton();
        this.checkbox = factory.CreateCheckbox();
    }

    public void Render()
    {
        button.Render();
        checkbox.Render();
    }
}