using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class TutorialController : MonoBehaviour {

    public GameObject backButton;
    public GameObject nextButton;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject image8;
    public GameObject image9;
    public GameObject image10;
    public GameObject image11;
    public GameObject image12;
    public GameObject image13;
    public GameObject aCObj;

    public Text guideText;
    public Text buttonText;

    public static int iNum;

    AudioController aC;

    Vector2 startPos;
    Vector2 endPos;

    void Start()
    {
        aC = aCObj.GetComponent<AudioController>();
        imageChange(iNum);
        this.nextButton.SetActive(true);
    }

    void Update () {

        if(iNum < 1)
        {
            iNum = 1;
            imageChange(iNum);
        }else if(iNum >13)
        {
            iNum = 13;
            imageChange(iNum);
        }

        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }else if (Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;
            compareNum(startPos.x, endPos.x);
        }
    }

    public void imageChange(int iN)
    {
        this.image1.SetActive(false);
        this.image2.SetActive(false);
        this.image3.SetActive(false);
        this.image4.SetActive(false);
        this.image5.SetActive(false);
        this.image6.SetActive(false);
        this.image7.SetActive(false);
        this.image8.SetActive(false);
        this.image9.SetActive(false);
        this.image10.SetActive(false);
        this.image11.SetActive(false);
        this.image12.SetActive(false);
        this.image13.SetActive(false);

        if (iN == 1)
        {
            this.backButton.SetActive(false);
            this.image1.SetActive(true);
            buttonText.text = "スキップ";
            guideText.text = "e-Selfでは，｢マイページ｣｢学習モード｣｢用語集｣｢オプション｣の4つのモードがあります．";
        }
        else if (iN == 2)
        {
            this.backButton.SetActive(true);
            this.image2.SetActive(true);
            guideText.text = "｢マイページ｣では，学習モードでの成績を確認することができます．";
        }
        else if (iN == 3)
        {
            this.image3.SetActive(true);
            guideText.text = "上のボタンをタップすることで，カテゴリー別に成績が表示がされ，自分の苦手な分野を確認することができます．";
        }
        else if (iN == 4)
        {
            this.image4.SetActive(true);
            guideText.text = "｢学習モード｣では，｢スタディ｣｢ランダム｣｢チャレンジ｣の3つの出題形式から選択して学習することができます．";
        }
        else if (iN == 5)
        {
            this.image4.SetActive(true);
            guideText.text = "｢スタディ｣は，指定された順番で出題．｢ランダム｣は，ランダムな順番で出題されます．";
        }
        else if (iN == 6)
        {
            this.image4.SetActive(true);
            guideText.text = "｢チャレンジ｣は｢ランダム｣と同様の出題形式です．不正解となるか全問解くまで継続します．";
        }
        else if (iN == 7)
        {
            this.image5.SetActive(true);
            this.image6.SetActive(true);
            guideText.text = "出題は，虫食い形式となっていて，正しい回答を4つの選択肢から選んでください．";
        }
        else if (iN == 8)
        {
            this.image7.SetActive(true);
            guideText.text = "出題の内容は，モードを選択した後に選ぶことができます．｢チャレンジ｣では，選択することができません．";
        }
        else if (iN == 9)
        {
            this.image8.SetActive(true);
            this.image9.SetActive(true);
            guideText.text = "｢用語集｣では，e-Selfで使用されている，また関連する用語の読み・意味を確認することができます．";
        }
        else if (iN == 10)
        {
            this.image10.SetActive(true);
            this.image11.SetActive(true);
            guideText.text = "｢あいうえお｣ボタンをタップすると，日本語表記または，日本語で始まる用語を昇順で表記をし，また｢ABCDE｣ボタンをタップすると，英数字で表記または始まる用語を昇順で表記します．";
        }
        else if (iN == 11)
        {
            this.image12.SetActive(true);
            guideText.text = "｢オプション｣では，アプリの設定変更や，成績データの初期化などを行うことができます．";
        }
        else if (iN == 12)
        {
            this.nextButton.SetActive(true);
            this.image12.SetActive(true);
            buttonText.text = "スキップ";
            guideText.text = "成績データの初期化を行うと，成績が初期の状態になります．一度行うと，元のデータに戻すことができないので注意してください．";
        }
        else if (iN == 13)
        {
            this.nextButton.SetActive(false);
            this.image13.SetActive(true);
            buttonText.text = "終了";
            guideText.text = "わからないことがあったら，上のヘルプボタン，またチュートリアルをもう一度確認してください．以上でチュートリアルを終了します．";
        }
        houseRule();
    }

    public void compareNum(float sP,float eP)
    {
        if(sP > eP)
        {
            nextImage();
        }
        else if(sP < eP)
        {
            backImage();
        }
        aC.panelOn();
    }

    public void nextImage()
    {
        iNum++;
        imageChange(iNum);
    }
    public void backImage()
    {
        iNum--;
        imageChange(iNum);
    }
    public void houseRule()
    {
        var generator = new TextGenerator();
        var warps = ",.[]{}()?!，．「」｛｝（）？！｢｣";
        generator.Populate(guideText.text, guideText.GetGenerationSettings(guideText.GetComponent<RectTransform>().sizeDelta));
        var lines = generator.lines;

        for (var i = 1; i < lines.Count; ++i)
        {
            if (warps.Contains(guideText.text[lines[i].startCharIdx]))
            {
                guideText.text = guideText.text.Insert(lines[i].startCharIdx - 1, System.Environment.NewLine);
                break;
            }
        }
    }
}
