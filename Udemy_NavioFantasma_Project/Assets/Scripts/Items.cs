using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Items : ScriptableObject
{
    public int ID;
    public string itemName = "New Item";
    public Sprite icon = null;
    public float attackMultiplier = 0;
    public float defenseMultiplier = 0;
    public bool isClue = false;
    public string pickUpMessage = "Você pegou um item novo";
    public string desciption = "Este item te ajudará a";
}
