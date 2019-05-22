using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MypageButton : MonoBehaviour {

    public Text playerScore;

    private string modeName;
    private string categoryName;

    private int rightNum_s;
    private int rightNum_r;
    private int rightNum_c;
    private int ansNum_s;
    private int ansNum_r;
    private int ansNum_c;
    private int mode;
    private int cNum;

    private float aPer;
    private float aPerc;

   //カテゴリー別で成績の表示をするので，modeを7まで増やす
    void Start()
    {//正解数の加算など
        mode = 1;
        cNum = 1;
        scoreText();
    }
    //マイページ下段のボタン操作
    public void studyScore()
    {
        mode = 1;
        scoreText();
    }
    public void ranScore()
    {
        mode = 2;
        scoreText();
    }
    public void challeScore()
    {
        mode = 3;
        scoreText();
    }
    //マイページ上段のボタン操作
    public void category1Choice()
    {
        cNum = 1;
        scoreText();
    }
    public void category2Choice()
    {
        cNum = 2;
        scoreText();
    }
    public void category3Choice()
    {
        cNum = 3;
        scoreText();
    }

    public void scoreText()
    {
        float numOfGood;
        float numOfGoodC;
        float numOfA;
        float numOfAC;

        if (cNum == 1)
        {
            categoryName = "基礎";

        }
        else if (cNum == 2)
        {
            categoryName = "セキュリティ";
        }
        else
        {
            categoryName = "著作権";
        }
        switch (mode)
        {//全て変数に代え，表示できるようにする
            case 1://Study
                modeName = "スタディモード：";
                if (cNum == 1)
                {
                     numOfGood = PlayerScoreDirector.s_numOfGood_c1;
                     numOfA    = PlayerScoreDirector.s_numOfA_c1;
                     numOfGoodC = PlayerScoreDirector.s_numOfGoodC_c1;
                     numOfAC    = PlayerScoreDirector.s_numOfAC_c1;
                }
                else if (cNum == 2)
                {
                    numOfGood = PlayerScoreDirector.s_numOfGood_c2;
                    numOfA    = PlayerScoreDirector.s_numOfA_c2;
                    numOfGoodC = PlayerScoreDirector.s_numOfGoodC_c2;
                    numOfAC    = PlayerScoreDirector.s_numOfAC_c2;
                }
                else
                {
                     numOfGood = PlayerScoreDirector.s_numOfGood_c3;
                     numOfA    = PlayerScoreDirector.s_numOfA_c3;
                     numOfGoodC = PlayerScoreDirector.s_numOfGoodC_c3;
                     numOfAC    = PlayerScoreDirector.s_numOfAC_c3;
                }
                aPer = numOfGood / numOfA*100;
                if (Double.IsNaN(aPer))
                    aPer = 0;
                aPerc = numOfGoodC / numOfAC * 100;
                if (Double.IsNaN(aPerc))
                    aPerc = 0.0f;
                playerScore.text = modeName + categoryName+"\n[前回]\n回答数：" + numOfA + "\n正解数：" + numOfGood + "\n正解率：" + aPer.ToString("F1") + "%\n[総合]\n回答数：" +numOfAC + "\n正解数：" + numOfGoodC + "\n正解率：" + aPerc.ToString("F1")+"%";
                break;
            case 2://random
                modeName = "ランダムモード：";

                if (cNum == 1)
                {
                     numOfGood = PlayerScoreDirector.r_numOfGood_c1;
                     numOfA    = PlayerScoreDirector.r_numOfA_c1;
                     numOfGoodC = PlayerScoreDirector.r_numOfGoodC_c1;
                     numOfAC    = PlayerScoreDirector.r_numOfAC_c1;
                }
                else if (cNum == 2)
                {
                    numOfGood = PlayerScoreDirector.r_numOfGood_c2;
                    numOfA    = PlayerScoreDirector.r_numOfA_c2;
                    numOfGoodC = PlayerScoreDirector.r_numOfGoodC_c2;
                    numOfAC    = PlayerScoreDirector.r_numOfAC_c2;
                }
                else
                {
                     numOfGood = PlayerScoreDirector.r_numOfGood_c3;
                     numOfA    = PlayerScoreDirector.r_numOfA_c3;
                     numOfGoodC = PlayerScoreDirector.r_numOfGoodC_c3;
                     numOfAC    = PlayerScoreDirector.r_numOfAC_c3;
                }
                aPer = numOfGood / numOfA*100;
                if (Double.IsNaN(aPer))
                    aPer = 0;
                aPerc = numOfGoodC / numOfAC * 100;
                if (Double.IsNaN(aPerc))
                    aPerc = 0.0f;
                playerScore.text = modeName + categoryName + "\n[前回]\n回答数：" + numOfA + "\n正解数：" +numOfGood + "\n正解率：" + aPer.ToString("F1") + "%\n[総合]\n回答数：" + numOfAC+"\n正解数："+numOfGoodC + "\n正解率："+aPerc.ToString("F1") + "%";
                break;
            case 3://challenge
                modeName = "チャレンジモード";
                playerScore.text = modeName + "\n[前回]\n到達した問題数：" + PlayerScoreDirector.c_numOfA + "\n[最高記録]\n到達した問題数：" + PlayerScoreDirector.c_numOfBest + "\n\n挑戦回数：" + PlayerScoreDirector.c_PlayCount;
                break;
        }
    }
}
