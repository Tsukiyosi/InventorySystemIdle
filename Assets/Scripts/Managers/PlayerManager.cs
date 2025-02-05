using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Heal(int amount)
    {
        if (health <= 100){
            health += amount;
            if (health >= 100){
                health = 100;
            }
        }
    }
}
