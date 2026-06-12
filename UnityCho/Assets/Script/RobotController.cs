using UnityEngine;

public class RobotController : MonoBehaviour
{

    Animator RBAni;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RBAni = GetComponent<Animator>();
    }

    public void SetAnimation(string mode) 
    {
        switch(mode)
        {
            case "idle":
                RBAni.SetFloat("Speed", 0.0f);
                break;
            case "walk":
                RBAni.SetFloat("Speed",2.0f);
                break;
            case "run":
                RBAni.SetFloat("Speed", 6.0f);
                break;
            case "jump":
                RBAni.SetBool("Jump", true);
                break;
            case "ground":
                RBAni.SetBool("Grounded", true);
                RBAni.SetBool("Jump", false);
                break;
            default:
                break;

        }
    }
}
