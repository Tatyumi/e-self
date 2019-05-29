using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;

public class QuestionDirector : MonoBehaviour
{
    public Text questionText;
    public Text questionNumText;
    public Text answerB_Text1_1;
    public Text answerB_Text1_2;
    public Text answerB_Text1_3;
    public Text answerB_Text1_4;
    public Text answerB_Text2_1;
    public Text answerB_Text2_2;
    public Text answerB_Text2_3;
    public Text answerB_Text2_4;
    public Text answerB_Text3_1;
    public Text answerB_Text3_2;
    public Text answerB_Text3_3;
    public Text answerB_Text3_4;
    public Text q_numText;
    public Text guideText;

    public string answer1;
    public static string answer2;
    public static string answer3;
    public string abt1_1;
    public static string abt1_2;
    public static string abt1_3;
    public static string abt1_4;
    public static string abt2_1;
    public static string abt2_2;
    public static string abt2_3;
    public static string abt2_4;
    public static string abt3_1;
    public static string abt3_2;
    public static string abt3_3;
    public static string abt3_4;
    static string category;
    


    public int[] number;
    bool isR;

    public AudioController studyA;

    public GameObject studyBgm;
    public GameObject endScreen;
    public GameObject passButton;
    //GameObject pSdobj;

    private int qCount;
    int endNum;

    //public Image progressBar;
    public Slider progresBar;

    enum studymode : int
    {
        STUDY_C1,
        STUDY_C2,
        STUDY_C3,
        STUDY_C4,
        RANDOM_C1,
        RANDOM_C2,
        RANDOM_C3,
        CHALLENGE
    };

    void Start()
    {
        isR = true;
        number = new int[(int)PlayerScoreDirector.numOfQuestion];
        qCount = 0;
        endScreen.gameObject.SetActive(false);
        fontCheck();
    }

