using TMPro;
using UnityEngine;

public class UIListener : MonoBehaviour
{
    [SerializeField] private StateChangeEvent stateChangeEvent; 
    [SerializeField] private TextMeshProUGUI stateText; 

    private void OnEnable()
    {
        stateChangeEvent.OnStateChange += UpdateUI;
    }

    private void OnDisable()
    {
        stateChangeEvent.OnStateChange -= UpdateUI;
    }

    private void UpdateUI(string newState)
    {
        stateText.text = $"Current State: {newState}";
    }
}
