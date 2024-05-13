using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    public string playerName {  get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void SettingPlayerName(string name)
    {
        playerName = name;
    }

    public string OutputPlayerName()
    {
        return playerName;
    }
}
