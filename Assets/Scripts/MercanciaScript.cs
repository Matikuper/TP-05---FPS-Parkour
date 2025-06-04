using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Contacto con {collision.gameObject.name}");
        if (collision.gameObject.name == "Player")
        {
            bool leAlcanza = moneyManager.updateMoney(-precio);
            if (leAlcanza)
            {
                Destroy(gameObject);
            }
        }
    }
}
