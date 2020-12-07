using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Category
{
    BodyColour,
    Hat,
    Tail,
    Wings,
    Neck,
    Face
}

[CreateAssetMenu(menuName = "Item")]
public class ItemSO : ScriptableObject
{
    public Sprite icon;
    public Category category;
    public string iName;
}