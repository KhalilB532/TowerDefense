using System.Collections;
using System.Collections.Generic;
using TowerDefense;
using UnityEngine;
using UnityEngine.Events;


public class Health : MonoBehaviour
{
    [SerializeField] int currentHealth = 10;
    public UnityEvent OnTakeDamage = new UnityEvent();
    public UnityEvent OnZeroHealth = new UnityEvent();

    void TakeDamage(int damageAmount)
    {
         currentHealth -= damageAmount;
        ValueDisplay.OnValueChanged.Invoke(gameObject.name + "Health", currentHealth);
         OnTakeDamage.Invoke();

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            OnZeroHealth.Invoke();
        }
    }

        // Update is called once per frame
    public static void TryDamage(GameObject target, int damageAmount)
    {
        Health health = target.GetComponent<Health>();
        if (health)
        {
            health.TakeDamage(damageAmount);
        }
    }
} 

