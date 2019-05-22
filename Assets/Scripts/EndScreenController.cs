using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenController : MonoBehaviour {

    public int eCount;

    void Start () {
        eCount = 0;
    }
	void Update () {

        eCount++;
        if(eCount == 80)
        {
            SceneManager.LoadScene("CheckAnswerScene");
        }
	}
}
