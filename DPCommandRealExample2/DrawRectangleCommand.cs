using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCommandRealExample2
{
    public class DrawRectangleCommand : ICommand
    {
        private Canvas _canvas;
        public DrawRectangleCommand(Canvas canvas)
        {
            _canvas = canvas;
        }
        public void Execute()
        {
            _canvas.DrawRectangle();
        }
        public void Undo()
        {
            _canvas.RemoveRectangle();
        }
    }
}
