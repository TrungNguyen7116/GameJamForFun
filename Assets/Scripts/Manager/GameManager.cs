using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instace;
    public CharacterData characterData;
    public int skillData;
    public List<ItemData> itemData;
    public int floor;

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
    }
}
