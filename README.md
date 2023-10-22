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

:warning: This version of software has no support for the camera hardware or any of its features.

# Getting started

Upon receiving the robot, plug the charger into the charging port and press the power button according to the Figure
![Elmo's power button and charging port illustration](https://github.com/joanabbrito/elmo_IST/main/src/elmo_1.png).

:warning: Always use Elmo with the charging cable plugged. Elmo discharges faster than it charges.

:warning: If Elmo shuts down immediately after powering on, plug charging cable (if not plugged in yet) and let the robot charge for ~15 min before using again.

:warning: The robot is noisy. The noise comes from the charging cable being plugged and can be eliminated if unplugged.

When powered on, Elmo will create a hotspot. You can use your device to connect to this hotspot.

name: _Elmo_

password: _1234567890_

# REST API

## Neck movement (pan and tilt)

## Face (change image/gif/video on screen)

## Chest (change LEDs)

## Other behaviours

### Blush

### Default screen image

# Companion app

The companion app source code is available inside the catkin_elmo/app folder.

:warning: The application was built using PyQt5 python module. There is no compatible version of this module for MAC OS Apple Silicon (M1/M2) devices.
