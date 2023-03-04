using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D erik;
    private Animator animator;
    private SpriteRenderer sprite;
    private float dirX = 0f;


    // Start is called before the first frame update
    void Start()
    {
        erik = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");

        erik.velocity = new Vector2(dirX * 7f, erik.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            erik.velocity = new Vector2(erik.velocity.x, 14);
        }

        UpdateAnimationUpdate();
    }

    private void UpdateAnimationUpdate()
    {

        if (dirX > 0f)
        {
            animator.SetBool("erikRunning", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            animator.SetBool("erikRunning", true);
            sprite.flipX = true;
        }
        else
        {
            animator.SetBool("erikRunning", false);
        }
    }
}