    public void qnumCheck()
    {
        

        if (CanvasController.qNum == PlayerScoreDirector.numOfQuestion + 1 || PlayerScoreDirector.numOfs_Mode == 7 && CanvasController.isMiss == false) { 
            gameEnd();
        }

        if (isR == true)
        {
            if (PlayerScoreDirector.numOfs_Mode == 1 || PlayerScoreDirector.numOfs_Mode == 2 || PlayerScoreDirector.numOfs_Mode == 3)
            {
                normalSelect(ref number);
            }
            else {
                shuffleNum(ref number);
                if (PlayerScoreDirector.numOfs_Mode == 7) {
                        this.passButton.SetActive(false);
                    }
            }
            isR = false;
        }

        try { 
            if (number[CanvasController.qNum - 1] == 1)
            {

                category = "情報社会";

                questionText.text = "　物事の事実を人に伝わるように文字や記号に変換した表現を" + answer1 + "といい，これを目的に応じて整理したものを" + answer2 + "という．また，新しい" + answer1 + "を得るためには，" + answer2 + "を多く集めて" + answer3 + "として身に着ける必要がある．";

                abt1_1 = "データ";
                abt1_2 = "情報";
                abt1_3 = "知識";
                abt1_4 = "常識";

                abt2_1 = "情報";
                abt2_2 = "データ";
                abt2_3 = "知識";
                abt2_4 = "常識";

                abt3_1 = "知識";
                abt3_2 = "情報";
                abt3_3 = "データ";
                abt3_4 = "常識";

                //answerText.text = "コンピュータやインターネットの利用について，個人の技術や" +"<color=red>" + qd.abt1_1 + "</color>"+"などの要因で差が生じ，情報を入手する機会や" + "<color=red>" + qd.abt2_1 + "</color>" + "が異なる現象を" +"<color=red>" + qd.abt3_1 + "</color>"+ "という．";


            }
            //else if (CanvasController.qNum == 2)
            else if (number[CanvasController.qNum -1] == 2)
            {
                category = "情報の特徴";

                questionText.text = "　情報には以下の3つの特徴がある\n他者に渡っても自分の手元に残る" + answer1 + "\n短時間で多くの複製が可能である" + answer2 + "\n短時間で伝えつ，また広めることができる" + answer3;

                abt1_1 = "残存性";
                abt1_2 = "複製性";
                abt1_3 = "伝播性";
                abt1_4 = "循環性";

                abt2_1 = "複製性";
                abt2_2 = "伝播性";
                abt2_3 = "循環性";
                abt2_4 = "残存性";

                abt3_1 = "伝播性";
                abt3_2 = "複製性";
                abt3_3 = "残存性";
                abt3_4 = "循環性";

            }
            // else if (CanvasController.qNum == 3)
            else if (number[CanvasController.qNum-1] == 3)
            {
                category = "電子商取引";

                questionText.text = "　ネットワークを介して商取引を行う電子商取引には，様々な取引形態がある．電子市場や電子調達のような企業間の商取引" + answer1 + "と，Amazonや楽天市場のような企業と消費者の商取引" + answer2 + "と，メルカリやオンラインオークションのような消費者間の商取引" + answer3 + "がある．";

                abt1_1 = "BtoB";
                abt1_2 = "BtoC";
                abt1_3 = "CtoC";
                abt1_4 = "CtoB";

                abt2_1 = "BtoC";
                abt2_2 = "BtoB";
                abt2_3 = "CtoB";
                abt2_4 = "CtoC";

                abt3_1 = "CtoC";
                abt3_2 = "BtoC";
                abt3_3 = "BtoB";
                abt3_4 = "CtoB";

            }
            //else if (CanvasController.qNum == 4)
            else if (number[CanvasController.qNum-1] == 4)
            {
                category = "ネチケット(環境)";

                questionText.text = "　全ての環境で同じように表示させるために，" + answer1 + "文字，つまり特殊な文字・フォントを使用した" + answer2 + "文字などの使用を控えることで" + answer3 + "といった受信者側に正しく伝わらな現象を極力なくす事を心がける．";

                abt1_1 = "機種依存";
                abt1_2 = "機種独自";
                abt1_3 = "機種専用";
                abt1_4 = "機種独特";

                abt2_1 = "顔";
                abt2_2 = "人";
                abt2_3 = "横";
                abt2_4 = "カナ";

                abt3_1 = "文字化け";
                abt3_2 = "文字割れ";
                abt3_3 = "文字壊れ";
                abt3_4 = "文字ぼけ";

            }
            //else if (CanvasController.qNum == 5)
            else if (number[CanvasController.qNum-1] == 5)
            {
                category = "身体への影響";

                questionText.text = "　コンピュータ環境に適応できないことで不安に陥るテクノ" + answer1 + "，インターネットやメールの送受信，ゲームアプリなどに過度に依存するテクノ" + answer2 + "などの，コンピュータを扱うことで原因が生じる病気を総称してテクノ" + answer3 + "という．この発症を防ぐには，自分に適したコンピュータとの付き合い方をすることが大事である．";

                abt1_1 = "不安症";
                abt1_2 = "不眠症";
                abt1_3 = "不信症";
                abt1_4 = "不穏症";

                abt2_1 = "依存症";
                abt2_2 = "習慣症";
                abt2_3 = "中毒症";
                abt2_4 = "耽溺症";

                abt3_1 = "ストレス";
                abt3_2 = "シック";
                abt3_3 = "トラブル";
                abt3_4 = "プレッシャー";

            }
            else if (number[CanvasController.qNum - 1] == 6)
            {
                category = "ネットワーク";

                questionText.text = "　全世界の膨大な数のコンピュータ，通信機器を相互のネットワーク繋ぐことで情報のやり取りを可能としている" + answer1 + "は，限られた範囲内でのコンピュータや通信機器，相互のデータ通信ができる" + answer2 + "どうしを結合し，より規模が大きいネットワークの" + answer3 + "を世界規模で実現した" + answer3 + "の事を指す．";

                abt1_1 = "インターネット";//正解
                abt1_2 = "URL";
                abt1_3 = "Web";
                abt1_4 = "ユビキタス";

                abt2_1 = "LAN";//正解
                abt2_2 = "MAN";
                abt2_3 = "WAN";
                abt2_4 = "IAN";

                abt3_1 = "WAN";//正解
                abt3_2 = "MAN";
                abt3_3 = "LAN";
                abt3_4 = "IAN";

            }
            else if (number[CanvasController.qNum - 1] == 7)
            {
                category = "通信の仕組み(通信構成)";

                questionText.text = "　コンピュータ同士の通信に関する取り決めを通信" + answer1 + "といい，これは複数のネットワークを繋ぎ合わせ相互を通信可能とする" + answer2 + "と，"+ answer2 + "を基盤に利用される" + answer3 + "を組み合わせたものをいう．";

                abt1_1 = "プロトコル";//正解
                abt1_2 = "プロバイダ";
                abt1_3 = "プロダクト";
                abt1_4 = "プロテクト";

                abt2_1 = "IP";//正解
                abt2_2 = "IC";
                abt2_3 = "ID";
                abt2_4 = "IT";

                abt3_1 = "TCP";//正解
                abt3_2 = "ICP";
                abt3_3 = "TPP";
                abt3_4 = "IPP";

            }
            else if (number[CanvasController.qNum - 1] == 8)
            {
                category = "通信の仕組み(識別番号)";

                questionText.text = "　パソコンやネット機器には，それぞれ識別するための番号" + answer1 + "アドレスは2種類あり，1つは，ネット接続をしているコンピュータが持つ他のものと重複しない世界で1つだけの番号" + answer2 + answer1 + "アドレス，もう1つはルータとパソコン間，またパソコンとパソコンの間のような限定された範囲のみ使用できる番号" + answer3 + answer1 + "アドレスである．";

                abt1_1 = "IP";//正解
                abt1_2 = "IC";
                abt1_3 = "ID";
                abt1_4 = "IT";

                abt2_1 = "グローバル";//正解
                abt2_2 = "プライベート";
                abt2_3 = "ナショナル";
                abt2_4 = "プライバシー";

                abt3_1 = "プライベート";//正解
                abt3_2 = "グローバル";
                abt3_3 = "ナショナル";
                abt3_4 = "プライバシー";

            }
            else if (number[CanvasController.qNum - 1] == 9)
            {
                category = "通信の仕組み(識別技術)";

                questionText.text = "　パソコンやネット機器には，それぞれ識別するための名前" + answer1 + "が付いている．通信を行う際に，IPアドレスで識別すると数字の羅列であるため人には扱いにくい問題があった．これを解消するためIPアドレスを" + answer1 + "に変換して扱われている．この変換を" + answer2 + "といい，また変換できるように" + answer1 + "とIPアドレスを対応させるシステムを" + answer3 + "という．";

                abt1_1 = "ドメイン名";//正解
                abt1_2 = "アドレス名";
                abt1_3 = "ファイル名";
                abt1_4 = "フォルダ名";

                abt2_1 = "名前解決";//正解
                abt2_2 = "名前変換";
                abt2_3 = "番号解決";
                abt2_4 = "番号変換";

                abt3_1 = "DNS";//正解
                abt3_2 = "BNS";
                abt3_3 = "SNS";
                abt3_4 = "FNS";

            }
            else if (number[CanvasController.qNum - 1] == 10)
            {
                category = "クライアントサーバシステム";

                questionText.text = "　クライアントサーバーシステムとは，データの提供をする" + answer1 + "と，データを要求する" + answer2 + "の2つに役割を分担してコンピュータで処理する" + answer3 + "を行う仕組みを指す．";

                abt1_1 = "サーバ";//正解
                abt1_2 = "クライアント";
                abt1_3 = "データベース";
                abt1_4 = "インターネット";

                abt2_1 = "クライアント";//正解
                abt2_2 = "データベース";
                abt2_3 = "サーバ";
                abt2_4 = "インターネット";

                abt3_1 = "分散処理";//正解
                abt3_2 = "分担処理";
                abt3_3 = "分割処理";
                abt3_4 = "分段処理";

            }
            else if (number[CanvasController.qNum - 1] == 11)
            {
                category = "通信プロトコル";

                questionText.text = "　サーバーとクライアント間でのデータの送受信の際に情報の位置を示す" + answer1 + "の文字列の先頭は，通信プロトコルの" + answer2 + "から始まり，インターネット接続している組織や国を表す" + answer3 + "に続く．";

                abt1_1 = "URL";//正解
                abt1_2 = "URR";
                abt1_3 = "URM";
                abt1_4 = "URN";

                abt2_1 = "HTTP";//正解
                abt2_2 = "HTTQ";
                abt2_3 = "HTTT";
                abt2_4 = "HTTC";

                abt3_1 = "ドメイン名";//正解
                abt3_2 = "IPアドレス";
                abt3_3 = "DNS";
                abt3_4 = "BBS";

            }
            else if (number[CanvasController.qNum - 1] == 12)
            {
                category = "通信の発展";

                questionText.text = "　｢いつでも，どこでも，何でも，誰でも｣がネットワークに繋がることで，生活が豊かにする社会を" + answer1 + "社会といい，これの実現に向けて，微量の電波によって情報の読み取りを可能とする" + answer2 + "，通信機能を持った家電製品である" + answer3 + "など，すでに実用化されたものがある．";

                abt1_1 = "ユビキタス";//正解
                abt1_2 = "グローバル";
                abt1_3 = "ユニバーサル";
                abt1_4 = "ネット";

                abt2_1 = "ICタグ";//正解
                abt2_2 = "IDタグ";
                abt2_3 = "ITタグ";
                abt2_4 = "IPタグ";

                abt3_1 = "情報家電";//正解
                abt3_2 = "通信家電";
                abt3_3 = "ネット家電";
                abt3_4 = "電子家電";

            }
            else if (number[CanvasController.qNum - 1] == 13)
            {
                category = "サーバの種類";

                questionText.text = "　サーバには，ネットワーク上でファイルを他のコンピュータと共有する" + answer1 + "サーバ，電子メールを送受信するための" + answer2 + "サーバ，Webページの表示を提供する" + answer3 + "サーバなどいくつか種類が存在する．";

                abt1_1 = "ファイル";//正解
                abt1_2 = "共有";
                abt1_3 = "シェア";
                abt1_4 = "フォルダ";

                abt2_1 = "メール";//正解
                abt2_2 = "メーリング";
                abt2_3 = "電子";
                abt2_4 = "アドレス";

                abt3_1 = "Web";//正解
                abt3_2 = "Wave";
                abt3_3 = "Wed";
                abt3_4 = "Wav";

            }
            else if (number[CanvasController.qNum - 1] == 14)
            {
                category = "コンピュータの歴史";

                questionText.text = "　コンピュータは初め" + answer1 + "を目的として作られ，電気回路を組み合わせることで演算を可能とした計算機の" + answer2 + "式計算機MARKⅠや，大量の真空管を用いたENIAC，現在でもほとんどのコンピュータが採用している" + answer3 + "型コンピュータEDSACが1949年にイギリスで開発された．";

                abt1_1 = "計算";//正解
                abt1_2 = "通信";
                abt1_3 = "記録";
                abt1_4 = "教育";

                abt2_1 = "リレー";//正解
                abt2_2 = "ノイマン";
                abt2_3 = "デジタル";
                abt2_4 = "アナログ";

                abt3_1 = "ノイマン";//正解
                abt3_2 = "リレー";
                abt3_3 = "デジタル";
                abt3_4 = "アナログ";

            }
            else if (number[CanvasController.qNum - 1] == 15)
            {
                category = "パソコンのOS";

                questionText.text = "　システム全体を管理するソフトウェアであるOSは，パソコンの環境によって使用されているものが異なる．代表的なものは，Microsoft社が開発した" + answer1 + "シリーズや，Apple社が開発した" + answer2 + "，サーバを中心とした，その他テレビやスマートフォンなど幅広いハードウェアに採用されている" + answer3 + "などがある．";

                abt1_1 = "Windows";//正解
                abt1_2 = "Android";
                abt1_3 = "iOS";
                abt1_4 = "MacOSX";

                abt2_1 = "MacOSX";//正解
                abt2_2 = "Windows";
                abt2_3 = "Android";
                abt2_4 = "iOS";

                abt3_1 = "Linux";//正解
                abt3_2 = "Emacs";
                abt3_3 = "Multics";
                abt3_4 = "Minix";

            }
            else if (number[CanvasController.qNum - 1] == 16)
            {
                category = "スマートフォンのOS";

                questionText.text = "　近年，莫大に普及率を上げたスマートフォンには様々なOSが採用されている．Apple社が開発した" + answer1 + "，Google社が開発した" + answer2 + "がほとんどである．他にもMicrosoft社が開発したWindows" + answer3 + "などがあるが，ほとんどが前者の2つが独占している．";

                abt1_1 = "iOS";//正解
                abt1_2 = "MacOSX";
                abt1_3 = "Windows";
                abt1_4 = "Android";

                abt2_1 = "Android";//正解
                abt2_2 = "iOS";
                abt2_3 = "MacOSX";
                abt2_4 = "Windows";

                abt3_1 = "Phone";//正解
                abt3_2 = "Vista";
                abt3_3 = "10";
                abt3_4 = "OS";

            }
            else if (number[CanvasController.qNum - 1] == 17)
            {
                category = "コミュニケーション(サービス)";

                questionText.text = "　インターネットが発達したことにより，遠くの人また見知らぬ人と交流をとることが容易となった．その手段として，ネットワーク上の掲示板" + answer1 + "，FaceBookやmixiなどの趣味や嗜好を通じて交流することのできるWebサイトの" + answer2 + "，投稿した記事を時系列に沿って表示するWeb上の日記のような" + answer3 + "がある．";

                abt1_1 = "BBS";//正解
                abt1_2 = "BSS";
                abt1_3 = "BBC";
                abt1_4 = "BCC";

                abt2_1 = "SNS";//正解
                abt2_2 = "SNL";
                abt2_3 = "SNM";
                abt2_4 = "SNN";

                abt3_1 = "ブログ";//正解
                abt3_2 = "ログ";
                abt3_3 = "チャット";
                abt3_4 = "レス";

            }
            else if (number[CanvasController.qNum - 1] == 18)
            {
                category = "コミュニケーション(機能)";

                questionText.text = "　twitter・LINE・FaceBookなどで，投稿に対して閲覧者が" + answer1 + "機能によって発言・意見の交換などが可能となった．しかし，個人を特定することのできない" + answer2 + "を利用して" + answer3 + "を目的とした行為が，近年多発しており社会問題として大きく取り上げられている．";

                abt1_1 = "コメント";//正解
                abt1_2 = "レビュー";
                abt1_3 = "コマンド";
                abt1_4 = "ポスト";

                abt2_1 = "匿名性";//正解
                abt2_2 = "特命性";
                abt2_3 = "特名性";
                abt2_4 = "匿命性";

                abt3_1 = "誹謗・中傷";//正解
                abt3_2 = "なりすまし";
                abt3_3 = "自己宣伝";
                abt3_4 = "不正アクセス";

            }
            else if (number[CanvasController.qNum - 1] == 19)
            {
                category = "画像のファイル形式";

                questionText.text = "　ソフトウェア毎に正しく処理・表示をするためには，それぞれ対応したファイル形式である必要がある．画像のファイル形式には，人の目で違いが認識できない色，また透明色を使わないことで容量が小さくしている" + answer1 + "，" + answer1 + "より少ない色の数256色での表示，また透明の実現，アニメーションが可能な" + answer2 + "，透明を表示するのに最も適している" + answer3 + "，など他にも多く種類がある．";

                abt1_1 = "jpg";//正解
                abt1_2 = "gqd";
                abt1_3 = "jqd";
                abt1_4 = "gpg";

                abt2_1 = "gif";//正解
                abt2_2 = "zif";
                abt2_3 = "jif";
                abt2_4 = "dif";

                abt3_1 = "png";//正解
                abt3_2 = "qng";
                abt3_3 = "pmg";
                abt3_4 = "qmg";

            }
            else if (number[CanvasController.qNum - 1] == 20)
            {
                category = "音声のファイル形式";

                questionText.text = "　ソフトウェア毎に正しく処理・表示をするためには，それぞれ対応したファイル形式である必要がある．音楽のファイル形式には，Windowsが標準で対応をしている" + answer1 + "，Apple社が開発した" + answer2 + "，人の聞き取りづらい音を省きファイルサイズが小さく，また著作権保護機能がないためCDのデータをコピーして配布・交換する行為が問題となっている" + answer3 + "，など他にも多く種類がある．";

                abt1_1 = "wav";//正解
                abt1_2 = "wad";
                abt1_3 = "wab";
                abt1_4 = "web";

                abt2_1 = "aiff";//正解
                abt2_2 = "alff";
                abt2_3 = "atff";
                abt2_4 = "aeff";

                abt3_1 = "mpg";//正解
                abt3_2 = "mq3";
                abt3_3 = "np3";
                abt3_4 = "nq3";

            }
            else if (number[CanvasController.qNum - 1] == 21)
            {
                category = "動画のファイル形式";

                questionText.text = "　毎に正しく処理・表示をするためには，それぞれ対応したファイル形式である必要がある．動画のファイル形式には，テレビ・DVDで採用されている" + answer1 + "，Apple社の開発した動画編集ソフトQuickTimePlayerで扱われる" + answer2 + "，これに対抗してMicrosoft社が開発した" + answer3 + "，など他にも多く種類がある．";

                abt1_1 = "mpg";//正解
                abt1_2 = "mqg";
                abt1_3 = "npg";
                abt1_4 = "nqg";

                abt2_1 = "mov";//正解
                abt2_2 = "nov";
                abt2_3 = "lov";
                abt2_4 = "uov";

                abt3_1 = "avi";//正解
                abt3_2 = "abi";
                abt3_3 = "adi";
                abt3_4 = "aui";

            }
            else if (number[CanvasController.qNum - 1] == 22)
            {
                category = "アカウント";

                questionText.text = "　アカウントとは，個人を識別するための" + answer1 + "と" + answer2 + "の2つで構成されている，インターネット上のサービスやコンピュータを利用する権利のことを言う．これを利用することで対象のサービス，またコンピュータに" + answer3 + "することが可能となる．";

                abt1_1 = "ユーザID";//正解
                abt1_2 = "ユーザIT";
                abt1_3 = "ユーザIP";
                abt1_4 = "ユーザIC";

                abt2_1 = "パスワード";//正解
                abt2_2 = "QRコード";
                abt2_3 = "バーコード";
                abt2_4 = "キーワード";

                abt3_1 = "ログイン";//正解
                abt3_2 = "アドイン";
                abt3_3 = "パスイン";
                abt3_4 = "プラグイン";

            }
            else if (number[CanvasController.qNum - 1] == 23)
            {
                category = "サイバー犯罪(侵入)";

                questionText.text = "　本来利用する権限のないコンピュータネットワークを操作する，また扱う権限のない情報の改ざんや削除をすることを" + answer1 + "といい，原因としてはセキュリティ" + answer2 + "からの侵入や，第三者がユーザID・" + answer3 + "を不正に使用するなりすまし行為によるものが挙げられる．";

                abt1_1 = "不正アクセス";//正解
                abt1_2 = "不正アドイン";
                abt1_3 = "不正アドレス";
                abt1_4 = "不正アクセル";

                abt2_1 = "ホール";//正解
                abt2_2 = "ソフト";
                abt2_3 = "アプリ";
                abt2_4 = "ウォール";

                abt3_1 = "パスワード";//正解
                abt3_2 = "QRコード";
                abt3_3 = "バーコード";
                abt3_4 = "キーワード";

            }
            else if (number[CanvasController.qNum - 1] == 24)
            {
                category = "パスワードの強度";

                questionText.text = "　パスワードを設定する際に12345や，" + answer1 + "などの規則性のある連続したワードや，名前と生年月日などの" + answer2 + "を単純に使用したパスワードは，簡単に解かれてしまう．また設定後は，パスワードをメモした紙・データを探し出したり，ネットの管理者になりすましパスワードを聞き出したりなどの行為にあたるソーシャル・" + answer3 + "に注意しなければならない．";

                abt1_1 = "abcde";//正解
                abt1_2 = "acedb";
                abt1_3 = "adcbe";
                abt1_4 = "aedbc";

                abt2_1 = "個人情報";//正解
                abt2_2 = "個人属性";
                abt2_3 = "個人番号";
                abt2_4 = "個人因子";

                abt3_1 = "エンジニアリング";//正解
                abt3_2 = "エンジニア";
                abt3_3 = "クラッキング";
                abt3_4 = "ハッキング";

            }
            else if (number[CanvasController.qNum - 1] == 25)
            {
                category = "サイバー犯罪(不正操作)";

                questionText.text = "　第三者による操作，データの改ざんなどの不正利用行為，つまり" + answer1 + "から守るために" + answer2 + "を十分に確保する必要がある．また，" + answer1 + "する人を"+ answer3 + "と呼ぶ．";

                abt1_1 = "クラッキング";//正解
                abt1_2 = "ハッキング";
                abt1_3 = "クロッキング";
                abt1_4 = "クリッキング";

                abt2_1 = "セキュリティ";//正解
                abt2_2 = "セーフティ";
                abt2_3 = "プライバシー";
                abt2_4 = "プロテクト";

                abt3_1 = "クラッカー";//正解
                abt3_2 = "ハッカー";
                abt3_3 = "クロッカー";
                abt3_4 = "クリッカー";

            }
            else if (number[CanvasController.qNum - 1] == 26)
            {
                category = "サイバー犯罪(ソフトウェア)";

                questionText.text = "　コンピュータに勝手に入り込み，悪さをするソフトウェアを総称して" + answer1 + "といい，その中で，他のファイルに寄生・感染をするソフトウェアをコンピュータ" + answer2 + "と呼ぶ．これらが原因で個人情報が流出して，身に覚えのないメールやハガキなどで架空請求が来る場合がある．いずれにしろ請求に答える必要がないが，発送元が" + answer3 + "である時は，放置をせずに必ず確認するべきである．";

                abt1_1 = "マルウェア";//正解
                abt1_2 = "ハードウェア";
                abt1_3 = "スパイウェア";
                abt1_4 = "ランサムウェア";

                abt2_1 = "ウイルス";//正解
                abt2_2 = "バイオス";
                abt2_3 = "オーエス";
                abt2_4 = "ウェア";

                abt3_1 = "裁判所";//正解
                abt3_2 = "警察署";
                abt3_3 = "区役所";
                abt3_4 = "市役所";

            }
            else if (number[CanvasController.qNum - 1] == 27)
            {
                category = "マルウェアの種類";

                questionText.text = "　マルウェアには多くの種類があり，中でも悪質なものは，ユーザのキーボード・マウス操作またWebの閲覧履歴などを外部に送信する" + answer1 + "や，単独で存在し，また自己増殖を行うことで他のデバイスに感染する" + answer2 + "，正当なセキュリティソフトを装いコンピュータにウイルスが感染していると嘘のメッセージを画面上に表示し，そこから個人情報を奪う" + answer3 + "などがある．";

                abt1_1 = "スパイウェア";//正解
                abt1_2 = "ワーム";
                abt1_3 = "ランサムウェア";
                abt1_4 = "スケアウェア";

                abt2_1 = "ワーム";//正解
                abt2_2 = "スパイウェア";
                abt2_3 = "ランサムウェア";
                abt2_4 = "スケアウェア";

                abt3_1 = "スケアウェア";//正解
                abt3_2 = "ワーム";
                abt3_3 = "ランサムウェア";
                abt3_4 = "スパイウェア";

            }
            else if (number[CanvasController.qNum - 1] == 28)
            {
                category = "マルウェア対策";

                questionText.text = "　マルウェアの侵入を防ぐには，危険性のあるサイトの閲覧を控えることや，OSやソフトウェアの修正・改良するための" + answer1 + "，メールの" + answer2 + "ファイルを開く前に確認，McAfeeやウイルスバスターといった" + answer3 + "をインストールするなどの手段がある．";

                abt1_1 = "アップデート";//正解
                abt1_2 = "アップグレード";
                abt1_3 = "アップロード";
                abt1_4 = "ダウングレード";

                abt2_1 = "添付";//正解
                abt2_2 = "付属";
                abt2_3 = "貼付";
                abt2_4 = "転付";

                abt3_1 = "セキュリティソフト";//正解
                abt3_2 = "セキュリティホール";
                abt3_3 = "セキュリティポリシー";
                abt3_4 = "セキュリティウェア";

            }
            else if (number[CanvasController.qNum - 1] == 29)
            {
                category = "情報の選別";

                questionText.text = "　インターンネット上の情報を受信する際に問題があった場合，その問題の部分を拒否・遮断する技術をコンテンツ" + answer1 + "という．問題のあるサイトを登録し，それの閲覧を不可能にする" + answer2 + "方式，問題のないサイトのみを登録して，それのみを閲覧可能とする" + answer3 + "方式などがある．";

                abt1_1 = "フィルタリング";//正解
                abt1_2 = "ファイリング";
                abt1_3 = "フィルム";
                abt1_4 = "フィルター";

                abt2_1 = "ブラックリスト";//正解
                abt2_2 = "ホワイトリスト";
                abt2_3 = "レッドリスト";
                abt2_4 = "イエローリスト";

                abt3_1 = "ホワイトリスト";//正解
                abt3_2 = "ブラックリスト";
                abt3_3 = "レッドリスト";
                abt3_4 = "イエローリスト";

            }
            else if (number[CanvasController.qNum - 1] == 30)
            {
                category = "暗号化";

                questionText.text = "　データのやり取りをする際に，第三者からの盗み見やデータの改ざんを防ぐためにデータ変換を暗号化という．暗号化前のデータは" + answer1 + "，「なんらかの手段」により暗号化したデータを暗号文と呼び，また暗号文を" + answer1 + "に戻すことを" + answer2 + "といい，この時の「何らかの手段」に必要な手順を" + answer3 + "という．";

                abt1_1 = "平文";//正解
                abt1_2 = "白文";
                abt1_3 = "序文";
                abt1_4 = "前文";

                abt2_1 = "復号";//正解
                abt2_2 = "復原";
                abt2_3 = "復元";
                abt2_4 = "復帰";

                abt3_1 = "鍵";//正解
                abt3_2 = "鈎";
                abt3_3 = "鉤";
                abt3_4 = "錠";

            }
            else if (number[CanvasController.qNum - 1] == 31)
            {
                category = "セキュリティの技術(管理仕様)";

                questionText.text = "　コンピュータ内のファイルやフォルダを利用するための権限を" + answer1 + "といい，複数人がコンピュータを共有して利用しているとき，特定の利用者だけが扱えるようにすることを" + answer2 + "という．また，この権限の設定は，管理者である" + answer3 + "が行う．";

                abt1_1 = "アクセス権";//正解
                abt1_2 = "ログイン権";
                abt1_3 = "アドイン権";
                abt1_4 = "アクセル権";

                abt2_1 = "アクセス制御";//正解
                abt2_2 = "ログイン制御";
                abt2_3 = "アドイン制御";
                abt2_4 = "アクセル制御";


                abt3_1 = "アドミニストレータ";//正解
                abt3_2 = "アクセラレータ";
                abt3_3 = "マネージャー";
                abt3_4 = "オペレータ";

            }
            else if (number[CanvasController.qNum - 1] == 32)
            {
                category = "セキュリティの技術(不正対策)";

                questionText.text = "　ネットワーク上の画像や音楽などのデジタルコンテンツの不正コピーによる" + answer1 + "などの侵害を防ぐために，不正コピーがされたことがわかるようにデジタルコンテンツに" + answer2 + "を埋め込む" + answer3 + "という技術がある．";

                abt1_1 = "著作権";//正解
                abt1_2 = "特許権";
                abt1_3 = "意匠権";
                abt1_4 = "商標権";

                abt2_1 = "情報";//正解
                abt2_2 = "ウイルス";
                abt2_3 = "権限";
                abt2_4 = "鍵";

                abt3_1 = "電子透かし";//正解
                abt3_2 = "電気透かし";
                abt3_3 = "電子印かん";
                abt3_4 = "電気印かん";

            }
            else if (number[CanvasController.qNum - 1] == 33)
            {
                category = "ネチケット(一括送信)";

                questionText.text = "　一度に複数の相手にメールを送信する同報は，" + answer1 + "欄に受信者のメールアドレスを表示するため，受信者同士お互いのメールアドレスが表示され，" + answer2 + "の漏洩となる．これを防ぐためには，" + answer3 + "機能を利用することで受信者のメールアドレスを非表示にする．";

                abt1_1 = "CC";//正解
                abt1_2 = "BBS";
                abt1_3 = "BC";
                abt1_4 = "BCC";

                abt2_1 = "個人情報";//正解
                abt2_2 = "個人属性";
                abt2_3 = "個人番号";
                abt2_4 = "個人因子";

                abt3_1 = "BCC";//正解
                abt3_2 = "BBS";
                abt3_3 = "BC";
                abt3_4 = "CC";

            }
            else if (number[CanvasController.qNum - 1] == 34)
            {
                category = "知的創作活動の保護";

                questionText.text = "　ネット上の画像や情報，音楽などの無形のものを無断に利用されないために一定期間だけ創作者に与えられる権利である" + answer1 + "は，大きく分けると知的活動による成果物を対象とした" + answer2 + "とロゴマークやデザイン，ネーミングといった商業上利益に繋がるものを独占する" + answer3 + "，この2つに属さない権利に分かれている．";

                abt1_1 = "知的財産権";//正解
                abt1_2 = "創造財産権";
                abt1_3 = "無形財産権";
                abt1_4 = "社会財産権";

                abt2_1 = "著作権";//正解
                abt2_2 = "特許権";
                abt2_3 = "商標権";
                abt2_4 = "意匠権";

                abt3_1 = "産業財産権";//正解
                abt3_2 = "著作財産権";
                abt3_3 = "社会財産権";
                abt3_4 = "知的財産権";

            }
            else if (number[CanvasController.qNum - 1] == 35)
            {
                category = "著作権法";

                questionText.text = "　著作権法とは，著作物の創造者である著作者の経済的利益を守る" + answer1 + "，精神的保護することを目的とする" + answer2 + "を付与することを目的としており，これと同時に実演家や，レコード製作者，放送事業など著作物の伝達する人を保護する" + answer3 + "も付与される．";

                abt1_1 = "著作財産権";//正解
                abt1_2 = "著作資産権";
                abt1_3 = "著作資材権";
                abt1_4 = "著作所有権";

                abt2_1 = "著作人格権";//正解
                abt2_2 = "著作者保護権";
                abt2_3 = "著作人品兼";
                abt2_4 = "著作人物権";

                abt3_1 = "著作隣接権";//正解
                abt3_2 = "著作臨接権";
                abt3_3 = "著作周辺権";
                abt3_4 = "著作隣傍権";

            }
            else if (number[CanvasController.qNum - 1] == 36)
            {
                category = "著作権の効果";

                questionText.text = "　著作権は，著作物の無断利用，また著作者を保護することで，" + answer1 + "の発展に寄与することを目的としており，著作物が" + answer2 + "された時点で発生する．保護期間は，著作者の死後" + answer3 + "年とされている．";

                abt1_1 = "文化";//正解
                abt1_2 = "技術";
                abt1_3 = "文明";
                abt1_4 = "産業";

                abt2_1 = "創作";//正解
                abt2_2 = "登録";
                abt2_3 = "公開";
                abt2_4 = "発表";

                abt3_1 = "50";//正解
                abt3_2 = "20";
                abt3_3 = "10";
                abt3_4 = "30";

            }
            else if (number[CanvasController.qNum - 1] == 37)
            {
                category = "産業財産権(発明の保護)";

                questionText.text = "　商業上利益に繋がるものを独占する産業財産権は，4つの権利の総称である．その内の1つは，新しい発明をした者に決められた期間だけその発明を独占できる" + answer1 + "である．対象となるものは，スマートフォンで例えると，機能の" + answer2 + "である．保護期間は，出願から最長" + answer3 + "年とされている．";

                abt1_1 = "特許権";//正解
                abt1_2 = "実用新案権";
                abt1_3 = "意匠権";
                abt1_4 = "商標権";

                abt2_1 = "発明";//正解
                abt2_2 = "ボタンの配置";
                abt2_3 = "デザイン";
                abt2_4 = "ブランド";

                abt3_1 = "20";//正解
                abt3_2 = "10";
                abt3_3 = "30";
                abt3_4 = "50";

            }
            else if (number[CanvasController.qNum - 1] == 38)
            {
                category = "産業財産権(形状の保護)";

                questionText.text = "　商業上利益に繋がるものを独占する産業財産権は，4つの権利の総称である．その内の1つは，物の形，構造に関係する考案を独占できる" + answer1 + "である．対象となるものは，スマートフォンで例えると，" + answer2 + "である．保護期間は，出願から最長" + answer3 + "年とされている．";

                abt1_1 = "実用新案権";//正解
                abt1_2 = "特許権";
                abt1_3 = "商標権";
                abt1_4 = "意匠権";

                abt2_1 = "ボタンの配置";//正解
                abt2_2 = "発明";
                abt2_3 = "デザイン";
                abt2_4 = "ブランド";

                abt3_1 = "10";//正解
                abt3_2 = "20";
                abt3_3 = "30";
                abt3_4 = "50";

            }
            else if (number[CanvasController.qNum - 1] == 39)
            {
                category = "産業財産権(デザインの保護)";

                questionText.text = "　商業上利益に繋がるものを独占する産業財産権は，4つの権利の総称である．その内の1つは，新規性・創作性のある物の形・模様・色彩などのデザインを独占できる" + answer1 + "ある．対象となるものは，スマートフォンで例えると，機種の" + answer2 + "である．保護期間は，登録から最長" + answer3 + "年とされている．";

                abt1_1 = "意匠権";//正解
                abt1_2 = "特許権";
                abt1_3 = "実用新案権";
                abt1_4 = "商標権";

                abt2_1 = "デザイン";//正解
                abt2_2 = "ボタンの配置";
                abt2_3 = "発明";
                abt2_4 = "ブランド";

                abt3_1 = "20";//正解
                abt3_2 = "10";
                abt3_3 = "30";
                abt3_4 = "50";

            }
            else if (number[CanvasController.qNum - 1] == 40)
            {
                category = "産業財産権(ロゴマークの保護)";

                questionText.text = "　商業上利益に繋がるものを独占する産業財産権は，4つの権利の総称である．その内の1つは，他のものと区別するための文字・図形，いわゆるロゴマークのような目印として作用するものを独占できる" + answer1 + "がある．対象となるものは，スマートフォンで例えると，機種の" + answer2 + "である．保護期間は，登録から原則" + answer3 + "年とされている．";

                abt1_1 = "商標権";//正解
                abt1_2 = "意匠権";
                abt1_3 = "実用新案権";
                abt1_4 = "特許権";

                abt2_1 = "ブランド";//正解
                abt2_2 = "デザイン";
                abt2_3 = "ボタンの配置";
                abt2_4 = "発明";

                abt3_1 = "10";//正解
                abt3_2 = "20";
                abt3_3 = "30";
                abt3_4 = "50";

            }
            else if (number[CanvasController.qNum - 1] == 41)
            {
                category = "著作権の侵害";

                questionText.text = "　市販のCDやDVDを無断でコピーし，友人に配った場合は" + answer1 + "の侵害になる．しかし，自分や自分の家族といった狭い範囲のような" + answer2 + "の場合は，著作権の例外で認められている．ただし，公衆に設置されている複製機の使用や，コピーガードを回避しての複製，正規に認められていないダウンロードなどは" + answer3 + "行為にあたる．";

                abt1_1 = "複製権";//正解
                abt1_2 = "公衆送信権";
                abt1_3 = "展示権";
                abt1_4 = "商標権";

                abt2_1 = "私的複製";//正解
                abt2_2 = "個人的複製";
                abt2_3 = "狭隘複製";
                abt2_4 = "内輪複製";

                abt3_1 = "違法";//正解
                abt3_2 = "合法";
                abt3_3 = "脱法";
                abt3_4 = "不法";

            }
            else if (number[CanvasController.qNum - 1] == 42)
            {
                category = "著作権の利用";

                questionText.text = "　著作物を利用する場合，著作権法の保護の有無・保護期間内であるかの確認などの手続きを経て著作者の許諾を得なければならないが，著作者があらかじめ許諾する意思が明確の場合がある．そのために，コピー・無料配布，障碍者のための非営利目的利用，学校教育のための非営利目的利用の3種類ある" + answer1 + "マーク，ネットワーク上では永続的に無償で使用できる" + answer2 + "と呼ばれるものがあるが，これらにも" + answer3 + "が存在し，配布やデータの書き換えなどを行う場合は，提示されている使用条件に従う必要がある．";

                abt1_1 = "自由利用";//正解
                abt1_2 = "無料利用";
                abt1_3 = "フリー";
                abt1_4 = "ユーズ";

                abt2_1 = "フリーウェア";//正解
                abt2_2 = "シェアウェア";
                abt2_3 = "マルウェア";
                abt2_4 = "オープンウェア";

                abt3_1 = "著作権";//正解
                abt3_2 = "特許権";
                abt3_3 = "商標権";
                abt3_4 = "意匠権";

            }
        }
        catch (IndexOutOfRangeException) {
        }

        q_numText.text = CanvasController.qNum + "/" + (int)PlayerScoreDirector.numOfQuestion;
        //q_numText.text = CanvasController.qNum + "/"+EndNum;
        //progressBar.fillAmount += 0.1f;
        //handle.transform.localPosition += new Vector3(0.1f, 0, 0);
        answerB_Text1_1.text = abt1_1;
        answerB_Text1_2.text = abt1_2;
        answerB_Text1_3.text = abt1_3;
        answerB_Text1_4.text = abt1_4;

        answerB_Text2_1.text = abt2_1;
        answerB_Text2_2.text = abt2_2;
        answerB_Text2_3.text = abt2_3;
        answerB_Text2_4.text = abt2_4;

        answerB_Text3_1.text = abt3_1;
        answerB_Text3_2.text = abt3_2;
        answerB_Text3_3.text = abt3_3;
        answerB_Text3_4.text = abt3_4;
        questionNumText.text = CanvasController.qNum + "問目:" + category;

        qCount++;
    }

