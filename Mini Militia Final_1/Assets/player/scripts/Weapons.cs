using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Bulletprefab;
    public float bulletForce=20f;
    public string fire;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(fire))
        {
            shoot();
        }
    }
    void shoot()
    {
     GameObject bullet=   Instantiate(Bulletprefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
