# Introduction
(Only windows) Set keys or Unicode characters automatically by using Keyboard class. Set or get cursor position and do clicks automatically by using Cursor class

It uses WINAPI to control cursor and keyboard input.

# How to use it (code example)
```csharp
// Import AutoGUI library
using AutoGUI;

// Move the cursor at the position X=100 Y=100 and click on it
Cursor.SetPos(100, 850);
Cursor.LeftClick();

// On any input field
Keyboard.Set("Hello world!");
```

# Previous requirements
- NET 5 or later versions
- Windows 7 or later versions