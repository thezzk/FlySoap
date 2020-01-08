﻿using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {

    void OnEnable()
    {
        EasyJoystick.On_JoystickMove += OnJoystickMove;
        EasyJoystick.On_JoystickMoveEnd += OnJoystickMoveEnd;
    }


    //移动摇杆结束
    void OnJoystickMoveEnd(MovingJoystick move)
    {
       
    }


    //移动摇杆中
    void OnJoystickMove(MovingJoystick move)
    {
        if (move.joystickName != "MoveJoystick")
        {
            return;
        }

        //获取摇杆中心偏移的坐标
        float joyPositionX = move.joystickAxis.x;
        float joyPositionY = move.joystickAxis.y;

    }
}