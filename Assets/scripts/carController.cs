using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

    public float carSpeed;
    public float maxPos = 2.08f;
    Vector2 position;



    // Use this for initialization
    void Start() {
        position = transform.position;

    }

    // Update is called once per frame
    void Update() {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;

      
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * carSpeed * Time.deltaTime);
            position.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;

        }
        else
        {
            carSpeed = 0;
        }
       

        transform.position = position;
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag== "Enemy Car")
        {
            Destroy(gameObject);
        }
    }
}
