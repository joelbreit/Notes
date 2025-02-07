# Terminals

<!-- Link to "./Terminal Aliases.md" -->
[Terminal Aliases](./Terminal%20Aliases.md)

## Terminology

### Terminals

1. **Terminal** - An application that allows for the use of CLIs
2. **Command Line Interface (CLI)** - A text-based interface for interacting with a system
3. **Shell** - A CLI like Bash, Zsh, or PowerShell that allows for interacting with an operating system
4. **Kernel** - The layer of an operating system needed for any software to interact with hardware
5. **Terminal.app** - The default terminal application on macOS
6. **Windows Terminal** - The default terminal application on Windows
7. **GNOME Terminal** - The default terminal application on most Linux distributions
8. **Package Manager** - A CLI for installing, updating, and managing pieces of software
9. **Homebrew (`brew`)** - The most popular package manager for macOS/zsh
10. **APT (`apt-get`)** - The package manager for most Linux distributions
11. **Bash** - The default shell for most Linux distributions that .sh files use
12. **Zsh** - The default shell for macOS based on Bash with more features
13. **Command Prompt (cmd.exe)** - The default shell for Windows
14. **PowerShell** - An application and shell for Windows with many more features than Command Prompt
15. **Darwin** - The kernel for macOS

```
root_directory (/)
    ├── home_directory (~)
```

### Syntax

1. **Shell Prompt** - The text that appears before a command in a shell like `$` or `>`
2. **Wildcard/Splat** - The `*` character used to represent any number of characters in a command
3. **Flag/Option** - A command-line argument that modifies the behavior of a command
4. **`./`** - Symbol representing the current directory in a command
5. **`../`** - Symbol representing the parent directory in a command
6. **`~`** - Symbol representing the home directory in a command
7. **Environment Variables** - Named values referenceable when prefixed with `$`
8. **Order of Operations** - Commands are run in the order they are written unless grouped with parentheses `()`

### Other

1. **full-screen mode / curses mode** - Mode entered by some commands that can be navigated around and exited with the `q` key
2. **pager mode** - a paged display of long command outputs

## Commands

### Command Basics

**general syntax** - `<command> <flags> <arguments>`

**help** (`--help`) - Flag for displaying a concise in-terminal manual for a command
- `<command> --help` - Works for most commands
- ~~`<command> -h`~~ - Works for commands

