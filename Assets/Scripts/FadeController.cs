using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeController : MonoBehaviour {

    public Image fadeImage;
    private float fC = 1.0f;
    private float bC = 0.01f;
    Color alpha;

    void Start () {
        fadeImage.color = new Color(0, 0, 0, fC);
    }
	
	void Update () {
        fC -= bC;
        fadeImage.color = new Color(0, 0, 0, fC);

        if (fC <= 0f)
        {
            TitleGenarator.isStart = true;
            fadeImage.gameObject.SetActive(false);
        }
    }
}
