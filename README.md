# BloodFX
BoodFX contains the particle system and decal for simulating the blood splatting. This effect can be used on a gunshot like killing a giant animal or alien.
## Requirements:
-	Unity 2021.3.18 and above
-	URP
Note: Add the Decal render feature to your URP renderer asset. Set the Technique to screen space.
![image](https://github.com/knowercoder/BloodFX/assets/43854177/d2291625-ef0b-4f84-b1ab-2dffbfffcacf)


## Demo Scene:
A demo scene is located under BloodFX/Scenes folder, named ‘BloodFX_Demo’
Just play the scene and click the ‘Shoot’ button on the top right corner. This will trigger the particle effects and the decal. To shoot again you have to click the ‘Reset’ button to reset the decal and then click the ‘Shoot’ button.

![image](https://github.com/knowercoder/BloodFX/assets/43854177/14e35064-a700-4c70-98bc-666d29b8e837)



## Particle System Effects:
There are three particle system effects included in the asset:
1.	BloodSplat
2.	BloodSparks
3.	BloodSmoke
4.	There is also another modification of the BloodSplat effect named ‘BloodSplat2’. You can find all these particle system effect prefabs under the BloodFX/Prefabs folder.

## Decal:
A Decal projector is used to render the blood on the ground. We have used a custom decal material that will dynamically vary its appearance with its position and you can change its material properties to customize.
![image](https://github.com/knowercoder/BloodFX/assets/43854177/00e8b9da-9deb-4382-93ef-7f5957c8cd85)

## Decal Material Properties:
![image](https://github.com/knowercoder/BloodFX/assets/43854177/bef8d68f-9d77-4ecf-bea5-76bf95a992e7)

1.	DarkColor – The dark color of the blood
2.	LightColor – The light color of the blood
3.	NormalScale – Adjust the height/depth of the blood
4.	Smoothness – Adjust the smoothness so that it will have reflectiveness
5.	Metallic – Adjust the metallicness so that it will have shine
6.	EnableEmission – Enabling this will make the HDR blood color glow with the bloom post processing effect
7.	DarkNoiseScale - The scale value of the simple noise for the dark color
8.	LightNoiseScale – The scale value of the simple noise for the light color
9.	LessBloodSpots – Adjust the overall amount of blood spots

