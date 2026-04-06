using UnityEngine;

public class WeaponData
{
    private int redWeapon;
    private int greenWeapon;
    private int blueWeapon;
    private int whiteWeapon;

    public Player targetHeathP;
    public Enemy targetHeathE;
    public int damageValue = 10;
    public WeaponData (int redWeapon, int greenWeapon, int blueWeapon, int whiteWeapon)
    {
        SetRedWeapon(RedWeapon);
        SetGreenWeapon(GreenWeapon);
        SetBlueWeapon(BlueWeapon);
        SetWhiteWeapon(WhiteWeapon);
    }
    
    public void SetRedWeapon(int redWeapon)
    {
        this.redWeapon = redWeapon;
    }

    public void SetGreenWeapon(int greenWeapon)
    {
        this.greenWeapon = greenWeapon;
    }

    public void SetBlueWeapon(int blueWeapon)
    {
        this.blueWeapon = blueWeapon;
    }

    public void SetWhiteWeapon(int whiteWeapon)
    {
        this.whiteWeapon = whiteWeapon;
    }

    public int RedWeapon => redWeapon;
    public int GreenWeapon => greenWeapon;
    public int BlueWeapon => blueWeapon;
    public int WhiteWeapon => whiteWeapon;

    ~WeaponData()
    {
        Debug.Log("Datos de tu arma");
    }
}
