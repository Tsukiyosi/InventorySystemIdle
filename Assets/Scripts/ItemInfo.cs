using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    [SerializeField] public BaseItemData.ItemType Type;
    [SerializeField] GameObject PopUp;
    
    [SerializeField] public int Stuck = 1;
    public Sprite Sprite;

    public string Title;

    public string Description;
    public int Weight;

    void Start()
    {
        PopUp = GameObject.FindAnyObjectByType<PopUpManager>().transform.gameObject;
        PopUp.gameObject.SetActive(false);
    }


    void Update()
    {
        if(Stuck <=0 ){
            Destroy(this.gameObject);
        }
    }

    public void GetInfo(Sprite sprite, string title, BaseItemData.ItemType type, int stuck, string description, int weight){
        Type = type;
        Sprite = sprite;
        Title = title;
        Stuck = stuck;
        Description = description;
        Weight = weight;
    }

    public void OpenPopUp(){
        
        PopUp.gameObject.SetActive(true);
        PopUp.GetComponent<PopUpManager>().GetItemInfo(Sprite, Title, Type, Stuck, Description, Weight);
    }

}
