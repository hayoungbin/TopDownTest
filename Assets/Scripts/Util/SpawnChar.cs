using UnityEngine;

public class SpawnChar : MonoBehaviour
{
    public void SpawnPlayer(GameObject gameObject)
    {
        Object.Instantiate(gameObject);
    }
}