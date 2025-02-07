using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    
    private BaseItemData.ItemType _type;
    private int _stuck;
    private Sprite _sprite;

    private string _title;

    private string _description;
    private int _weight;

    void Start()
    {
        DrowItemInfo();
    }


    public void GetItemInfo(Sprite sprite, string title, BaseItemData.ItemType type, int stuck, string description, int weight){
        _sprite = sprite;
        _title = title;
        _type = type;
        _stuck = stuck;
        _description = description;
        _weight = weight;
        DrowItemInfo();
    }
    private void DrowItemInfo(){

    }
}
