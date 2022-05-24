// Code example
using AutoGUI;

// Get asfinaskjca
Point p = Cursor.GetPos();
Console.WriteLine(p);

// Move the cursor at the position X=100 Y=100 and click on it
Cursor.SetPos(100, 100);
Cursor.LeftClick();


// On any input field
Keyboard.Set("Hello world!");