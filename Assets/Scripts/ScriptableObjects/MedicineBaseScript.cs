using UnityEngine;

[CreateAssetMenu(fileName = "MedicineBaseScript", menuName = "Scriptable Objects/MedicineBaseScript")]
public class MedicineBaseScript : BaseItemData
{
    [SerializeField]
    public int healAmount;

    [SerializeField]
    public int maxCollectionCount;

    private PlayerManager playerManager;
    public void UseItem(){
        playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
        playerManager.Heal(healAmount);
    }
}
