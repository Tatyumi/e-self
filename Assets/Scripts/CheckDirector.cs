using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckDirector : MonoBehaviour
{
    private new AudioSource audio;
    public AudioClip imageSE;

    public Text modeName;
    public Text numOfQText;
    public Text numOfRAText;
    public Text raPerText;

    GameObject pSdobj;

    private float qA;
    private int count;
    PlayerScoreDirector pSd;
    
    public GameObject OsiiImage;
    public GameObject BadImage;
    public GameObject GoodImage;
    public GameObject ExcellentImage;

    private bool isSe;
        
    void Start()
    {   /*
        PlayerScoreDirector.numOfQuestion = 12.0f;
        PlayerScoreDirector.numOfAnswer = 12.0f;
        PlayerScoreDirector.numOfs_Mode = 1;
        */
        this.OsiiImage.SetActive(false);
        this.BadImage.SetActive(false);
        this.GoodImage.SetActive(false);
        this.ExcellentImage.SetActive(false);
        audio = gameObject.GetComponent<AudioSource>();
        isSe = true;

        count = 0;
        this.pSdobj = GameObject.Find("PlayerScoreDirector");
        pSd = pSdobj.GetComponent<PlayerScoreDirector>();
        checkMode();
        Debug.Log(PlayerScoreDirector.numOfQuestion);
        Debug.Log(PlayerScoreDirector.numOfAnswer);
    }

    void Update()
    {
        count++;

        if( count == 70)
        { 
            if(PlayerScoreDirector.numOfs_Mode == 7){
                challngescoreCheck(CanvasController.qNum);
            }else{
                scoreCheck(qA);
            }
        }

        if (count == 150)
        {
            SceneManager.LoadScene("SelectScene");
        }
    }
    public void checkMode()
    {
        if (PlayerScoreDirector.numOfs_Mode == 1 || PlayerScoreDirector.numOfs_Mode == 2 || PlayerScoreDirector.numOfs_Mode == 3 )//スタディモードの場合
        {
            modeName.text = "スタディ";
            numOfQText.text = "問題数：" + PlayerScoreDirector.numOfQuestion + "問";
            numOfRAText.text = "正解数：" + PlayerScoreDirector.numOfAnswer + "問";
            qA = PlayerScoreDirector.numOfAnswer / PlayerScoreDirector.numOfQuestion * 100;
            raPerText.text = "正解率：" + qA.ToString("F1") + "%";
        }
        else if (PlayerScoreDirector.numOfs_Mode == 4 || PlayerScoreDirector.numOfs_Mode == 5 || PlayerScoreDirector.numOfs_Mode == 6)//ランダムモードの場合
        {
            modeName.text = "ランダム";
            numOfQText.text = "問題数：" + PlayerScoreDirector.numOfQuestion + "問";
            numOfRAText.text = "正解数：" + PlayerScoreDirector.numOfAnswer + "問";
            qA = PlayerScoreDirector.numOfAnswer / PlayerScoreDirector.numOfQuestion * 100;
            raPerText.text = "正解率：" + qA.ToString("F1") + "%";

        }
        else //チャレンジモードの場合
        {
            modeName.text = "チャレンジ"; // CanvasController.qNum
            CanvasController.qNum -= 1;
            numOfQText.text = "到達問題数：" + CanvasController.qNum + "問";
            numOfRAText.text = "";
            raPerText.text = "";
            PlayerScoreDirector.c_numOfA = CanvasController.qNum;

            if(PlayerScoreDirector.c_numOfBest < PlayerScoreDirector.c_numOfA)
            {//記録更新をしたら保存
                PlayerScoreDirector.c_numOfBest = PlayerScoreDirector.c_numOfA;
            }
        }
        pSd.saveNum(PlayerScoreDirector.numOfs_Mode);//そのモードのセーブ
    }

    public void scoreCheck(float score)
    {
        if(score < 50.0f)
        {
            this.BadImage.SetActive(true);
        }
        else if (score == 100)
        {
            this.ExcellentImage.SetActive(true);
        }
        else if(score > 90.0f  &&  score < 100.0f ){
            this.OsiiImage.SetActive(true);
        }
        else
        {
            this.GoodImage.SetActive(true);
        }

        if(isSe == true) {
            audio.PlayOneShot(imageSE);
            isSe = false;
        }


    }

    public void challngescoreCheck(int score)
    {
        if (score < 21)
        {
           this.BadImage.SetActive(true);
        }
        else if (score > 39 || score < 41)
        {
            this.OsiiImage.SetActive(true);
        }
        else if (score == 42)
        {
            this.ExcellentImage.SetActive(true);
        }
        else
        {
            this.GoodImage.SetActive(true);
        }


        if (isSe == true)
        {
            audio.PlayOneShot(imageSE);
            isSe = false;
        }

    }






}
