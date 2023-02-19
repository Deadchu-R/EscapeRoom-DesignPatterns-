using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public StateManager stateManager;
    public State LeftState;
    public State RightState;
    public Transform CameraTransform;
    public Transform StateTransform;

    private void Start()
    {
        stateManager = GameObject.Find("StateManager").GetComponent<StateManager>();
    }

    public void RunState(State state)
    {        
        CameraTransform.position = StateTransform.position;
        CameraTransform.rotation = StateTransform.rotation;
        stateManager.UpadateState(state);
    }
}
