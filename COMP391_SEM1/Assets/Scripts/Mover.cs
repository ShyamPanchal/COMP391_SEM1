using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    // Use this for initialization
    private Rigidbody2D rb;
    public float speed;
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = this.transform.right * speed; // set velocity = (1,0)
        
	}
    public void Update()
    {
        if (this.transform.position.x > 8.5)
        {
            Destroy(this.gameObject);
        }
    }

}
