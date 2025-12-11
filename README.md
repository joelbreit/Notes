# Notes and Flashcards

I keep this repository for notes on all kinds of technical things I am learning because keeping track of them in a git repo makes tracking things easy and is good practice. It also allows me to sync markdown files which in combination with VSCode and Copilot are one of the best ways to take notes and learn new things.

> AI assisted autocomplete is very helpful for notes like these. However, in VSCode and Cursor, such autocomplete is off by default and will need to be enabled in settings. E.g. add "markdown": "true" to `github.copilot.enable` in VSCode or `"cursor.cpp.disabledLanguages": [],` in Cursor

## Flashcards Philosophy

Flashcards, when designed well and used frequently with spaced repetition, are an incredible way to learn and retain new information. This repo contains a ton (thousands+) of flashcards for technical concepts that I've learned over the years.

### Markdown Formatting

The formatting that I've settled on for making flashcards readable in markdown notes is 1) used numbered lists, 2) bold terms, and 3) dash separated descriptions. E.g. this...
```md
1. **term** - description of that thing
...
```
will be formatted like...

1. **term** - description of that thing
2. **Proper Term** - a thing that is proper; capitalized appropriately
3. **TLA (Three Letter Acronym)** - Describe your term. Avoid including the term or obvious parts of the term in the description

#### Cloze Deletions

### Style

#### Capitalization

Don't use capitalization unless the term should always be capitalized. That makes it more clear whether terms are proper on their own. 

- [ ] Example of when this matters

> Exceptions can be made e.g. in descriptions that warrant multiple sentences

#### Punctuation

Punctuation was made for man, not man for punctuation. Descriptions don't need trailing periods if they don't add anything to the meaning of the description.

> Exceptions can be made e.g. in descriptions that warrant multiple sentences

#### Acronyms

The expanded version of acronyms should always be included in either the term or description. It is usually better to do so in the term, so that each side of a flashcard doesn't make the other side too easy, but exceptions can be made.

#### Length

Flashcards should be as concise as possible while preserving other priorities like clarity, completeness, accuracy, sufficiency, etc

#### Difficulty