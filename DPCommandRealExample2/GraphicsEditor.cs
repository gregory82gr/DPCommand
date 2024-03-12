using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCommandRealExample2
{
    //Invoker - Graphics Editor
    public class GraphicsEditor
    {
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }
        public void UndoLastCommand()
        {
            if (_commandHistory.Any())
            {
                var lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
            }
        }
    }
}
