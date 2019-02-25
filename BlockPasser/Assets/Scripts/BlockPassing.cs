using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPassing : MonoBehaviour
{

    float speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime,Space.World);
        transform.Rotate(Vector2.right * 90 * Time.deltaTime);


        if (transform.position.x >= 50)
        {
            Destroy(gameObject);
        }

    }
}
