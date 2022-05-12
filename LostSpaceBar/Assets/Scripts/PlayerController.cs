using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody playerRB;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector3(playerRB.velocity.x, playerRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if(Input.GetButtonDown("Jump"))
        {
            playerRB.velocity = new Vector3(playerRB.velocity.x, jumpForce, playerRB.velocity.z);
        }
    }
}
