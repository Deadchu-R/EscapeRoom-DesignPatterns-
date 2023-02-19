using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditorInternal.VersionControl.ListControl;

public class StateManager : MonoBehaviour
{
   public State CurrentState;
    State RightState;
    State LeftState;

    private void Update()
    {
        LeftState = CurrentState.LeftState;
        RightState = CurrentState.RightState;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CurrentState.RunState(RightState);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentState.RunState(LeftState);
        }

    }

    public void UpadateState(State state)
    {
        CurrentState = state;
    }
    
}
