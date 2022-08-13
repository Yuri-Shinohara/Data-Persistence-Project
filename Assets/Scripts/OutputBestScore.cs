using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class OutputBestScore : MonoBehaviour
{
    [SerializeField] private Text bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best Score: " + DataManager.Instance.bestplayerName + ": " + DataManager.Instance.bestScore;//.ToString();
    }
}
