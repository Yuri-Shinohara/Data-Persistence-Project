using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
    }

    public void SetPlayerName()
    {
        string inputValue = inputField.text;
        DataManager.Instance.playerName = inputValue;
    }
}
