using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInGame : MonoBehaviour
{
    public Item item;
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer.sprite = item.sprite;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            var newItem = new ItemAmount()
            {
                item = item,
                amount = 1
            };
            var collected = false;
                Debug.Log(InventoryTracker.Items.Count);
            foreach(var slot in InventoryTracker.Items)
            {
                if(slot.item.ID == item.ID)
                {
                    collected = true;
                }
            }
            if (collected)
            {
                return;
            }
            InventoryTracker.Items.Add(newItem);
            Destroy(gameObject);
        }
    }
}
