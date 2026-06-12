using System.Collections;
using UnityEngine;

public class Robotcontroll : MonoBehaviour
{
    Animator RBAnl;
    void Start()
    {
        RBAnl = GetComponent<Animator>();
    }

    public void SetAnimation(string mode)
    {
        switch (mode)
        {
            case "idle":
                RBAnl.SetFloat("Speed", 0);
                break;
            case "walk":
                RBAnl.SetFloat("Speed", 2.0f);
                break;
            case "run":
                RBAnl.SetFloat("Speed", 6.0f);
                break;
            case "jump":
                RBAnl.SetBool("Jump", true);
                break;
            case "ground":
                RBAnl.SetBool("Ground", true);
                RBAnl.SetBool("Jump", false);
                break;
            default:
                break;
        }
    }
}
