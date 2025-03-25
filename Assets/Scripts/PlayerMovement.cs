using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jump;
    public float screenBorder;

    private float Move;
    private Rigidbody2D rb;
    private bool isWalking;
    private bool isJumping;

    private Camera cam;

    public delegate void PlayerWalking(bool isWalking);
    public static event PlayerWalking OnPlayerWalk;

    public delegate void PlayerJumping(bool isWalking);
    public static event PlayerJumping OnPlayerJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if(rb.velocity.x != 0)
        {
            isWalking = true;
            OnPlayerWalk?.Invoke(isWalking);
        }

        else
        {
            isWalking = false;
            OnPlayerWalk?.Invoke(isWalking);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
            OnPlayerJump?.Invoke(isJumping);
        }

        BoundPlayer();
    }

    private void BoundPlayer()
    {
        Vector2 screenPosition = cam.WorldToScreenPoint(transform.position);

        if((screenPosition.x < screenBorder && rb.velocity.x < 0) ||
            (screenPosition.x > cam.pixelWidth - screenBorder && rb.velocity.x > 0))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            OnPlayerJump?.Invoke(isJumping);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            OnPlayerJump?.Invoke(isJumping);
        }
    }
}
