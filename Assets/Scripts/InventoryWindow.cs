using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] InventoryManager inventory;
    [SerializeField] RectTransform inventoryGrid;
    [SerializeField] GameObject DrawablePrefab;

    private List<GameObject> Slots = new List<GameObject>();

    void Start()
    {
       
        foreach (Transform slot in inventoryGrid.transform){
            Slots.Add(slot.gameObject);
        }
        
        DrowItems();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrowItems(){
        for (var i = 0; i< inventory.Items.Count; i++){
            var item =  inventory.Items[i];

            var drawbleItem = Instantiate(DrawablePrefab);
            drawbleItem.name = item.Title;
            drawbleItem.GetComponent<Image>().sprite = item.Sprite;
            var drawbleInfo = drawbleItem.GetComponent<ItemInfo>();
            drawbleInfo.GetInfo(item.Sprite, item.Title, item.Type, stuck: 10, item.Description, item.Weight);
            drawbleItem.transform.SetParent(Slots[i].GetComponent<Transform>());
        }
    }
}
