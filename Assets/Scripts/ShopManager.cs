using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class ShopManager : MonoBehaviour
{
    public InventorySlot[] BackpackSpace;
    public GameObject ItemPrefab;
    public MoneyManager MoneyManager;
    
   

    public bool AddItem( ITEMS item )
    {
        for( int i = 0; i < BackpackSpace.Length; i++ )
        {
            
            InventorySlot slot = BackpackSpace[i];

            
            DraggableItem itemInSlot = slot.GetComponentInChildren<DraggableItem>();
            if ( itemInSlot == null && MoneyManager.gold >= item.value)
            {
                SpawnNewItem(item, slot);
                return true;
            }
        }
        return false;
    }   
    
    void SpawnNewItem (ITEMS item, InventorySlot slot)
    {
        GameObject Merch = Instantiate(ItemPrefab, slot.transform);
        DraggableItem Item = Merch.GetComponent<DraggableItem>();
  
        Item.InitialiseItem(item); 
    }


}
