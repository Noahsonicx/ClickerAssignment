using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyValue : MonoBehaviour
{
    float currency = 0;
    private TextMeshProUGUI display;

    public void OnClick()
    {
        currency += 1;
    }


    // Start is called before the first frame update
    void Start()
    {
        // TextMeshProUGUI is the display value
        display = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // .text is the Text Input in TextMeshPro - Text (UI)
        display.text = currency.ToString();
    }
}
