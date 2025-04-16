# Regex

VSCode has a built-in regex search and replace feature. You can enable it by clicking the `.*` button in the search bar. VSCode uses JavaScript's regex engine. Here are some common regex patterns and their meanings:

https://www.rexegg.com

## Vocab

Taken from [NLP Concepts Notes](NLP%20Concepts%20Notes.md)

### Basics

1. **regular expressions**: a language for specifying text search strings
2. **anchors**: special characters in a regular expression for specifying particular places such as `^` and `$` for the beginning and end of a line, respectively
3. **disjunction**: regex operator for specifying alternatives, using `|` to separate them
4. **greedy matching**: regex matching that tries to match as much as possible
5. **lazy matching**: regex matching that tries to match as little as possible (like the `*?` and `+?` operators)
6. **Kleene star ("cleany star")**: the `*` operator in regex for matching zero or more occurrences of a pattern
7. **Kleene plus ("cleany plus")**: the `+` operator in regex for matching one or more occurrences of a pattern
8. **regex flags**: special characters that modify the behavior of a regex pattern (e.g. `re.IGNORECASE` for case-insensitive matching)
9.  **regex escape sequences**: special characters that match specific characters (e.g. `\d` for any digit)

### Registers and Groups

8. **substitution**: replacing a matched pattern with another pattern
9.  **capture group**: a part of a regex pattern that is enclosed in parentheses and can be referred to later
10. **register**: a numbered list of capture groups in a regex pattern
11. **non-capturing group**: a group in a regex pattern that is not stored in a register e.g. `(?:pattern)`
12. **lookahead assertion**: a regex operator for matching a pattern only if it is followed by another pattern e.g. `(?=pattern)`
13. **zero-width assertion**: a regex operator for matching a pattern without consuming any characters
14. **negative lookahead assertion**: a regex operator for matching a pattern only if it is not followed by another pattern e.g. `(?!pattern)`
16. **regex groups**: a way to group parts of a regex pattern together (e.g. `(a|b)` for matching either "a" or "b")

## Character Classes

Character classes are used to match specific types of characters.

1. **`.`**: Matches any character except a newline.
2. **`\d`**: Matches any digit (0-9).
3. **`\D`**: Matches any non-digit character.
4. **`\w`**: Matches any word character (alphanumeric + underscore).
5. **`\W`**: Matches any non-word character.
6. **`\s`**: Matches any whitespace character (space, tab, newline).
7. **`\S`**: Matches any non-whitespace character.
8. **`[abc]`**: Matches any character in the set (a, b, or c).
9. **`[^abc]`**: Matches any character not in the set (not a, b, or c).
10. **`[a-z]`**: Matches any character in the range (a to z).
11. **`[A-Z]`**: Matches any character in the range (A to Z).
12. **`[0-9]`**: Matches any digit (0 to 9).
13. **`[a-zA-Z0-9]`**: Matches any alphanumeric character.

## Anchors

Anchors are used to match a position in the input string rather than a character.

8. **`^`**: Matches the start of a string.
9.  **`$`**: Matches the end of a string.
10. 

## Quantifiers

Quantifiers specify how many instances of a character, group, or character class must be present in the input for a match to be found

10. **`*`**: Matches zero or more occurrences of the preceding character.
11. **`+`**: Matches one or more occurrences of the preceding character.
12. **`?`**: Matches zero or one occurrence of the preceding character.
13. **`{n}`**: Matches exactly n occurrences of the preceding character.
14. **`{n,}`**: Matches n or more occurrences of the preceding character.
15. **`{n,m}`**: Matches between n and m occurrences of the preceding character.

## Logic

16. **`|`**: Alternation, matches either the pattern on the left or the pattern on the right.

## Groups

17. **`()`**: Groups multiple tokens together.
18. **`\1`, `\2` or `$1`, `$2`, ...**: Backreferences to captured groups.
19. **`(?:...)`**: Non-capturing group, groups without creating a backreference.
20. **`(?=...)`**: Positive lookahead, matches a group after the main pattern without including it in the match.
21. **`(?!...)`**: Negative lookahead, matches a group that is not followed by the main pattern.
22. **`(?<=...)`**: Positive lookbehind, matches a group before the main pattern without including it in the match.
23. **`(?<!...)`**: Negative lookbehind, matches a group that is not preceded by the main pattern.

- [ ] Inline modifiers?

## Esoteric Patterns I Like

(For search and replace in VSCode) Put quotes around all strings with commas in them (for a tsv file):
```sh
\t([^\t]+,[^\t]+)\t
\t"$1"\t
```