namespace Command_Pattern
{
    public class InsertTextCommand : ICommand
    {
        private TextEditor _textEditor;
        private string _text;

        public InsertTextCommand(TextEditor textEditor, string text)
        {
            _textEditor = textEditor;
            _text = text;
        }

        public void Execute()
        {
            _textEditor.InsertText(_text);
        }

        public void Undo()
        {
            _textEditor.DeleteText(_text.Length);
        }
    }
}