**version** (`-v) - Display the version of a CLI
- `<command> -v` - Displays the version of a the CLI
- `<command> -V` - Sometimes this is used instead

**background command** (`&`) - Run a command in the background
- `<command> &`

**command sequences** `;` `&&` - Run multiple commands with one line
- `<command1> ; <command2>` - Runs command2 after command1 finishes -->
- `<command1> && <command2>` - Runs command2 if command1 succeeds
- `<command1> || <command2>` - Runs command2 if command1 fails

**redirection** - Redirect the input/output of a command
- `<command> > <file>` - Redirects the output of a command to a file
- `<command> >> <file>` - Appends the output of a command to a file
- `<command> < <file>` - Redirects the input of a command from a file
- `<command1> | <command2>` - Pipes the output of command1 to command2
- `<command> 2> <file>` - Redirects the error output of a command to a file
- `<command> 2>&1` - Redirects the error output of a command to the standard output
- `<command> &> <file>` - Redirects the output and error output of a command to a file

**print working directory** (`pwd`) - Prints the current working directory

**list directories** (`ls`) - Lists the contents of a directory
- `ls -<tags>` - Lists the contents of a directory
- Flags:
  - `-a` - All files
  - `-l` - Long format
  - `-t` - Sort by time
  - `-h` - Human-readable sizes (KB, MB, GB)
  - `-R` - Recursive listing
  - `-F` - Add `/` to directories, `*` to executables
  - `-G` - Colorized output
- Favorite - `alias ll='ls -laFhG'`

**make directory** (`mkdir`) - Creates a new directory
- `mkdir <name>` - Creates a new directory with this name
  
**change directory** (`cd`) - Changes the current working directory
- `cd <path>` - Changes the current working directory to path
- `cd` - Changes to the home directory
- `cd -` - Changes to the previous directory
- `cd ..` - Changes to the parent directory
- `cd .` - Changes to the current directory
- `cd ~` - Changes to the home directory
- `cd /` - Changes to the root directory

**find** (`find`) - Search for files in a directory hierarchy
- Find can search for files by file name, file type, file size, and more and can execute commands on found files like deleting them or printing their contents
- `find <directory> <criteria>`
- Flags
  - `-name` - Find files by name rather than by full path/to/file
  - `-type` - Find files by type
  - `-size` - Find files by size
  - `-exec` - Execute a command on found files
  - `-delete` - Delete found files
- `find . -name "filename.txt"` - Find files within the current directory by name
- `find . -iname "filename.txt"` - Find files within the current directory by name case-insensitive
- `find . -type f` - Find files within the current directory
- `find . -type d` - Find directories within the current directory

**less** (`less`) - View the contents of a file
- `less <file>` - View the contents of a file
**echo** (`echo`) - Print text to the terminal
- `echo <text>` - Prints text to the terminal
- `echo $<variable>` - Prints the value of a variable to the terminal
- `echo -n <text>` - Prints text to the terminal without a newline
- `echo -e <text>` - Interprets backslash escapes in text
**touch** (`touch`) - Create a new file
- `touch <file>` - Creates a new file with this name
**copy** (`cp`) - Copy files and directories
- `cp <source> <destination>` - Copies a file or directory to a new location
- `cp -r <source> <destination>` - Copies a directory and its contents to a new location
- Flags
  - `-r` - Recursive (for directories)
  - `-i` - Interactive (asks before overwriting)
  - `-v` - Verbose (shows what's being copied)

**move/rename** (`mv`) - Move files and directories
- `mv <source> <destination>` - Moves a file or directory to a new location
- `mv <pattern> <destination>` - Moves files matching a pattern to a new location
- Flags
  - `-i` - Interactive (asks before overwriting)
  - `-v` - Verbose (shows what's being moved)

**remove** (`rm`/`rmdir`) - Remove files and directories
- `rm <file>` - Removes a file
- `rm -r <directory>` - Recursive (for directories)
- `rm -f <file>` - Force (for when a file is write-protected)
- `rmdir` only removes empty directories, so it's kind of pointless

**concatenate** (`cat`) - Outputs the contents of a file
- `cat <file>` - Displays the contents of a file
- Flags
  - `-n` - Number lines

**filter** (`grep`) - Search for patterns in text
- `grep <pattern> <file>` - Searches for a pattern in a file
- Flags
  - `-i` - Case-insensitive
  - `-v` - Invert match
  - `-n` - Show line numbers
  - `-c` - Show count of matches
  - `-r` - Recursive (when specifying a directory instead of a file)
  - `-l` - Show only filenames
  - `-E` (or use `egrep`) - Use extended regular expressions

**peak** (`head` / `tail`) - Display the beginning or end of a file
- `head <file>` - Displays the beginning of a file
- `tail <file>` - Displays the end of a file
- Flags
  - `-n` - Number of lines to display (default is 10)
    - e.g. `head -n 5 <file>` - Displays the first 5 lines
  - `-f` - Follow the file (like `tail -f`)

**change mode** (`chmod`) - Change the permissions of a file or directory
- `chmod <mode> <file>` - Changes the permissions of a file
- Symbolic mode
  - `chmod <who><operator><permissions> <file>`
    - `<who>` - `u` (user/owner), `g` (group), `o` (others), `a` (all)
    - `<operator>` - `+` (add), `-` (remove), `=` (set)
    - `<permissions>` - `r` (read), `w` (write), `x` (execute)
  - `chmod u+x <file>` - Adds execute permission for the owner
  - `chmod go-w <file>` - Removes write permission for the group and others
  - `chmod a=r <file>` - Sets read permission for all
  - `chmod u=rw,go=r <file>` - Sets read and write permission for the owner and read permission for the group and others
- Numeric (octal) mode
  - `chmod <mode> <file>`
    - `<mode>` - Three-digit number representing permissions
      - First digit - Owner
      - Second digit - Group
      - Third digit - Others
      - Each digit is the sum of the permissions
        - 4 - Read
        - 2 - Write
        - 1 - Execute
      - 7 - All permissions, 6 - Read/write, 5 - Read/execute, 4 - Read, 3 - Write/execute, 2 - Write, 1 - Execute, 0 - No permissions
  - `chmod 755 <file>` - All permission for owner, read/execute for others
  - `chmod 644 <file>` - Read/write for owner, read for group and others

**change owner** (`chown`) - Change the owner of a file or directory
- `chown <owner> <file>` - Changes the owner of a file

### Networking

**ping** (`ping`) - Send a packet to a network host
- `ping <host>` - Sends a packet to a network host
- `ping -c <count> <host>` - Sends a specific number of packets to a network host
- `ping google.com` - Pings google.com
- `ping 8.8.8.8` - Pings Google's DNS server
- Flags
  - `-c` - Number of packets to send
  - `-i` - Interval between packets (in seconds)
  - `-t` - TTL (time to live)
  - `-s` - Packet size
  - `-W` - Timeout (in seconds)
  - `-q` - Quiet mode
  - `-v` - Verbose mode

**curl** (`curl`) - Transfer data from or to a server
- "**Client URL**" or "**Curl URL Request Library**"
- `curl <url>` - Downloads the contents of a URL
- `curl -O <url>` - Downloads the contents of a URL and saves it with the same name
- `curl -o <output> <url>` - Downloads the contents of a URL and saves it with a specific name
- Example
```bash
curl -X POST https://api.example.com/users \
     -H "Content-Type: application/json" \
     -d '{"name": "Joel", "age": 28}'
```
- Flags
  - `-O` - Save with the same name
  - `-o` - Save with a specific name
  - `-L` - Follow redirects
  - `-I` - Show headers only
  - `-H` - Add a header
  - `-X` - HTTP method
  - `-d` - Data to send in a POST request
  - `-u` - User and password
  - `-v` - Verbose mode

**secure shell** (`ssh`) - Securely connect to a remote server
- `ssh <user>@<remote_host>` - Connects to a remote server
- `ssh -p <port> <user>@<remote_host>` - Connects to a remote server on a specific port

**secure copy** (`scp`) - Securely copy files to or from a remote server
- `scp <source> <destination>` - Copies a file to or from a remote server
- `scp -r <source> <destination>` - Copies a directory to or from a remote server

**ssh-keygen** (`ssh-keygen`) - Generate an SSH key pair
- `ssh-keygen` - Creates a public-private key pair.
  - Default type: RSA 3072-bit
  - Private key: ~/.ssh/id_rsa
  - Public key: ~/.ssh/id_rsa.pub
- `ssh-keygen -t <type> -b <bits> -C <comment> -f <file>` - Creates a key pair with specific options
- Flags
  - `-t` - Type of key (rsa, dsa, ecdsa, ed25519)
  - `-b` - Number of bits in the key
  - `-C` - Comment
  - `-f` - File name

**ssh-copy-id** (`ssh-copy-id`) - Copy an SSH key to a remote server
- `ssh-copy-id -i ~/.ssh/id_rsa.pub user@remote_host` Appends the public key to ~/.ssh/authorized_keys on remote_host, allowing password-less login



### Process Management

**process status** (`ps`) - Display information about processes
- `ps` - Displays information about processes
- `ps -p <pid>` - Displays information about a specific process
- Flags
  - `-e` - All processes
  - `-f` - Full format
  - `-l` - Long format
  - `-u` - User format
  - `-x` - All processes (including those not attached to a terminal)
  - `-a` - All processes (including those not attached to a terminal)
  - `-p` - Process ID

**top** (`top`) - Display a dynamic view of system processes
- `top` - Displays a dynamic view of system processes
- Curses Mode Commands
  - `q` - Quit
  - `k` - Kill a process (enter PID)
  - `h` - Help

**htop** (`htop`) - Enhanced top with colors and more
- `htop` - Displays a dynamic view of system processes

**kill** (`kill`) - Terminate a process

### Special Commands

**clear** (`clear`) - Clear the terminal screen

**time** (`time`) - Measure the time a command takes to run
- `time <command>` - Measures the time a command takes

**man** (`man`) - Display the manual for a command
- `man <command>` - Displays the manual for <command>
- Used in UNIX-based systems, not included in GitBash


## To Add

* `sort`
* `uniq`
* `wc`
* `tree`
* `history`
* `alias`
* `source`
* `export`
* `which`
* `ipconfig`
* `clip`
* `pbcopy`
* `sudo`
* `su`
* `tee`
* `vim`
* `nano`

### New

* `nc`
* `df`
* `du`
* `tar`
* `zip`
* `unzip`
* `wget`
* `sed`
* `awk`
* `cut`
* `tr`
* `diff`
* `watch`
* `env`
* `whereis`
* `ifconfig`
* `locate`
* `uname`

## Esoteric Commands I Like

Count the total number of lines in a project (directory and subdirectories) from all files of a certain type (in this case, C, C++, and C# files)
```bash
find . -type f \( -name "*.c" -o -name "*.cpp" -o -name "*.h" -o -name "*.hpp" -o -name "*.cs" \) -exec wc -l {} \; | awk '{total += $1} END {print total}'`
```
* To count by file, remove the awk part:
```bash
find . -type f \( -name "*.txt" -o -name "*.md" \) -exec wc -l {} \;
```

## Unclear

* Debian
* Unix