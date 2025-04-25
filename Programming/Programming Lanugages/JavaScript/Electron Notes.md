# Electron

Electron is an open-source framework for building cross-platform desktop applications using web technologies like HTML, CSS, and JavaScript. It allows developers to create native applications for Windows, macOS, and Linux using a single codebase and uses a Chromium web browser and allows you to use native features of desktop operating systems.

Apps built with Electron include VSCode, Postman, Slack, Notion, Obsidian, and Spotify.

## Notes

Ctrl + R - Reload the app

Absoute paths:
- Use `path.join(__dirname, 'path/to/file')` to create paths relative to the current directory.
- Use `path.resolve(__dirname, 'path/to/file')` to create absolute paths.
- `${__dirname}`: Template literal to create a string with the current directory.

## Modules

### `app`

The `app` module controls the application's lifecycle and manages application-level events.

- `app.whenReady()`: A promise that resolves when Electron has finished initializing and is ready to create browser windows. This is where you typically create your main window.
- `app.quit()`: Quits the application
- `app.on(event, callback)`: Listens for application-level events. Common events include:
  - `ready`: Emitted when Electron has finished initializing.
  - `window-all-closed`: Emitted when all windows have been closed. On macOS, this is where you typically quit the app.
  - `activate`: Emitted when the application is activated (e.g., when the dock icon is clicked). This is where you typically create a new window if none are open.

### `BrowserWindow`

The `BrowserWindow` module is used to create and manage application windows.

- `new BrowserWindow(options)`: Creates a new browser window with the specified options. Common options include:
  - `width`: The width of the window.
  - `height`: The height of the window.
  - `icon`: The icon for the window.
  - `webPreferences`: An object that contains web-related preferences for the window, such as enabling Node.js integration or context isolation.

### `ipcMain` and `ipcRenderer`

The `ipcMain` and `ipcRenderer` modules are used for inter-process communication (IPC) between the main process and renderer processes.

- `ipcMain`: Used in the main process to listen for events sent from renderer processes and send responses back.
  - `ipcMain.on(channel, listener)`: Listens for events sent from the renderer process on the specified channel.
  - `ipcMain.handle(channel, listener)`: Listens for events sent from the renderer process and returns a promise that resolves with the result.
- `ipcRenderer`: Used in the renderer process to send events to the main process and listen for responses.
  - `ipcRenderer.send(channel, ...args)`: Sends an event to the main process on the specified channel.
  - `ipcRenderer.invoke(channel, ...args)`: Sends an event to the main process and returns a promise that resolves with the result.
  - `ipcRenderer.on(channel, listener)`: Listens for events sent from the main process on the specified channel.

### `dialog`

The `dialog` module is used to create native system dialogs, such as file open/save dialogs and message boxes.

- `dialog.showOpenDialog(options)`: Opens a file open dialog and returns the selected file paths.
- `dialog.showSaveDialog(options)`: Opens a file save dialog and returns the selected file path.
- `dialog.showMessageBox(options)`: Opens a message box with a specified message and buttons.

### `Menu` and `MenuItem`

The `Menu` and `MenuItem` modules are used to create application menus and context menus.

- `Menu.buildFromTemplate(template)`: Creates a new menu from a template array of menu items.
- `MenuItem`: Represents a single item in a menu. Common properties include:
  - `label`: The label for the menu item.
  - `click`: A function to be called when the menu item is clicked.
  - `submenu`: An array of sub-menu items.
  - `enabled`: A boolean indicating whether the menu item is enabled or disabled.
- `visible`: A boolean indicating whether the menu item is visible or hidden.
- `checked`: A boolean indicating whether the menu item is checked or unchecked.
- `type`: The type of menu item (e.g., "normal", "separator", "submenu").
- `role`: A predefined role for the menu item (e.g., "undo", "redo", "cut", "copy", "paste").
- `accelerator`: A string representing the keyboard shortcut for the menu item (e.g., "CmdOrCtrl+N").

