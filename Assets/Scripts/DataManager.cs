using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName = " ";
    public string bestplayerName = " ";
    public int bestScore = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadScore(); 
    }

    [System.Serializable]
    class SaveData
    {
        public string bestplayerName;
        public int bestScore;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.bestplayerName = bestplayerName;
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);
        Debug.Log("Save");
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            Debug.Log("Load");
            bestplayerName = data.bestplayerName;
            bestScore = data.bestScore;
        }
    }
}
