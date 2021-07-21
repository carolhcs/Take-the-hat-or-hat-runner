using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private float jumpingPower = 15f;
    private float downPower = 30f;
    private Vector2 jumpDirection;

    private PlayerStatus playerStatus;
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
    /// Se estiver no chão, abaixa. Se estiver no ar, dá impulso para baixo.
    /// </summary>
    public void DownBehavior()
    {
        if (IsGrounded())
        {
            playerStatus.PlayerIsDown = true;
            playerAnimator.PlayAnimationPlayerDown();
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
        playerStatus = new PlayerStatus();
        playerStatus.InitPlayerStatus();
        jumpDirection = new Vector2(0.0f, 2.0f);
        playerAnimator = this.gameObject.GetComponent<PlayerAnim>();
    }


}
