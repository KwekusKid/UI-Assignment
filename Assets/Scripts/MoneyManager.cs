using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    
    public float gold;
    public Text GoldTxt;
    
    

    public void Start()
    {
        GoldTxt.text = "Gold:" + gold;

        //ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //price 
        shopItems[2, 1] = 15;
        shopItems[2,2] = 40;
        shopItems[2,3] = 10;
        shopItems[2, 4] = 35;

        


    }


    

    
}
