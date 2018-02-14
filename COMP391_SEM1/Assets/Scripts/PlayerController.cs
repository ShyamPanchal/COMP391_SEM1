using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
    public float nextFire = 0.25f;
    public float myTime = 0.0f;
    public Boundary boundary;
    Rigidbody2D rb;
    public GameObject laser;
    public Transform LaserSpawn;
    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();   //establishes a connection to the rigid body 2d component
        
    }
    //used when performing physics calculations
    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");//returns value between -1 and 1
        float moveVertival = Input.GetAxis("Vertical");//returns value between -1 and 1
        Vector2 movement = new Vector2 (moveHorizontal, moveVertival);
		rb.velocity = movement * speed;
        rb.position = new Vector2(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax), 
            Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax) );
    }
    private void Update()
    {
        myTime += Time.deltaTime;
        if (Input.GetButton("Fire1") && myTime>nextFire)
        {
            Instantiate(laser, LaserSpawn.position, LaserSpawn.rotation);
            myTime = 0.0f;
        }
    }
}
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}