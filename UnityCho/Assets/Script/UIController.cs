using UnityEngine;
public class UIController : MonoBehaviour
{
    public GameObject UIPanner;

    public void showUI()
    {
        UIPanner.SetActive(true);
    }
}