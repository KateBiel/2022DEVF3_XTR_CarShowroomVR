# 2022DEVF3_XTR_CarShowroomVR_Apr28/22

![IMG_6225](https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD/assets/103016794/b2487035-99b5-4c8b-8437-c423cc0e257d)

# 🚖 Car Showroom VR 🚔

The Car Showroom VR project stems from a prototype I developed during the [Pair Programming DRD (Defend, Run, Display)](https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD/blob/main/README.md) exercises. The overarching aim was to transfer the prototype to virtual reality while capitalizing on insights from prior sessions and lectures. 

Game Description: The player's journey begins at a car shop. They can customize their future car's appearance, even transforming it into an ambulance or a police car. After selecting their preferred style, the player can take it for a spin around town. This test drive allows them to experience their car in action and explore the town from the driver's seat.


✨ Timeline: 3 weeks (Sep 2022)

🔴 YouTube Demo: [Car Showroom VR: Updated Version](https://www.youtube.com/watch?v=i8Cd1QPI0qI)
   
    - Unity 2020.3.13
    - 3D URP
    - XR Interaction Toolkit 2.0
    - Works on the Oculus Quest; compatibility with other platforms hasn't been tested. 
✨ Timeline: 1 week (Apr 2022)

🔴 YouTube Demo: [Car Showroom VR: Original Version](https://www.youtube.com/watch?v=E6ZCthEHDYc)

    - Unity 2020.3.13
    - 3D URP
    - XR Interaction Toolkit 2.0
    - Works on the Oculus Quest; compatibility with other platforms hasn't been tested. 


> [!NOTE]
>My "Original Version" served as the primary submission, encapsulating my early efforts. Yet, upon wrapping up my academic term, I felt a pull towards refining this endeavor further. The allure of the customization feature, enriched by an array of new insights and a bit more free time, spurred me to enhance aspects I had initially sidestepped.

<div style="border-top: 0px solid #3a3c43; margin-bottom: 20px;"></div>


<div style="border-top: 1.4px solid #3a3c43; margin-top: 50px; margin-bottom: 10px;"></div>
<div style="border-top: 1.4px solid #3a3c43; margin-top: 10px; margin-bottom: 10px;"></div>

<summary><h2> Features </h2></summary>

1. Customize Your Car: Design a car according to your preferences.
![CarCustomization1](https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/fbe1e995-85b1-4d6e-af3f-200eb507a106)

2. Adjust Day-Night Cycle: Modify the day-night cycle at your whim using the slider.
![DayCycle](https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/a58377e9-e037-4c1a-a85e-813ee4de12da)

3. Explore the Town: Complete a test drive in your new vehicle.
![TestDrive](https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/ca70f515-e017-43aa-a04a-f078b9ce7a80)

<div style="border-top: 0px solid #3a3c43; margin-bottom: 20px;"></div>

<div style="border-top: 1.4px solid #3a3c43; margin-top: 50px; margin-bottom: 10px;"></div>
<div style="border-top: 1.4px solid #3a3c43; margin-top: 10px; margin-bottom: 10px;"></div>

<summary><h2> Design Process </h2></summary>

For Car Models, I chose to experiment with a different modeling software called [Blockbench](https://www.blockbench.net/). After some research, I discovered that it's highly recommended for voxel modeling, which was exactly what I was looking for.

Below is an overview of my working process in Blockbench.

![carProcess](https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/54d3d147-0e6d-44f0-92ca-55a2e9b61ad3)

How it turned out in Unity. 
<p style="text-align:center;">
<a href="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/8676fe3e-e484-469b-9dd0-8d878dce72a3" target="_blank">
  <img src="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/8676fe3e-e484-469b-9dd0-8d878dce72a3" width="49%" />
</a>
<a href="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/236dfcf0-6698-4eb7-b864-d913fca33278" target="_blank">
  <img src="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/236dfcf0-6698-4eb7-b864-d913fca33278" width="49%" /> 
</a>
</p>

For Level Environment, I used assets from the Unity Asset Store and Sketchfab. However, I made modifications to them in Blender and also crafted new textures. The aim was to ensure variety while maintaining consistency with the original style.

List  of Assets:
  
* [Simple Town Lite - Unity Asset Store](https://assetstore.unity.com/packages/3d/simple-town-lite-cartoon-assets-43480)
* [Mr. Noodles - Sketchfab](https://sketchfab.com/3d-models/mr-noodles-d24fdce023a649aa9b198d56de9ccdf1)
* [Shark Ebisu - Sketchfab](https://sketchfab.com/3d-models/shark-ebisu-ac7089c0a160484cbfa8849d6fbc3cfc)

Before and After modifications.
<p style="text-align:center;">
<a href="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/c6961969-8d86-496e-b8c6-4936204da754" target="_blank">
  <img src="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/c6961969-8d86-496e-b8c6-4936204da754" width="49%" />
</a>
<a href="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/a8e7fe25-a1d7-4c4e-bed8-7cc27ada80a6 " target="_blank">
  <img src="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/a8e7fe25-a1d7-4c4e-bed8-7cc27ada80a6" width="49%" /> 
</a>
</p>
<p style="text-align:center;">
<a href="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/e9a886e8-47b9-414a-857d-e530c77f345a" target="_blank">
  <img src="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/e9a886e8-47b9-414a-857d-e530c77f345a" width="49%" />
</a>
<a href="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/19334ecb-6153-4dc6-9b0b-b74bcf017862" target="_blank">
  <img src="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/19334ecb-6153-4dc6-9b0b-b74bcf017862" width="49%" /> 
</a>
</p>
Here is a closer look at the new city buildings.
<div style="border-top: 0px solid #3a3c43; margin-bottom: 10px;"></div>

![carProcess](https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/341a24db-859b-4d30-b01e-61673bec795a)
![carProcess](https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/6cc2e3bf-b498-4c08-a32f-4e93e242213e)
![carProcess](https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/9e5b94d0-454f-4d07-a8b8-a214c5db5dfe)
![carProcess](https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/56256eb8-dcdb-4228-a60f-d5da03e54ca0)

<div style="border-top: 1.4px solid #3a3c43; margin-top: 50px; margin-bottom: 10px;"></div>
<div style="border-top: 1.4px solid #3a3c43; margin-top: 10px; margin-bottom: 10px;"></div>

 <h2>There is Always Room for Improvements!!!</h4>


- Improve button and slider interactions. At present, button selections lack visual feedback. Additionally, sliders are too closely positioned. 

- Enrich the driving experience. The current version lacks engagement during the drive; it's mainly looking around. Introducing interactive elements might captivate users more.

- Incorporate audio elements, such as city ambience or car engine noises. Contemplating the addition of a car radio for players to tune into during their ride can be an immersive touch.

- Introduce more animation elements, like NPCs in motion, to add life to the environment.

 <h2>Reflection</h4>


I never truly believed I could create something in virtual reality, but against my own expectations, I succeeded. The unwavering support from my peers and instructors made the implementation of the XR Interaction Toolkit a smooth experience for me.

Revisiting this project after my term concluded, I noticed numerous mistakes I'd made earlier in the code. This retrospection allowed me to refine the development aspect of the project.

I don't plan to continue developing this project or address all the points I've outlined. Instead, I'll use this experience as valuable learning material for upcoming projects. I firmly believe the mechanics I've mastered and incorporated here can extend beyond games, potentially addressing real-life challenges or enhancing people's lives.

<div style="margin-top: 20px;">
  <h4> 🐱‍👓 Thanks for your time! I hope you have a sunny day.🌞</h4>
</div>


<div style="border-top: 1.4px solid #3a3c43; margin-top: 20px;"></div>

# 🤟 Featured Repositories

<p style="text-align:center;">
    <a href="https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD">
      <img src="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/84259a14-3d3f-4c72-93f8-5cbe790f4ed9" width="49%" />
    </a>
    <a href="https://github.com/KateBiel/2022C3_XRT_XReOnia_WayFarer" target="_blank">
        <img src="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR/assets/103016794/4a332bac-dde6-4f5c-a278-079c6be82949" width="49%" />
    </a>
</p>

In case clicking the images doesn't redirect you to the correct repository, try the links below:

- [Pair Programming DRD PC](https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD)

- [WayFarer VR/360](https://github.com/KateBiel/2022C3_XRT_XReOnia_WayFarer)
