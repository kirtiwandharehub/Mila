TextEditor textEditor = new();
MementoHistory mementoHistory = new();

textEditor.SetText("How to make ice cream !!");
mementoHistory.Add(textEditor.Save());

textEditor.SetText("Ingredients");
textEditor.MarkSaved();
mementoHistory.Add(textEditor.Save());

textEditor.SetCursorPosition(0);

Console.WriteLine("---------Current Text Editor----------");
Console.WriteLine(textEditor);

// Undo
textEditor.Restore(mementoHistory.Get());
Console.WriteLine("---------First Undo----------");
Console.WriteLine(textEditor);

textEditor.Restore(mementoHistory.Get());
Console.WriteLine("---------Second Undo----------");
Console.WriteLine(textEditor);