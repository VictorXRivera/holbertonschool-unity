# Project 0x01. Unity - Unity Concepts
# Specializations - AR/VR ― Unity
# by Carrie Ybay, Software Engineer at Holberton School

## Learning Objectives:
* What is a GameObject
* What is a Component
* What is a Prefab
* What is a Tag
* What is a Layer
* How to create and change the properties of a GameObject
* How to create a Prefab
* How to add Tags and Layers
* Why is it important to name GameObjects and assets clearly and organize your project hierarchy
* What are gameplay and game mechanics and how do they relate to developing any kind of interactive experience

## Requirements:
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your holbertonschool-unity directory
* Push the entire project folder 0x01-unity_concepts to your repo, including .meta files
* Scenes and project assets such as Materials must be named and organized as described in the tasks
* No scripts are allowed for this project

## Tasks:
### 0. Floor plans
* Create a new 3D Unity project called 0x01-unity_concepts. Save your new scene as 0-floor.
* Create a new Cube GameObject named Floor with the following Transform properties:
Position: X: 0, Y: 0, Z: 0
Rotation: X: 0, Y: 0, Z: 0
Scale: X: 16, Y: 0.5, Z: 16

### 1. On the ball
* Duplicate 0-floor by selecting the scene in the Project window and either Edit > Duplicate from the Toolbar or CTRL / CMD + D. 
* Rename the scene 1-ball and open it. 
* Create a new Sphere GameObject named Ball with the following Transform properties:
Position: X: 0, Y: 8, Z: 0
Rotation: X: 0, Y: 0, Z: 0
Scale: X: 1.5, Y: 1.5, Z: 1.5

### 2. Colors!
* Duplicate 1-ball, rename it 2-colors, and open it.
* Create a Materials folder in the Project window, then create a new material named floor.
* In the Inspector window, change the Albedo color to any coloryou like using the color picker. Assign the material to the Floor GameObject.
* Create a second new material named ball. Change the material color and assign the new material to the Ball GameObject.

### 3. Gravity is a harsh mistress
* Duplicate 2-colors, rename it 3-gravity, and open it. Add a Rigidbody Component to the Ball GameObject. Press Play to see what happens. Wouldn’t it be better if the ball bounced when it fell?
* Create a new folder in the Project window named Physic Materials and create a new Physic Material called bounce. Feel free to edit the material’s settings to get an idea of what the different settings affect. Add the bounce material to the Ball’s Sphere Collider. Press Play. For this task, your final bounce material settings should be:
Bounciness: 0.8
Bounce Combine: Maximum

### 4. Prefabricated
* Duplicate 3-gravity, rename it 4-prefab, and open it.
* Create a new folder named Prefabs.
* Create a prefab from the Ball inside the new folder, then, using the prefab, add four more instance of the Ball to the scene. Position and scale them any way you like.

### 5. Even more colors!
* Duplicate 4-prefab, rename it 5-more_colors, and open it. Change the colors of each ball so they are different hex colors as defined below. 
New materials should be named as listed below. You cannot use scripts in this task.
#### Ball colors:
* ball-red : FF0000FF
* ball-blue : 0000FFFF
* ball-green : 00FF00FF
* ball-white : FFFFFFFF
* ball-black : 000000FF
* Rename each Ball GameObject in your scene with their color name.
* Red Ball
* Blue Ball
* Green Ball
* White Ball
* Black Ball

### 6. Tag yourself
* Duplicate 5-more_colors, rename it 6-tags, and open it.
* Add a tag to all Ball objects called Obstacles.

