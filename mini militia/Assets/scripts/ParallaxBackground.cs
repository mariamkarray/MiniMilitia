using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private float length, start_position; 
    public GameObject camera;
    public float parallaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        start_position = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = (camera.transform.position.x * parallaxEffect);
        transform.position = new Vector3(start_position + distance, transform.position.y, transform.position.z);
    }
}