    public void q_textRenew()
    {
        questionText.text = questionText.text;

    }
    public void barRestart()
    {
        progresBar.value = 0.0f;
        barAdd();
    }
    public void barAdd()
    {
        progresBar.value += 1.0f / PlayerScoreDirector.numOfQuestion;
    }

    public void normalSelect(ref int[] namN)
    {
        int a = 0;
        if(PlayerScoreDirector.numOfs_Mode == 1)
        {
            a += 1;
        }else if (PlayerScoreDirector.numOfs_Mode == 2)
        {
            a += 22;
        }
        else if (PlayerScoreDirector.numOfs_Mode == 3)
        {
            a += 34;
        }
        for (int i = 0; i < namN.Length; i++)
        {
            namN[i] = i + a;//iに足す値は，問題のカテゴリーによって変わる
        }
    }
    /// <summary>
    /// 出題形式をランダムにする関数
    /// </summary>
    /// <param name="nam"></param>
    public void shuffleNum(ref int[]nam)
    {
        int a = 0;

        if (PlayerScoreDirector.numOfs_Mode == 4)
        {
            a += 1;
        }
        else if (PlayerScoreDirector.numOfs_Mode == 5)
        {
            a += 22;
        }
        else if (PlayerScoreDirector.numOfs_Mode == 6)
        {
            a += 34;
        }
        else
        {
            a += 1;
        }

        for (int i = 0; i < nam.Length; i++)
        {
            nam[i] = i + a;
        }
        int n = nam.Length;
        int temp;

        while ( n > 1 )
        {
            n--;
            int k = UnityEngine.Random.Range(1, n);
            temp = nam[k];
            nam[k] = nam[n];
            nam[n] = temp;
        }

        for (int i = 0; i < nam.Length; i++)
        {
            Debug.Log("nam[" + i + "] = " + nam[i]);
        }
    }
    /// <summary>
    /// 既定の問題数と現在の出題数の比較，それによるゲームエンド
    /// </summary>
    public void gameEnd()
    {
        studyA.gameEnd();
        endScreen.gameObject.SetActive(true);
        studyBgm.gameObject.SetActive(false);
    }

    public void fontCheck()
    {
        if(PlayerScoreDirector.q_fontNum == 1)
        {
            questionText.fontSize = 85;
        }
        else
        {
            questionText.fontSize = 105;
        }
    }
}