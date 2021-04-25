using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvailablePotions : MonoBehaviour
{
    public List<GameObject> availablePotions;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var obj in availablePotions)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < InventoryTracker.Items.Count; i++)
        {
            if(InventoryTracker.Items[i].item.name == "Shield Potion") availablePotions[0].SetActive(true);
            else if (InventoryTracker.Items[i].item.name == "Healing Potion") availablePotions[1].SetActive(true);
            else if (InventoryTracker.Items[i].item.name == "Speed Potion") availablePotions[2].SetActive(true);
            else if (InventoryTracker.Items[i].item.name == "Stone Potion") availablePotions[3].SetActive(true);
            else if (InventoryTracker.Items[i].item.name == "Ressurection Potion") availablePotions[4].SetActive(true);
        }
    }
}
