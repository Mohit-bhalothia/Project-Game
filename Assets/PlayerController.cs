using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb;
    public float moveSpeed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0, moveDirection * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
