using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // All variables
    // Makes sure there can only be 1 instance of this script
    public static PlayerController instance;

    public Rigidbody2D theRB;
    public float moveSpeed;
    public bool canMove = true;

    // Use this for initialization
    void Start()
    {

        // Checks if there is a player, makes the player this, on scene load there is already an instance so other object gets destroyed
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }

        // Makes sure this gameobject doesnt gets destoryed on loading next scene
        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            // Makes the player move
            theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;
        }
        else
        {
            theRB.velocity = Vector2.zero;
        }
    }

}
