using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenManager : MonoBehaviour
{
    public GameObject tokenPrefab; 
    public int tokenCount = 10; 
    public BoxCollider spawnArea; 
    public float respawnDelay = 1f; 

    private Queue<GameObject> tokenPool = new Queue<GameObject>();

    private void Start()
    {
        for (int i = 0; i < tokenCount; i++)
        {
            GameObject token = Instantiate(tokenPrefab);
            token.SetActive(false);
            tokenPool.Enqueue(token);
        }

        for (int i = 0; i < tokenCount; i++)
        {
            SpawnToken();
        }
    }

    private void SpawnToken()
    {
        if (tokenPool.Count > 0)
        {
            GameObject token = tokenPool.Dequeue();
            Vector3 randomPosition = GetRandomPositionInArea();
            token.transform.position = randomPosition;
            token.SetActive(true);
        }
    }

    private Vector3 GetRandomPositionInArea()
    {
        Bounds bounds = spawnArea.bounds;

        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);

        float y = bounds.max.y;

        return new Vector3(randomX, y, randomZ);
    }


    public void ReturnTokenToPool(GameObject token)
    {
        token.SetActive(false);
        tokenPool.Enqueue(token);
        StartCoroutine(RespawnToken());
    }

    private IEnumerator RespawnToken()
    {
        yield return new WaitForSeconds(respawnDelay);
        SpawnToken();
    }
}


