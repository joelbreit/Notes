# Pandoc Notes

Pandoc is a universal document converter CLI tool that converts between markup and document formats.

## Installation

```bash
# Windows (Scoop)
scoop install pandoc

# macOS (Homebrew)
brew install pandoc

# Linux (apt)
sudo apt install pandoc
```

> *PDF output also requires a LaTeX engine: `scoop install latex` / `brew install --cask mactex`*

## Core Concept

```
pandoc [options] [input-file] -o [output-file]
```

Pandoc infers formats from file extensions. Use `-f` / `-t` to specify explicitly.

## Common Conversions

```bash
# Markdown → Word
pandoc input.md -o output.docx

# Markdown → PDF (requires LaTeX)
pandoc input.md -o output.pdf

# Markdown → HTML
pandoc input.md -o output.html

# Word → Markdown
pandoc input.docx -o output.md

# HTML → Markdown
pandoc input.html -o output.md

# Multiple input files → one output
pandoc ch1.md ch2.md ch3.md -o book.docx
```

## Key Options

| Option                    | Description                                                                |
| ------------------------- | -------------------------------------------------------------------------- |
| `-f FORMAT`               | Input format (e.g. `markdown`, `html`, `docx`)                             |
| `-t FORMAT`               | Output format (e.g. `pdf`, `latex`, `rst`)                                 |
| `-o FILE`                 | Output file                                                                |
| `--standalone` / `-s`     | Produce a standalone document (with header/footer)                         |
| `--template=FILE`         | Use a custom template                                                      |
| `--reference-doc=FILE`    | Use a .docx/.odt file as a style reference                                 |
| `--toc`                   | Add a table of contents                                                    |
| `--toc-depth=N`           | Depth of TOC headings (default: 3)                                         |
| `--number-sections`       | Number section headings                                                    |
| `--css=FILE`              | Link a CSS stylesheet (HTML output)                                        |
| `--highlight-style=STYLE` | Code highlighting style (e.g. `pygments`, `zenburn`)                       |
| `--pdf-engine=ENGINE`     | PDF engine: `pdflatex`, `xelatex`, `lualatex`, `wkhtmltopdf`, `weasyprint` |
| `--metadata KEY=VALUE`    | Set document metadata                                                      |
| `--variable KEY=VALUE`    | Set template variable                                                      |
| `-V KEY=VALUE`            | Shorthand for `--variable`                                                 |
| `--wrap=none`             | Disable line wrapping in output                                            |
| `--extract-media=DIR`     | Extract media files to a directory                                         |

## Formats

**Common input formats:** `markdown`, `html`, `docx`, `odt`, `epub`, `latex`, `rst`, `mediawiki`, `textile`, `csv`

**Common output formats:** `markdown`, `html`, `html5`, `docx`, `odt`, `pdf`, `epub`, `latex`, `beamer`, `pptx`, `plain`, `rst`, `man`

## Markdown Extensions

Pandoc uses its own extended Markdown dialect. Notable extensions:

- Footnotes: `[^1]` / `[^1]: Footnote text`
- Tables (pipe tables and grid tables)
- Definition lists
- Fenced code blocks with attributes: ` ```python`
- Math: inline `$x^2$`, display `$$E=mc^2$$`
- Citations via `--citeproc` and a `.bib` file
- Divs and spans with attributes: `[text]{.class}`

## Metadata / Front Matter

```yaml
---
title: "My Document"
author: "Joel"
date: "2025-01-01"
---
```

Can also be passed via `--metadata title="My Document"`.

## Styling Word Output

```bash
# Generate a default reference.docx to customize
pandoc -o custom-reference.docx --print-default-data-file reference.docx

# Use your customized reference for styled output
pandoc input.md --reference-doc=custom-reference.docx -o output.docx
```

## Quick Reference

```bash
pandoc --version
pandoc --list-input-formats
pandoc --list-output-formats
pandoc --print-default-template=html5    # View built-in template
pandoc --print-default-data-file reference.docx  # Export default reference doc
```

## Todo

- [ ] Citations
- [ ] Lua Filters
- [ ] PDF engines