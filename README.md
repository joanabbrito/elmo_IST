# ELMO version used by GAIPS, INESC-ID IST

This repository contains the version of the software for [idmind](https://www.idmind.pt/)'s Elmo robot used by [GAIPS](https://www.inesc-id.pt/research-areas/artificial-intelligence-for-people-and-society/) (research group at INESC-ID, IST), along with a C# wrapper to communicate with the REST API. Please refer to [idmind](https://github.com/idmind-robotics)'s Github repository for the most recent version of Elmo's drivers and tools.

Robot features:

    - Raspberry PI 4 Running PiOS Buster (Linux);
    - Battery
    - 13x13 Led matrix (in the chest);
    - Touch sensor in front of the led matrix (in the chest);
    - Pan/Tilt mechanism for neck movement;
    - Image or video can be shown in the screen (face);
    - USB Camera with microphone;
    - Touch sensors on top of head.

:warning: This version of Elmo's software has no support for the camera hardware or any of its features.

# Getting started

Upon receiving the robot, plug the charger into the charging port and press the power button according to the Figure
![Elmo's power button and charging port illustration](https://github.com/joanabbrito/elmo_IST/main/src/elmo_1.png).

:warning: Always use Elmo with the charging cable plugged. Elmo discharges faster than it charges.

:warning: If Elmo shuts down immediately after powering on, plug charging cable (if not plugged in yet) and let the robot charge for ~15 min before using again.

:warning: The robot is noisy. The noise comes from the charging cable being plugged and can be eliminated if unplugged.

## Connect to Elmo 

When powered on, Elmo will create a hotspot. You can use your device to connect to this hotspot.

name: _Elmo_

password: _1234567890_

# Use Elmo

Now you can use Elmo. To control Elmo's behaviour you can use 1) ssh to access files and scripts; 2) the REST API; 3) the companion app.

## 1) Communicate with Elmo via ssh
When connected to Elmo's hotspot, you can access Elmo's files remotely via ssh. Connect to Elmo via ssh by writing in the terminal / command line: `ssh idmind@10.42.0.1`. The __password__ is: `asdf`.

## 2) Communicate with Elmo via the REST API

### Neck movement (pan and tilt)

### Face (change image/gif/video on screen) and voice (sounds)

The files need to be placed in a particular directory `/home/idmind/elmo/catkin_elmo/src/elmo/src/static/folder` in which `folder` is either `images` or `sounds`.

To place files in Elmo, use the following ssh command to access that remote location: `scp filename idmind@10.42.0.1:/home/idmind/elmo/catkin_elmo/src/elmo/src/static/folder`. Replace `folder` with `images` or `sounds` and `filename` with the specific image or sound file and use this command from the directory in your local machine that contains the file.

:warning: sound files should be in .wav format. .mp3 files do not work.

### Chest (change LEDs)

### Other behaviours

#### Blush
Blush behaviour consists of heart eyes image on screen, moving ECG figure in the chest LEDs and a characteristic noise.

Elmo will exhibit "blush" behaviour when touch sensors in the head are activated (i.e. when he is petted). It might be possible to activate touch sensors in chest using the `touch_sensors.py` script (not tested yet).

To verify whether blush behaviour is active, you can access Elmo via ssh (as explained in 1) and check out the list of active nodes with `rosnode list` and look for a node named `/blush`. In order to deactivate this behaviour you can `rosnode kill /blush`.

### Default screen image

## 3) Communicate with Elmo via the Companion app

The companion app source code is available inside the catkin_elmo/app folder.

    - control the chest LEDs;
    - change the screen;
    - play Audio files;
    - toggle behaviours;
    - inspect touch sensors;
    - control the pan/tilt motors;
    - upload and delete multimedia files;
    - upload wifi credentials;
    - shutdown;

:warning: The application was built using PyQt5 python module. There is no compatible version of this module for MAC OS Apple Silicon (M1/M2) devices.

# Developing Elmo (ROS)

Python development
/home/idmind/elmo/catkin_elmo/src/elmo/src
robot_server.py
robot.py
touch_sensors.py

rosnode list

# FAQ and common problems

:warning: __You try to turn off Elmo (power button in the bottom of his back) and the screen shuts down but the light on the bottom of his back (next to the power button) stays on__

You have to unscrew Elmo's cover (grey part on the bottom) using an appropriate screwdriver (in the robot room, 3rd drawer from the 2nd row of drawers counting from the right, white dresser behind the door) and manually remove the battery's plug. Afterwards, you can reconnect it, screw the bottom back on and turn on Elmo as usually.
