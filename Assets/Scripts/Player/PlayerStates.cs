using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
    [SerializeField] protected List<PlayerTransition> _transitions;

    public Transform Target { get; set; }

    public void SwitchState()
    {
        enabled = !enabled;

        foreach (var transition in _transitions)
        {
            transition.enabled = !transition.enabled;
        }
    }

    public PlayerStates GetNextState()
    {
        foreach (var transition in _transitions)
        {
            if (transition.NeedTransit)
                return transition.TargetState;
        }

        return null;
    }
}
