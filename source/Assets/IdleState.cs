using UnityEngine;

public class IdleState : BaseState
{
    public override void EnterState(StateManager stateManager)
    {
        Debug.Log("Idle State'e Giriş");
    }

    public override void UpdateState(StateManager stateManager)
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            stateManager.SwitchState(stateManager.walkingState);
        }
    }

    public override void ExitState(StateManager stateManager)
    {
        Debug.Log("Idle State'ten Çıkış");
    }
}
