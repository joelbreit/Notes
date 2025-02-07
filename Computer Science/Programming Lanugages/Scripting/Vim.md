# Vim

**Vim**
- Text editor for editing text files from within terminal applications
- Uses lots of keyboard shortcuts for quick editing with a keyboard
- Based on the vi (**Vi**sual editor) text editor (1976)
- Vim (**V**i **Im**proved) was created in 1991 with more features and improvements
- Open source and free to use

## Modes

- **Normal Mode**: Default mode for navigating and editing text

### Commands from Normal Mode

`i` or `a`: Enter **Insert Mode** (before or after the cursor)
`v`: Enter **Visual Mode** for selecting text
`V`: Enter **Visual Line Mode** for selecting lines
`R`: Enter **Replace Mode** for writing over text
`:`: Enter **Command Mode** for entering commands

`p`: Paste
`U`: Undo the last change


#### Navigation

`h`: Move left
`j`: Move down
`k`: Move up
`l`: Move right
`w`: Move forward one word
`b`: Move back one word
`e`: Move to the end of the word
`^`: Move to the beginning of the line
`$`: Move to the end of the line
`gg`: Move to the beginning of the file
- [number]`gg`: Move to a specific line number
`G`: Move to the end of the file
- [number]`G`: Move to a specific line number

#### Normal Mode Actions

`x`: Delete character under the cursor
`X`: Delete character before the cursor
`d`[navigation]: Delete text based on navigation
- `dd`: Delete the current line
- `dw`: Delete to the end of the word
`y`[navigation]: Yank (copy) text based on navigation
- `yy`: Yank the current line
- `yw`: Yank to the end of the word
`p`: Paste the last deleted or yanked text after the cursor
`P`: Paste the last deleted or yanked text before the cursor


#### Command Templates

[number] [navigation] - Navigate [number] times
- `3j`: Move down 3 lines
[number] [action] - Perform [action] [number] times
- `3w`: Move forward 3 words
[action] [navigation] - Perform [action] on [navigation]
- `d$`: Delete to the end of the line


- **Insert Mode**: Text editing mode entered with 'i' or 'a'
- **Visual Mode**: Text selection mode entered with 'v'
- **Visual Line Mode**: Text selection mode entered with 'Shift + v'
- **Command Mode**: Mode for entering commands with ':'
- **Ex Mode**: Mode for entering commands with ':' key and running them with 'Enter'
- **Replace Mode**: Text editing mode entered with 'R'
- **Visual Block Mode**: Text selection mode entered with 'Ctrl + v'
- **Select Mode**: Text selection mode entered with 'g' and 'v'

## Notes

Annoyances
- Only one undo level

Other Optons
- Emacs
- Nano
- Micro
- Helix
- Just use cli to open real editor
  - `code .`
  - `notepad .`

## Questions

Q: How do I cut a line from normal mode?
A: `dd`