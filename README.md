# CameraSwitching-System-for-Unity
A lightweight and flexible camera switching system designed for Unity. Perfect for horror games, surveillance-style interfaces, or interactive security terminals.

Getting Started
To set up the Camera Switching System, follow these steps:
***
  1. Create Render Textures
Go to Assets > Create > Render Texture.
***
  2. Assign Render Textures to Cameras
Select your security camera in the scene.
In the Inspector, find the Output section.
Set the Target Texture field to your created Render Texture.
***
  3. Set Up the Camera Switcher
Create an empty GameObject in the scene (e.g., CameraSystem).
Attach the CameraSwitcher script to it.
In the Inspector, assign:
All your Render Textures to the Camera Feeds list.
The RawImage Canvas that will display the camera feed.
***
Done. You can now use ← and → arrow keys to switch between camera feeds.
