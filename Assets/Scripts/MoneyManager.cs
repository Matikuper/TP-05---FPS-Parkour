using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;

    void Start()
    {
        uiManager.updateMoneyText(money.ToString());
    }

    public bool updateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("No te alcanza para comprar este objeto");
            return false;
        }

        else
        {
            money += amount;
            uiManager.updateMoneyText(money.ToString());
            return true;
        }
    }
}
