# Starship Prompt

**Starship** is a customizable, cross-shell prompt written in Rust. It makes terminal prompts informative and aesthetic.

It works in many shells and platforms including **PowerShell**, **Bash**, and **Zsh**

### Install via Scoop

You can install Starship with Scoop:
  
```powershell
scoop install starship
```

### Initialize in Your Shell

**PowerShell** (`$PROFILE`):

```powershell
Invoke-Expression (&starship init powershell)
```

**Bash** (`~/.bashrc`):

```bash
eval "$(starship init bash)"
```

**Zsh** (`~/.zshrc`):

```zsh
eval "$(starship init zsh)"
```

---

### ⚙️ **Configuration**

Settings live in:

```
~/.config/starship.toml
```

My Preferred Configuration:

```toml
# Put this in ~/.config/starship.toml
[directory]
truncate_to_repo = false
truncation_length = 0
```