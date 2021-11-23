using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHealth = 5;
    int currentHealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    void OnParticleCollision(GameObject other)
    {
        Hit();
    }

    void Hit()
    {
        currentHealth--;
    }
}
