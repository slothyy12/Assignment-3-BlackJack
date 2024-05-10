COMP-213 Visual Programming
Author: Tamanda Mdyanyama
Date:02/05/2024 - 10/05/2024
Program: Assignment-3-BlackJack

----------------------------------------------------------------------------------

Completed Specifications:

Basic Rules:
- Created a class card which l used to start the game by assigning random card to the dealer and player.

- cardValue() calculates the Hand Total for each player.

- Busted function checks whether a hand has exceeded 21 and returns true or false.

- Button "Twist" allows the player to add a card to their hand using AddCard() function. If the player's hand value more than 21, Busted() is called to check if the player busts.

- Button "stay" allows the player to stay on their current hand while the dealer (operated by the program) twists until it surpasses 17.

- As the dealer takes cards, Busted() is called to check if he busts. if so, player's bet is doubled and a request to play again is displayed to the user.

- An "if statement" is used to check who has the highest hand after the dealer doesn't bust and the player has stayed. Whoever has the highest wins the bet. Displays draw if equal.


Extra Rules: 
- IsBlackJack() function checks to see if the player has a blackjack and only executes after first two cards are dealt.

- DoubleDown() function checks the player's hand total and if it equals 9,10 or 11, the double down button is enabled for the player to use. it doubles the player's bet

- The dealer in cannot double-down or split.

- Random class is used to generate a new card each time a card is needed.

- only the first player's card are kept because they are face up.


Betting Rules:

- bet is a variable of type int that keeps the player's current bet.

- winnings is a variable of type int that keeps the player's winnings.

- When the player loses their hand to the dealer, the current bet is added to the dealer's winnings.


---------------------------------------------------------------------

Pending Specifications:
- Split button; separation of the hand with a new bet. Program was designed in a fixed way that makes it difficult to implement multiple other players with multiple hands.

- cardValue() function assigns Ace a value of 11 only by default and never 1.

- When the player chooses to double down, there's no restriction on the number of times they choose to twist before busting.


---------------------------------------------------------------------


Resources:
52 playing cards pack

Created/distributed by MrEliptik (www.victormeunier.com)
Creation date: October 31st, 2020

------------------------------

License: (Creative Commons Zero, CC0)
http://creativecommons.org/publicdomain/zero/1.0/

This content is free to use in personal, educational and commercial projects.

Support me by crediting MrEliptik or www.victormeunier.com (this is not mandatory)

------------------------------

Donate:   https://www.buymeacoffee.com/mreliptik

Follow on Twitter for updates:
http://twitter.com/VicMeunier