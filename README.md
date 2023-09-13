# simple-pong

## General Information
1. Full unity projects are difficult to push to github due to file size constraints, so in this repository are the C# scripts for a simple pong game.
2. The game starts on the opponent's turn.
3. The player can be controlled with arrow keys.
4. When either the player or the opponent scores, the scoreboard will be updated by one point.

## Script Information
1. ballScript.cs handles the ball's motion and bounces using a rigidbody (myRigidBody) and a vector (direction) to represent its collision behavior and direction.
2. logicScript.cs handles the scoreboard of the game, as well as the resetting of the player, opponent, and the ball's position and direction upon each score.
3. PT_script.cs (player trigger) and OT_script.cs (opponent trigger) handle the Trigger2D game objects that help determine when the ball goes into either the player's or opponent's goal.
4. opponentScript.cs handles the opponent's behavior and movement. In its simplest form, the opponent will trace the ball's y position, though do so with very slow movement.
5. playerScript.cs handles the player's movement, also ensuring that it stays within the boundaries of the game board.

## Images
1. When the game is first started, the board will look like this.
![gameboard](https://github.com/ngolp/simple-pong/assets/144621445/82e69ddd-df7b-4d45-80e7-b1fd5bd74f03)

2. When either side scores (in this case, the opponent), the scoreboard will be updated as shown (the opponent scored twice).
![scoreboard](https://github.com/ngolp/simple-pong/assets/144621445/01f152f8-0344-4e61-8041-f1c4b055a4fa)

## Authors
 - Nicholas Golparvar
