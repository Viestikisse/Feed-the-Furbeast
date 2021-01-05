using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.up * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        MovementConstraint();
    }

    void MovementConstraint()
    {
        // Code borrowed from https://www.youtube.com/watch?v=CFf2woe4gdg
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -370f, 370f),
            Mathf.Clamp(transform.position.y, -450f, -80f), transform.position.z);
    }
}
