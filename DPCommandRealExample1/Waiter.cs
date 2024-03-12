using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCommandRealExample1
{
    //Invoker - Waiter
    public class Waiter
    {
        private List<ICommand> _orders = new List<ICommand>();

        public void TakeOrder(ICommand orderCommand)
        {
            _orders.Add(orderCommand);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }
            _orders.Clear();
        }
    }
}
