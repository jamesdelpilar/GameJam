# Game Jam Humber Fall 2020

Sword Movement //move_an_object.cs

The swords are moving through -X and  coordinate -y (meaning swords are moving left and slightly downards)


Spawning //End.cs // Spawner.cs

There are 2 colliders:
One on the left side/outside of the screen - This destroys the sword when it collides/triggers
On the right side/outside of the screen - There are 5 fixed spawnpoints but in the begginning I have 5 swords coming at you at once (this is so when you play for the 1st time the player if forced to press spacebar multiple times, which kinda teaches them you can jump multiple times)

Menu //MenuControl.cs // PlayerCollision.cs

Attaches to buttons and loads a scene

Score //Score.cs // ScoreCollider.cs

When the sword touches a collider past the screen/player it does a "score ++;" code which is attached to the text

Main Camera //sound.cs

Player Jumping //player_controls.cs //PlayerCollision.cs

Check is there is a ground.The cloud had a "ground" tag 
The jump mechanic communicates with the ground tag
Jump uses the players rigidbody does a ground check and dtilize jumpforce.
Player is juping with the use of RigidBody2D(physics)& BoxCollider(so he wont fall down)
When the sword and player collides into eachother's colliders it loads the "retry screen" Also whenn it collides it activates a sound effect,
Moving left and right
players velocity = A/D key * speed
Audiosource plays on trigger

Members of Group 16:

James Del Pilar 
Alberto Barrios 
Simran Punia 
Ivan Chernychko 
Minh Quan Doan 
Ryan Jaros


Music Used:
"Makai Symphony - Dragon Castle" is under a Creative Commons license (CC BY-SA 3.0).
Music promoted by BreakingCopyright: https://youtu.be/9gBTKiVqprE

Unity Published Game:
https://connect.unity.com/mg/other/sky-hero-1

itch.io Published Game (Aspect Ratio Issues may occur):
https://jamesdelpilar.itch.io/skyhero

itch.io Download Game:
https://jamesdelpilar.itch.io/sky-hero-download

Unity Package (Unity 2019.3.13f1) Public Download:
https://drive.google.com/drive/folders/1yzJ-3wCKzLcbfuMCUYRaIIHvGUzpBc6p?usp=sharing

GitHub:
https://github.com/jamesdelpilar/GameJam

YouTube Link:
https://www.youtube.com/watch?v=eZwlayEc5Xs&ab_channel=JamesDelPilar

Trello Board:
https://trello.com/b/ASdTWDvc/game-jam-game-100-105

