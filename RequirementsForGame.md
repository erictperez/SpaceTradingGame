# Space Trading Game

Start on Earth
Have at least 5 planets to which the player can travel
Player at start of game should be 18 years old and have a ship (or ability to gain a ship) and a small amount of starting currency (credits)
Game ends when the player reaches the game goal or ages to 60yo

Primary goal of the game is amass wealth by trading goods and services among plantets

You write the story
Your game should have a "good", "bad" ending, optionally a separate "age out" ending
Your game should have a compelling story
User interface should be a TUI built as a console application

Travel between planets should follow a standard "warp speed" calculation (I will provide)
Planets should be arranged on a 2D X/Y coordinate system, s.t. distances between planets are provided by the pythagorean theorem
Earth should be at the origin (x = 0, y = 0)
One of the remaining 4 (minimum) planets should be alpha proxima 1 (x = ~4.7, y = 0)
Travel between planets should occur at a user-defined speed specified in warp units, potentially limited by ship speed or other conditions

Ships have a specified capacity which can not be exceeded


## Stretch goals
Space piracy & other random events
Conditions which allow faster than normal travel (ship upgrades, natural phenomena [wormhole], stargate, etc.)
Ships consume fuel when travelling
Ship flying mini game (asteroid field)

## Warp Equation
Given Warp speed (W) with non-inclusive bounds of 0 and 10, velocity in multiples of the speed of light = W^(10/3)  + (10 − W)^(-11/3).

Thus, if you want to travel to a location 1 light year away in one day, you need a warp factor which equates to a velocity of 365.25 times the speed of light. 

## Side Note:
Create the REPO
Add the other user
Both clone
Create an "AUTHORS" document and README
Have each user push their own name to the AUTHORS document.
git commit
git pull
git push
