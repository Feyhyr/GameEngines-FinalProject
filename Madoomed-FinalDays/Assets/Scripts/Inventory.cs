using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject prefab_Container;
    public Transform invListLocation;
    public Transform equippedListLocation;
    public List<ItemSO> itemList;
    public List<ItemSO> equippedList;

    private void Start()
    {
        AddItemToList();
    }

    public void AddItemToList()
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            GameObject myPrefab = Instantiate(prefab_Container, invListLocation);
            myPrefab.GetComponent<ItemController>().inv = this;
            myPrefab.GetComponent<ItemController>().item = itemList[i];
            myPrefab.GetComponent<ItemController>().audioSFX = itemList[i].audio;
            if ((itemList[i].category == ItemSO.Category.BodyColour) || (itemList[i].category == ItemSO.Category.Hat))
            {
                myPrefab.GetComponent<ItemController>().itemIcon.sprite = itemList[i].displayIcon;
            }
            else
            {
                myPrefab.GetComponent<ItemController>().itemIcon.sprite = itemList[i].icon;
            }
        }
    }
}