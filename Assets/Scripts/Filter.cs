using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Filter : MonoBehaviour
{

    public GameObject[] everything;
    

    public void FilteroutPotions()
    {
        GameObject[] Potions = GameObject.FindGameObjectsWithTag("Potion");

        foreach (GameObject Potion in Potions)
        {
            Potion.SetActive(false);
        }  
    }
   
    public void Filteritems()
    {
        GameObject[] Items = GameObject.FindGameObjectsWithTag("Items");
        
        foreach (GameObject Item in Items)
        {
            Item.SetActive(false);
        }
    }


    public void ResetFilter()
    {
        
      
    }











}
