using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType {GOOD_FOOD, BAD_FOOD, WEAPON};
    public ItemType currentItemType;
    private int value;
    // Start is called before the first frame update
    void Start()
    {
        if(currentItemType == ItemType.GOOD_FOOD)
        {
            value = 1;
        }else if (currentItemType == ItemType.BAD_FOOD)
        {
            value = -1;
        }
        else
        {
            value = -2;
        }
    }

    public int getValue()
    {
        return value;
    }
}
