using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleGenarator : MonoBehaviour {

    public Text titleGuide;

    public static bool isStart;

    private int count;
    public AudioController titleA;
	void Start()
    {
        count = 0;
        isStart = false;
    }

	void Update () {

        count++;

        if (Input.GetMouseButtonDown(0) && isStart == true)
        {
            titleA.answerbuttonPush();
            SceneManager.LoadScene("SelectScene");
        }
        if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
        {
            Application.Quit();
            return;
        }

        if(count >= 30)
        {
            count = 0;
            if (titleGuide.GetComponent<Text>().enabled == false)
            {
                titleGuide.GetComponent<Text>().enabled = true;
            }
            else if (titleGuide.GetComponent<Text>().enabled == true)
            {
                titleGuide.GetComponent<Text>().enabled = false;
            }
        }
    }
}
