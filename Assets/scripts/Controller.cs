using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
    public float bicSpeed = 5f;
    public float delta = 1f;
    public float maxSpeed = 20;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



        if(bicSpeed >= maxSpeed){
            bicSpeed = maxSpeed;
        }


         float translation = Input.GetAxis("Vertical") * bicSpeed * Time.deltaTime*delta;
         transform.Translate(0, translation, 0);


        float translation2 = Input.GetAxis("Horizontal") * bicSpeed * Time.deltaTime;
        transform.Translate(translation2, 0, 0);



    }
}
