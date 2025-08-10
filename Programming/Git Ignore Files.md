# Git Ignore Files

The .gitignore file tells Git which files or directories to ignore in a project.

## Basic Syntax

  * `*.log` — Ignore all .log files
  * `temp/` — Ignore the temp directory and all its contents
  * `build` — Ignore build file or directory (both)
    * Any file in any directory named build (with no extension) will be ignored
    * Any file in any directory or subdirectory named build/ will be ignored
  * `/config.js` — Ignore config.js in the root only

## Wildcards

| Pattern | Matches                                            |
| ------- | -------------------------------------------------- |
| `*`     | Any number of characters except /                  |
| `**`    | Matches directories at any level (e.g. foo/**/bar) |
| `?`     | Any single character                               |
| `[abc]` | Matches one character: a, b, or c                  |
| `[0-9]` | Matches any digit                                  |

## Negation

  * `!important.js` — Do not ignore important.js (i.e., include it even if ignored by a broader rule)

Note: negations only work if a parent directory isn’t already ignored.

## Comments

  * Lines starting with `#` are comments.

## Examples

Ignore all node modules:

```
node_modules/
```

Ignore all .env files:

```
*.env
```

Ignore all .log files, but not debug.log:

```
*.log
!debug.log
```

Ignore all files in logs/ except keep.log:

```
logs/*
!logs/keep.log
```

Ignore .DS_Store on macOS:

```
.DS_Store
```

Ignore everything in /dist except dist/app.js:

```
dist/*
!dist/app.js
```