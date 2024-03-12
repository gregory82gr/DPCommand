using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCommandRealExample1
{
    //Concrete Commands
    public class PastaOrderCommand : ICommand
    {
        private Kitchen _kitchen;

        public PastaOrderCommand(Kitchen kitchen)
        {
            _kitchen = kitchen;
        }

        public void Execute()
        {
            _kitchen.PreparePasta();
        }
    }
}
