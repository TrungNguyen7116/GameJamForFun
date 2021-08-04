using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : MonoBehaviour
{
    public ItemFactory()
    { }
    public static Items GetItem(EnumItem type)
    {
        //switch-case
        return new Items();
    }
}
