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

    private PlayerStatus playerStatus;
    private PlayerAnim playerAnimator;



    void Start()
    {
        GetPlayerComponents();
    }

    void FixedUpdate()
    {

        //if (playerStatus.PlayerIsJump && IsGrounded()) StopJumpBehavior(); // ... Onde chamar de modo a n�o dar erro?
    }

    public void JumpBehavior()
    {
        if (IsGrounded())
        {
            //rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpingPower); // Use velocity to jump
            rigidBody.AddForce(jumpDirection * jumpingPower, ForceMode2D.Impulse);
            playerStatus.PlayerIsJump = true;
            playerAnimator.PlayAnimationPlayerJump(playerStatus.PlayerIsJump);
        }
    }

    public void StopJumpBehavior()
    {
        playerStatus.PlayerIsJump = false;
        playerAnimator.PlayAnimationPlayerJump(playerStatus.PlayerIsJump);
    }

    /// <summary>
    /// Se estiver no ch�o, abaixa. Se estiver no ar, d� impulso para baixo.
    /// </summary>
    public void DownBehavior()
    {
        if (IsGrounded())
        {
            playerStatus.PlayerIsDown = true;
            playerAnimator.PlayAnimationPlayerDown(playerStatus.PlayerIsDown);
        } 
        else if (!IsGrounded() && playerStatus.PlayerIsJump)
        {
            rigidBody.AddForce(-transform.up * downPower, ForceMode2D.Impulse);
        }
    }

    public void StopDownBehavior()
    {
        playerStatus.PlayerIsDown = false;
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void GetPlayerComponents()
    {
        rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        playerStatus = new PlayerStatus();
        playerStatus.InitPlayerStatus();
        jumpDirection = new Vector2(0.0f, 2.0f);
        playerAnimator = this.gameObject.GetComponent<PlayerAnim>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController gameController = FindObjectOfType<GameController>();
        if (collision.gameObject.tag.Equals("Trap")) gameController.PauseGame(gameController.gameStatus.IsPause);
    }

}
