using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator playerAnimator;

    public void PlayAnimationPlayerIdle(bool active)
    {
        playerAnimator.SetBool("IsPlay", !active);
    }

    public void PlayAnimationPlayerRun(bool active)
    {
        playerAnimator.SetBool("IsPlay", active);
        playerAnimator.SetBool("IsFloor", active);
    }

    public void PlayAnimationPlayerJump(bool active)
    {
        //playerAnimator.SetBool("isJumping", true);
    }

    public void PlayAnimationPlayerDown(bool active)
    {

    }

    public void PlayAnimationPlayerDie(bool active)
    {

    }

    public void StopAnimationPlayerAll(bool active)
    {

    }
}
