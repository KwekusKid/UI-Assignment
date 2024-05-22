
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public GameObject TheMenu;
    public GameObject theMerchant;
    public GameObject chest;
    

    public void Chest()
    {
        TheMenu.SetActive(false);
        theMerchant.SetActive(false);
        chest.SetActive(true);
        
    }

    public void Merchant()
    {
        TheMenu.SetActive(false);
        chest.SetActive(false);
        theMerchant.SetActive(true);

    }

    public void MenufromChest()
    {
        TheMenu.SetActive(true);
        chest.SetActive(true);
        theMerchant.SetActive(false);
    }

     public void MenufromMerchant()
    {
        TheMenu.SetActive(true);

        chest.SetActive(false);
        theMerchant.SetActive(true);
    }


}
