using UnityEngine;
using UnityEngine.UI;

public class UIControl2Manager : MonoBehaviour
{
    public Sprite[] brandLogos;
    public string[] brandNames;
    public Image[] logoImages;
    public Text[] nameTexts;

    private int currentPage = 0;
    private const int logosPerPage = 4;

    void Start()
    {
        ShowPage(0);
    }

    public void NextPage()
    {
        int total = Mathf.CeilToInt((float)brandLogos.Length / logosPerPage);
        currentPage = (currentPage + 1) % total;
        ShowPage(currentPage);
    }

    public void PrevPage()
    {
        int total = Mathf.CeilToInt((float)brandLogos.Length / logosPerPage);
        currentPage = (currentPage - 1 + total) % total;
        ShowPage(currentPage);
    }

    void ShowPage(int page)
    {
        int startIdx = page * logosPerPage;
        for (int i = 0; i < logosPerPage; i++)
        {
            int idx = startIdx + i;
            if (idx < brandLogos.Length)
            {
                logoImages[i].sprite = brandLogos[idx];
                nameTexts[i].text = brandNames[idx];
                logoImages[i].transform.parent.gameObject.SetActive(true);
            }
            else
            {
                logoImages[i].transform.parent.gameObject.SetActive(false);
            }
        }
    }
}
