using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instace;
    public CharacterData characterData;
    //public List<Skills> skills;
    public List<ItemData> itemData;

    void Start()
    {
        if (instace == null)
        {
            instace = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        SaveManager.LoadData();
        PlayerPrefs.GetInt("FLOOR"); //Get floor - initial = 0;
    }
}
