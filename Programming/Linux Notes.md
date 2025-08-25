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

## TODO

- [ ] symlinks
- [ ] Linux paths e.g. /etc/, /usr/, /var/...