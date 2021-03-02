# Project 3 - *MineSweeper*

**MineSweeper** is a class assignment that requires to use Visual Studio 2019 as the IDE and C# programming language. The appropriate VS19 project
type for this is assignment is "Windows Forms App (.NET Framework)/C#".

**MineSweeper** is a single-player puzzle video game. The objective of the game is to clear a
rectangular board containing hidden "mines" or bombs without detonating any of them, with
help from clues about the number of neighboring mines in each field.

Time spent: **~15** hours spent in total

Here's a walkthrough of the app:

<img src='https://github.com/apena141/MineSweeper/blob/main/demo.gif' title='Video Walkthrough' width='' alt='Video Walkthrough' />

GIF created with [LiceCap](http://www.cockos.com/licecap/).

The following **required** functionality is completed:

- [x] Main Form
  - [x] One System.Windows.Forms.TextBox object for displaying the number of currently open games.
  - [x] One System.Windows.Forms.TextBox object for receiving the player name from the user.
  - [x] Four radio buttons for labels Easy, Medium, Expert, and Custom (by default, Medium is checked).
  - [x] One System.Windows.Forms.Button object to start a new game.
  - [x] One System.Windows.Forms.Button object to end all currently open games.
  - [x] One System.Windows.Forms.MenuStrip object with items "Play a new game", "Close all games", "Exit". The first item has a sub-menu containing "Easy", "Medium", and "Expert".

- [x] A click on the "Play a new game" should results in one of these possibilities
  - [x] If any radio button except "Custom" is checked, a new form containing an empty board is shown, but a new game has not started yet.
  - [x] If "Custom" radio button is checked, a dialog must appear on screen and asks user to input three parameters: int row (# of rows of the game board), int col (# of columnsof the game board), and int mines (# of mines in the game board). If any negative
number is entered, row*col < 18, or mines > row*col/2, then the user should be asked
- [x] The "Easy" game parameters are row = col = 9, and mines = 10. The "Medium" game parameters are row = col = 16, and mines = 40. The "Expert" game parameters are row =
30, col = 16, and mines = 99.
to enter the parameters again, otherwise, a new game board is shown on screen.

The following **optional** features are implemented:
- [x] Game and clock starts when the player makes the first left-click on one the buttons on the board.
- [x] Mines get distributed randomly throughout the board after first left-click.
- [x] Right-click on a covered cell will place a flag on the cell clicked.
- [x] Game timer pauses when user clicks outside of board and resumes when clicked on board.
- [x] Game timer pauses when game is over and sends feedback to user they lost.
- [x] Closing a open games asks user if they are sure they want to close.
- [x] "End all open games" closes all current games open.
