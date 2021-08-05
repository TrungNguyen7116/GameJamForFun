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
            //Assign data from file to GameManager
            GameManager.instace.characterData = data.characterData;
            GameManager.instace.itemData = data.itemData;
            GameManager.instace.skillData = data.skillData;
            GameManager.instace.floor = data.floor;
            //End assign
            file.Close();
            Debug.Log("Load");
        }
        else
        {
            //Default when the first start game
            GameManager.instace.characterData = new CharacterData();
            GameManager.instace.itemData = new List<ItemData>();
            GameManager.instace.skillData = 1;
            GameManager.instace.floor = 1;
            SaveData();
        }
    }
}
