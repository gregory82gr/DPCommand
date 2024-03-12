using DPCommandRealExample1;

Kitchen kitchen = new Kitchen();

ICommand pastaOrder = new PastaOrderCommand(kitchen);
ICommand burgerOrder = new BurgerOrderCommand(kitchen);

Waiter waiter = new Waiter();

waiter.TakeOrder(pastaOrder);
waiter.TakeOrder(burgerOrder);

// Later, the waiter sends all orders to the kitchen
waiter.PlaceOrders();

Console.ReadKey();