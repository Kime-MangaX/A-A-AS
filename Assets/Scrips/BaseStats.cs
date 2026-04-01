using UnityEditor.Animations;
using UnityEngine;

public class BaseStats
{
    private int health;
    private int strike;

    public BaseStats(int health, int strike)
    {
        SetHealth(health);
        SetStrike(strike);
    }

    public void SetHealth(int health)
    {
        if (health <= 0)
            health = 0;

        this.health = health;
    }

    public void SetStrike(int strike)
    {
        this.strike = strike;
    }

    public int Heath => health;
    public int Strike => strike;

    ~BaseStats()
    {
        Debug.Log("ELIMINADO XD");
    }
}
