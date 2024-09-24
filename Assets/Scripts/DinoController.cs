using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class DinoController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool CanJump = true;
    public GameObject Retry;
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

        if (collision.gameObject.CompareTag("Spike"))
        {
            Time.timeScale = 0f;
            Retry.SetActive(true);
        }
    }

}
