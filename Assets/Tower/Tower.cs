using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField] int towerCost = 100;
    Bank bank;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CreateTower(Tower tower, Vector3 position)
    {

        bank = FindObjectOfType<Bank>();
        if (bank.CurrentBalance >= towerCost)
        {
            PayForTower();
            Instantiate(tower.gameObject, position, Quaternion.identity);
            return false;
        }

        return true;
    }

    void PayForTower()
    {
        bank.Withdrawl(towerCost);
    }
}
