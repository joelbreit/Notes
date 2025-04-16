# Computer Engineering

## Windows Registry

Windows Registry is a database of system settings, configurations, and application data. It is a hierarchiacal database that stores low-level settings for the operating system and for applications that opt to use the registry.

- Editing the registry incorrectly can break Windows
- The registry is set up like a file system
  - Keys are like top-level folders
  - Subkeys are like subfolders
  - Values are like files
- Top level keys are called "hives"
- Each hive has a root key
- Each root key has subkeys and values
- Can be edited with the regedit tool
- Can be accessed in Command Prompt/PowerShell with the `reg` command
  - `reg query` to view registry keys and values
  - `reg add` to add keys and values
  - `reg delete` to delete keys and values


### HKEY_LOCAL_MACHINE (HKLM)

HKLM is a "registry hive" that stores settings that are specific to the local computer.

## COM

### COM (Component Object Model)

A Microsoft-developed binary-interface standard for software components to communicate with each other in a language-agnostic way

### COM Port (Communication Port)

**COM Port** is a hardware/software interface for serial communication, used to transmit data between devices

It works on physical ports between 2 devices rather than over a network.

It sends data one bit at a time, over a single wire, unencrypted, without error-checking, and at a relatively slow speed.

## .NET

**NuGet** - package manager for .NET

## Need to clarify

- USB virtual port?
- "baud rate" - speed of data transfer
- RS-323
- UART - Universal Asynchronous Receiver-Transmitter
- USB-to-serial