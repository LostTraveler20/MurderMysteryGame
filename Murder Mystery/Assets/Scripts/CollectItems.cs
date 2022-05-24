using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public GameObject player;
    public float collectDistance;

    Vector3 playerDistance;
    //bool activeItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ItemCollected()
    {
        Destroy(gameObject);

        //add to player inventory
    }
}
