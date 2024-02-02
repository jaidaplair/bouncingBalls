using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb;//get a reference to our rb        
        rb = GetComponent<Rigidbody2D>();//get a reference to our rb        

        //set velocity
        rb.velocity = new Vector2(Random.Range(-200f, 200f), Random.Range(-200f,200));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
