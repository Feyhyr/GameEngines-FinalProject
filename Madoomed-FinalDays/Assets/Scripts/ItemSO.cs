using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class ItemSO : ScriptableObject
{
    public enum Category
    {
        BodyColour,
        Hat,
        Tail,
        Wings,
        Neck,
        Face
    }

    public int id;
    public Sprite icon;
    public Sprite displayIcon;
    public Category category;
    public string iName;
    public AudioClip audio;
}