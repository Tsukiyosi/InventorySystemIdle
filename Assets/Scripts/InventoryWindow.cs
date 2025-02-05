using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEditor.SceneManagement;
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
            drawbleItem.transform.SetParent(Slots[i].GetComponent<Transform>());
        }
    }
}
