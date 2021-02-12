using System;
namespace Engine
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; private set; }
        public bool AddExtraNewLine { get; private set; }

        // MessageEventArgs constructor
        public MessageEventArgs(string message, bool addExtraNewLine)
        {
            Message = message;
            AddExtraNewLine = addExtraNewLine;
        } // End MessageEventArgs constructor
    }
}
