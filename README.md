# GameJam

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

Player Jumping //player_controls.cs //PlayerCollision.cs

Check is there is a ground.The cloud had a "ground" tag 
The jump mechanic communicates with the ground tag
Jump uses the players rigidbody does a ground check and dtilize jumpforce.
Player is juping with the use of RigidBody2D(physics)& BoxCollider(so he wont fall down)
When the sword and player collides into eachother's colliders it loads the "retry screen" Also whenn it collides it activates a sound effect,
Moving left and right
players velocity = A/D key * speed
Audiosource plays on trigger
