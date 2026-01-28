# Notes and Flashcards

I keep this repository for notes on all kinds of technical things I am learning because keeping track of them in a git repo makes tracking things easy and is good practice. It also allows me to sync markdown files which in combination with VSCode and Copilot are one of the best ways to take notes and learn new things.

> AI assisted autocomplete is very helpful for notes like these. However, in VSCode and Cursor, such autocomplete is off by default and will need to be enabled in settings. E.g. add "markdown": "true" to `github.copilot.enable` in VSCode or `"cursor.cpp.disabledLanguages": [],` in Cursor

## Flashcards Philosophy

Flashcards, when designed well, and used frequently with spaced repetition, are an incredible way to learn and retain new information. This repo contains a ton (thousands+) of flashcards for technical concepts that I've learned over the years.

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

The ability to quickly review cards without unnecessarily bloated language reduces the burden of each card which adds up significantly over time.

Therefore, it can be worth cutting card language down to very terse language when all the information needed is available from context.

Flashcards should be as concise as possible while preserving other priorities like clarity, completeness, accuracy, sufficiency, etc

#### Difficulty

Cards that are easy to guess a priori are useless. The effort of remembering and fact of sometimes failing to recall the answer is what strengthens memory.

#### Reversibility

Making flashcards reversible where each side of the card is specific enough to necessitate the reverse but not so specific that it gives away the answer is ideal.

Creating reversible cards reduces the investment of creating cards before the learning process.

Learning cards in both directions helps reinforce memory and ensures a deeper understanding of the material.

However, this only works for a term -> definition model which is not the only kind of information that you may want to capture with flashcards.

For example, statistics or lists of items may not be easily reversible but they still may be useful as flashcards.

#### Repeating Terms

Using key words from one side of a card on the other side makes the card too easy to guess and bypasses the effort of recall.

It is better to have tortured language to avoid reusing wording from a term in its definition.

It is however, entirely appropriate to reuse the term that just specifies the context of the content e.g. "AWS", "Azure", or "HTTP".

## Examples

### Remove Redundant Wording

- "ability to automatically scale resources up or down" to "ability to scale resources"

### Use Active Language to Avoid Verbosity

- "design approach that ensures" -> "ensuring"

### Being Concise is Sometimes Better than Being Exact

- "when one or more components fail" -> "when components fail"

### Some Details Are Implicit in the Context

- "the ability of a system to continue operating" -> "the ability to continue operating"

### Replacing Terms with Synonyms Can Be Awkward but Necessary

This wording: "**Shared Responsibility Model**: which responsibilities belong to the cloud provider and which belong to the customer" is too easy and therefore useless, so I replaced it "security framework defining what needs to be done by the cloud provider and by the customer". In this case "what needs to be done" is wordy, but worth making the card an actual challenge to recall.

### Too Vague

- **Microsoft Defender for Cloud**: Azure service that provides security posture management and threat protection
- **Azure Batch**: managed service for running large-scale parallel and high-performance computing (HPC) workloads