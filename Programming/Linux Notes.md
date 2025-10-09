# Linux Notes

## Terms

> *Italicized definitions* are ones that I need to review/revise further

- **Userland** - Everything “above” the kernel — the tools and libraries you interact with
- **Kernel** - The core part of an operating system, managing hardware and system resources
- **BusyBox** - A single binary that provides several stripped-down Unix tools in a single executable
  - Instead of having separate binaries /bin/ls, /bin/cp, /bin/mv, you just have one binary /bin/busybox, and symlinks point to it
  - Saves space, but fewer options for commands than GNU
- **Symlink** - *A symbolic link, or symlink, is a file that points to another file or directory*
- **GNU** - *A recursive acronym for "GNU's Not Unix!", a free software operating system*

## Standard Linux Directories

/ - Root, top of filesystem hierarchy
/bin - Binaries for CLI tools
/boot - Files for booting the system
/dev - Device files like hard drives
/etc - Configuration files
/home - User home directories
/lib - Shared libraries
/media - Removable media mount points
/opt - Optional third-party software
/root - Root user's home directory
/run - Runtime data (PIDs, sockets)
/sbin - System binaries (requires root)
/srv - Service data (web servers, FTP)
/sys - Virtual filesystem for hardware/kernel info
/tmp - Temporary files
/usr - User programs and data (most software)
/var - Variable data (logs, caches, databases)

- [ ] /mnt
- [ ] /proc
- [ ] /sbin
- [ ] /srv

## TODO

- [ ] symlinks
- [ ] Linux paths e.g. /etc/, /usr/, /var/...