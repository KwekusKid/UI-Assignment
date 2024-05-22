using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceTxt;
    public Text QuanityTxt;
    public ITEMS item;
    public GameObject MoneyManager;

    // Update is called once per frame
    void Update()
    {
        PriceTxt.text = "$" + MoneyManager.GetComponent<MoneyManager>().shopItems[2,ItemID].ToString();
    }
}
