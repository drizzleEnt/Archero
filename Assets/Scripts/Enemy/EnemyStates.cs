using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStates : MonoBehaviour
{
    [SerializeField] protected List<EnemyTransitions> _transitions;

    public Transform Target { get; set; }

    public void Switch()
    {
        enabled = !enabled;

        foreach (var transition in _transitions)
        {
            transition.enabled = !transition.enabled;
        }
    }
}
