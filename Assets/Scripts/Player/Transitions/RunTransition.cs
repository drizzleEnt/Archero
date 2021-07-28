using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTransition : PlayerTransition
{
    private void OnEnable()
    {
        Joystick.PointerDown += Transit;
    }

    private void OnDisable()
    {
        Joystick.PointerDown -= Transit;
    }

    private void Transit()
    {
        PlayerMachine.Transit(TargetState);
    }
}
