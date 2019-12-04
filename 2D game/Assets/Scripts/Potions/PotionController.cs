using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionController : MonoBehaviour
{
    public Text txtPotion;
    static public int AmountHPSmall;
    
    public void Update()
    {
        txtPotion.text = AmountHPSmall.ToString();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            HealthGain();
        }
    }

    public void HealthGain()
    {
        if (AmountHPSmall > 0)
        {
            PlayerTwo.currentHealth += 5;
            AmountHPSmall--;
            //ChackMaxHP();
        }
    }

    public void ChackMaxHP()
    {
        if (PlayerTwo.currentHealth > GetComponent<PlayerTwo>().maxHealth)
        {
            PlayerTwo.currentHealth = GetComponent<PlayerTwo>().maxHealth;
        }
    }
}
