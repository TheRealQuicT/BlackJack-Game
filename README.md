
# BlackJack Game using C#

This is a console BlackJack game that I have made to test my C# skills. I will be using everything I have been taught in my programming class to create this game. This isn't gonna be the most efficient way to make it but it will be functional and hopefully will look professional.

## Rules

<u>**Deck**</u>

The standard 52-card pack is used, but in most casinos several decks of cards are shuffled together. In a typical casion game there is a total of 4 decks used but for the purpose of this game we will only be using 2.

<u>**Object of the game**</u>

If you have never played BlackJack before, each participant attempts to beat the dealer by getting a count as close to 21 as possible, without going over 21.

<u>**Card Values/scoring**</u>

It is up to each individual player if an ace is worth 1 or 11. Face cards are 10 and any other card is it's shown value.

<u>**Betting**</u>
Before the deal begins, each player places a bet. The minimum bet is $2.
<u>**Shuffle**</u>

The 2 decks will be shuffled in a random order using the built-in C# Random Class.

<u>**How to play**</u>

The dealer will start off by giving themself one card face up and one card hidden to the players. Each player will receive **2 cards** face up. If the player gets a **natural 21 (on the first two cards)**, and the dealer does not, the player **immediately** wins that round and is payed out **1.5x** their current bet. If the dealer has an **ace** or a **"ten-card"**, they will check to see if their count is **21**, if not each player will have 4 options, **Hit**, **Stand**, **Split** and **Double**.

`Hit:` The player will receive another card.

`Stand:` The player will keep the current count of cards that they have.

`Split:` The player can split their first two cards, treating them as seperate hands. The player will need to place down an equal sized bet on their "second" hand.

`Double:` The player can double their bet but will only receive one more card face down.

Each player will try to reach as close as possbile to **21**, if the player goes **over 21** they lose the hand and forfeit their bet. If the player **does not** go over 21 and the dealer ends up getting **the same count** as the player it is called a **Push**, this means no one wins and the player gets their money back. Each time a player **beats** the dealer they they will be payed **2x** their current bet.

<u>**Dealer**</u>

The dealer can only hit and stand depending on specific parameters.

| Dealer Hit's | Dealer Stand's |
|-|-|
|Count of 16 and Under|Count of 17 and Over|

## Basic BlackJack Strategy

### Dealer's Up Card

|     |2|3|4|5|6|7|8|9|10|A|
|-|-|-|-|-|-|-|-|-|-|-|
| 17+ |<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|
| 16  |<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 15  |<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 14  |<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 13  |<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 12  |<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 11  |<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:goldenrod;">H</span>|
| 10  |<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 9   |<span style="color:goldenrod;">H</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 5-8 |<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| A,8-10 |<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|
| A,7 |<span style="color:green;">S</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| A,6 |<span style="color:goldenrod;">H</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| A,5 |<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| A,4 |<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| A,3 |<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| A,2 |<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| A,A\8,8 |<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|
| 10,10 |<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|
| 9,9 |<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:green;">S</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:green;">S</span>|<span style="color:green;">S</span>|
| 7,7 |<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 6,6 |<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 5,5 |<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:red;">D</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 4,4 |<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 3,3 |<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|
| 2,2 |<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:royalblue;">SP</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|<span style="color:goldenrod;">H</span>|


| **KEY** |   |   |
|:-------|:--|:----------------|
| <span style="background-color:goldenrod; color:black; padding:2px 8px; border-radius:4px;">**H**</span> |   | HIT |
| <span style="background-color:green; color:black; padding:2px 8px; border-radius:4px;">**S**</span> |   | STAND |
| <span style="background-color:red; color:black; padding:2px 8px; border-radius:4px;">**D**</span> |   | DOUBLE DOWN |
| <span style="background-color:royalblue; color:black; padding:2px 8px; border-radius:4px;">**SP**</span> |   | SPLIT |

