using UnityEngine;
public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;   
    public float currentHealth;
    public bool isAlive;
    public bool damageCheck;

    private void Awake()
    {
        currentHealth = _maxHealth;
        isAlive = true;
    }

    public void TakeDamage(float damage)
    {       
        currentHealth -= damage;
        damageCheck = true;        
        CheckIsAlive();     
    }

    private void CheckIsAlive()
    {
        if(currentHealth > 0)
        {
            isAlive = true;
        }
        else
        {
            isAlive = false; 
            Destroy(gameObject);                      
        }
    }    
}
