using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moments : MonoBehaviour
{
    public GameObject Player;
    public float movespeed = 5f ;
    public float x = 48f;
    public float y = 1f;
    public float z = 4.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    transform.Rotate(Vector3.forward* 90 * Time.deltaTime);

        transform.Translate(0f, 0f, movespeed * Input.GetAxis("Horizontal") * Time.deltaTime);


        if (transform.position.z >= 3.5f || transform.position.z <= -3.5)
        {

            //transform.Translate( 48f, 1f, -z);
            transform.position = new Vector3( x , y , -transform.position.z);

        }

        if (transform.position.x != 48 || transform.position.y != 1)
            {
            FindObjectOfType<GameOver> ().OnGameOver ();
            Destroy(gameObject);
        }

    }

    //void OnCollisionEnter(Collision collision)
    //{
      //  if(collision.gameObject.name == "block")
        //{
          //  Destroy (gameObject);
        //}
    //}
}
