using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCommandRealExample2
{
    //Concrete Commands
    public class DrawCircleCommand : ICommand
    {
        private Canvas _canvas;
        public DrawCircleCommand(Canvas canvas)
        {
            _canvas = canvas;
        }
        public void Execute()
        {
            _canvas.DrawCircle();
        }
        public void Undo()
        {
            _canvas.RemoveCircle();
        }
    }
}
