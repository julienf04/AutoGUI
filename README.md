# Introduction
(Only windows) Set keys or Unicode characters automatically by using Keyboard class. Set or get cursor position and do clicks automatically by using Cursor class

It uses WINAPI to control cursor and keyboard input.

# How to use it (code example)
```csharp
// Import AutoGUI library
using AutoGUI;

// Get the current position of the cursor and print its values
Point p = Cursor.GetPos();
System.Console.WriteLine(p); // Output: X=[X value], Y=[Y value]

// Move the cursor at the position X=100 Y=100 and click on it
Cursor.SetPos(100, 100);
Cursor.LeftClick();

// On any input field
Keyboard.Set("Hello world!");
```

# Previous requirements
- **NET 5 or later versions**
- **Windows 7 or later versions**

If you are in Visual Studio you probably have to set this in your project:
In your **project->Properties** you need to have **.NET 6 or later** in your **Target framework** , and you need to have **Windows 7.0 or later** in your **Target OS**

# Contact me
- Instagram: [https://www.instagram.com/julienf_04/](https://www.instagram.com/julienf_04/ "https://www.instagram.com/julienf_04/")
- Gmail: julian.fajardo000@gmail.com