# HWgame1
Flatgame


Initial goal: Wanted to make a short bit of written prose and have it move incrementally every time the speech bubbles and text were lined up. 

Things I've learned (before initial commit) 
1. in order to make the "reverse" masking system, i had to utilize the mask materials. Unity could create a mask of paper on the background, but not the other way around. In order to do this, with a bit of research, I used the materials from the mask and the masked surface, and SWAPPED them on each game object. this worked!
2. I originally tried to have the scenes (each verse) be separate, with a shared script. this led to a  lot of confusion- poorly executed references, missing variables, etc. With the advice of daniel i parented all the stuff onto one scene, which streamlined things.
3. originally controlled the code to check for overlap inside of the triggers, not the masks. Bad.
4. i also hard-coded checking for collisions by finding the width/height of each speech bubble and checking it with the triggers. after class on 9/8, i learned a much more efficient way to do this.
5. Had to combine scripts. Global trigger could become part of the scene script, and i didn't need to code anything on the trigger fields. 
