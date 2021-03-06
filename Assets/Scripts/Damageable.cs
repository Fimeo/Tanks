using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    public int maxHealth = 100;
    [SerializeField]
    private int health;

    public int Health
    {
        get { return health; }
        set 
        {
            health = value;
            OnHealthChange?.Invoke((float)Health / maxHealth);
        }
    }

    public UnityEvent OnDead;
    public UnityEvent<float> OnHealthChange;
    public UnityEvent OnHit;
    public UnityEvent OnHeal;

    private void Start()
    {
        Health = maxHealth;
    }

    internal void Hit(int damagePoints)
    {
        Health -= damagePoints;
        if (Health <= 0)
            OnDead?.Invoke();
        else
            OnHit?.Invoke();
    }

    public void Heal(int healBoost)
    {
        Health += healBoost;
        Health = Mathf.Clamp(Health, 0, maxHealth);
        OnHeal?.Invoke();
    }
}
