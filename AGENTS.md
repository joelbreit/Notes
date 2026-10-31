# AGENTS.md

Guidance for AI agents working in this repository.

## What This Repo Is

Personal notes on technical (and some non-technical) topics. Most of the content is flashcards meant for spaced repetition review, so card wording matters more than it would in ordinary notes. There is no build, and there are no tests.

## Flashcards

All flashcard guidance (format, style, examples) lives in the **Flashcards Philosophy** section of [README.md](README.md). Read it before writing or editing cards.

- The standard format is `1. **term**: description`.
- When editing an existing file, **match the file's existing format** (some files still use `**term** - description`, plain bullets, or no list prefix). Don't convert a file's format unless asked.
- TSV flashcard files are `term<TAB>description`, one card per line. They are imported into [flashcards.joelbreit.com](https://flashcards.joelbreit.com), which accepts TSV files; empty lines are okay.

## Layout

- `Programming/`: technical notes, grouped into topic folders (`AWS/`, `ML/`, `Databases/`, `Networking/`, `Scripting Languages/`, `Programming Lanugages/`, etc.)
- `Misc/`: non-programming notes, vocabulary, and prompt templates (`Misc/Prompts.md`)
- `TODO.md`: things to learn, repo tasks, and ideas

Put new notes in the most specific existing topic folder. Don't add notes at the repo root.

## Don'ts

- Don't rewrite, reorder, or delete existing cards unless asked.
- Don't rename files or folders unless asked (some renames are tracked in `TODO.md`).
