using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int currentHealth = 100;
    private int maxHealth = 100;
    public WeaponData data;
    public BaseStats stats;
    public float range;

    private void Awake()
    {
        stats = new BaseStats(10, 20);
        print(stats.Strike);
        print(stats.Heath);

        data = new WeaponData(10, 10, 10, 10);
        
        print(data.RedWeapon);
        print(data.GreenWeapon);
        print(data.BlueWeapon);
        print(data.WhiteWeapon);
    }


    void Start()
    {
        InvokeRepeating("AutoAttackEnemies", 1f, 1f);
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


    public void AutoAttackEnemies()
    {
        print("ATAQUE!");

        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in allEnemies)
        {
            float distance = Vector3.Distance(enemy.transform.position, transform.position);

            if (distance <= range)
                enemy.GetComponent<Enemy>().TakeDamage(this);
        }

    }



    void Update()
    {
        
    }
}
