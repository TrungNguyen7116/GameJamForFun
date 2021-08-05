using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public CharacterData characterData;
    public List<ItemData> itemData;
    public int skillData;
    public int floor;

    public SaveData()
    {
        characterData = GameManager.instace.characterData;
        itemData = GameManager.instace.itemData;
        skillData = GameManager.instace.skillData;
        floor = GameManager.instace.floor;
    }
}
