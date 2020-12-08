using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public ItemSO item;
    public Image itemIcon;

    public Inventory inv;

    /*public void MoveList()
    {
        if (transform.parent == inv.invListLocation)
        {
            //FindObjectOfType<QuestUtil>().submitBTN.SetActive(true);
            transform.SetParent(inv.npcListLocation);
            inv.npcList.Add(item);
        }
    }*/

    public void ChangeCharacterPart()
    {
        /*if (item.category == ItemSO.Category.BodyColour)
        {
            GetComponent<CharacterManager>().body.sprite = item.icon;
        }*/
        
    }
}