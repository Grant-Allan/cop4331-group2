# Program Organization

![System Context Diagram](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/system_context_diagram.png)

* Player (person): The user of the game. The player directly controls the Game with user input. Only one person may use the game at a time. 
* Game (Software System): Randomly generates a finite number of minigames in which the user will navigate till completion. Information will be stored from the user after completion of the game.

* High Level Architecture and User Stories Table

| **ID** | **User Story**                                                                                              | **High Level Architecture** |
| ------ | ----------------------------------------------------------------------------------------------------------- | --------------------------- |
| 000    | As a player, I want a main menu, so that I can have access to the main game modes                           | Game                        |
| 001    | As a player, I want a clickable play button, so that I can begin the game                                   | Game                        |
| 002    | As a player, I want to access the leaderboard from the main menu, so that I can evaluate my performance     | Game & Player               |
| 003    | As a player, I want a volume button, so I can control the volume of the music                               | Game                        |
| 004    | As a player, I want a quit button, so that I can return to the main menu                                    | Game                        |
| 005    | As a player, I want the controls displayed in the main menu, so that I know which buttons to use            | Game                        |
| 006    | As a player, I want my winning scores to be entered in the leaderboard where I can enter my name            | Game & Player               |
| 007    | As a player, I want to have multiple lives, so that I can have multiple chances when I lose a minigame      | Game                        |
| 008    | As a player, I want to see my lives, so that I know when I could lose                                       | Game & Player               |
| 009    | As a player, I want the minigames to keep cycling, so that I can keep playing until I lose                  | Game & Player               |
| 010    | As a player, I want to have my level displayed, so that I know how far I am into the game                   | Game                        |
| 011    | As a player, if I win a minigame I would like to progress to the next minigame so I can continue playing    | Game                        |
| 012    | As a player, if I run out of lives I would like to return to the main menu so that I can replay             | Game & Player               |
| 013    | As a player, I want the music and game to increase in tempo after each win so that the difficulty increases | Game                        |
| 014    | As a player, I want a timer shown, so that I know when the minigame will end                                | Game                        |
| 015    | As a player, I want appropriate, in-tempo music to accompany the minigames I play.                          | Mini Game                   |



# Major Classes

![Class Diagram](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/class_diagram.png)

* Player class: this handles the main game mechanics and information for the player. The player's name, lives, and score are tied to this class. This information is accessed by the Leaderboard and Transistion classes, as they need this information to display it on the screen for the user. It has a composition relationship to the classes for each individual minigame, because all the minigames run off of this starting class. 
* Main Menu (UI) class: This class handles the main display for the game, including all of its buttons and functionalities. It has a composition relationship to the Leadership and Transition classes because they don't exist without the Main Menu class first.
* Leaderbeard (UI) class: This class displays the leaderboard and includes a button to exit back to the main menu screen.
* Transition (UI) class: This class displays information between the minigames. This includes displays the lives and current level.
* Game Over (UI) class: This class is the display shown when the game is lost. It includes a main menu button and an exit button. It also inherits from the transition class.
* Minigames: Each of the many minigames will have its own class because they may have difference attributes and methods. As there will be many minigames, we felt it was too much to include in the class diagram. We kept it to the major classes. Each minigram class will inherit from a minigame interface, which has a set of standard attributes and methods that each should need.

* Classes and User Stories Table

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
| 1      | As a player, I want a main menu, so that I can have access to the main game modes                           | Main Menu               |
| 2      | As a player, I want a clickable play button, so that I can begin the game                                   | Main Menu               |
| 3      | As a player, I want to access the leaderboard from the main menu, so that I can evaluate my performance     | Main Menu & Leaderboard |
| 4      | As a player, I want a volume button, so I can control the volume of the music                               | Main Menu               |
| 5      | As a player, I want a quit button, so that I can return to the main menu                                    | Transition              |
| 6      | As a player, I want the controls displayed in the main menu, so that I know which buttons to use            | Main Menu               |
| 7      | As a player, I want my winning scores to be entered in the leaderboard where I can enter my name            | Game Over & Leaderboard |
| 8      | As a player, I want to have multiple lives, so that I can have multiple chances when I lose a minigame      | Transition              |
| 9      | As a player, I want to see my lives, so that I know when I could lose                                       | Transition              |
| 10     | As a player, I want the minigames to keep cycling, so that I can keep playing until I lose                  | Mini Game               |
| 11     | As a player, I want to have my level displayed, so that I know how far I am into the game                   | Transistion             |
| 12     | As a player, if I win a minigame I would like to progress to the next minigame so I can continue playing    | Transistion             |
| 13     | As a player, if I run out of lives I would like to return to the main menu so that I can replay             | Game Over & Leaderboard |
| 14     | As a player, I want the music and game to increase in tempo after each win so that the difficulty increases | Transistion             |
| 15     | As a player, I want a timer shown, so that I know when the minigame will end                                | Mini Game               |
| 16     | As a player, I want appropriate, in-tempo music to accompany the minigames I play.                          | Mini Game               |

