using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartScreenController : MonoBehaviour {

    public Text startText;
    public GameObject thinkingBgm;
    private int count;
    private float sX;
	void Start () {
        thinkingBgm.SetActive(false);
        this.gameObject.SetActive(false);
        this.startText.transform.localScale = new Vector2(0,1);
        this.startText.transform.localPosition = new Vector3(0,0,0);
        count = 0;
        sX= 0.07f;
	}
	
	void Update () {

        this.startText.transform.localScale += new Vector3(sX,0);
        if (this.startText.transform.localScale.x >= 1)
        {
            sX = 0;
            count++;
        }

        if (count == 60)
        {
            thinkingBgm.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
