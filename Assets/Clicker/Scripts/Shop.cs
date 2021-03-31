using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public CurrencyValue currencyValue;
    
    public void UpgradePerClickEarnings()
    {
        if (currencyValue.currency > 5)
        {
            currencyValue.perClick++;

            currencyValue.currency -= 5;
        }
    }
    public void DoubleAmountPerClickEarnings()
    {
        if (currencyValue.currency > 15)
        {
            currencyValue.perClick *= 2;

            currencyValue.currency -= 15;
        }
    }

}

