// Render windows UI
IUIControlsFactory windowsFactory = new WindowsUIControlsFactory();
Application app = new Application(windowsFactory);
app.Render();

Console.WriteLine("---------------------------");

// Render Mac UI
IUIControlsFactory macFactory = new MacUIControlsFactory();
app = new Application(macFactory);
app.Render();