using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject clothesRoot;
    private int clothesCount;
    private int currentClothesID;

    // Start is called before the first frame update
    void Start()
    {
        clothesCount = clothesRoot.transform.childCount;
        //var go = clothesRoot.transform.child
        currentClothesID = 0;
        deactivateAllChildren();
        clothesRoot.transform.GetChild(0).gameObject.SetActive(true);
    }


    private void deactivateAllChildren()
    {
        for (int i = 0; i < clothesRoot.transform.childCount; i++)
        {
            clothesRoot.transform.GetChild(i).gameObject.SetActive(false);
        }
    }


    public void next()
    {
        currentClothesID = (currentClothesID + 1) % clothesCount;
        deactivateAllChildren();
        clothesRoot.transform.GetChild(currentClothesID).gameObject.SetActive(true);
    }
    public void prev()
    {
        currentClothesID = (2*currentClothesID - 1) % clothesCount;
        deactivateAllChildren();
        clothesRoot.transform.GetChild(currentClothesID).gameObject.SetActive(true);
    }
}
