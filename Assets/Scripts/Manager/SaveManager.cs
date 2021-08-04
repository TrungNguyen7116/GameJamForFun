using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager
{
    public static void SaveData()
    {
        SaveData data = new SaveData();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/data.save");
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Saved");
    }
    public static void LoadData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        if (File.Exists(Application.persistentDataPath + "/data.save"))
        {
            FileStream file = File.Open(Application.persistentDataPath + "/data.save", FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            GameManager.instace.characterData = data.characterData;
            GameManager.instace.itemData = data.itemData;
            file.Close();
            Debug.Log("Load");
        }
        else
        {
            GameManager.instace.characterData = new CharacterData();
            GameManager.instace.itemData = new List<ItemData>();
            SaveData();
        }
    }
}
