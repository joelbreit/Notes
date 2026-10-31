# TODO

## To Learn

- [ ] NSSM
- [ ] Chocolatey
- [ ] Duf, dust, fd, and rg
- [ ] mdls (macOS command-line tool that prints Spotlight metadata for a file)
- [ ] ffmpeg (multimedia CLI tools)
- [ ] make
- [ ] xargs
- [ ] winget
- [ ] Husky
- [ ] Dixie

## Repo Tasks

- [ ] Convert remaining dash-format cards (`**term** - description`) to the colon format (`**term**: description`). Files with dash-format cards:
  - `Misc/Biostatistics Vocabulary.md`
  - `Programming/Programming Lanugages/C#/C# Notes.md`
  - `Programming/Programming Lanugages/Golang Notes.md`
  - `Programming/Programming Lanugages/Java Notes.md`
  - `Programming/Scripting Languages/PowerShell.md`
  - `Programming/Scripting Languages/Scoop.md`
  - `Programming/Scripting Languages/Git.md`
  - `Programming/Scripting Languages/Terminal Commands.md`
  - `Programming/Linux Notes.md`
  - `Programming/Design Patterns.md`
- [ ] Flashcard formatter: script that normalizes cards to the standard format
- [ ] Flashcard format checker: script that flags malformed cards, trailing periods, unexpanded acronyms, and definitions that repeat words from the term
- [ ] Pre-commit hook that runs the format checker
- [ ] Rename `Programming Lanugages/` to `Programming Languages/` (and update links/references)
- [ ] Delete or document the empty `config.json` at the repo root
- [ ] Fill in or remove the empty "Cloze Deletions" section in `README.md`
- [ ] Merge `C++ (GPT).md` and `C++ (Claude).md`, or note why both exist

## Ideas

- YAML front-matter on notes (e.g. `tags`, `topic`, `type: flashcards|notes`) so agents and tools can find the right file
- Agent skills in `.claude/skills/` for repeated workflows, e.g.:
  - `add-cards`: write cards on a topic in the repo's style and put them in the right file
  - `review-cards`: tighten existing cards using the README examples
