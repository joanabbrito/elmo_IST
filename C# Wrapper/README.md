# ELMO robot C# wrapper 

C# wrapper for [idmind](https://www.idmind.pt/)'s Elmo tabletop robot. Has a wrapper for every available command of the REST API available on idmind's [Github repository](https://github.com/idmind-robotics). Copied and updated from the fine work done by [Ana Teresa Antunes](https://github.com/ana3A/EmotionalGame_Elmo_Wrapper).

Designed for Unity game development. Place into "Scripts" folder.

{
    pan: int -> current pan value
    tilt: int -> current tilt value
    pan_min: int -> minimum pan value
    pan_max: int -> maximum pan value
    tilt_min: int -> minimum tilt value
    tilt_max: int -> maximum til value
    pan_torque: boolean -> is torque enabled for pan
    tilt_torque: boolean -> is torque enabled for tilt
    pan_temperature: int -> pan temperature
    tilt_temperature: int -> tilt temperature
    touch_chest: boolean -> is chest touch sensor active
    touch_head_n: boolean -> is head north touch sensor active
    touch_head_s: boolean -> is head south touch sensor active
    touch_head_e: boolean -> is head east touch sensor active
    touch_head_w: boolean -> is head west touch sensor active
    touch_threshold: int -> touch sensor calibration threshold
    behaviour_test_motors: boolean -> is test motors behaviour active
    behaviour_test_leds: boolean -> is test leds behaviour active
    speech_list: string[] -> speech files
    sound_list: string[] -> sound files
    image_list: string[] -> image files
    icon_list: string[] -> icon files
    volume: int -> current volume percentage
    video_port: string -> port of video server for camera
    video_path: string -> path of video server for camera
    multimedia_port: int -> port of multimedia server
    image_address: string -> path of image files in multimedia server
    icon_address: string -> path of icon files in multimedia server
    sound_address: string -> path of sound files in multimedia server
    speech_address: string -> path of speech files in multimedia server
}

The available robot commands are the following:

    {
        "op": "enable_behaviour",
        "name": string -> name of behaviour to enable,
        "control": boolean -> True to enable, False to disable
    }

    {
        "op": "update_touch_threshold",
        "threshold": int -> the new threshold
    }

    {
        "op": "set_pan_torque",
        "control": boolean -> True to enable torque
    }

    {
        "op": "set_tilt_torque",
        "control": boolean -> True to enable torque
    }

    {
        "op": "set_pan",
        "angle": boolean -> angle to set pan motor
    }

    {
        "op": "set_tilt",
        "angle": boolean -> angle to set tilt motor
    }

    {
        "op": "update_motor_limits",
        "pan_min": int -> minimum value for pan,
        "pan_max": int -> maximum value for pan,
        "tilt_min": int -> minimum value for tilt,
        "tilt_max": int -> maximum value for tilt,
    }

    {
        "op": "play_sound",
        "name": string -> name of sound file to play,
    }

    {
        "op": "play_speech",
        "name": string -> name of speech file to play,
    }

    {
        "op": "set_volumme",
        "volume": int -> volume to set,
    }

    {
        "op": "set_screen",
        "image": string -> name of image file to set, if any,
        "text": string -> text to show, if any,
        "url": string -> url to load, if any
        "camera": boolean -> True to show camera feed
    }

    {
        "op": "update_leds",
        "colors": int[13*13][3] -> rgb values (max 255) for each led, in row major order
    }

    {
        "op": "update_leds_icon",
        "name": string -> name of icon file to set
    }

    {
        "op": "update_wifi_credentials",
        "ssid": string -> SSID of network,
        "password": string -> password of network
    }

    {
        "op": "shutdown",
    }
