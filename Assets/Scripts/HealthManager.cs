using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager.updateHealthText(healthPoints.ToString());
    }

    public void updateHealth(int damageAmount)
    {
        if (healthPoints + damageAmount <= 0)
        {
            Debug.Log("Game Over");
            uiManager.updateHealthText("0");
            return;
        }

        healthPoints += damageAmount;
        uiManager.updateHealthText(healthPoints.ToString());
    }
}