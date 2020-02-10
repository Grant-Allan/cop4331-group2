Populate each section with information as it applies to your project. If a section does not apply, explain why. Include diagrams (or links to diagrams) in each section, as appropriate. For example, sketches of the user interfaces along with an explanation of how the interface components will work; ERD diagrams of the database; rough class diagrams; context diagrams showing the system boundary; etc.

# Program Organization

* [High Level System Context Diagram](https://drive.google.com/open?id=1fBGgtRbptirduLq4V3FgDUbiGbtzVavR3OgEFIwpN6A)

* [High Level Architecture and User Stories Table](https://docs.google.com/spreadsheets/d/1zdU818LYJrSiTwV1lMdpcRenk0wmDiD_mqKB8IdFmb8/edit?usp=sharing)

# Major Classes

* [Class Diagram](https://drive.google.com/open?id=1whEYAJHdVstfufMPsA3q2mUNBmp2zzbTo6CBhDky6mg)

* [Classes and User Stories Table](https://docs.google.com/spreadsheets/d/10gMX3J2eLyLBGGlVqlST6ApMDbC5cVMB9u_VOisA83M/edit?usp=sharing)

* Player class: this handles the main game mechanics and information for the player. The player's name, lives, and score are tied to this class. This information is accessed by the Leaderboard and Transistion classes, as they need this information to display it on the screen for the user. It has a composition relationship to the classes for each individual minigame, because all the minigames run off of this starting class. 
* Main Menu (UI) class: This class handles the main display for the game, including all of its buttons and functionalities. It has a composition relationship to the Leadership and Transition classes because they don't exist without the Main Menu class first.
* Leaderbeard (UI) class: This class displays the leaderboard and includes a button to exit back to the main menu screen.
* Transition (UI) class: This class displays information between the minigames. This includes displays the lives and current level.
* Game Over (UI) class: This class is the display shown when the game is lost. It includes a main menu button and an exit button. It also inherits from the transition class.
* Minigames: Each of the many minigames will have its own class because they may have difference attributes and methods. As there will be many minigames, we felt it was too much to include in the class diagram. We kept it to the major classes. Each minigram class will inherit from a minigame interface, which has a set of standard attributes and methods that each should need.


# Data Design

We are not using databases for this project. All data will be stored in data structures of various types.

# Business Rules

You should list the assumptions, rules, and guidelines from external sources that are impacting your program design. 

# User Interface Design

* [User Interface Diagram](https://drive.google.com/open?id=1FexvPpQ8Ox2AmTJ0VWvaqbrU6XRwpKBc0SEi-uM7ASg)

* [UI and User Stories Table](https://drive.google.com/open?id=1_HayEiugMIzurYnrgulZgZl15rbOsW379TlGrbu7EnQ)

# Resource Management

Due to our group being comprimesd of college students, resources will be managed individually in accordance to our class schedules and budgets. Because of this, resource management does not apply to this project.

# Security

We are creating a game that users are able to modify if they please; therefore, we do not need any security measures put into place. 

# Performance

The performance of the game almost entirely relies on the capabilities of Unity and the users computer. Otherwise, we will write code with efficiency and speed in mind.

# Scalability

The game will be able to be updated with new minigames to increase the games variance between each play-through.

# Interoperability

We currently plan to make this a game to work on Windows computers. We may or may not make plans for capatibility with mobile devices further into the development cycle.

# Internationalization/Localization



# Input/Output



# Error Processing

# Fault Tolerance

# Architectural Feasibility

# Overengineering

# Build-vs-Buy Decisions

This section should list the third party libraries your system is using and describe what those libraries are being used for.

# Reuse

# Change Strategy
