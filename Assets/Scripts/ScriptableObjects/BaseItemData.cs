using UnityEngine;

[CreateAssetMenu(fileName = "BaseItemData", menuName = "Scriptable Objects/BaseItemData")]
public class BaseItemData : ScriptableObject
{

    public enum Type {
        Bullet,
        Medicine,
        Armor
    }
    public Sprite Sprite;

    public string Title;

    public string Description;
    public int Weight;

    public void Useitem(){

    }
}
