# Programming Language Syntax and Naming Convention Notes

# Code Syntax

## Capitalization

### Styles

- camelCase
- PascalCase / TitleCase
- kebab-case / dash-case
- Train-Case
- snake_case
- SCREAMING_SNAKE_CASE
- dot.case

- "lower" would obviously modify any of these to specify only lowercase
- "UPPER" or "SCREAMING" would obviously modify any of these to specify only uppercase

### Domains

1. Class/Enum/Struct/Interface names
   1. Languages usually use the same style for all of these
4. Private/Public/Protected methods and members
   1. Lanugages usually do not distinguish between private and protected
   2. Generally, only C# and Go use different styles for private vs public
   3. Private members sometimes prefixed with `_` or `m_`
5. Functions/Procedures
6. Global variables
   1. Sometimes prefixed with `g_`
7. Static variables/methods
   1. C# and Java sometimes prefix with `s_` or `k`
8. Constants / Macros
   1. Many different styles for these
9.  Namespaces / Modules / Packages
    1.  Many different styles for these
10. Type defs
    1.  Sometimes prefixed with `T`
11. Parameters
12. Arguments
13. Enum members
14. Special cases like loop iterators, counters, sentinels, etc.
    1.  i, j, k... and n are common

## Naming

- Abbreviations
  - Universal four: id, num, cnt, ref. All others should at least get a comment
- Acronyms
  - Usually treated as words e.g. HttpRequest
- Hungarian notation
  - Hungarian notation is including information about a variables type in its name e.g. `strName` or `iCount`
    - Not needed with modern IDEs that surface type information easily
    - Make refactoring annoying, so usually not used in modern programming
- Prefixes/Suffixes
  - `m_` for member variables
  - `g_` for global variables 
  - `s_` for static variables
  - `T` for type definitions
  - `p` for pointers
- Pluralization, etc
  - Collections typically use pluralization e.g. customers, orderItems
  - Methods that return collections typically use pluralization e.g. getCustomers, getOrderItems
  - Boolean variables typically use `is`, `has`, `can`, etc. e.g. isValid, hasChildren, canExecute
  - Functions should be verbs or verb phrases e.g. getCustomer, calculateTotal, sendEmail

## Other

- Tabs / Spaces
- Indentation optional/required
- Semicolon unused/optional/required
- Braces/brackets used/optional/required
- Braces/brackets style (K&R, Allman, etc.)

# File Naming

- Naming files for single(ish) class definitions typically follows the class name
- Naming of entry point / main files
  - `main.c`, `Main.java`, `Program.cs`, `__main__.py`, `index.js`, `app.go`, etc.