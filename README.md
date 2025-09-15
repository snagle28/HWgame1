HOW TO PLAY:
1


# HWgame1
Flatgame

PROMPT: A short (150 to 200 words) devlog about your intentions for this project, what you learned, and how well you think you did.

For this project, I was inspired by some of the flatgames we discussed in class. 
I had to do a bit of research into unity's UI, specifically, using a canvas and creating the materials. The hardest part of implementing this was all of the layering, scaling, organizing, and playtesting I had to do to get it right; this included hard-coding trigger boxes, starting over entirely to use trigger components, re-ordering everything, and consolidating several scripts. The process taught me a lot about how to cross-reference objects and prioritize concision and simplicity in my code. 
Overall, I think it works well, because this was my first time making a game in Unity. I feel like my scaling was a bit jank, and I wish I had more time to polish things and add a small tutorial/intro. I would definitely spend more time on this one, but overall, I had a lot of fun with it, and am happy with what I learned.
 



STUFF FOR ME:
Initial goal: Wanted to make a short bit of written prose and have it move incrementally every time the speech bubbles and text were lined up. 

Things I've learned (before initial commit) 
1. in order to make the "reverse" masking system, i had to utilize the mask materials. Unity could create a mask of paper on the background, but not the other way around. In order to do this, with a bit of research, I used the materials from the mask and the masked surface, and SWAPPED them on each game object. this worked!
2. I originally tried to have the scenes (each verse) be separate, with a shared script. this led to a  lot of confusion- poorly executed references, missing variables, etc. With the advice of daniel i parented all the stuff onto one scene, which streamlined things.
3. originally controlled the code to check for overlap inside of the triggers, not the masks. Bad.
4. i also hard-coded checking for collisions by finding the width/height of each speech bubble and checking it with the triggers. after class on 9/8, i learned a much more efficient way to do this.
5. Had to combine scripts. Global trigger could become part of the scene script, and i didn't need to code anything on the trigger fields. 
