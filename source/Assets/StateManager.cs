using UnityEngine;

public class StateManager : MonoBehaviour
{
    public BaseState currentState;
    public IdleState idleState = new IdleState();
    public WalkingState walkingState = new WalkingState();
    
    [SerializeField] private StateChangeEvent stateChangeEvent; 
    [SerializeField] private float movementSpeed = 3f; 

    private void Start()
    {
        currentState = idleState; 
        currentState.EnterState(this);
        stateChangeEvent.TriggerEvent("Idle"); // ui icin-1
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(BaseState newState)
    {
        currentState.ExitState(this);
        currentState = newState;
        currentState.EnterState(this);

        stateChangeEvent.TriggerEvent(currentState.GetType().Name); // ui icin-2
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}
