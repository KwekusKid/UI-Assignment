using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Merchant : MonoBehaviour
{
  public ShopManager ShopManager;
  public ITEMS[] itemsToBuy;
  public MoneyManager MoneyManager;
  
  

    public void BuyableItem(int id)
    {



       


        bool result = ShopManager.AddItem(itemsToBuy[id]);

       if ( MoneyManager.gold >= itemsToBuy[id].value)
        {
            result = true;
            MoneyManager.gold -= itemsToBuy[id].value;   
            MoneyManager.GoldTxt.text = "Gold;" + MoneyManager.gold.ToString();
           
        }
       else 
        {
            result = false;
        }
       
        
        
        
    }
    

}
