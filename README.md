# PongController

A controller/game created for the 2020 Falmouth University 1st year pong controller competition, winning first place. The brief was to create a hardware controller using an arduino, and a version of pong that interfaced with it. Although some sensors were provided, I preferred to create my own pads that functioned as buttons, to allow me a little more flexibility.

The sensors were designed as cardboard pads with a top and bottom side coated in tin foil. The bottoms were all wired to ground, and the tops were individually connected to inputs on the arduino. I had originally intended for it to be two-player, however I ran out of duct tape to make the controllers, and made the second player "ai" controlled.

To play the game, the user must press the pads when the corresponding arrow reaches the line on the screen. This will provide the maximum amount of points, with less accurate presses yielding less points. This will increase the score, which is then fed back to the right paddle. A higher score makes the paddle move faster towards the ball, whereas the opponent is limited in speed.
