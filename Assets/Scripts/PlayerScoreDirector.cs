using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerScoreDirector : MonoBehaviour {
    
    public static float s_numOfGood_c1;//スタディモードカテゴリー１の正解数
    public static float s_numOfGood_c2;//スタディモードカテゴリー２の正解数
    public static float s_numOfGood_c3;//スタディモードカテゴリー３の正解数

    public static float s_numOfA_c1;//スタディモードカテゴリー１の回答数
    public static float s_numOfA_c2;//スタディモードカテゴリー２の回答数
    public static float s_numOfA_c3;//スタディモードカテゴリー３の回答数
    
    public static float r_numOfA;//ランダムモードの回答数
    
    public static float r_numOfGood_c1;//スタディモードカテゴリー１の正解数
    public static float r_numOfGood_c2;//スタディモードカテゴリー２の正解数
    public static float r_numOfGood_c3;//スタディモードカテゴリー３の正解数

    public static float r_numOfA_c1;//ランダムモードカテゴリー１の回答数
    public static float r_numOfA_c2;//ランダムモードカテゴリー２の回答数
    public static float r_numOfA_c3;//ランダムモードカテゴリー３の回答数
    
    public static float c_numOfA;//チャレンジモードの回答数
    public static float numOfQuestion;//解く問題数
    public static float numOfAnswer;//正解数
    public static int numOfs_Mode;//スタディモードを表す
    public static float s_numOfGoodC;//スタディモードの総正解数
    
    //カテゴリー別スタディモードの総正解数
    public static float s_numOfGoodC_c1;
    public static float s_numOfGoodC_c2;
    public static float s_numOfGoodC_c3;
    
    public static float r_numOfGoodC;//ランダムモードの総正解数
    
    //カテゴリー別ランダムモードの総正解数
    public static float r_numOfGoodC_c1;//ランダムモードの総正解数
    public static float r_numOfGoodC_c2;//ランダムモードの総正解数
    public static float r_numOfGoodC_c3;//ランダムモードの総正解数
    public static float c_numOfBest;//チャレンジモードの最高正解回数
    public static float s_numOfAC;//スタディモードの総回答数
    //カテゴリー別スタディモードの総回答数
    public static float s_numOfAC_c1;
    public static float s_numOfAC_c2;
    public static float s_numOfAC_c3;
    public static float r_numOfAC;//ランダムモードの総回答数
    
    //カテゴリー別スランダムモードの総回答数
    public static float r_numOfAC_c1;
    public static float r_numOfAC_c2;
    public static float r_numOfAC_c3;
    public static int c_numOfAC;//チャレンジモードの総回答数
    public static int studybackNum;//StudySceneの背景を設定する番号
    public static int selectbackNum;//SelectSceneの背景を設定する番号
    public static int q_fontNum;
    public static int c_PlayCount;//チャレンジモードのプレイ数
    public static int isPlay;

    string sceneName;

    string S_keyA_c1 = "S_NUMOFOFA_C1";//前回の回答数
    string S_keyA_c2 = "S_NUMOFOFA_C2";//前回の回答数
    string S_keyA_c3 = "S_NUMOFOFA_C3";//前回の回答数

    string S_keyAC_c1 = "S_NUMOFOFAC_C1";//総合の回答数
    string S_keyAC_c2 = "S_NUMOFOFAC_C2";//総合の回答数
    string S_keyAC_c3 = "S_NUMOFOFAC_C3";//総合の回答数
    
    string S_keyG_c1 = "S_NUMOFOFGOOD_C1";//前回の正解数
    string S_keyG_c2 = "S_NUMOFOFGOOD_C2";//前回の正解数
    string S_keyG_c3 = "S_NUMOFOFGOOD_C3";//前回の正解数
    

    string S_keyGC_c1 = "S_NUMOFOFGOODC_C1";//総合正解数
    string S_keyGC_c2 = "S_NUMOFOFGOODC_C2";//総合正解数
    string S_keyGC_c3 = "S_NUMOFOFGOODC_C3";//総合正解数

    //ランダムモードの設定保存キー
    
    string R_keyA_c1 = "R_NUMOFOFA_C1";//前回の回答数
    string R_keyA_c2 = "R_NUMOFOFA_C2";//前回の回答数
    string R_keyA_c3 = "R_NUMOFOFA_C3";//前回の回答数
    
    string R_keyAC_c1 = "R_NUMOFOFAC_C1";//総合回答数
    string R_keyAC_c2 = "R_NUMOFOFAC_C2";//総合回答数
    string R_keyAC_c3 = "R_NUMOFOFAC_C3";//総合回答数
    
    string R_keyG_c1 = "R_NUMOFOFGOOD_C1";//前回の正解数
    string R_keyG_c2 = "R_NUMOFOFGOOD_C2";//前回の正解数
    string R_keyG_c3 = "R_NUMOFOFGOOD_C3";//前回の正解数
    
    string R_keyGC_c1 = "R_NUMOFOFGOODC_C1";//総合正解数
    string R_keyGC_c2 = "R_NUMOFOFGOODC_C2";//総合正解数
    string R_keyGC_c3 = "R_NUMOFOFGOODC_C3";//総合正解数
    
    //チャレンジモードの設定保存キー
    string C_keyA = "C_NUMOFOFA";//前回の回答数
    string C_keyBest = "C_NUMOFOFBest";//最高回答数
    string C_keyPlayCount = "C_PlayCount";//挑戦回数

    //オプションの詳細設定での保存キー
    public static string StudyB_key = "STUDYBACK_NUM";
    public static string SelectB_key = "SELECTBACK_NUM";
    public static string F_key = "Q_FONTSIZE";

    public static string isP = "ISP";

    void Start()
    {
        numOfQuestion = 0;
        numOfs_Mode = 0;
        DontDestroyOnLoad(this);

        isPlay = PlayerPrefs.GetInt(isP, 0);

        s_numOfA_c1 = PlayerPrefs.GetFloat(S_keyA_c1, 0);
        s_numOfA_c2 = PlayerPrefs.GetFloat(S_keyA_c2, 0);
        s_numOfA_c3 = PlayerPrefs.GetFloat(S_keyA_c3, 0);

        s_numOfAC_c1 = PlayerPrefs.GetFloat(S_keyAC_c1, 0);
        s_numOfAC_c2 = PlayerPrefs.GetFloat(S_keyAC_c2, 0);
        s_numOfAC_c3 = PlayerPrefs.GetFloat(S_keyAC_c3, 0);

        s_numOfGood_c1 = PlayerPrefs.GetFloat(S_keyG_c1, 0);
        s_numOfGood_c2 = PlayerPrefs.GetFloat(S_keyG_c2, 0);
        s_numOfGood_c3 = PlayerPrefs.GetFloat(S_keyG_c3, 0);

        s_numOfGoodC_c1 = PlayerPrefs.GetFloat(S_keyGC_c1, 0);
        s_numOfGoodC_c2 = PlayerPrefs.GetFloat(S_keyGC_c2, 0);
        s_numOfGoodC_c3 = PlayerPrefs.GetFloat(S_keyGC_c3, 0);

        r_numOfA_c1 = PlayerPrefs.GetFloat(R_keyA_c1, 0);
        r_numOfA_c2 = PlayerPrefs.GetFloat(R_keyA_c2, 0);
        r_numOfA_c3 = PlayerPrefs.GetFloat(R_keyA_c3, 0);

        r_numOfAC_c1 = PlayerPrefs.GetFloat(R_keyAC_c1, 0);
        r_numOfAC_c2 = PlayerPrefs.GetFloat(R_keyAC_c2, 0);
        r_numOfAC_c3 = PlayerPrefs.GetFloat(R_keyAC_c3, 0);

        r_numOfGood_c1 = PlayerPrefs.GetFloat(R_keyG_c1, 0);
        r_numOfGood_c2 = PlayerPrefs.GetFloat(R_keyG_c2, 0);
        r_numOfGood_c3 = PlayerPrefs.GetFloat(R_keyG_c3, 0);

        r_numOfGoodC_c1 = PlayerPrefs.GetFloat(R_keyGC_c1, 0);
        r_numOfGoodC_c2 = PlayerPrefs.GetFloat(R_keyGC_c2, 0);
        r_numOfGoodC_c3 = PlayerPrefs.GetFloat(R_keyGC_c3, 0);
        //チャレンジモードのスコア読み込み
        c_numOfA = PlayerPrefs.GetFloat(C_keyA, 0);
        c_numOfBest = PlayerPrefs.GetFloat(C_keyBest, 0);
        c_PlayCount = PlayerPrefs.GetInt(C_keyPlayCount, 0);
        //詳細設定に関する変数
        studybackNum = PlayerPrefs.GetInt(StudyB_key, 1);
        selectbackNum = PlayerPrefs.GetInt(SelectB_key, 1);
        q_fontNum = PlayerPrefs.GetInt(F_key, 1);
    }

    public void saveNum(int m)
    {   
        if(m == 1){
            s_numOfGood_c1 = numOfAnswer;//正解数の取得
            s_numOfA_c1 = numOfQuestion;//回答数の取得
            s_numOfGoodC_c1 += numOfAnswer;//正解数の加算
            s_numOfAC_c1 += numOfQuestion; //回答数の加算

            PlayerPrefs.SetFloat(S_keyA_c1, s_numOfA_c1);
            PlayerPrefs.SetFloat(S_keyAC_c1, s_numOfAC_c1);
            PlayerPrefs.SetFloat(S_keyG_c1, s_numOfGood_c1);
            PlayerPrefs.SetFloat(S_keyGC_c1, s_numOfGoodC_c1);
        }else if(m == 2){
            s_numOfGood_c2 = numOfAnswer;//正解数の取得
            s_numOfA_c2 = numOfQuestion;//回答数の取得
            s_numOfGoodC_c2 += numOfAnswer;//正解数の加算
            s_numOfAC_c2 += numOfQuestion; //回答数の加算

            PlayerPrefs.SetFloat(S_keyA_c2, s_numOfA_c2);
            PlayerPrefs.SetFloat(S_keyAC_c2, s_numOfAC_c2);
            PlayerPrefs.SetFloat(S_keyG_c2, s_numOfGood_c2);
            PlayerPrefs.SetFloat(S_keyGC_c2, s_numOfGoodC_c2);
        }else if(m == 3){
            s_numOfGood_c3 = numOfAnswer;//正解数の取得
            s_numOfA_c3 = numOfQuestion;//回答数の取得
            s_numOfGoodC_c3 += numOfAnswer;//正解数の加算
            s_numOfAC_c3 += numOfQuestion; //回答数の加算

            PlayerPrefs.SetFloat(S_keyA_c3, s_numOfA_c3);
            PlayerPrefs.SetFloat(S_keyAC_c3, s_numOfAC_c3);
            PlayerPrefs.SetFloat(S_keyG_c3, s_numOfGood_c3);
            PlayerPrefs.SetFloat(S_keyGC_c3, s_numOfGoodC_c3);
        }else if(m == 4){
            r_numOfGood_c1 = numOfAnswer;//正解数の取得
            r_numOfA_c1 = numOfQuestion;//回答数の取得
            r_numOfGoodC_c1 += numOfAnswer;//正解数の加算
            r_numOfAC_c1 += numOfQuestion; //回答数の加算

            PlayerPrefs.SetFloat(R_keyA_c1, r_numOfA_c1);
            PlayerPrefs.SetFloat(R_keyAC_c1, r_numOfAC_c1);
            PlayerPrefs.SetFloat(R_keyG_c1, r_numOfGood_c1);
            PlayerPrefs.SetFloat(R_keyGC_c1, r_numOfGoodC_c1);
        }else if(m == 5){
            r_numOfGood_c2 = numOfAnswer;//正解数の取得
            r_numOfA_c2 = numOfQuestion;//回答数の取得
            r_numOfGoodC_c2 += numOfAnswer;//正解数の加算
            r_numOfAC_c2 += numOfQuestion; //回答数の加算

            PlayerPrefs.SetFloat(R_keyA_c2, r_numOfA_c2);
            PlayerPrefs.SetFloat(R_keyAC_c2, r_numOfAC_c2);
            PlayerPrefs.SetFloat(R_keyG_c2, r_numOfGood_c2);
            PlayerPrefs.SetFloat(R_keyGC_c2, r_numOfGoodC_c2);
        }else if(m == 6){
            r_numOfGood_c3 = numOfAnswer;//正解数の取得
            r_numOfA_c3 = numOfQuestion;//回答数の取得
            r_numOfGoodC_c3 += numOfAnswer;//正解数の加算
            r_numOfAC_c3 += numOfQuestion; //回答数の加算

            PlayerPrefs.SetFloat(R_keyA_c3, r_numOfA_c3);
            PlayerPrefs.SetFloat(R_keyAC_c3, r_numOfAC_c3);
            PlayerPrefs.SetFloat(R_keyG_c3, r_numOfGood_c3);
            PlayerPrefs.SetFloat(R_keyGC_c3, r_numOfGoodC_c3);
        }
        else
        {//チャレンジモード
            PlayerPrefs.SetFloat(C_keyA, c_numOfA);
            PlayerPrefs.SetFloat(C_keyBest, c_numOfBest);
            PlayerPrefs.SetInt(C_keyPlayCount, c_PlayCount);
        }
        PlayerPrefs.Save();
        
    }
}
