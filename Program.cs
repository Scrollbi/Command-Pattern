using Command_Pattern;

public interface ICommand
{
    void Execute();
    void Undo();
}

public class Program
{
    public static void Main(string[] args)
    {
        TextEditor textEditor = new TextEditor();

        ICommand text1 = new InsertTextCommand(textEditor, "123 ");
        textEditor.ExecuteCommand(text1);

        ICommand text2 = new InsertTextCommand(textEditor, "456789");
        textEditor.ExecuteCommand(text2);

        ICommand delete = new DeleteTextCommand(textEditor, 6);
        textEditor.ExecuteCommand(delete);

        textEditor.Undo();
        textEditor.Undo();
        textEditor.Undo();
    }
}