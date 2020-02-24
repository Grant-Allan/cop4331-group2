# Program Organization

### System Context Diagram
![System Context Diagram](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/system_context_diagram.png)

Our game is designed to be played by one person at a time. The Player will play the game, view the leaderboard, and change the game settings through the BeezleBop Minigame Arcade gaming system. The gaming system itself will be developed by the Unity3D gaming engine, but our final product will run without any external dependencies.






### Container Diagram
![Container Diagram](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/container_diagram.png)

* Player (person): The user of the game. The player directly controls the Game with user input. Only one person may use the game at a time. 
* Game Context (Software System): The context created when the Player executes our product game. 
* Main Menu Container: The main menu is the container which allows the Player to access all aspects of our project such as the settings, leaderboard, quit, and most importantly the minigame loop.
* Minigame Loop Container: The minigame loop provides the Player with a series of minigames that the Player must beat in order to advance. The Player's score and health will be updated throughout the Minigame loop.



### High Level Architecture and User Stories Table

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

Internally, we will need to maintain data pertaining to the Player such as health, score, name, volume and et cetera. These data values will be local variables that we can store and modify as needed. These data values will belong to Unity GameObjects and will be handled by scripts when the game is running. No data will be saved when the product game is closed. We do not need to consider our database in our project.

# Business Rules

Currently, there are no official rules or guidelines we must follow regarding video games. However, we will strive to make sure our game is understandable and playable by people of all levels of videogame experience.

# User Interface Design

![User Interface Diagram](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/user_interface_document.png)

* Main Menu screen: First screen shown when you start the program. This screen displays 4 options: "Start Game," "Leaderboard," "Settings," and "Exit." Each of these buttons will lead to the next UI screen with the exception of "Exit."
* Minigame screen: Shown when the "Start Game" button is clicked in the Main Menu screen. This screen displays a randomly generated minigame for the user to play out. The minigame will be selected from a finite pool of minigames.
* Pause screen: While the user is in the Minigame screen, the user may input the "Esc" button on the keyboard and enter the Pause screen. This screen will display two options: "Unpause" and "Restart." "Unpause" will continue the game. "Restart" will restart the game from the beginning.
* Leaderboard screen: Can be accessed from the Main Menu screen via the "Leaderboard" button. This screen will display the users highscores. Highscores have a direct correlation to the amount of minigames completed in a single play through the game.
* Settings screen: Can be accessed from the Main Menu screen via the "Settings" button. Will provide an option to change the volume of the overall game. (More features may be added in the future)
* Transistion screen: Will be shown after the user has completed a minigame on the Minigame screen. Will display the amount of lives left for the user and procceed to the next minigame.
* Game Over screen: Will be shown once the user has lost all lives (3 or 5). Will show an "ok" button that will take the user back to the Main Menu screen.

