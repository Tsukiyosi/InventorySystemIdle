using UnityEngine;

[CreateAssetMenu(fileName = "BaseItemData", menuName = "Scriptable Objects/BaseItemData")]
public class BaseItemData : ScriptableObject
{
    [SerializeField] public string Title;
    [SerializeField] public string Description;
    [SerializeField] public Sprite Sprite;
    [SerializeField] public InventoryManager inventory;

    [HideInInspector]public enum ItemType {
        Bullet,
        Medicine,
        Armor
    }
    public ItemType Type;
    public int Weight;
    public int MaxStuck;

    public virtual void UseItem(){

    }
    public virtual void DeleteItem(){

    }
}
