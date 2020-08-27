using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject hitEffect;
    int counter = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("bullet"))
        {
            counter += 10;
            if(counter==100)
            {
               
                Destroy(gameObject);
            }
            Destroy(collision.gameObject);
        }


    }
}
