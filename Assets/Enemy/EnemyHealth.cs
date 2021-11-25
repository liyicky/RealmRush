using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHealth = 5;
    [SerializeField] int currentHealth = 0;

    Enemy enemy;
    // Start is called before the first frame update
    void OnEnable()
    {
        currentHealth = maxHealth;
    }

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void OnParticleCollision(GameObject other)
    {
        Hit();
    }

    void Hit()
    {
        currentHealth--;
        if (currentHealth == 0)
        {
            gameObject.SetActive(false);
            enemy.RewardGold();
        }
    }
}
