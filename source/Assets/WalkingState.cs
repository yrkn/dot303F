using UnityEngine;

public class WalkingState : BaseState
{
    public override void EnterState(StateManager stateManager)
    {
        Debug.Log("Walking State'e Giriş");
    }

    public override void UpdateState(StateManager stateManager)
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward; 
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left; 
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right; 
        }

        stateManager.Move(direction);

        if (direction == Vector3.zero)
        {
            stateManager.SwitchState(stateManager.idleState);
        }
    }

    public override void ExitState(StateManager stateManager)
    {
        Debug.Log("Walking State'ten Çıkış");
    }
}
