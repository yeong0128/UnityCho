using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    public Sprite[] Logos;

    [SerializeField]
    Image LogoImg;

    int pocusNum = 0;
    public Button nextBtn;
    public Button prevBtn;

    public Image ProImg;

    void Start()
    {
        LogoImg.sprite = Logos[0];
        prevBtn.interactable = false;

        //ProImg.fillAmount = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeLogo(int order) 
    {
        if ((order < 0 && pocusNum > 0) || (order > 0 && pocusNum < Logos.Length - 1))
        {
            pocusNum += order;
            LogoImg.sprite = Logos[pocusNum];
        }
        if (pocusNum == 0)
        {
            prevBtn.interactable = false;
        }
        else if (pocusNum == Logos.Length - 1)
        {
            nextBtn.interactable = false;
        }
        else 
        {
            prevBtn.interactable = true;
            nextBtn.interactable = true;
        }

        float fillval = (float)pocusNum / (float)(Logos.Length - 1);
        ProImg.fillAmount = fillval;
        Debug.Log(fillval+"/"+pocusNum+"/"+(Logos.Length-1));

    }
}
