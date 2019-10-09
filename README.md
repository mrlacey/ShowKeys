# ShowKeys

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
![Works with Visual Studio 2019](https://img.shields.io/static/v1.svg?label=VS&message=2019&color=5F2E96)

Show the default keyboard shortcuts on screen when comon commands are invoked.

Intended for use during code demos or presentations to help the audience see what you're typing.

Works with

- Back Tab (Shift+Tab)
- Copy (Ctrl+C)
- Cut (Ctrl+X)
- Delete (Delete)
- Escape (Escape)
- Go To Definition (F12)
- Invoke Quick Info (Ctrl+K, Ctrl+I)
- Left (Left Arrow)
- Move Selected Lines Down (Alt+Down Arrow)
- Move Selected Lines Up (Alt+Up Arrow)
- Page Down (PgDown)
- Page Up (PgUp)
- Paste (Ctrl+V)
- Redo (Ctrl+Y)
- Rename (Ctrl+R, Ctrl+R)
- Return (Enter)
- Right (Right Arrow)
- Save (Ctrl+S)
- Select All (Ctrl+A)
- Tab (Tab)
- Undo (Ctrl+Z)
- View Code (F7)
- View Form Designer (Shift+F7)

For a list of all default shortcuts see the list on [docs.microsoft.com](https://docs.microsoft.com/en-us/visualstudio/ide/default-keyboard-shortcuts-in-visual-studio?view=vs-2019).

## FAQs

**Why are so few commands supported?**
Only those commands that are exposed via by Visual Studio to the extensibility model are shown. Sorry.

**Why are the default shortcuts shown rather than what was pressed?**
The purpose of displaying the keys is to help anyone viewing to understand what you did. By showing the default shortcut combinations it is hoped that this will enable others to also use the shortcuts.

**Why are some commands only shown for some file types?**
This is a limitation of Visual Studio extensibility. If you have specific examples of commands that don't work for specific file types, please raise an issue and I'll investigate if it's possible to do anything about it.

<!--

The following commands should work but don't because of a probable VS bug.

- Duplicate Selection (Ctrl+D)
- Insert Snippet (Ctrl+K, Ctrl+X)
- Comment Selection (Ctrl+K, Ctrl+C)
- Uncomment Selection (Ctrl+K, Ctrl+U)
- Format Document (Ctrl+K, Ctrl+D)
- Format Selection (Ctrl+K, Ctrl+F)
- Surround With (Ctrl+K, Ctrl+S)

-->
