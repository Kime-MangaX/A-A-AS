using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Player : MonoBehaviour
{
    public WeaponData data;
    public BaseStats stats;

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
        
    }

    void Update()
    {
        
    }
}
