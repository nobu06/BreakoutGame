/*
 * TODO
 * - set limits on how far the paddle can go (-3 to 3 from the original position)
 *   - perhaps use Math.Clamp  https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html
 *   - keep track of the initial position
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    public float speed = 1f;

    private float xMvmt;

    // set max and min position 3, -3


	private void Start()
	{
        xMvmt = 0;
	}

	void Update () {
        
        xMvmt = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * xMvmt * speed * Time.deltaTime);
	}
}
