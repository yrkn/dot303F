using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/Durum Degisim Event")] 
public class StateChangeEvent : ScriptableObject
{
    public Action<string> OnStateChange;

    public void TriggerEvent(string newState)
    {
        if (OnStateChange != null)
        {
            OnStateChange.Invoke(newState);
        }
    }
}
