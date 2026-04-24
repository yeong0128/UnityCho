using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.Mathematics;

public class PopupUI : MonoBehaviour
{
    public GameObject UIPannel;

    public Transform cbTrans;
    public Transform spTrans;
    public Transform csTrans;

    public TMP_Text bodyText;
    private InstantiateParameters parentTrans;

    public GameObject BgObjs { get; private set; }

    private void Start()
    {
        UIPannel.SetActive(false);
    }

    public void showUI()
    {
        /*        Debug.Log("showUI 실행됨");
                UIPannel.SetActive(true);
                bodyText.text = ClacSceneInfo();*/

        GameObject popUI = Resources.Load<GameObject>("PopupUI");
        Transform canvasTrans = GameObject.Find("Canvas").transform;

/*        Sprite imgsprite = Resources.Load<Sprite>("images/Unity");
        Image logoImg = GameObject.Find("LogoImg").GetComponent<Image>();*/

        GameObject popObj = Instantiate(popUI, canvasTrans);
        popObj.name = "pop";

        Text titTxt = popObj.transform.Find("TitleTxt").gameObject.GetComponent<Text>();
        titTxt.text = "Scene Info";

        Text bdTxt = popObj.transform.Find("BodyTxt").gameObject.GetComponent<Text>();
        bdTxt.text = ClacSceneInfo();

        GameObject btnObj = popObj.transform.Find("CloseBtn").gameObject;
        Button button = btnObj.GetComponent<Button>();
        Button closeBtn = button;
        closeBtn.onClick.AddListener(() => hideUI(popObj));
    }

    public void hideUI()
    {
        UIPannel.SetActive(false);
    }

    string ClacSceneInfo()
    {
 /*       float cbTosp = Vector3.Distance(cbTrans.position, spTrans.position);
        float cbTocs = Vector3.Distance(cbTrans.position, csTrans.position);*/

        /*        return "박스와 공과의 거리 : " + cbTosp
                     + " / 박스와 캡슐과의 거리 : " + cbTocs;*/ //0417꺼 좀 수정됨
        string retStr = "박스와 공과의 거리:";
        float cbTosp = Vector3.Distance(cbTrans.position, csTrans.position);
        retStr += cbTosp;

        retStr += "\n박스와 캡슐과의 거리:";
        float cbTocs = Vector3.Distance(cbTrans.position, csTrans.position);
        retStr += cbTocs;

        retStr += "\n공과 캡슐과의 거리:";
        float spTocs = Vector3.Distance(cbTrans.position, csTrans.position);
        retStr += cbTocs;

        retStr += "\n\n전체거리:" + (cbTosp + cbTocs + spTocs);
        return retStr;
    }
    void hideUI(GameObject hideObj) {
        Destroy(hideObj);
    
    }
    public void Show3DObjs() {
        GameObject Objs = Instantiate(BgObjs, Vector3.zero, quaternion.identity, parentTrans);
        cbTrans = Objs.transform.Find("Cube").transform;
        spTrans = Objs.transform.Find("Sphere").transform;
        csTrans = Objs.transform.Find("Capsule").transform;
    }
}