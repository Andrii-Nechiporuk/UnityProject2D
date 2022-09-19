using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed1 = 5;
    private float Move1;

    private Rigidbody2D rb1;
    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move1 = Input.GetAxis("Horizontal");

        rb1.velocity = new Vector2(speed1 * Move1, rb1.velocity.y);
    }
}
