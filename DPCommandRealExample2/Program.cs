using DPCommandRealExample2;

Canvas canvas = new Canvas();
GraphicsEditor editor = new GraphicsEditor();
ICommand drawCircle = new DrawCircleCommand(canvas);
ICommand drawRectangle = new DrawRectangleCommand(canvas);
editor.ExecuteCommand(drawCircle);
editor.ExecuteCommand(drawRectangle);
// Undo last action (Remove rectangle)
editor.UndoLastCommand();
// Undo previous action (Remove circle)
editor.UndoLastCommand();
Console.ReadKey();