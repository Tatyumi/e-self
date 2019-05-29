using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartScreenController : MonoBehaviour {

    public Text startText;
    public GameObject thinkingBgm;
    private int count;
	void Start () {
        thinkingBgm.SetActive(false);
        this.gameObject.SetActive(false);
        count = 0;
	}
	
	void Update () {

        count++;
        if (count == 70)
        {
            thinkingBgm.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
