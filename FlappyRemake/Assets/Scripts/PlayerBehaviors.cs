using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviors : MonoBehaviour
{
    public float Jump = 1.5f;
    public float RotationSpeed = 10f;
    public Rigidbody2D player;
    public GameManager gameManager;

// Mouvement
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            player.velocity = new Vector2(0, Jump);
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, player.velocity.y * RotationSpeed);
    }

    // Collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            gameManager.GameOver();
        }
    }
}
