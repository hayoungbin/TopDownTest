using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private SpawnChar spawn;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        spawn = GetComponent<SpawnChar>();
    }

    private void Start()
    {
        spawn.SpawnPlayer(DataManager.instance.PlayerChar);
    }
}
