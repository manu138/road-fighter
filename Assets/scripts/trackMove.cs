using UnityEngine;
using System.Collections;

public class trackMove : MonoBehaviour {
	public float speed;
	Vector2 offset;
    private float currentSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        

        Vector3 offset = GetComponent<Renderer>().material.mainTextureOffset;
        offset.y +=  Time.deltaTime * currentSpeed;
        GetComponent<Renderer>().material.mainTextureOffset = offset;


    }
}
