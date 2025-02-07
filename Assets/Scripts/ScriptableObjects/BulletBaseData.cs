using UnityEngine;

[CreateAssetMenu(fileName = "BulletBaseData", menuName = "Scriptable Objects/BulletBaseData")]
public class BulletBaseData : BaseItemData
{
    [SerializeField] public int damageAmount = 100;

    [SerializeField] public EnemyManager enemyManager;

    

}
