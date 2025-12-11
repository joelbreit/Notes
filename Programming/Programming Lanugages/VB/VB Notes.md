# Visual Basic (VB) Notes

> These notes focus on VB.NET, which may differ from classic VB (VB6) or VBScript

## Vibe

Visual Basic (VB) is a legacy programming language developed by Microsoft. It was released in 1991 as a dialect of BASIC to be easy to learn and use for Windows app development. Since 2002, VB has been part of .NET as VB.NET. It acts very similar to C#.

- Like most modern languages: imperative, procedural, object-oriented
- Like C#, it is compiled to Intermediate Language (IL) and runs on the Common Language Runtime (CLR)
- Uses syntax with more English-like keywords and constructs compared to C-style languages
  - `End If` instead of `}`
  - No () in control flow statements

## History

1991: Original release as part of Visual Studio 1.0
- Evolved from earlier versions of BASIC
- Designed for easy development of Windows apps
1998: VB 6.0 released
- Peak popularity
2002: VB.NET introduced with .NET Framework 1.0 and C# 1.0
- Breaking changes from VB6
- Kind of a distinct language from classic VB
2017: Microsoft announced VB.NET would only get bug fixes, no new features
2020: VB.NET capped at .NET Framework 4.8 - won't move to modern .NET (6+)

## Hello World

```vb
```

### Notes

- `Imports System`
  - Simple things like `Console.WriteLine()` (print) historically needed the `System` namespace imported or to be fully qualified as `System.Console.WriteLine()`
  - .NET 6+ have implicit global imports enabled by default
- The entry point is any `Sub Main()` - the compiler finds it automatically
  - Must be a Sub, not a Function

## Key Words

- **`Module`**: *A module is a container for functions, subroutines, and variables. It is similar to a class, but it cannot be instantiated.*
- **`Sub`**: short for "subroutine"; a procedure that does not return a value
- **`Function`**: a procedure that returns a value
- **`Return`**: used to exit a procedure and optionally return a value
- **`Dim`**: short for "dimension"; used to declare variables
- **`As`**: used to specify the data type of a variable or the return type of a function
- **`End`**: used to terminate a block of code, such as `End Sub`, `End Function`, `End If`, etc.
- **`If...Then...Else`**: *conditional statement*

## Console App Features

- `Console.WriteLine()` - prints text to the console with a newline
- `Console.Write()` - prints text to the console without a newline
- `Console.ReadLine()` - reads a line of text from the console input, returns it as a string
  - Can also be used to keep a console window open until the user presses Enter
- `Console.ReadKey()` - reads a single key press from the console input, returns a `ConsoleKeyInfo` object
- `Console.Clear()` - clears the console screen
- `Sub Main(args As String())` - the entry point of a console application, where `args` is an array of command-line arguments passed to the program
- `Environment.GetCommandLineArgs()` - retrieves an array of command-line arguments passed to the program

## Flashcards

1. **procedure**: term in VB that encompasses both subroutines (`Sub`) and functions (`Function`)
2. 

## Questions

- [ ] What global imports enabled by default?
- [ ] Why `<ImplicitUsings>enable</ImplicitUsings>` not needed for me
  - [ ] Only for old .NET?
  - [ ] True by default in new .NET?
- [ ] Does everything need to be in a Class
- [ ] `Environment.GetCommandLineArgs()` for getting command line args independent of `Sub Main(args As String())`?
- [x] Interpreted?
- [ ] Common Language Runtime (CLR)
- [ ] History
- [ ] Order of modifiers for
  - [ ] Procedures
  - [ ] Variables
  - [ ] Classes
  - [ ] Other?