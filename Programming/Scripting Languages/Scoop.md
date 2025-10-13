# Scoop

Scoop is a user-space package manager CLI for Windows.

## Terms

- **Buckets** - Collections of packages that can be added to Scoop
- **Cache** - Storage for downloaded packages (Scoop downloads all necessary files to a local cache so that an offline installation can be performed later)

## General Workflow

1. **Install Scoop** - 
2. (**Add Buckets**)
   - Scoop comes with a default bucket, but you can add more buckets to access additional packages.
   - Example: `scoop bucket add extras`
3. (**Search for Packages in Your Buckets**) - `scoop search <package>`
4. **Install Packages** - Use `scoop install <package>` to install packages from the available buckets
5. (**List Installed Packages**) - `scoop list` to see all installed packages
6. (**Update Packages**) - `scoop update <package>` to update a specific package or `scoop update` to update all packages
7. **Copy Buckets and Cache** - `cp -r ~/.scoop/buckets <destination>` to copy buckets, and `cp -r ~/.scoop/cache <destination>` to copy the cache for offline installations
8. **Install Package Offline** - `scoop install <package> -u` to install a package using the offline cache
9. (**Uninstall Packages**) - `scoop uninstall <package>` to remove a package

## Commands

**Install Package Online**
- `scoop install <package>`
- Ex: `scoop install git`

**Install Package Offline**
- `scoop install <package> -u`

## Examples

```powershell
scoop install go
scoop install python
scoop install pandoc # For markdown to PDF/DOCX conversion
scoop install tokei # For codebase statistics e.g. lines of code
scoop install pwsh # PowerShell v7
```

### Starship Prompt

[Starship.md](./Starship.md)

```
scoop install starship
```