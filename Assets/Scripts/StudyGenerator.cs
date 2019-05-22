using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StudyGenerator : MonoBehaviour {

    public GameObject subCanvas;
    public GameObject pausePanel;
    public GameObject passPanel;

    public GameObject backGround_M;
    public GameObject backGround_B;
    public GameObject backGround_W;

    void Start()
    {
        p_canvasOff();
        backSelect();
    }

    public void p_canvasOff()
    {
        this.pausePanel.SetActive(false);
        this.passPanel.SetActive(false);
        this.subCanvas.SetActive(false);
    }
    public void pauseMode()
    {
       this.subCanvas.SetActive(true);
       this.pausePanel.SetActive(true);
    }
    public void passMode()
    {
        this.subCanvas.SetActive(true);
        this.passPanel.SetActive(true);
    }

    public void selectBack()
    {
        SceneManager.LoadScene("SelectScene");
    }
    
    public void backSelect()
    {
        if(PlayerScoreDirector.studybackNum == 1)
        {//メッシュ拝啓
            this.backGround_M.SetActive(true);
            this.backGround_B.SetActive(false);
            this.backGround_W.SetActive(false);
        }
        else if(PlayerScoreDirector.studybackNum == 2)
        {//ボーダー背景
            this.backGround_M.SetActive(false);
            this.backGround_B.SetActive(true);
            this.backGround_W.SetActive(false);
        }
        else if (PlayerScoreDirector.studybackNum == 3)
        {//ホワイトバック
            this.backGround_M.SetActive(false);
            this.backGround_B.SetActive(false);
            this.backGround_W.SetActive(true);
        }
    }
}
