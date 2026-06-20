using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // UI ���� ���̺귯��
using UnityEngine.SceneManagement; // �� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    private bool isGameover;

    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    void Update()
    {
        if (!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + (int) surviveTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("PlayerCont3D");
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);
        float bestTime = PlayerPrefs.GetFloat("BestTime");
        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        recordText.text = "Best Time: " + (int) bestTime;
    }
}
