using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public ItemSO item;
    public Image itemIcon;
    public Image displayIcon;

    public Inventory inv;
    public AudioClip audioSFX;

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
        GameObject character = GameObject.Find("Character");
        CharacterManager charM = character.GetComponent<CharacterManager>();

        if (item.category == ItemSO.Category.BodyColour)
        {
            charM.body.sprite = item.icon;
        }

        /*if (item.category == ItemSO.Category.Hat)
        {
            GetComponent<CharacterManager>().hat.sprite = item.icon;
        }

        if (item.category == ItemSO.Category.Tail)
        {
            GetComponent<CharacterManager>().tail.sprite = item.icon;
        }

        if (item.category == ItemSO.Category.Wings)
        {
            GetComponent<CharacterManager>().wings.sprite = item.icon;
        }

        if (item.category == ItemSO.Category.Face)
        {
            GetComponent<CharacterManager>().face.sprite = item.icon;
        }*/

        if (item.category == ItemSO.Category.Neck)
        {
            charM.neck.sprite = item.icon;
        }
    }

    public void PlayAudio()
    {
        AudioManager.Instance.Play(audioSFX);
    }
}