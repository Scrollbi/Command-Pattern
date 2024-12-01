namespace Command_Pattern
{
    public class DeleteTextCommand : ICommand
    {
        private TextEditor _textEditor;
        private int _length;
        private string _deletedText;

        public DeleteTextCommand(TextEditor textEditor, int length)
        {
            _textEditor = textEditor;
            _length = length;
        }

        public void Execute()
        {
            _deletedText = _textEditor.DeleteText(_length);
        }

        public void Undo()
        {
            _textEditor.InsertText(_deletedText);
        }
    }
}
