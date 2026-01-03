using System.Data.Common;

public class TextEditor
{
    private string text;
    private int cursorPosition;
    private bool isDirty;

    public TextEditor()
    {
        text = "";
        cursorPosition = 0;
        isDirty = false;
    }

    public void SetText(string text)
    {
        this.text = text;
        cursorPosition = text.Length;
        isDirty = true;
    }

    public void SetCursorPosition(int cursorPosition)
    {
        if (cursorPosition < 0 || cursorPosition > text.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(cursorPosition));
        }
        this.cursorPosition = cursorPosition;
    }

    public void MarkSaved() => isDirty = false;

    public override string ToString() => $"Text: {text} Cursor: {cursorPosition} Dirty: {isDirty}";

    private sealed class TextEditorMemento : IMemento
    {
        public string Text { get; private set;}
        public int CursorPosition { get; private set;}
        public bool IsDirty { get; private set;}

        public TextEditorMemento(string text, int cursorPosition, bool isDirty)
        {
            Text = text;
            CursorPosition = cursorPosition;
            IsDirty = isDirty;
        }
    }

    public IMemento Save()
    {
        return new TextEditorMemento(text, cursorPosition, isDirty);
    }

    public void Restore(IMemento memento)
    {
        if (memento is not TextEditorMemento textEditorSnapshot)
        {
            throw new InvalidCastException("Should be TextEditorMemento");
        }

        text = textEditorSnapshot.Text;
        cursorPosition = textEditorSnapshot.CursorPosition;
        isDirty = textEditorSnapshot.IsDirty;
    }
}