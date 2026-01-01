using System.Windows.Input;

public class VoiceController
{
    private Stack<ICommand> commands;

    public VoiceController()
    {
        commands = new Stack<ICommand>();
    }

    public void Submit(ICommand command)
    {   
        commands.Push(command);
        command.Execute();  
    }
}