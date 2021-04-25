using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTopDown : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public GameObject recipeWindow;
    public List<Recipe> recipes;

    Vector2 movement;
    bool canMove = true;
    bool recipeWindowActive = false;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.R))
        {
            canMove = !canMove;
            recipeWindowActive = !recipeWindowActive;
            recipeWindow.SetActive(recipeWindowActive);
        }

        if (recipeWindowActive)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                canMove = !canMove;
                recipeWindowActive = !recipeWindowActive;
                recipeWindow.SetActive(recipeWindowActive);
                CraftItem(0);
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                canMove = !canMove;
                recipeWindowActive = !recipeWindowActive;
                recipeWindow.SetActive(recipeWindowActive);
                CraftItem(1);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                canMove = !canMove;
                recipeWindowActive = !recipeWindowActive;
                recipeWindow.SetActive(recipeWindowActive);
                CraftItem(2);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                canMove = !canMove;
                recipeWindowActive = !recipeWindowActive;
                recipeWindow.SetActive(recipeWindowActive);
                CraftItem(3);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                canMove = !canMove;
                recipeWindowActive = !recipeWindowActive;
                recipeWindow.SetActive(recipeWindowActive);
                CraftItem(4);
            }
        }
    }

    private void FixedUpdate()
    {
        if (!canMove)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void CraftItem(int itemIndex)
    {
        if (canCraft(recipes[itemIndex]))
        {
            Debug.Log("Craft " + recipes[itemIndex].name);
            for (int j = recipes[itemIndex].materials.Count - 1; j >= 0; j--)
            {
                Debug.Log("Remove " + recipes[itemIndex].materials[j].item.name);
                InventoryTracker.Items.Remove(recipes[itemIndex].materials[j]);
            }
            foreach(var result in recipes[itemIndex].result)
            {
                InventoryTracker.Items.Add(result);
            }
        };
    }
    bool canCraft(Recipe recipe)
    {
        bool canCraft = true;
        if (InventoryTracker.Items.Count <= 0)
        {
            return false;
        }
        foreach (var material in recipe.materials)
        {
            for (int i = 0; i < InventoryTracker.Items.Count; i++)
            {
                if (material.item.ID == InventoryTracker.Items[i].item.ID)
                {
                    break;
                }
                if (i == InventoryTracker.Items.Count - 1)
                {
                    canCraft = false;
                }
            }
        }
        return canCraft;
    }
}
