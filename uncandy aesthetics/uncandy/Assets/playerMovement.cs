using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //velocitat del player quan es mou amb wasd
    float speed = 0.5f;
    
    // aquesta només s'executa al principi
    void Start(){

        Debug.Log("hello world");
        
    }

    // aquesta es fa executant a cada frame
    void Update()
    {
        //si es piquen tecles wasd mou el player

        if (Input.GetKey("w"))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + speed;
            this.transform.position = position;
        }

        if (Input.GetKey("a"))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + speed;
            this.transform.position = position;
        }

        if (Input.GetKey("s"))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - speed;
            this.transform.position = position;
        }

        if (Input.GetKey("d"))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - speed;
            this.transform.position = position;
        }


    }
}