![Main Menu](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/main_menu.JPG)
![Pause](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/pause.JPG)
![Leaderboard](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/leaderboard.JPG)
![Settings](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/settings.JPG)
![Game Over](https://github.com/rashawnpeters/cop4331-group2/blob/master/Artifacts/images/game_over.JPG)

* User Interface and User Stories Table

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

We will only need to perform resource management within the minigames of our Minigame Arcade. Many of our minigames only involve a few moving objects and so they will not require their own resource management plan as they use relatively few resources. However, we are planning a few minigames that require a large number of moving objects. The cost of instantiating and/or destroying a large number of objects can cause slowdowns of our CPU. In this case, we can improve performance by using object pooling, which decreases the load on the CPU.

# Security

We are creating a game that users are able to modify if they please; therefore, we do not need any security measures put into place. Furthermore, our videogame is singleplayer and will be locally run on the Player's computer, so we don't need to worry about securing user data. We conclude that security is not a consideration in our system architecture.

# Performance

The graphics of our game are in a 2 Dimentional 8-Bit style, which should not be graphically intensive. Furthermore, the minigames are the most computationally intesive part of our project. These minigames are designed to be simple and independent, so they will have a low cpu and memory usage. Because of these two factors, we believe that our game will perform well under our system architecture on any reasonable gaming computer.



# Scalability

The game will be able to be updated with new minigames to increase the games variance between each playthrough. Slightly bigger, badder, and more dangerous minigames called "Boss Stages" can also be added into the mix to present more of a challenge to veteran "Beezlebop-ers." The structure of our code will allow for the further addition of new minigames later down the line. This will be done by keeping the minigames self-contained, and not depending on other minigames. They will draw from a common interface with certain attributes that all minigames will need.

# Interoperability

Our product will not need to share data or resources with any other software or hardware because it is created within the Unity3D engine. Interoperability is not a consideration in our system architecture.

# Internationalization/Localization

Our project will only be released within the United States in English, so this section does not apply. 

# Input/Output

For input the Player will be using the computer WASD keys to navigate through the menu and the spacebar to confirm selections. The Player will be using those same keys to play the minigames as well. When a player has finished a game, they will be prompted to input their name for their stats to be tracked on the leaderboard menu. All I/O errors will be handled by the Unity3D input system.

# Error Processing

Most of the error processing will be handled by the Unity3D engine. Because this is a video game and errors are less important than other software such as an online banking system, the user will not be notified of an error and the game program will continue as usual. All errors will be sent to the Console Window in Unity for debugging. Specifically, any bug or event that deviates from the intended behavior of our game will send an error to the console. However, error processing will never involve the Player in our final product.

# Fault Tolerance

In our development strategy, we will ignore small bugs and glitches because reliability and security is not the highest priority because we are designing a game. In this sense, fault tolerance is not very important for our project. Additionally, our minigames are all independent, and there are not many values being maintained in our program that could be erroneous or cause an error.

# Architectural Feasibility

Our architecture is relatively simple. The basic components of our product like the leaderboard, settings, and game play cycle are all relatively simple and easy to implement. Our minigames are designed to be small, manageable game programs within the Minigame Arcade, so implementing them should not be too much difficulty. All of us have some experience with C# and we are in the process of learning Unity3D, and we believe our architecture is feasible within the development period. 


# Overengineering

We will keep our product robust without overengineering by sticking to SOLID coding principles. First we will construct the basic building blocks of our BeezleBop Minigame Arcade, which include the settings, quit, leaderboard, and game loop structure. Then we will focus on our minigames, which are all highly modular and exist only in one or a few different contexts. Because of this, we can make our code robust without overengineering. We have currently created the scope of our project with the three month development period in mind. We envision our minigames as being simple and relatively short, so we can avoid overengineering by sticking to our ideal of simple, short minigames. We will tune back certain features if overengineering becomes a factor further into the development process.



# Build-vs-Buy Decisions

We are building this project on the free Unity3D game engine. All software in our final product will be built by us. All animation drawings will be drawn by us, and the 8-bit music that will be used in the game will be outsourced to another individual at no expense to us. The Unity3D game engine and all the packages in the Unity3D asset store are free, so using this software comes at no cost to us. Unity3D provides significant software functionality with its built-in user interface system. We will have no need to buy any additional software for our final product. Because all the existing software that would be useful to us is free, our Build-vs-Buy decision was very straightforward.

# Reuse

No preexisting software, test cases, data formats or other materials will be used in our product, so this section is not applicable. 

# Change Strategy

A lot of the content in our project is within highly independent minigames. This makes our project more modular and makes it easier to perform changes to our software. If we wish to change an individual minigame, then we can make changes within the minigame without considering the rest of our product. Otherwise, if we want to make a change to the overall structure of our game, then we can use the modular minigames in any way we want, since they all run independently and make no assumptions about their context. More generally, we plan to write the code in an organized way to make it easy to alter. This includes using SOLID coding principles and Clean code practices. We will meet biweekly to discuss future changes and how we can adapt our architecture to meet our project needs.
