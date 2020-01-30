# Snake-3D 
There are no external tools or assets used in this project.
Link :- https://drive.google.com/open?id=1yGNDpRJUqMYJ1i1a4Tqgou-V3ZhR3Kwx

Design of Code
This Simple 3D Snake game has two scenes which are Main scene and GameScene;and a start button is attached to the start scene in order to start the Game.
This game has a Snake which will move in the direction of horizontal and vertical (as it is a top down type game i am referring z- axis for vertical and x-axis for horizontal).This snake character will not move backwards of the current direction.
The play area is limited to a plane, so the player cannot move out side of the play area and also attached walls at each side of the play area.so if our snake character collides with walls or snake itself character will die and game over screen will popup.
During the gameplay, the player has to collect different types of Food items which are spawned randomly once at a time.Player has to collect these spawned food in order to achieve scores.also if player collects 2 same types of food Score value will be multiplied by the streak and if he collected different types of food in between a streak, Streak will be resetted to zero. Eg if player collects 2 same type of food of value of 15,in a streak,then player will have a score of 15 +(15*2) = 45., if he collects different food in between then the streak value will resets to zero. ie he will get the normal value of the food for the time.
Snake length will increase according to the collected food and color of the increased part will be the color of collected food;
In this game there are 2 types of food(red,blue), which has  values of 15 and 20 respectively,This game is flexible for Spawning unlimited number of types of food
.In Game scene Player can see the current score,highest Score and as well as food type streaks.In Game over Screen player can see the current Score as well as the highest score. Also retry button and main menu button is added to navigate to the respective scenes.

Solution
1)Using unityengine Ui button is added for the Mainscene. And added click trigger events through Script;
2)Direction set up is based on vector3.forward,backward,left and vector3.right,booleans has been added to check the snake movement direction.so the snake will not come backwards of current direction
3)added a timer in the update Method of playerController to move the character in unit length(pixel by pixel)
4)Player area is limited by the walls and spawn position of food is based on the transform position of walls.so the food will spawn in between the walls
5)Scores and scorestreaks  are calculated in a static class and it is called in mono behaviour script at the time of displaying Score and streak value;
6)Snake length will be increased by adding prefabs at the end of the array at the time of collected Food.and also color of this prefabs are decided by the collected food.ie when player collected red food then the prefab color of the extended part will be red..
7)parameters food color and score values are defined by type of food collected and it is passed to the score and streak text.
8) box and sphere colliders are used to trigger events at the time of collecting food and death.
9)Game over panel buttons are using the same Script that is used in the maimenu.and it has the retry and back to main menu functions are attached to navigate through scenes.
