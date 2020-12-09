using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

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
            else if (itemList[i].iName == "Bowtie")
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
            myPrefab.GetComponent<ItemController>().itemIcon.sprite = itemList[i].displayIcon;
            myPrefab.GetComponent<ItemController>().itemId.text = itemList[i].id.ToString();
        }
    }

    public void ChooseFilter(string filter)
    {
        if (filter == "Body")
        {
            FilterItems(ItemSO.Category.BodyColour);
        }
        else if (filter == "Face")
        {
            FilterItems(ItemSO.Category.Face);
        }
        else if (filter == "Hat")
        {
            FilterItems(ItemSO.Category.Hat);
        }
        else if (filter == "Neck")
        {
            FilterItems(ItemSO.Category.Neck);
        }
        else if (filter == "Tail")
        {
            FilterItems(ItemSO.Category.Tail);
        }
        else if (filter == "Wings")
        {
            FilterItems(ItemSO.Category.Wings);
        }
    }

    public void FilterItems(ItemSO.Category category)
    {
        filteredList = (from item in itemList where item.category == category select item).ToList();
    }

    public void FilterCharacterPart()
    {
        foreach(ItemSO singleItem in filteredList)
        {
            foreach (Transform t in invListLocation)
            {
                if (t.GetComponentInChildren<Text>() != null)
                {
                    if (t.GetComponentInChildren<Text>().text == singleItem.id.ToString())
                    {
                        t.gameObject.SetActive(true);
                    }
                    else if (t.GetComponentInChildren<Text>().text != singleItem.ToString())
                    {
                        t.gameObject.SetActive(false);
                    }
                }
            }
        }
    }

    public void ResetFilter()
    {
        foreach (Transform t in invListLocation)
        {
            t.gameObject.SetActive(true);
        }
    }
}