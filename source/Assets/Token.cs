using UnityEngine;

public class Token : MonoBehaviour
{
    public TokenManager tokenManager; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tokenManager.ReturnTokenToPool(gameObject);
        }
    }
}
