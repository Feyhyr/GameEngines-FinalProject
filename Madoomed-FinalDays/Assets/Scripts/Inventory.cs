using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject prefab_Container;
    public Transform invListLocation;
    public Transform bodyEquippedLocation;
    public Transform faceEquippedLocation;
    public Transform neckEquippedLocation;
    public Transform hatEquippedLocation;
    public Transform tailEquippedLocation;
    public Transform wingsEquippedLocation;
    public List<ItemSO> itemList;
    public List<ItemSO> filteredList;

    private void Start()
    {
        AddItemToList();
    }

    public void AddItemToList()
    {
        GameObject myPrefab;

        for (int i = 0; i < itemList.Count; i++)
        {
            if ((itemList[i].iName == "Blue"))
            {
                myPrefab = Instantiate(prefab_Container, bodyEquippedLocation);
            }
            else if (itemList[i].iName == "Smug Face")
            {
                myPrefab = Instantiate(prefab_Container, faceEquippedLocation);
            }
            else if (itemList[i].iName == "Cat Ears")
            {
                myPrefab = Instantiate(prefab_Container, hatEquippedLocation);
            }
            else if (itemList[i].iName == "Soul Gem Pendant")
            {
                myPrefab = Instantiate(prefab_Container, neckEquippedLocation);
            }
            else if (itemList[i].iName == "Cat Tail")
            {
                myPrefab = Instantiate(prefab_Container, tailEquippedLocation);
            }
            else if (itemList[i].iName == "Angel Wings")
            {
                myPrefab = Instantiate(prefab_Container, wingsEquippedLocation);
            }
            else
            {
                myPrefab = Instantiate(prefab_Container, invListLocation);
            }

            myPrefab.GetComponent<ItemController>().inv = this;
            myPrefab.GetComponent<ItemController>().item = itemList[i];
            myPrefab.GetComponent<ItemController>().audioSFX = itemList[i].audio;

            if ((itemList[i].category == ItemSO.Category.BodyColour) || (itemList[i].category == ItemSO.Category.Hat) || (itemList[i].category == ItemSO.Category.Neck) || (itemList[i].category == ItemSO.Category.Wings))
            {
                myPrefab.GetComponent<ItemController>().itemIcon.sprite = itemList[i].displayIcon;
            }
            else
            {
                myPrefab.GetComponent<ItemController>().itemIcon.sprite = itemList[i].icon;
            }
        }
    }

    public List<ItemSO> FilterItems(ItemSO.Category category)
    {
        filteredList = (from item in itemList where item.category == category select item).ToList();
        return filteredList;
    }
}