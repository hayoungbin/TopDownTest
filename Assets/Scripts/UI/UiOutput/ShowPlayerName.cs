using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerName : MonoBehaviour
{
    private Text nameText;

    private void Awake()
    {
        nameText = GetComponent<Text>();
        nameText.text = DataManager.instance.OutputPlayerName();
    }

}
