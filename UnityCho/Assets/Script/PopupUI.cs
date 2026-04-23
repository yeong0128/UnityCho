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
        Debug.Log("showUI 실행됨");
        UIPannel.SetActive(true);
        bodyText.text = ClacSceneInfo();
    }

    public void hideUI()
    {
        UIPannel.SetActive(false);
    }

    string ClacSceneInfo()
    {
        float cbTosp = Vector3.Distance(cbTrans.position, spTrans.position);
        float cbTocs = Vector3.Distance(cbTrans.position, csTrans.position);

        return "박스와 공과의 거리 : " + cbTosp
             + " / 박스와 캡슐과의 거리 : " + cbTocs;
    }
}