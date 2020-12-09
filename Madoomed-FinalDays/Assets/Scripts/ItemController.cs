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

    public void MoveList()
    {
        if (transform.parent == inv.invListLocation)
        {
            transform.SetParent(inv.equippedListLocation);
            inv.equippedList.Add(item);
        }
    }

    public void ChangeCharacterPart()
    {
        GameObject character = GameObject.Find("Character");
        CharacterManager charM = character.GetComponent<CharacterManager>();

        if (item.category == ItemSO.Category.BodyColour)
        {
            charM.body.sprite = item.icon;
        }

        if (item.category == ItemSO.Category.Hat)
        {
            charM.hat.sprite = item.icon;
        }

        if (item.category == ItemSO.Category.Tail)
        {
            charM.tail.sprite = item.icon;
        }

        if (item.category == ItemSO.Category.Wings)
        {
            charM.wings.sprite = item.icon;
        }

        if (item.category == ItemSO.Category.Face)
        {
            charM.face.sprite = item.icon;
        }

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