# Assignment-3-Forest-Fire

#### Extra Feature 1: NPC following the user 
![alt text](https://github.com/FionaOwen/Pictures/blob/main/Project%201.png)

This feature adds functionality to the Forest Fire scene by introducing a dynamic Non-Player Character (NPC) that follows the user, including responsive animations, based on the distance between the NPC and the user. The concept of target tracking is applied, guiding the NPC towards an escape window. By setting a distance threshold, the NPC adopts a slow-running animation when further from the user and switches to an idle position as it approaches. This feature enhances the scene by creating a responsive NPC behaviour, smoothly tracking the user, adjusting animations based on distance, and continuously adapting to the player's movements. This adds a layer of realism and interactivity to the scene.

#### Extra Feature 2: Punch 
![alt text](https://github.com/FionaOwen/Pictures/blob/main/Project%203.png)

This feature enhances the Forest Fire scene by introducing player interaction. Through the implementation of a punch detection mechanism, the user can engage with the werewolf, preventing it from causing harm to either the player or an NPC. Punches are registered when a collider with the ‘hand’ tag enters the werewolf's trigger zone. A variable keeps a record of the number of punches and once it reaches a predefined limit, it triggers a ‘sit’ animation and disables the Werewolf, restricting any further movement.  Serialised fields facilitate easy adjustments in Unity Editor, which allows developers to adjust values without modifying the script.


### Credits
1. Mannequin and Animations: Mixamo 
2. Wolf 3D Model and Animations: DzenGames
