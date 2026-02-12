# EditorConfig Files

EditorConfig ( `.editorconfig`) files are used to maintain consistent coding styles across different editors and IDEs.

## Example

```ini
# top-most EditorConfig file
root = true

# Unix-style newlines with a newline ending every file
[*]
charset = utf-8
end_of_line = lf
insert_final_newline = true
indent_style = tab
indent_size = 4

[*.md]
max_line_length = off
trim_trailing_whitespace = false

# JSON files need double quotes
[*.json]
quote_type = double
```

## Details

### Root Declaration
- `root = true` means "Stop searching parent directories for more EditorConfig files"

### Section Headers

Listed before a set of properties; means "Apply the following properties to files matching this pattern"

- `[*]` applies to all files
- `[*.py]` applies to all Python files
- `[*.{js,ts}]` applies to all JavaScript and TypeScript files
- `[src/**.cs]` applies to all C# files in the `src` directory and its subdirectories

### Common Properties

* `indent_style = tab`: use tabs instead of spaces for indentation (or `space` to use spaces)
* `indent_size = 4`: use 4 spaces per indentation level (or `tab` to use the same width as a tab character)
* `end_of_line = lf`: use Unix-style line endings (or `crlf` for Windows-style)
* `insert_final_newline = true`: ensure that files end with a newline
* `charset = utf-8`: use UTF-8 character encoding for the file
* `trim_trailing_whitespace = true`: remove any whitespace characters at the end of lines
* `max_line_length = 80`: set a maximum line length for the file (note: not all editors support this property)