using UnityEngine;
using TMPro;

public class PopupUI : MonoBehaviour
{
    public GameObject UIPannel;

    public Transform cbTrans;
    public Transform spTrans;
    public Transform csTrans;

    public TMP_Text bodyText;

    private void Start()
    {
        UIPannel.SetActive(false);
    }

    public void showUI()
    {
        UIPannel.SetActive(true);
        bodyText.text = CalcSceneInfo();
    }

    public void hideUI()
    {
        UIPannel.SetActive(false);
    }

    string CalcSceneInfo()
    {
        float cbTosp = Vector3.Distance(cbTrans.position, spTrans.position);
        float cbTocs = Vector3.Distance(cbTrans.position, csTrans.position);
        float spTocs = Vector3.Distance(spTrans.position, csTrans.position);

        string retStr = "박스와 공의 거리: " + cbTosp;
        retStr += "\n박스와 캡슐의 거리: " + cbTocs;
        retStr += "\n공과 캡슐의 거리: " + spTocs;
        retStr += "\n\n전체 거리: " + (cbTosp + cbTocs + spTocs);
        return retStr;
    }
}