# Data Design

We are not using databases for this project. All data will be stored in a text file.

# Business Rules

Currently there are no external guidelines or rules regarding our work. 

# User Interface Design

![User Interface Diagram](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/user_interface_document.png)

* Main Menu screen: First screen shown when you start the program. This screen displays 4 options: "Start Game," "Leaderboard," "Settings," and "Exit." Each of these buttons will lead to the next UI screen with the exception of "Exit."
* Minigame screen: Shown when the "Start Game" button is clicked in the Main Menu screen. This screen displays a randomly generated minigame for the user to play out. The minigame will be selected from a finite pool of minigames.
* Pause screen: While the user is in the Minigame screen, the user may input the "Esc" button on the keyboard and enter the Pause screen. This screen will display two options: "Unpause" and "Restart." "Unpause" will continue the game. "Restart" will restart the game from the beginning.
* Leaderboard screen: Can be accessed from the Main Menu screen via the "Leaderboard" button. This screen will display the users highscores. Highscores have a direct correlation to the amount of minigames completed in a single play through the game.
* Settings screen: Can be accessed from the Main Menu screen via the "Settings" button. Will provide an option to change the volume of the overall game. (More features may be added in the future)
* Transistion screen: Will be shown after the user has completed a minigame on the Minigame screen. Will display the amount of lives left for the user and procceed to the next minigame.
* Game Over screen: Will be shown once the user has lost all lives (3 or 5). Will show an "ok" button that will take the user back to the Main Menu screen.

* UI and User Stories Table

| **ID** | **User Story**                                                                                              | **User Interface Components** |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------------- |
| 1      | As a player, I want a main menu, so that I can have access to the main game modes                           | Main Menu                     |
| 2      | As a player, I want a clickable play button, so that I can begin the game                                   | Main Menu                     |
| 3      | As a player, I want to access the leaderboard from the main menu, so that I can evaluate my performance     | Main Menu & Leaderboard       |
| 4      | As a player, I want a volume button, so I can control the volume of the music                               | Main Menu (Settings Pop-Up)   |
| 5      | As a player, I want a quit button, so that I can return to the main menu                                    | Pause                         |
| 6      | As a player, I want the controls displayed in the main menu, so that I know which buttons to use            | Main Menu                     |
| 7      | As a player, I want my winning scores to be entered in the leaderboard where I can enter my name            | Game Over & Leaderboard       |
| 8      | As a player, I want to have multiple lives, so that I can have multiple chances when I lose a minigame      | Transition                    |
| 9      | As a player, I want to see my lives, so that I know when I could lose                                       | Transistion                   |
| 10     | As a player, I want the minigames to keep cycling, so that I can keep playing until I lose                  | N/A                           |
| 11     | As a player, I want to have my level displayed, so that I know how far I am into the game                   | Transistion                   |
| 12     | As a player, if I win a minigame I would like to progress to the next minigame so I can continue playing    | Transistion                   |
| 13     | As a player, if I run out of lives I would like to return to the main menu so that I can replay             | Game Over & Leaderboard       |
| 14     | As a player, I want the music and game to increase in tempo after each win so that the difficulty increases | Transistion                   |
| 15     | As a player, I want a timer shown, so that I know when the minigame will end                                | N/A                           |
| 16     | As a player, I want appropriate, in-tempo music to accompany the minigames I play.                          | N/A                           |

# Resource Management

Due to our group being comprimesd of college students, resources will be managed individually in accordance to our class schedules and budgets. Because of this, resource management does not apply to this project.

# Security

We are creating a game that users are able to modify if they please; therefore, we do not need any security measures put into place. 

# Performance

The performance of the game almost entirely relies on the capabilities of Unity and the users computer. Otherwise, we will write code with efficiency and speed in mind.

# Scalability

The game will be able to be updated with new minigames to increase the games variance between each play-through. Slightly, bigger, badder, and more dangerous minigames called "Boss Stages" can also be added into the mix to present more of a challenge to veteran "Beezlebop-ers."

# Interoperability

We currently plan to make this a game to work on Windows computers. We may or may not make plans for capatibility with mobile devices further into the development cycle.

# Internationalization/Localization

For the purposes of the project we won't be doing any localization or internalization. We only require an English translation and the program to be written in C#.

# Input/Output

Nothing will be inputted or outputted due to the nature of a video game.

# Error Processing

Error Processing will be handled internally.

# Fault Tolerance

Our program will account for fault tolerance via good programming strategems.

# Architectural Feasibility

We will be conducting gampeplay tests internally to account for architectural feasibility.

# Overengineering

We have currently created the scope of our project with the 3 month development period in mind. We will tune back certain features if overengineering becomes a factor further into the development process.

# Build-vs-Buy Decisions

We have not yet decided on all the third party libraries that will be used in our game at this time.

# Reuse

The game will be able to be played as many times as the user desires.

# Change Strategy

...
