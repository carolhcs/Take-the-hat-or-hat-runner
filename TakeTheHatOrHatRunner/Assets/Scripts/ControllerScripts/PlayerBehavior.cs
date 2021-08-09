using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{

    
    public Transform groundCheck;
    public LayerMask groundLayer;
    private Rigidbody2D rigidBody;

    private float jumpingPower = 15f;
    private float downPower = 50f;
    private Vector2 jumpDirection;

    private PlayerAnim playerAnimator;



    void Start()
    {
        GetPlayerComponents();
    }

    void FixedUpdate()
    {

        //if (playerStatus.PlayerIsJump && IsGrounded()) StopJumpBehavior(); // ... Onde chamar de modo a não dar erro?
    }

    public void JumpBehavior()
    {
        if (IsGrounded())
        {
            //rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpingPower); // Use velocity to jump
            rigidBody.AddForce(jumpDirection * jumpingPower, ForceMode2D.Impulse);
            PlayerStatus.PlayerIsJump = true;
            playerAnimator.PlayAnimationPlayerJump(PlayerStatus.PlayerIsJump);
        }
    }

    public void StopJumpBehavior()
    {
        PlayerStatus.PlayerIsJump = false;
        playerAnimator.PlayAnimationPlayerJump(PlayerStatus.PlayerIsJump);
    }

    /// <summary>
    /// Se estiver no chão, abaixa. Se estiver no ar, dá impulso para baixo.
    /// </summary>
    public void DownBehavior()
    {
        if (IsGrounded())
        {
            PlayerStatus.PlayerIsDown = true;
            playerAnimator.PlayAnimationPlayerDown(PlayerStatus.PlayerIsDown);
        } 
        else if (!IsGrounded() && PlayerStatus.PlayerIsJump)
        {
            rigidBody.AddForce(-transform.up * downPower, ForceMode2D.Impulse);
        }
    }

    public void StopDownBehavior()
    {
        PlayerStatus.PlayerIsDown = false;
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void GetPlayerComponents()
    {
        rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        PlayerStatus.InitPlayerStatus();
        jumpDirection = new Vector2(0.0f, 2.0f);
        playerAnimator = this.gameObject.GetComponent<PlayerAnim>();
    }

    private void Dead()
    {
        GameController gameController = FindObjectOfType<GameController>();
        gameController.PauseGame(GameStatus.IsPause);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag.Equals("Trap")) Dead();
    }

}
