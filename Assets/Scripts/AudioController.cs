using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

    private new AudioSource audio;
    public AudioClip menubuttonSe;
    public AudioClip buttonSe;
    public AudioClip cancelSe;
    public AudioClip pausebuttonSe;
    public AudioClip checkbuttonSe;
    public AudioClip resetSe;
    public AudioClip gameEndSe;
    public AudioClip gameStartSe;
    public AudioClip titleBgm;
    public AudioClip selectBgm;
    public AudioClip studyBgm;
    public AudioClip passbuttonSe;
    public AudioClip panelOnSe;
    public AudioClip questionSe;
    public AudioClip answerbuttonSe;
    public AudioClip goodSe;
    public AudioClip badSe;

    void Start () {
        audio = gameObject.GetComponent<AudioSource>();
    }

    public void menuButtonPush()
    {
        audio.PlayOneShot(menubuttonSe);
    }

    public void buttonPush()
    {
        audio.PlayOneShot(menubuttonSe);
    }

    /// <summary>
    /// 解答ボタンを押したときの音
    /// </summary>
    public void answerbuttonPush()
    {
        audio.PlayOneShot(answerbuttonSe);
    }
    public void nextbuttonPush()
    {
        audio.PlayOneShot(questionSe);
    }
    /// <summary>
    /// パネル(ポーズやヘルプ)の時の効果音
    /// </summary>
    public void panelOn()
    {
        audio.PlayOneShot(panelOnSe);
    }

    /// <summary>
    /// パスパネルの｢はい｣を押したとき
    /// </summary>
    public void passbuttonPush()
    {
        audio.PlayOneShot(passbuttonSe);
    }
    /// <summary>
    /// 「戻る」また，「キャンセル」の意味合いを持つボタンを押したときの音．少し低め
    /// </summary>
    public void cancelbuttonPush()
    {
        audio.PlayOneShot(cancelSe);
    }

    /// <summary>
    /// 「動きが止まるのような働きを持つボタンのSE，
    /// </summary>
    public void pausebuttonPush()
    {
        audio.PlayOneShot(pausebuttonSe);
    }

    /// <summary>
    /// ｢採点ボタン｣を押したときのSE,正解または不正解の効果音と被るかもしれないから優先順位は低め
    /// </summary>
    public void checkbuttonPush()
    {
        audio.PlayOneShot(checkbuttonSe);
    }

    /// <summary>
    /// 正解・不正解の時になる効果音・もしかしたら別のスクリプトに書くかも
    /// </summary>
    public void goodChoice()
    {
        audio.PlayOneShot(goodSe);
    }
    public void badChoice()
    {
        audio.PlayOneShot(badSe);
    }

    /// <summary>
    /// ｢データの初期化｣をした場合の効果音，機械の電源が落ちるようなのが良い．ぎゅおーん
    /// </summary>
    public void resetbuttonSe()
    {
        audio.PlayOneShot(resetSe);
    }

    /// <summary>
    /// スタディモードの始まりと終わりを告げる音．スタートは｢ピー！｣，エンドは｢ピッピー！｣が理想的．
    /// </summary>
    public void gamaStart()
    {
        audio.PlayOneShot(gameStartSe);
    }
    public void gameEnd()
    {
        audio.PlayOneShot(gameEndSe);
    }

    /// <summary>
    /// それぞれのシーンのBGM
    /// </summary>
    public void titlebgmStart()
    {
        audio.PlayOneShot(titleBgm);
    }
    public void selectbgmStart()
    {
        audio.PlayOneShot(titleBgm);
    }
    public void studybgmStart()
    {
        audio.PlayOneShot(titleBgm);
    }
}
