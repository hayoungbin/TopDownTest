using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InPutName : MonoBehaviour
{
    public InputField playerNameInput;

    private string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }


    public void PlayerInputNameSave()
    {
        if (playerNameInput.text.Length >= 2 && playerNameInput.text.Length <= 10)
        {
            playerName = playerNameInput.text;

            DataManager.instance.SettingPlayerName(playerName);

            SceneManager.LoadScene("MainScene");
        }
    }
}
