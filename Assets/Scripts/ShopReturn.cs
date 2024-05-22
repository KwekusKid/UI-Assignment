using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopReturn : MonoBehaviour
{
    public GameObject Merchant;
    public InventorySlot[] backpack;
    
   
    public MoneyManager MoneyManager;
  public void Return()
    {
        InventorySlot pocket = backpack[0];
        if(Merchant.activeInHierarchy && pocket.GetComponentInChildren<DraggableItem>())
        {
            int addBack =  this.gameObject.GetComponent<DraggableItem>().item.value;
            Destroy(this.gameObject);
            MoneyManager.gold = MoneyManager.gold + addBack; 
        }
    }

}
