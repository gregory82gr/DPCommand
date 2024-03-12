// Create receiver, command, and invoker
using DPCommand;

Receiver receiver = new Receiver();
Command command = new ConcreteCommand(receiver);
Invoker invoker = new Invoker();
// Set and execute command
invoker.SetCommand(command);
invoker.ExecuteCommand();
// Wait for user
Console.ReadKey();
