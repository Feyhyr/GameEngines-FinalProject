using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject prefab_Container;
    public Transform invListLocation;
    //public Transform npcListLocation;
    public List<ItemSO> itemList;
    //public List<ItemSO> npcList;

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
            myPrefab.GetComponent<ItemController>().itemIcon.sprite = itemList[i].icon;
        }
    }
}