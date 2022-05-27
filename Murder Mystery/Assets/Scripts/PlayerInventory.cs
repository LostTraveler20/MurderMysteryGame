using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public GameObject[] itemsInInventory;
    public int itemMaxCount;

    int currentItemCount;

    // Start is called before the first frame update
    void Start()
    {
        currentItemCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(GameObject item)
    {
        currentItemCount++;

        if (currentItemCount <= itemMaxCount)
        {
            itemsInInventory[currentItemCount] = item;
        }
    }
}