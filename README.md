# Workshop-1-Whack-a-Mole

--Folders--
Groundhog Day = Finished Game
Resources = Starter Sprites
Scripts = Starter Scripts (with comments)

--Steps--
Create a new Unity Project
	Set the name and make sure you select 2D game

Drag the Resources and Scripts folder into the project's Assets folder

Drag the field picture from Resources into the scene panel
	In the Inspector panel (usually @ the top right) set the position (under Transform) to (0, 0, 0)
	Reduce the image scale to a size that fit's mostly in the camera (0.5, 0.5, 1)

Drag the hole sprite from Resources into the scene panel
	Position it at (0, 0, 0) for now

In the hierarchy panel (usually @ the bottom left) you should see the Camera, field, and hole

Select the mole sprite in the Resources folder
	In the Inspector change the Sprite Mode to Multiple
	Click on the Sprite Editor button directly bellow (if a prompt appears choose apply)
	Click Slice (hard to find, check near the top left beneath where it says scene)
	Set the Type of the slice to Grid by Cell Count 10 x 1 (this cuts our sprite into 10 equal frames)
	Click Apply on the right side of the bar where you found the Slice button

Select the Scene tab again (above the slice button)
	Drag the newly cut mole sprite into the scene panel
	Unity will automatically ask you to create an animation, name your animation mole.anim and click save
	You will notice two new files in your resources folder, the animation and controller file

CHECKPOINT - Select the Play button above the Scene panel and you should see our mole animation looping

In the Assets folder (not the Resources folder) create a new folder called Prefabs (Right click --> Create --> New folder)
	Drag the Mole animation from the Hierarchy panel to the new Prefabs folder
	Delete the Mole animation from the Hierarchy panel ( :( Don't worry he'll be back)

Select the Hole object in the Hierarchy panel
	In the Inspector click on the Add Component button (at the bottom) and search for the "Hole" script 
	Click on the script to add it to the hole

Under the new Hole script you should see some values
	Alive Time = how long our mole object will stay alive
	Interval Min = the minimum amount of time before the hole spawns a mole
	Interval Max = the maximum amount of time before the hole spawns a mole
	Also, notice the filed that says Mole - Missing (Game Object)
	Drag the mole from the Prefabs folder into that field and you should see it change

From the Hierarchy select the hole and drag it to the Prefabs folder as well (it should turn blue in the hierarchy)
	Click on the hole in the Hierarchy and press Control + D to duplicate it as many times as you want
	Arrange your newly created holes however you like in the scene by dragging them around
	
CHECKPOINT - Select the Play button, you should now see our holes randomly spawning moles

Select the mole in the Prefabs folder and drag it back to our scenes folder (told you :) )
	Click on Add Component and search for the "Mole" script
	Click on the script to add it to the mole
	Click on Add Component again and search for "Box Collider 2D"
	Click on the add the Box Collider (make sure it's the 2D one) to the mole
	Change the Offset of the Box Collider to -1 and the size to 2 x 2
	Go to the top of the Inspector and make sure you press Apply to change the Prefab
	Delete the mole from the scene again ( goodbye mole! Q.Q)

Now go back to the resources folder and select the mole animation (the icon with the play button)
	Click on it and uncheck Loop Time

Now select the mole controller (the icon with the shapes)
	You'll see an orange box, which is our mole animation, click on it and change it's name to "spawn" (at the top of the inspector, press enter to save the new name)
	Drag another copy of the mole animation to the controller, you'll see a grey box, click on it and change it's name to "retreat"
	Also change the speed of this animation from (1) to (-1)
	Right click on the orange box and select Make Transition, then click on the grey box and an arrow shoul appear pointing from the orange to the grey box
	
Go back to the Prefabs folder
	Select the hole prefab, find it's sprite renderer and change the value of Order in layer to 1
	Select the mole prefab, find it's sprite renderer and change the value of Order in layer to 2

CHECKPOINT - Select the Play button, our moles should now smoothly spawn and retreat back into their holes
	     We should also be able to click on our moles to make them turn red
	