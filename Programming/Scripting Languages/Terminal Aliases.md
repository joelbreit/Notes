# Terminal Aliases

[Terminals.md](./Terminals.md)

## Overview

**Aliases** allow you to create shortcut commands for longer commands or command chains.

"**rc**" traditionally stands for "**run commands**" or "**resource configuration**"

## Default Aliases

Creating a new `~/.zshrc` or `~/.bashrc` file will override aliases in other locations. Other common locations for aliases are `/etc/profile` and `/etc/bash.bashrc` and GitBash stores aliases in `~/profile.d/aliases.sh`. You can add those aliases to your `~/.zshrc` or `~/.bashrc` file or source those files in your new rc file like so:

```bash
if [ -f /etc/bash.bashrc ]; then
    . /etc/bash.bashrc
fi

# etc...
```

## Creating Aliases

**zsh (MacOS)**

zsh aliases are stored in the `~/.zshrc` file. You can create an alias by adding the following line to the `~/.zshrc` file:

```bash
alias alias_name='command'
```

**bash (GitBash or GNOME)**

bash aliases are stored in the `~/.bashrc` file. You can create an alias by adding the following line to the `~/.bashrc` file:

```bash
alias alias_name='command'
```

## Activating Aliases

After creating an alias, you can activate it by sourcing the rc file (`source ~/.zshrc` or `source ~/.bashrc`). New terminals should load these aliases automatically. You can also restart your terminal to activate the aliases.

**restart zsh** `exec zsh`

**restart GitBash/GNOME** `exec bash`

## Viewing Aliases

You can view all active aliases by running the `alias` command in the terminal.

```bash
alias
```

## Helpful Aliases

Here are some helpful aliases that I use:

```bash
alias ll='ls -laFhG' # The Best(TM) ls command :D
alias grep='grep --color=auto' # Colorize grep output
# alias mkcd='mkdir -p "$1" && cd "$1"'  # Create and enter a directory
mkcd() { mkdir -p "$1" && cd "$1"; }  # Create and enter a directory
```

Pretty-print ping output:

```bash
pping() {
    ping -t $1 | awk '
    /Request timed out/ {
        printf "\033[31m" $0 "\033[0m\n"; # red
    }
    /Destination host unreachable/ {
        printf "\033[31m" $0 "\033[0m\n"; # red
    }
    /time/ {
        if ($1 == "Request") {
            printf "";
        } else if ($5 == "time<1ms") {
            printf "\033[32m" $0 "\033[0m\n"; # green
        } else if ($5 == "time=1ms") {
            printf "\033[33m" $0 "\033[0m\n"; # yellow
        } else {
            printf "\033[35m" $0 "\033[0m\n"; # orange
        }
    }'
}
```