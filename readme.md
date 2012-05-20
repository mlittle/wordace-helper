## Word Ace Helper

.NET application that calculates possible Word Ace hands and their values.


### What is Word Ace?

Texas Hold'Em __+__ Words With Friends (aka Scrabble) __=__ Word Ace

Game is part of the suite of casino games that are included with "Card Ace: Casino" on [iPhone](http://itunes.apple.com/us/app/card-ace-casino/id398692284?mt=8)/[iPad](http://itunes.apple.com/us/app/card-ace-casino-hd/id408468471?mt=8).

### Screens
![](http://i.imgur.com/vrpYV.png)![](http://i.imgur.com/ZM62r.jpg)

### Why?

CIC of course! ;)

I realize there are already 'helpers' out there for word ace.

Example: [Anagrammer's Word Ace Helper](http://www.anagrammer.com/word-ace/) - determines your possible hand and hands that could beat you.

But knowing the possible hands is only part of the game.  The other part is betting strategy.  Calculating hand odds would aid with betting.  Not sure at this point what will be feasible, but at a minimum it could determine your 'outs' which in turn determine best possible hands.

### Notes

When launching the application, it currently looks in the current working directory for a wordlist.txt.  You will need to provide your own list of words.  Check the FAQ for details.

### TODOs

Calculate the hand value for the 'negative' E & S cards. -E/-S are valued the same way the regular E/S are valued currently.

Determine hand probability

Allow user to specify word list location at run-time

### FAQ

#####*What is the format of the word list?*
Plain text file with one word per line. When the list is loaded, any word over 7 letters is thrown out since the max hand length is 7 letters.

#####*Where can I get a word list?*

I found a decent list of words that yields fairly good results on [Google Code](http://code.google.com/p/dotnetperls-controls/downloads/detail?name=enable1.txt). Rename it to wordlist.txt and place it in the working directory (i.e. same dir as the exe) before running the application.

#####*What is the card distribution and card point values in a word ace deck?*

[Straight from the game publisher's blog:](http://www.selfawaregames.com/2009/08/21/word-ace-letter-distribution/)

(E), (S) = backwards E/S

Number of each letter in the deck:
* E = 10
* A,I,O = 7
* R,T,N,L,C = 5
* U,D,P = 4
* M,H,Y,S = 3
* G,B,F,W,K,V = 2
* X,Z,J,Q, (E), (S) = 1

Point value of all letters:
* (E), (S) = -2pts
* A, E, I, O, U, S, T, N, R, L = 1pt
* C, D, P, M, H = 2pts
* G, B, F, Y = 4 pts
* W, K, V = 6 pts
* X, Z, J = 8 pts
* Q = 10 pts


