using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class EnableBehaviourCommand {
    public string op = "enable_behaviour";
    public string name;
    public bool control;
}

[System.Serializable]
public class UpdateLedsCommand {
    public string op = "update_leds";
    public int[,] colors; 
}

[System.Serializable]
public class UpdateLedsIconCommand {
    public string op = "update_leds_icon";
    public string name;
}

[System.Serializable]
public class UpdateWifiCredentialsCommand {
    public string op = "update_wifi_credentials";
    public string ssid;
    public string password;
}

[System.Serializable]
public class ShutdownCommand {
    public string op = "shutdown";
}

[System.Serializable]
public class UpdateTouchThresholdCommand {
    public string op = "update_touch_threshold";
    public int threshold; 
}

[System.Serializable]
public class SetPanTorqueComamnd {
    public string op = "set_pan_torque";
    public bool control; 
}

[System.Serializable]
public class SetTiltTorqueCommand {
    public string op = "set_tilt_torque";
    public bool control; 
}

[System.Serializable]
public class SetPanCommand {
    public string op = "set_pan";
    public float angle; 
}

[System.Serializable]
public class SetTiltCommand {
    public string op = "set_tilt";
    public float angle; 
}

[System.Serializable]
public class SetPanWithPlaytimeCommand {
    public string op = "set_pan";
    public float angle;
    public float playtime; 
}

[System.Serializable]
public class SetTiltWithPlaytimeCommand {
    public string op = "set_tilt";
    public float angle; 
    public float playtime;
}

[System.Serializable]
public class UpdateMotorLimitsCommand {
    public string op = "update_motor_limits";
    public int pan_min;
    public int pan_max;
    public int tilt_min;
    public int tilt_max;
}

[System.Serializable]
public class PlaySoundCommand {
    public string op = "play_sound";
    public string name;
}

[System.Serializable]
public class PlaySpeechCommand {
    public string op = "play_speech";
    public string name;
}

[System.Serializable]
public class SetVolumeCommand {
    public string op = "set_volume";
    public int volume;
}

[System.Serializable]
public class SetScreenCommand {
    public string op = "set_screen";
    public string image;
    public string text;
    public string url;
    public bool camera;
}