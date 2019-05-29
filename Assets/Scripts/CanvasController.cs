using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class CanvasController : MonoBehaviour
{

    public Text questionB_Text1;
    public Text questionB_Text2;
    public Text questionB_Text3;
    public Text nextButton_T;
    public Text guideText;

    public Text checkButton_T;
    private Text answer1;
    private Text answer2;
    private Text answer3;

    public static int s_M_answerNum;//スタディモードの回答数
    public static int s_M_goodNum;//スタディモードの正解数
    public static int qNum;
    public static int sW;
    public static int sH;

    public static bool isMiss;

    public Vector2 mC;

    private string answerA;
    private string answerB;
    private string answerC;

    string selectedTextC;

    private Image goodImage;
    private Image badImage;

    private int a;
    private int a_1;
    private int a_2;
    private int a_3;
    private int checkMode;
    private int shuffleNum1;
    private int shuffleNum2;
    private int shuffleNum3;
    private int yPos1;
    private int yPos2;
    private int yPos3;

    private bool isAnswer1 = false;
    private bool isAnswer2 = false;
    private bool isAnswer3 = false;
    private bool isCheck = false;

    GameObject answerPanel1;
    GameObject answerPanel2;
    GameObject answerPanel3;
    GameObject checkPanel;
    GameObject nextPanel;
    GameObject guidePanel;
    GameObject qdobj;
    GameObject abdobj;
    public GameObject subPobj;
    QuestionDirector qd;
    AnsButtonDirector abd;
    public StudyGenerator sg;
    public GameObject firsttapScreen;
    public GameObject startScreen;

    public AudioController studyA;

    void Start()
    {
        isMiss = true;
        qNum = 1;
        selectedTextC = "<color=#7fff00>";
        PlayerScoreDirector.numOfAnswer = 0;
        sW = Screen.width;
        this.guidePanel = GameObject.Find("GuidePanel");
        this.answerPanel1 = GameObject.Find("AnswerPanel1");
        this.answerPanel2 = GameObject.Find("AnswerPanel2");
        this.answerPanel3 = GameObject.Find("AnswerPanel3");
        this.checkPanel = GameObject.Find("CheckPanel");
        this.nextPanel = GameObject.Find("NextPanel");
        this.qdobj = GameObject.Find("QuestionDirector");
        this.abdobj = GameObject.Find("ButtonDirector");
        goodImage = GameObject.Find("GoodImage").GetComponent<Image>();//Image型にキャスト
        badImage = GameObject.Find("BadImage").GetComponent<Image>();//Image型にキャスト
        qd = qdobj.GetComponent<QuestionDirector>();
        abd = abdobj.GetComponent<AnsButtonDirector>();
        goodImage.GetComponent<Image>().enabled = false;
        badImage.GetComponent<Image>().enabled = false;
        qd.barRestart();
        questiontextReset();
    }

    void Update()
    {
        if (a == 0 && a_1 == 1 && a_2 == 1 && a_3 == 1 && checkMode == 0)
        {
            panelCalling(4);
        }
    }
    public void questiontext1Move()
    {
        questionB_Text2.text = "［2］";
        questionB_Text3.text = "［3］";
        if (a == 1)//答えのボタンを押さずに，他の問題に移った場合
        {
            QuestionDirector.answer2 = answerB;
            QuestionDirector.answer3 = answerC;
        }
        qd.answer1 = selectedTextC + "［1］" + "</color>";
        questionB_Text1.text = selectedTextC + "［1］" + "</color>";
        panelCalling(1);
        a = 1;
        if (a_1 == 1)
        {
            a_1 = 1;
        }
        else
        {
            a_1 = 0;
        }
        qd.qnumCheck();
    }
    public void questiontext2Move()
    {
        questionB_Text1.text = "［1］";
        questionB_Text3.text = "［3］";
        if (a == 1)
        {
            qd.answer1 = answerA;
            QuestionDirector.answer3 = answerC;
        }
        QuestionDirector.answer2 = selectedTextC + "［2］" + "</color>";
        questionB_Text2.text = selectedTextC + "［2］" + "</color>";
        panelCalling(2);
        a = 1;
        if (a_2 == 1)
        {
            a_2 = 1;
        }
        else
        {
            a_2 = 0;
        }
        qd.qnumCheck();
    }
    public void questiontext3Move()
    {
        questionB_Text1.text = "［1］";
        questionB_Text2.text = "［2］";
        if (a == 1)
        {
            qd.answer1 = answerA;
            QuestionDirector.answer2 = answerB;
        }
        QuestionDirector.answer3 = selectedTextC + "［3］" + "</color>";
        questionB_Text3.text = selectedTextC  + "［3］" + "</color>";
        panelCalling(3);
        a = 1;
        if (a_3 == 1)
        {
            a_3 = 1;
        }
        else
        {
            a_3 = 0;
        }
        qd.qnumCheck();
    }
    /// <summary>
    /// 回答する時にボタンを押したときの処理
    /// </summary>
    public void a_buttonPush1_1()//(1)のあたり 
    {
        qd.answer1 = "<color=#0000ff>" + qd.abt1_1 + "</color>";
        goodChoicedProcessing1();
    }
    public void a_buttonPush1_2()
    {
        qd.answer1 = "<color=#0000ff>" + QuestionDirector.abt1_2 + "</color>";
        badChoicedProcessing1();
    }
    public void a_buttonPush1_3()
    {
        qd.answer1 = "<color=#0000ff>" + QuestionDirector.abt1_3 + "</color>";
        badChoicedProcessing1();
    }
    public void a_buttonPush1_4()
    {
        qd.answer1 = "<color=#0000ff>" + QuestionDirector.abt1_4 + "</color>";
        badChoicedProcessing1();
    }

    public void a_buttonPush2_1()//(2)のあたり
    {
        QuestionDirector.answer2 = "<color=#0000ff>" + QuestionDirector.abt2_1 + "</color>";
        goodChoicedProcessing2();
    }
    public void a_buttonPush2_2()
    {
        QuestionDirector.answer2 = "<color=#0000ff>" + QuestionDirector.abt2_2 + "</color>";
        badChoicedProcessing2();
    }
    public void a_buttonPush2_3()
    {
        QuestionDirector.answer2 = "<color=#0000ff>" + QuestionDirector.abt2_2 + "</color>";
        badChoicedProcessing2();
    }
    public void a_buttonPush2_4()
    {
        QuestionDirector.answer2 = "<color=#0000ff>" + QuestionDirector.abt2_4 + "</color>";
        badChoicedProcessing2();
    }

    public void a_buttonPush3_1()//(3)あたり
    {
        QuestionDirector.answer3 = "<color=#0000ff>" + QuestionDirector.abt3_1 + "</color>";

        goodChoicedProcessing3();
    }
    public void a_buttonPush3_2()
    {
        QuestionDirector.answer3 = "<color=#0000ff>" + QuestionDirector.abt3_2 + "</color>";
        badChoicedProcessing3();

    }
    public void a_buttonPush3_3()
    {
        QuestionDirector.answer3 = "<color=#0000ff>" + QuestionDirector.abt3_3 + "</color>";
        badChoicedProcessing3();
    }
    public void a_buttonPush3_4()
    {
        QuestionDirector.answer3 = "<color=#0000ff>" + QuestionDirector.abt3_4 + "</color>";
        badChoicedProcessing3();
    }
    /// <summary>
    /// 答え合わせの時の処理
    /// </summary>
    public void checkButtonPush()
    {
        //全部正解の場合
        if (isAnswer1 == true && isAnswer2 == true && isAnswer3 == true)
        {
            studyA.goodChoice();

            PlayerScoreDirector.numOfAnswer += 1.0f;
            goodImage.GetComponent<Image>().enabled = true;
            checkMode = 1;

        }
        else if (isAnswer1 == false || isAnswer2 == false || isAnswer3 == false)//1つでもはずれがあった場合
        {
            studyA.badChoice();

            badImage.GetComponent<Image>().enabled = true;
            checkMode = 2;
        }
        lastcheck();
    }
    public void lastcheck()
    {
        panelCalling(5);
        if (isCheck == false)
        {
            if (checkMode == 1)
            {//正解の時  
                if (CanvasController.qNum == PlayerScoreDirector.numOfQuestion)
                {
                    nextButton_T.text = "タップ！";
                }
                else
                {
                    nextButton_T.text = "次の問題へ";
                }
                isCheck = true;
            }
            else if (checkMode == 2)
            {//一問でも不正解の場合
                nextButton_T.text = "答え";
                checkMode = 3;
            }
            else if (checkMode == 3)
            {
                badImage.GetComponent<Image>().enabled = false;
                if (isAnswer1 == false)
                {
                    qd.answer1 = "<color=red>" + qd.abt1_1 + "</color>";
                }

                if (isAnswer2 == false)
                {
                    QuestionDirector.answer2 = "<color=red>" + QuestionDirector.abt2_1 + "</color>";
                }

                if (isAnswer3 == false)
                {
                    QuestionDirector.answer3 = "<color=red>" + QuestionDirector.abt3_1 + "</color>";
                }

                qd.qnumCheck();
                isCheck = true;
                isMiss = false;
                if (CanvasController.qNum == PlayerScoreDirector.numOfQuestion || PlayerScoreDirector.numOfs_Mode == 7 && isMiss == false)
                {
                    nextButton_T.text = "タップ！";
                }
                else
                {
                    nextButton_T.text = "次の問題へ";
                }
            }
        }
        else
        {
            if (CanvasController.qNum == PlayerScoreDirector.numOfQuestion + 1 || PlayerScoreDirector.numOfs_Mode == 7 && CanvasController.isMiss == false)
            {

            }
            else
            {
                studyA.nextbuttonPush();
            }
            goodImage.GetComponent<Image>().enabled = false;
            nextQuestion();
        }
    }
    public void questionPass()//パスを選択した場合
    {
        //回答を赤字表示，または，答えの表示
        qd.answer1 = "<color=red>" + qd.abt1_1 + "</color>";
        QuestionDirector.answer2 = "<color=red>" + QuestionDirector.abt2_1 + "</color>";
        QuestionDirector.answer3 = "<color=red>" + QuestionDirector.abt3_1 + "</color>";
        sg.p_canvasOff();
        checkMode = 3;
        lastcheck();
    }
    public void nextQuestion()
    {
        checkMode = 0;
        qNum += 1;
        qd.barAdd();
        questiontextReset();
        qd.qnumCheck();
    }
    public void questiontextReset()
    {
        qd.answer1 = "<color=#a9a9a9>" + "［1］" + "</color>";
        QuestionDirector.answer2 = "<color=#a9a9a9>" + "［2］" + "</color>";
        QuestionDirector.answer3 = "<color=#a9a9a9>" + "［3］" + "</color>";
        questionB_Text1.text = "<color=black>" + "［1］" + "</color>";
        questionB_Text2.text = "<color=black>" + "［2］" + "</color>";
        questionB_Text3.text = "<color=black>" + "［3］" + "</color>";
        answerA = qd.answer1;
        answerB = QuestionDirector.answer2;
        answerC = QuestionDirector.answer3;
        a = 0;
        a_1 = 0;
        a_2 = 0;
        a_3 = 0;
        checkMode = 0;
        abd.shuffleButton();
        isCheck = false;
        panelCalling(0);
    }
    public void goodChoicedProcessing1()//(1)の正解を選んだあとの処理
    {
        answerA = qd.answer1;
        a = 0;
        a_1 = 1;
        isAnswer1 = true;
        questionB_Text1.text = "<color=black>" + "［1］" + "</color>";
        qd.qnumCheck();
        panelCalling(0);
    }
    public void badChoicedProcessing1()//(1)の不正解を選んだあとの処理
    {
        answerA = qd.answer1;
        a = 0;
        a_1 = 1;
        isAnswer1 = false;
        questionB_Text1.text = "<color=black>" + "［1］" + "</color>";
        qd.qnumCheck();
        panelCalling(0);
    }
    public void goodChoicedProcessing2()//(2)の正解を選んだあとの処理
    {
        answerB = QuestionDirector.answer2;
        a = 0;
        a_2 = 1;
        isAnswer2 = true;
        questionB_Text2.text = "<color=black>" + "［2］" + "</color>";
        qd.qnumCheck();
        panelCalling(0);
    }

    public void badChoicedProcessing2()//(2)の不正解を選んだあとの処理
    {
        answerB = QuestionDirector.answer2;
        a = 0;
        a_2 = 1;
        isAnswer2 = false;
        questionB_Text2.text = "<color=black>" + "［2］" + "</color>";
        qd.qnumCheck();
        panelCalling(0);
    }
    public void goodChoicedProcessing3()//(3)の正解を選んだあとの処理
    {
        answerC = QuestionDirector.answer3;
        a = 0;
        a_3 = 1;
        isAnswer3 = true;
        questionB_Text3.text = "<color=black>" + "［3］" + "</color>";
        qd.qnumCheck();
        panelCalling(0);
    }
    public void badChoicedProcessing3()//(3)の不正解を選んだあとの処理
    {
        answerC = QuestionDirector.answer3;
        a = 0;
        a_3 = 1;
        isAnswer3 = false;
        questionB_Text3.text = "<color=black>" + "［3］" + "</color>";
        qd.qnumCheck();
        panelCalling(0);
    }
    public void changeGtext()
    {
        if (a_1 == 1 && a_2 == 0 && a_3 == 0)
        {
            guideText.text = "［2］,［3］を\nタップしてください";
        }
        else if (a_1 == 1 && a_2 == 1 && a_3 == 0)
        {
            guideText.text = "［3］を\nタップしてください";
        }
        else if (a_1 == 0 && a_2 == 1 && a_3 == 0)
        {
            guideText.text = "［1］,［3］を\nタップしてください";
        }
        else if (a_1 == 0 && a_2 == 1 && a_3 == 1)
        {
            guideText.text = "［1］を\nタップしてください";
        }
        else if (a_1 == 0 && a_2 == 0 && a_3 == 1)
        {
            guideText.text = "［1］,［2］を\nタップしてください";
        }
        else if (a_1 == 1 && a_2 == 0 && a_3 == 1)
        {
            guideText.text = "［2］を\nタップしてください";
        }
        else
        {
            guideText.text = "［1］,［2］,［3］を\nタップしてください";
        }

    }
    /// <summary>
    /// パネルを表示する関数 
    /// </summary>
    /// <param name="modeNum"></param>
    public void panelCalling(int modeNum)
    {
        guidePanel.SetActive(false);
        answerPanel1.SetActive(false);
        answerPanel2.SetActive(false);
        answerPanel3.SetActive(false);
        checkPanel.SetActive(false);
        nextPanel.SetActive(false);

        if (modeNum == 0)
        {
            changeGtext();
            guidePanel.SetActive(true);

        }
        else if (modeNum == 1)
        {
            answerPanel1.SetActive(true);
        }
        else if (modeNum == 2)
        {
            answerPanel2.SetActive(true);
        }
        else if (modeNum == 3)
        {
            answerPanel3.SetActive(true);
        }
        else if (modeNum == 4)
        {
            checkPanel.SetActive(true);
        }
        else if (modeNum == 5)
        {
            nextPanel.SetActive(true);
        }
    }
    public void firsttapAct()
    {
        qd.qnumCheck();
        this.startScreen.SetActive(true);
        this.firsttapScreen.SetActive(false);
    }
}

