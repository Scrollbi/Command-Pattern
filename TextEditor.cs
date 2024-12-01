namespace Command_Pattern
{
    public class TextEditor
    {
        private string _text = string.Empty;
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void InsertText(string text)
        {
            _text += text;
            Console.WriteLine($"Text: {_text}");
        }

        public string DeleteText(int length)
        {
            if (length > _text.Length) length = _text.Length;
            string deletedText = _text[^length..]; 
            _text = _text.Remove(_text.Length - length);
            Console.WriteLine($"new text: {_text}");
            return deletedText;
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void Undo()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand command = _commandHistory.Pop();
                command.Undo();
            }
            else return;

        }
    }
}
