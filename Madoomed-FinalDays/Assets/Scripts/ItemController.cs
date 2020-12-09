using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public ItemSO item;
    public Image itemIcon;
    public Image displayIcon;
    public Text itemName;

    public Inventory inv;
    public AudioClip audioSFX;

    public void MoveList()
    {
        if (transform.parent == inv.invListLocation)
        {
            if (item.category == ItemSO.Category.BodyColour)
            {
                transform.SetParent(inv.bodyEquippedLocation);
                inv.bodyEquippedLocation.GetChild(0).SetParent(inv.invListLocation);
            }

            else if (item.category == ItemSO.Category.Hat)
            {
                transform.SetParent(inv.hatEquippedLocation);
                inv.hatEquippedLocation.GetChild(0).SetParent(inv.invListLocation);
            }

            else if (item.category == ItemSO.Category.Tail)
            {
                transform.SetParent(inv.tailEquippedLocation);
                inv.tailEquippedLocation.GetChild(0).SetParent(inv.invListLocation);
            }

            else if (item.category == ItemSO.Category.Wings)
            {
                transform.SetParent(inv.wingsEquippedLocation);
                inv.wingsEquippedLocation.GetChild(0).SetParent(inv.invListLocation);
            }

            else if (item.category == ItemSO.Category.Face)
            {
                transform.SetParent(inv.faceEquippedLocation);
                inv.faceEquippedLocation.GetChild(0).SetParent(inv.invListLocation);
            }

            else if (item.category == ItemSO.Category.Neck)
            {
                transform.SetParent(inv.neckEquippedLocation);
                inv.neckEquippedLocation.GetChild(0).SetParent(inv.invListLocation);
            }
            ChangeCharacterPart();
            PlayAudio();
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