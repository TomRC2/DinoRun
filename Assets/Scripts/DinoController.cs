using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour
{
        public float jumpForce = 5f;
        private Rigidbody2D rb;
        private bool CanJump = true;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && CanJump)
            {
                rb.velocity = Vector2.up * jumpForce;
                CanJump = false;
            }
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                CanJump = true;
            }
        }
    
}
