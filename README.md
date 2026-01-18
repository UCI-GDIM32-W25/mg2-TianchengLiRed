[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog

During the break down section, I seperate the whole game to different objects and decide to achieve each function and attributes seperately. Bird gameobject with compoenent of collider2D, rigidBody2D and script to implement jump and collison detect. GameController with component of script to randomly generate Coin prefab in the scene. Coin as prefab with component of collider and rigidbody andn a script to make it move to left constantly. UI with script to update point to the text. Then I compared it against the plan and linked each plan to my code. I make bird call jump() to jump, call OncollisionEnter2D and OnCollisonTrigger2D() to detect if bird collide with ground to reset jump, and get point from coin. UI calls Updatetext() every frame from Update().GameController using while loop on IEnumerator generate()to randomly generate coins. Coins call Update() to translate their location every frame to make them move to left. My plan changed after view professor's plan. Before i viewed it i think i can implement generate on prefabs script. After that i realize it is much more easier if i create a emptyObject to generate prefab.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites