using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System.Linq;

public class SelectGenerator : MonoBehaviour
{
    GameObject myPage;
    GameObject studyMode;
    GameObject dictionaryMode;
    GameObject optionMode;
    GameObject titleText;
    GameObject backCanvas;
    GameObject s_sPanel;
    GameObject s_rPanel;
    GameObject s_cPanel;
    public GameObject tutorialPanel;
    public GameObject restartPanel;
    public GameObject settingPanel;
    // Use this for initialization
    public GameObject mB;//マイページ移行のボタン
    public GameObject sB;//スタディ
    public GameObject dB;//ディクショナリ(用語集)
    public GameObject oB;//オプション
    public GameObject checkMark_M;
    public GameObject checkMark_B;
    public GameObject checkMark_W;
    public GameObject selectcheckMark_B;
    public GameObject selectcheckMark_R;
    public GameObject selectcheckMark_G;
    public GameObject selectcheckMark_M;
    public GameObject checkMark_FN;
    public GameObject checkMark_FB;
    public GameObject endMessage;
    public GameObject h_MypageImage;
    public GameObject h_StudyImage;
    public GameObject h_DictionaryImage;
    public GameObject h_OptionImage;
    public GameObject helpPanel;
    public GameObject aiueoView;
    public GameObject abcdeView;
    public GameObject creditPanel;
    public GameObject tCObj;
    public GameObject dicConOb;
    public GameObject aCObj; 

    public Image fadeimage;
    public GameObject backimage_B;
    public GameObject backimage_R;
    public GameObject backimage_G;
    public GameObject backimage_M;

    public Text helpTitle;
    public Text helpText;
    //GameObject pSdobj;

    private Vector2 mBls;
    private Vector2 sBls;
    private Vector2 dBls;
    private Vector2 oBls;

    private int hNum;
    private bool isFade;

    private float fc = 0.0f;
    private float bc = 0.01f;

    DictionaryController dicCon;
    TutorialController tC;
    AudioController aC;

    Color alpha;
    //PlayerScoreDirector pSd;
    enum mode : int
    {
        MYPAGE,
        STUDY,
        DICTIONARY,
        OPTION
    };

    void Start()
    {
        aC = aCObj.GetComponent<AudioController>();
        dicCon = dicConOb.GetComponent<DictionaryController>();
        selectbackimageCheck(PlayerScoreDirector.selectbackNum);
        isFade = false;
        fadeimage.color = new Color(0, 0, 0,fc);
        fadeimage.gameObject.SetActive(false);
        this.myPage = GameObject.Find("MypagePanel");
        this.studyMode = GameObject.Find("StudyPanel");
        this.dictionaryMode = GameObject.Find("DictionaryPanel");
        this.optionMode = GameObject.Find("OptionPanel");
        this.titleText = GameObject.Find("TitleText");
        this.backCanvas = GameObject.Find("BackCanvas");
        this.s_sPanel = GameObject.Find("S_sPanel");
        this.s_rPanel = GameObject.Find("S_rPanel");
        this.s_cPanel = GameObject.Find("S_cPanel");
        //this.pSdobj = GameObject.Find("PlayerScoreDirector");
        changeWord(1);
        PlayerScoreDirector.numOfs_Mode = 0;
        //pSd = pSdobj.GetComponent<PlayerScoreDirector>();
        studybacknumCheck(PlayerScoreDirector.studybackNum);
        fontnumCheck();
        this.backCanvas.SetActive(false);
        this.restartPanel.SetActive(false);
        this.endMessage.SetActive(false);
        this.helpPanel.SetActive(false);
        this.creditPanel.SetActive(false);
        mBls = this.mB.transform.localScale;
        sBls = this.sB.transform.localScale;
        dBls = this.dB.transform.localScale;
        oBls = this.oB.transform.localScale;
        tC = tCObj.GetComponent<TutorialController>();

        //初回起動かどうかの判別
        if(PlayerScoreDirector.isPlay == 0)
        {
            panelCalling(0);
        }else
        {
            panelCalling(1);
        }

        buttonScalling(1);
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            daialogOn();
        }

        if(isFade == true) { 
            fc += bc;
            fadeimage.color = new Color(0, 0, 0, fc);
        }
        if (fc >= 1.0f)
        SceneManager.LoadScene("StudyScene");
    }

    public void mypageMove()
    {
        this.titleText.GetComponent<Text>().text = "マイページ\n";
        panelCalling(1);
        buttonScalling(1);
    }

    public void studyMove()
    {
        this.titleText.GetComponent<Text>().text = "学習モード";
        panelCalling(2);
        buttonScalling(2);
    }

    /// <summary>
    /// 辞書モードに移行
    /// </summary>
    public void dictionaryMove()
    {
        this.titleText.GetComponent<Text>().text = "用語集";
        panelCalling(3);
        buttonScalling(3);
    }

    /// <summary>
    /// オプションモードに移行
    /// </summary>
    public void optionMove()
    {
        this.titleText.GetComponent<Text>().text = "オプション";
        panelCalling(4);
        buttonScalling(4);
    }

    public void s_sceneMove(int cNum)
    {
        if (cNum == 1)
        {
            PlayerScoreDirector.numOfs_Mode = 1;
            PlayerScoreDirector.numOfQuestion = 21.0f;
            fadeoutScene();
        }
        else if (cNum == 2)
        {
            PlayerScoreDirector.numOfs_Mode = 2;
            PlayerScoreDirector.numOfQuestion = 12.0f;
            fadeoutScene();
        }
        else if (cNum == 3)
        {
            PlayerScoreDirector.numOfs_Mode = 3;
            PlayerScoreDirector.numOfQuestion = 9.0f;
            fadeoutScene();
        }
    }
    /// <summary>
    /// ランダムモードでの選択した場合
    /// </summary>
    /// <param name="qValue"></param>
    /// 
    public void r_sceneMove(int qValue)
    {
        if(qValue == 1) { 
        PlayerScoreDirector.numOfs_Mode = 4;
        PlayerScoreDirector.numOfQuestion = 21.0f;
            fadeoutScene();
        }
        else if (qValue == 2)
        {
            PlayerScoreDirector.numOfs_Mode = 5;
            PlayerScoreDirector.numOfQuestion = 12.0f;
            fadeoutScene();
        }
        else
        {
            PlayerScoreDirector.numOfs_Mode = 6;
            PlayerScoreDirector.numOfQuestion = 9.0f;
            fadeoutScene();
        }
    }

    public void c_sneneMove()
    {
        PlayerScoreDirector.c_PlayCount += 1;
        PlayerScoreDirector.numOfs_Mode = 7;
        PlayerScoreDirector.numOfQuestion = 42.0f;
        fadeoutScene();
    }

    public void daialogOn()
    {
        aC.panelOn();
        this.backCanvas.SetActive(true);
    }

    public void restartdialogOn()
    {
        this.restartPanel.SetActive(true);
    }

    public void titleBack()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void daialogOff()
    {
        this.backCanvas.SetActive(false);
    }

    public void restartdialogOff()
    {
        this.restartPanel.SetActive(false);
    }

    /// <summary>
    /// メニューパネルのボタンサイズの変更
    /// </summary>
    /// <param name="num"></param>
    void buttonScalling(int num)
    {
        if (num == 1)
        {
            this.mB.transform.localScale = mBls * 1.3f;
            this.sB.transform.localScale = sBls;
            this.dB.transform.localScale = dBls;
            this.oB.transform.localScale = oBls;
        }
        else if (num == 2)
        {
            this.mB.transform.localScale = mBls;
            this.sB.transform.localScale = sBls * 1.3f;
            this.dB.transform.localScale = dBls;
            this.oB.transform.localScale = oBls;
        }
        else if (num == 3)
        {
            this.mB.transform.localScale = mBls;
            this.sB.transform.localScale = sBls;
            this.dB.transform.localScale = dBls * 1.3f;
            this.oB.transform.localScale = oBls;
        }
        else if (num == 4)
        {
            this.mB.transform.localScale = mBls;
            this.sB.transform.localScale = sBls;
            this.dB.transform.localScale = dBls;
            this.oB.transform.localScale = oBls * 1.3f;
        }
    }

    /// <summary>
    /// パネルの呼び出し
    /// </summary>
    /// <param name="mN"></param>
    public void panelCalling(int mN)
    {
        this.myPage.SetActive(false);
        this.studyMode.SetActive(false);
        this.dictionaryMode.SetActive(false);
        this.optionMode.SetActive(false);
        this.s_sPanel.SetActive(false);
        this.s_rPanel.SetActive(false);
        this.s_cPanel.SetActive(false);
        this.settingPanel.SetActive(false);
        this.h_MypageImage.SetActive(false);
        this.h_StudyImage.SetActive(false);
        this.h_DictionaryImage.SetActive(false);
        this.h_OptionImage.SetActive(false);
        this.tutorialPanel.SetActive(false);

        if (mN == 0)
        {
            TutorialController.iNum = 1;
            tC.imageChange(1);
           tutorialPanel.SetActive(true);
        }else if (mN == 1)
        {
            myPage.SetActive(true);
            this.h_MypageImage.SetActive(true);
            hNum = (int)mode.MYPAGE;
        }
        else if (mN == 2)
        {
            studyMode.SetActive(true);
            this.h_StudyImage.SetActive(true);
            hNum = (int)mode.STUDY;
        }
        else if (mN == 3)
        {
            dictionaryMode.SetActive(true);
            this.h_DictionaryImage.SetActive(true);
            hNum = (int)mode.DICTIONARY;
        }
        else if (mN == 4)
        {
            optionMode.SetActive(true);
            this.h_OptionImage.SetActive(true);
            hNum = (int)mode.OPTION;
        }
        else if (mN == 5)
        {
            this.h_StudyImage.SetActive(true);
            s_sPanel.SetActive(true);
            hNum = (int)mode.STUDY;
        }
        else if (mN == 6)
        {
            this.h_StudyImage.SetActive(true);
            s_rPanel.SetActive(true);
            hNum = (int)mode.STUDY;
        }
        else if (mN == 7)
        {
            this.h_StudyImage.SetActive(true);
            s_cPanel.SetActive(true);
            hNum = (int)mode.STUDY;
        }
        else if (mN == 8)
        {
            this.h_OptionImage.SetActive(true);
            settingPanel.SetActive(true);
            hNum = (int)mode.OPTION;
        }
    }
    /// <summary>
    /// データの初期化
    /// </summary>
    /// 
    public void dateReset()
    {
        PlayerScoreDirector.r_numOfA = 0;
        PlayerScoreDirector.c_numOfA = 0;
        PlayerScoreDirector.numOfQuestion = 0;
        PlayerScoreDirector.numOfAnswer = 0;
        PlayerScoreDirector.s_numOfGoodC = 0;
        PlayerScoreDirector.r_numOfGoodC = 0;
        PlayerScoreDirector.c_numOfBest = 0;
        PlayerScoreDirector.s_numOfAC = 0;
        PlayerScoreDirector.r_numOfAC = 0;
        PlayerScoreDirector.c_numOfAC = 0;
        PlayerScoreDirector.c_PlayCount = 0;
        PlayerScoreDirector.studybackNum = 1;
        PlayerScoreDirector.selectbackNum = 1;
        PlayerScoreDirector.q_fontNum = 1;
        PlayerScoreDirector.isPlay = 0;

        PlayerPrefs.DeleteAll();

        studybacknumCheck(PlayerScoreDirector.studybackNum);
        fontnumCheck();
        
        this.endMessage.SetActive(true);
    }
    /// <summary>
    /// 学習モードの背景設定
    /// </summary>
    /// <param name="bN"></param>
    public void studybacknumCheck(int bN)
    {
        PlayerScoreDirector.studybackNum = bN;
        this.checkMark_M.SetActive(false);
        this.checkMark_B.SetActive(false);
        this.checkMark_W.SetActive(false);
        if (bN == 1)
        {
            this.checkMark_M.SetActive(true);
        }
        else if (bN == 2)
        {
            this.checkMark_B.SetActive(true);
        }
        else if (bN == 3)
        {
            this.checkMark_W.SetActive(true);
        }
        PlayerPrefs.SetInt(PlayerScoreDirector.StudyB_key, PlayerScoreDirector.studybackNum);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// ヘルプ画面表示
    /// </summary>
    public void openHelpPanel()
    {
        if (hNum == (int)mode.MYPAGE)
        {
            helpTitle.text = "マイページとは？";
            helpText.text = "　｢マイページ｣では，学習モードでのカテゴリー別の前回とこれまでの回答数，正解数，正解率の表示，またチャレンジモードの成績では前回の分と，今までの最高記録の到達問題数を確認することができます．\n　回答数は解いた問題の数，正解数は正解した問題の数の事を指し，この2つを基に正解率を算出しています．";
        }
        else if (hNum == (int)mode.STUDY)
        {
            helpTitle.text = "学習モードとは？";
            helpText.text = "　｢学習モード｣では，3つの出題形式から1つ選び，選択したカテゴリー別に学ぶ事が出来ます．\n・スタディモード…選択したカテゴリーの問題が指定された順番に出題されます．\n・ランダムモード…選択したカテゴリーの問題がランダムに出題されます．\n・チャレンジ…全ての問題を不正解または全問正解するまで解き続けることができます．";
        }
        else if (hNum == (int)mode.DICTIONARY)
        {
            helpTitle.text = "用語集とは？";
            helpText.text = "　｢用語集｣では，e-Selfで使用されている，また関連する用語の読み・意味を確認することができます．｢あいうえお｣と書いてあるボタンをタップすると日本語で表記されている用語，また日本語で始まる用語が表示され，｢ABCDE｣と書いてあるボタンをタップすると，英数字で表記されている用語，また英数字で始まる用語を表示します．";
        }
        else if (hNum == (int)mode.OPTION)
        {
            helpTitle.text = "オプションとは？";
            helpText.text = "　｢オプション｣では，チュートリアルの表示やe-Selfの設定の変更，成績データの初期化などを行うことができます．成績データの初期化を行うと，初期の状態になりますが，以前の状態には戻せないので注意してください．";
        }
        houseRule();
        this.helpPanel.SetActive(true);
    }

    public void houseRule()
    {
        var generator = new TextGenerator();
        var warps = ",.[]{}()?!，．「」｛｝（）［］？！";
        generator.Populate(helpText.text, helpText.GetGenerationSettings(helpText.GetComponent<RectTransform>().sizeDelta));
        var lines = generator.lines;
        for (var i = 1; i < lines.Count; ++i)
        {
            if (warps.Contains(helpText.text[lines[i].startCharIdx]))
            {
                helpText.text = helpText.text.Insert(lines[i].startCharIdx - 1, System.Environment.NewLine);
                break;
            }
        }
    }

    /// <summary>
    /// ヘルプ画面を閉じる
    /// </summary>
    public void closeHelpPanel()
    {
        this.helpPanel.SetActive(false);
    }

    /// <summary>
    /// モードの変更
    /// </summary>
    /// <param name="cNum"></param>
    public void changeWord(int cNum) {

        if(cNum == 1)
        {
            this.aiueoView.SetActive(true);
            this.abcdeView.SetActive(false);
        }
        else if(cNum == 2)
        {
            this.aiueoView.SetActive(false);
            this.abcdeView.SetActive(true);
        }
    }

    /// <summary>
    /// オプションモードでの文字サイズに関する機能
    /// </summary>
    /// <param name="fN"></param>
    public void fontSet(int fN)
    {
        if (fN == 1)
        {
            PlayerScoreDirector.q_fontNum = 1;
        }
        else if (fN == 2)
        {
            PlayerScoreDirector.q_fontNum = 2;
        }
        fontnumCheck();
    }
    public void fontnumCheck()
    {
        this.checkMark_FN.SetActive(false);
        this.checkMark_FB.SetActive(false);
        if (PlayerScoreDirector.q_fontNum == 1)
        {
            this.checkMark_FN.SetActive(true);
        }
        else if (PlayerScoreDirector.q_fontNum == 2)
        {
            this.checkMark_FB.SetActive(true);
        }
        PlayerPrefs.SetInt(PlayerScoreDirector.F_key, PlayerScoreDirector.q_fontNum);
        PlayerPrefs.Save();
    }


    public void fadeoutScene()
    {
        isFade = true;
        fadeimage.gameObject.SetActive(true);
    }

    public void openCreditpanel()
    {
        this.creditPanel.SetActive(true);
    }

    public void closeCreditpanel()
    {
        this.creditPanel.SetActive(false);
    }

    /// <summary>
    /// チュートリアルをスキップ
    /// </summary>
    public void skipbuttonPush()
    {
        panelCalling(1);
        if(PlayerScoreDirector.isPlay == 0) { 
            PlayerScoreDirector.isPlay = 1;
            PlayerPrefs.SetInt(PlayerScoreDirector.isP, PlayerScoreDirector.isPlay);
            PlayerPrefs.Save();
        }
    }

    public void selectbackimageCheck(int sbN)
    {
        PlayerScoreDirector.selectbackNum = sbN;

        this.selectcheckMark_B.SetActive(false);
        this.selectcheckMark_R.SetActive(false);
        this.selectcheckMark_G.SetActive(false);
        this.selectcheckMark_M.SetActive(false);

        this.backimage_B.SetActive(false);
        this.backimage_R.SetActive(false);
        this.backimage_G.SetActive(false);
        this.backimage_M.SetActive(false);
        if (sbN == 1)
        {
            this.selectcheckMark_B.SetActive(true);
            this.backimage_B.SetActive(true);
        }
        else if (sbN == 2)
        {
            this.selectcheckMark_R.SetActive(true);
            this.backimage_R.SetActive(true);
        }
        else if (sbN == 3)
        {
        this.selectcheckMark_G.SetActive(true);
            this.backimage_G.SetActive(true);
        }
        else if (sbN == 4)
        {
        this.selectcheckMark_M.SetActive(true);
            this.backimage_M.SetActive(true);
        }
        PlayerPrefs.SetInt(PlayerScoreDirector.SelectB_key, PlayerScoreDirector.selectbackNum);
        PlayerPrefs.Save();
    }
    
}