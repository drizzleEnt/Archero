using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayTransition : PlayerTransition
{
    private void OnEnable()
    {
        Joystick.PointerUp += Transit;
    }

    private void OnDisable()
    {
        Joystick.PointerUp -= Transit;
        
    }

    private void Transit()
    {
        PlayerMachine.Transit(TargetState);
    }
}
