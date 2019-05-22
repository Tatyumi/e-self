using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndMessageController : MonoBehaviour {

    private int eCount;

    void Start () {
        eCount = 0;
	}

    void Update () {
        eCount++;
        if(eCount == 150)
        {
            SceneManager.LoadScene("TitleScene");
        }
	}
}
