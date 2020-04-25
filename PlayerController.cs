using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private float speed = 20.0f;
	private float turnSpeed = 45.0f;
	
	public float horizontalInput;
	public float forwardInput;
	
	private float timer = 0;

    void Update()
    {
		//Axis setup
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");
		
        //Move the vehicle forward
		transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		
		//Rotate the vehicle left or right
		transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
		
		
		
		//Щосекунди записувати до логу розсташування автоівки по вісі Z
		timer += Time.deltaTime;
		if (timer >= 1)
		{
			Debug.Log(transform.position.z);
			timer = 0;
		}
    }
}
