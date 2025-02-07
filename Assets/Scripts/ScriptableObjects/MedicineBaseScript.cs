using UnityEngine;

[CreateAssetMenu(fileName = "MedicineBaseScript", menuName = "Scriptable Objects/MedicineBaseScript")]
public class MedicineBaseScript : BaseItemData
{
    [SerializeField]
    public int healAmount;

    [SerializeField]
    public int maxCollectionCount;

    [SerializeField]
    public PlayerManager playerManager;

    public override void UseItem(){
        playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
        playerManager.Heal(healAmount);
    }

    public override void DeleteItem(){
        foreach (var item in inventory.Items){
            
        }
    }
}
