using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int currentHealth = 100;
    private int maxHealth = 100;


    private void Awake()
    {

    }

    public void TakeDamage(int AmountDamage)
    {
        currentHealth -= AmountDamage;

        if (currentHealth < 0)
        {
            currentHealth = 0;
            Debug.Log("MORISTE");
        }

        Debug.Log("Salud restante" + currentHealth);
    }


    public void Heal(int AmountHeal)
    {
        currentHealth += AmountHeal;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        Debug.Log("Sanando. Salud acatual" + currentHealth);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    internal void TakeDamage(Player player)
    {
        throw new NotImplementedException();
    }
}
