# PowerShell

Check version of Windows: `winver`

## Basic Commands

Outline:

1. Navigate to a directory
2. Show the current directory
3. Print
4. Show the contents of a directory
5. Show the contents of a file
6. Create a new file/directory
7. Delete a file/directory
8. Copy a file/directory
9. Move/Rename a file/directory
10. Change access/permissions of a file/directory
11. Pipe commands together

Commands:

1. **Navigate** - `Set-Location` or `cd`
   - `Set-Location <path>`
2. **Show Current Directory** - `Get-Location` or `pwd`
   - `Get-Location`
3. **Print** - `Write-Host` or `echo`
   - `Write-Host "Hello, World!"`
   - Print with color:
     - Add `-ForegroundColor <color>` or `-BackgroundColor <color>`
     - Example: `Write-Host "Hello, World!" -ForegroundColor Cyan`
   - *`echo` is an alias for `Write-Output` which does not support color
4. **Show Directory Contents** - `Get-ChildItem` or `ls`
   - `Get-ChildItem [path]`
   - `[path]` is optional; defaults to current directory
5. **Show File Contents** - `Get-Content` or `cat`
   - `Get-Content <file>`
6. **Create a New File/Directory** - `New-Item` or `ni` / `mkdir`
   - `New-Item <file_name>`
   - `New-Item <dir_name> -ItemType Directory`
7. **Delete a File/Directory** - `Remove-Item` or `rm`
   - `Remove-Item <file_name>`
   - `Remove-Item <dir_name> -Recurse`
8. **Copy a File/Directory** - `Copy-Item` or `cp`
   - `Copy-Item <source> <destination>`
9. **Move/Rename a File/Directory** - `Move-Item` or `mv`
   - `Move-Item <source> <destination>`
10. **Change Access/Permissions** - TODO
11. **Pipe Commands Together** - TODO

## More Commands

**Tee-Object** - `<command> | Tee-Object -FilePath <file_path>`
- Send output to both the console and a file at the same time.

**Tree** - TODO

**Get-History** - `Get-History` or `history` or `h`
- Show a list of previously executed commands in the current session.
- > Note: Only for the current session. To get history across sessions, you can use: `Get-Content (Get-PSReadLineOption).HistorySavePath`

**Set-Clipboard** - `<command> | Set-Clipboard`
- Copy the output of a command to the clipboard:

## Command Help

- `Get-Help <command>` - Get detailed help about a specific command
- `Get-Help <command> -Examples` - Get examples of how to use a specific command


## Notes About Paths

- Windows paths are case-insensitive
- Windows typically uses backslashes `\` in paths, but PowerShell accepts forward slashes `/` as well
- Paths can be absolute (starting from the root, e.g., `C:\Users\Joel`) or relative (relative to the current directory, e.g., `Documents\Notes`)
- You can use `~` to refer to your home directory (e.g., `~/Documents`). Your home directory is typically located at `C:\Users\<YourUsername>`.
- Root directories are denoted by a drive letter followed by a colon (e.g., `C:`). You can use `/` to refer to the root of the current drive.
- You can use environment variables in paths, like `$env:USERPROFILE` to refer to your home directory

## Enable Git Autocompletion

### Posh-Git

```powershell
Install-Module posh-git -Scope CurrentUser
code $PROFILE
```
Add `Import-Module posh-git`

## PowerShell Profile

```powershell
# "Dumb" terminals cause a warning
# Cursor agents use dumb terminals
# This check prevents the warnings
if ($env:TERM -ne "dumb") {
	# Initialize Starship prompt by default
	Invoke-Expression (&starship init powershell)
}
# Allows for git command autocompletion in PowerShell
Import-Module posh-git
```

## Commands I Find Useful

Delete all .orig files from a repo

```powershell
Get-ChildItem -Path . -Filter *.orig -Recurse | Remove-Item
```