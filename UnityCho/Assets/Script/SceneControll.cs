using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{
    public void LoadScene(string sName)
    {
        SceneManager.LoadScene(sName);
    }
}
