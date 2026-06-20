using System.Collections;
using UnityEngine;

public class Robotcontroll : MonoBehaviour
{
    Animator RBAni;
    bool isJumping = false;

    void Start()
    {
        RBAni = GetComponent<Animator>();
    }

    public void SetAnimation(string mode)
    {
        if (isJumping && mode != "ground") return;

        switch (mode)
        {
            case "idle":
                RBAni.SetBool("Jump", false);
                RBAni.SetBool("Grounded", true);
                RBAni.SetFloat("Speed", 0.0f);
                break;
            case "walk":
                RBAni.SetBool("Jump", false);
                RBAni.SetBool("Grounded", true);
                RBAni.SetFloat("Speed", 2.0f);
                break;
            case "run":
                RBAni.SetBool("Jump", false);
                RBAni.SetBool("Grounded", true);
                RBAni.SetFloat("Speed", 6.0f);
                break;
            case "jump":
                isJumping = true;
                RBAni.SetBool("Grounded", false);
                RBAni.SetBool("Jump", true);
                StartCoroutine(ResetJump());
                break;
            case "ground":
                isJumping = false;
                RBAni.SetBool("Jump", false);
                RBAni.SetBool("Grounded", true);
                RBAni.SetFloat("Speed", 0.0f);
                break;
            default:
                break;
        }
    }

    public void OnLand()
    {
        isJumping = false;
        RBAni.SetBool("Jump", false);
        RBAni.SetBool("Grounded", true);
    }

    IEnumerator ResetJump()
    {
        yield return new WaitForSeconds(1.5f);
        isJumping = false;
        RBAni.SetBool("Jump", false);
        RBAni.SetBool("Grounded", true);
    }
}
