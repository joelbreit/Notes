# Flashcards App

## Modes

* Navigate decks
* Create new deck
* Import deck
* View group
  * (Deck, Folder, Tag?)
  * Cards View
  * Review View
    * Suggested
    * Custom
  * Stats
  * Settings
* Review cards
* Edit card

## Data Structure

* Card
  * Term Side
    * Text
    * CreatedAt
	* UpdatedAt
    * (Image)
    * (Notes)
    * (Hint)
    * (Similar Terms)
  * Definition Side
    * Text
    * (Image)
    * (Notes)
    * (Hint)
    * (Similar Terms)
  * (Tags)
  * Folder
  * Deck
  * Review History
* Deck
  * Name
  * (Tags)
  * (Folder)
  * Cards
* Folder
  * Name
  * (Tags)
  * (Folder)
  * Decks
* Tag
  * Name
  * (Tags)
  * (Folder)
  * (Decks)

## Notes

I think I want to use my own algorithm. I want to optimize for making cards not too easy or too hard. I still like the Again, Hard, Good, Easy framework. But I want to try to avoid showing cards that will be rated as easy. I have a huge database of cards and I don't want to overview cards I already know. I think I want Again to reset a card to to-review. I want Hard to repeat half the last interval, and want Good to keep the interval, and I want Easy to double the interval.
