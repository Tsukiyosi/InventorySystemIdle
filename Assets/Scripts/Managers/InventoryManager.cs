using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Searcher;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Action<BaseItemData> onItemChanged;

    [SerializeField] public List<BaseItemData> _startItems = new List<BaseItemData>();

    public List<BaseItemData> Items = new List<BaseItemData>();

    public void Start() {
        
        for (var i = 0; i < _startItems.Count; i++){
            AddItem(_startItems[i]);
        }
        
    }

    public void AddItem(BaseItemData item){
        Items.Add(item);
    }
    
}
