using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCommandRealExample1
{
    public class BurgerOrderCommand : ICommand
    {
        private Kitchen _kitchen;

        public BurgerOrderCommand(Kitchen kitchen)
        {
            _kitchen = kitchen;
        }

        public void Execute()
        {
            _kitchen.PrepareBurger();
        }
    }
}
