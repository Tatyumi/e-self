using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class DictionaryController : MonoBehaviour {

    public GameObject wordPanel;
    public GameObject wordImage;

    public Text wordButtonName1;
    public Text wordButtonName2;
    public Text wordButtonName3;
    public Text wordButtonName4;
    public Text wordButtonName5;
    public Text wordButtonName6;
    public Text wordButtonName7;
    public Text wordButtonName8;
    public Text wordButtonName9;
    public Text wordButtonName10;
    public Text wordButtonName11;
    public Text wordButtonName12;
    public Text wordButtonName13;
    public Text wordButtonName14;
    public Text wordButtonName15;
    public Text wordButtonName16;
    public Text wordButtonName17;
    public Text wordButtonName18;
    public Text wordButtonName19;
    public Text wordButtonName20;
    public Text wordButtonName21;
    public Text wordButtonName22;
    public Text wordButtonName23;
    public Text wordButtonName24;
    public Text wordButtonName25;
    public Text wordButtonName26;
    public Text wordButtonName27;
    public Text wordButtonName28;
    public Text wordButtonName29;
    public Text wordButtonName30;
    public Text wordButtonName31;
    public Text wordButtonName32;
    public Text wordButtonName33;
    public Text wordButtonName34;
    public Text wordButtonName35;
    public Text wordButtonName36;
    public Text wordButtonName37;
    public Text wordButtonName38;
    public Text wordButtonName39;
    public Text wordButtonName40;
    public Text wordButtonName41;
    public Text wordButtonName42;
    public Text wordButtonName43;
    public Text wordButtonName44;
    public Text wordButtonName45;
    public Text wordButtonName46;
    public Text wordButtonName47;
    public Text wordButtonName48;
    public Text wordButtonName49;
    public Text wordButtonName50;
    public Text wordButtonName51;
    public Text wordButtonName52;
    public Text wordButtonName53;
    public Text wordButtonName54;
    public Text wordButtonName55;
    public Text wordButtonName56;
    public Text wordButtonName57;
    public Text wordButtonName58;
    public Text wordButtonName59;
    public Text wordButtonName60;
    public Text wordButtonName61;
    public Text wordButtonName62;
    public Text wordButtonName63;
    public Text wordButtonName64;
    public Text wordButtonName65;
    public Text wordButtonName66;
    public Text wordButtonName67;
    public Text wordButtonName68;
    public Text wordButtonName69;
    public Text wordButtonName70;
    public Text wordButtonName71;
    public Text wordButtonName72;
    public Text wordButtonName73;
    public Text wordButtonName74;
    public Text wordButtonName75;
    public Text wordButtonName76;
    public Text wordButtonName77;
    public Text wordButtonName78;
    public Text wordButtonName79;
    public Text wordButtonName80;
    public Text wordButtonName81;
    public Text wordButtonName82;
    public Text wordButtonName83;
    public Text wordButtonName84;
    public Text wordButtonName85;
    public Text wordButtonName86;
    public Text wordButtonName87;
    public Text wordButtonName88;
    public Text wordButtonName89;
    public Text wordButtonName90;

    public Text wordButtonNamea1;
    public Text wordButtonNamea2;
    public Text wordButtonNamea3;
    public Text wordButtonNamea4;
    public Text wordButtonNamea5;
    public Text wordButtonNamea6;
    public Text wordButtonNamea7;
    public Text wordButtonNamea8;
    public Text wordButtonNamea9;
    public Text wordButtonNamea10;
    public Text wordButtonNamea11;
    public Text wordButtonNamea12;
    public Text wordButtonNamea13;
    public Text wordButtonNamea14;
    public Text wordButtonNamea15;
    public Text wordButtonNamea16;
    public Text wordButtonNamea17;
    public Text wordButtonNamea18;
    public Text wordButtonNamea19;
    public Text wordButtonNamea20;
    public Text wordButtonNamea21;
    public Text wordButtonNamea22;
    public Text wordButtonNamea23;
    public Text wordButtonNamea24;
    public Text wordButtonNamea25;
    public Text wordButtonNamea26;
    public Text wordButtonNamea27;
    public Text wordButtonNamea28;
    public Text wordButtonNamea29;
    public Text wordButtonNamea30;
    public Text wordButtonNamea31;
    public Text wordButtonNamea32;
    public Text wordButtonNamea33;
    public Text wordButtonNamea34;
    public Text wordButtonNamea35;

    public Text wordName;
    public Text wordNamehira;
    public Text wordMean;
    public AudioController selectA;

    private string space;

    float ly ;

    public Vector3 Image_ySize;
    
    // Use this for initialization
    void Start () {
        Image_ySize.y = this.wordImage.transform.localScale.y;
        this.space = "<color=white>" + "_" + "</color>";

        this.wordButtonName1.text = "アクセス権";
        this.wordButtonName2.text = "アクセス制御";
        this.wordButtonName3.text  = "アップデート";
        this.wordButtonName4.text  = "アップロード";
        this.wordButtonName5.text  = "アドイン";
        this.wordButtonName6.text = "アドミニスター";
        this.wordButtonName7.text = "暗号化";
        this.wordButtonName8.text  = "意匠権";
        this.wordButtonName9.text  = "インターネット";
        this.wordButtonName10.text = "顔文字";
        this.wordButtonName11.text = "鍵";
        this.wordButtonName12.text = "架空請求";
        this.wordButtonName13.text = "機種依存文字";
        this.wordButtonName14.text = "クライアント";
        this.wordButtonName15.text = "クライアントサーバシステム";
        this.wordButtonName16.text = "クラッカー";
        this.wordButtonName17.text = "クラッキング";
        this.wordButtonName18.text = "グローバルIPアドレス";
        this.wordButtonName19.text = "個人情報";
        this.wordButtonName20.text = "コメント機能";
        this.wordButtonName21.text = "コンテンツフィルタリング";
        this.wordButtonName22.text = "コンピュータウイルス";
        this.wordButtonName23.text = "サイバー犯罪";
        this.wordButtonName24.text = "サーバ";
        this.wordButtonName25.text = "残存性";
        this.wordButtonName26.text = "産業財産権";
        this.wordButtonName27.text = "実用新案権";
        this.wordButtonName28.text = "自由利用マーク";
        this.wordButtonName29.text = "商標権";
        this.wordButtonName30.text = "情報";
        this.wordButtonName31.text = "情報家電";
        this.wordButtonName32.text = "スケアウェア";
        this.wordButtonName33.text = "スパイウェア";
        this.wordButtonName34.text = "セキュリティ";
        this.wordButtonName35.text = "セキュリティソフト";
        this.wordButtonName36.text = "セキュリティホール";
        this.wordButtonName37.text = "セキュリティポリシー";
        this.wordButtonName38.text = "ソーシャル・エンジニアリング";
        this.wordButtonName39.text = "ソフトウェア";
        this.wordButtonName40.text = "ダウンロード";
        this.wordButtonName41.text = "知識";
        this.wordButtonName42.text = "知的財産権";
        this.wordButtonName43.text = "著作権";
        this.wordButtonName44.text = "著作財産権";
        this.wordButtonName45.text = "著作人格権";
        this.wordButtonName46.text = "著作隣接権";
        this.wordButtonName47.text = "通信プロトコル";
        this.wordButtonName48.text = "テクノ依存症";
        this.wordButtonName49.text = "テクノストレス";
        this.wordButtonName50.text = "テクノ不安症";
        this.wordButtonName51.text = "データ";
        this.wordButtonName52.text = "データベース";
        this.wordButtonName53.text = "電子商取引";
        this.wordButtonName54.text = "電子透かし";
        this.wordButtonName55.text = "伝播性";
        this.wordButtonName56.text = "添付ファイル";
        this.wordButtonName57.text = "匿名";
        this.wordButtonName58.text = "特許権";
        this.wordButtonName59.text = "ドメイン名";
        this.wordButtonName60.text = "名前変換";
        this.wordButtonName61.text = "ネチケット";
        this.wordButtonName62.text = "ノイマン型コンピュータ";
        this.wordButtonName63.text = "パスワード";
        this.wordButtonName64.text = "ハッカー";
        this.wordButtonName65.text = "ハッキング";
        this.wordButtonName66.text = "ハードウェア";
        this.wordButtonName67.text = "へいぶん";
        this.wordButtonName68.text = "復号";
        this.wordButtonName69.text = "複製権";
        this.wordButtonName70.text = "複製性";
        this.wordButtonName71.text = "不正アクセス";
        this.wordButtonName72.text = "分散処理";
        this.wordButtonName73.text = "ファイル";
        this.wordButtonName74.text = "ファイル形式";
        this.wordButtonName75.text = "ファイルサーバ";
        this.wordButtonName76.text = "プライベートIPアドレス";
        this.wordButtonName77.text = "プラグイン";
        this.wordButtonName78.text = "ブラックリスト方式";
        this.wordButtonName79.text = "フリーウェア";
        this.wordButtonName80.text = "ブログ";
        this.wordButtonName81.text = "ホワイトリスト方式";
        this.wordButtonName82.text = "マルウェア";
        this.wordButtonName83.text = "メールサーバ";
        this.wordButtonName84.text = "文字化け";
        this.wordButtonName85.text = "ユーザID";
        this.wordButtonName86.text = "ユビキタス社会";
        this.wordButtonName87.text = "ワーム";             
        this.wordButtonName88.text = "リレー方式コンピュータ";
        this.wordButtonName89.text = "ログアウト";
        this.wordButtonName90.text = "ログイン";

        this.wordButtonNamea1.text = "aiff";
        this.wordButtonNamea2.text = "Android";
        this.wordButtonNamea3.text = "avi";
        this.wordButtonNamea4.text = "BBS";
        this.wordButtonNamea5.text = "BCC機能";
        this.wordButtonNamea6.text = "B to B";
        this.wordButtonNamea7.text = "B to c";
        this.wordButtonNamea8.text = "CC欄";
        this.wordButtonNamea9.text = "C to C";
        this.wordButtonNamea10.text = "DNS";
        this.wordButtonNamea11.text = "gif";
        this.wordButtonNamea12.text = "HTTP";
        this.wordButtonNamea13.text = "ICタグ";
        this.wordButtonNamea14.text = "iOS";
        this.wordButtonNamea15.text = "IP";
        this.wordButtonNamea16.text = "IPアドレス";
        this.wordButtonNamea17.text = "IT";
        this.wordButtonNamea18.text = "jpg";
        this.wordButtonNamea19.text = "LAN";
        this.wordButtonNamea20.text = "Linux";
        this.wordButtonNamea21.text = "Mac OS X";
        this.wordButtonNamea22.text = "mp3";
        this.wordButtonNamea23.text = "mpg";
        this.wordButtonNamea24.text = "mov";
        this.wordButtonNamea25.text = "OS";
        this.wordButtonNamea26.text = "png";
        this.wordButtonNamea27.text = "SNS";
        this.wordButtonNamea28.text = "TCP";
        this.wordButtonNamea29.text = "URL";
        this.wordButtonNamea30.text = "WAN";
        this.wordButtonNamea31.text = "wav";
        this.wordButtonNamea32.text = "Web";
        this.wordButtonNamea33.text = "Webサーバ";
        this.wordButtonNamea34.text = "Windows";
        this.wordButtonNamea35.text = "Windows Phone";
        closeWordPanel();
    }
    
    public void openWordPanelA(int eNum)
    {

        if (eNum == 1)
        {
            this.wordNamehira.text = "[アイフ/エーアイエフエフ]";
            this.wordName.text = this.wordButtonNamea1.text;//単語の名前
            this.wordMean.text = "　｢Audio"+space+ "Interchange" + space + "File" + space + "Format｣の略称．Apple社によって開発された音声データのファイル形式．";//単語の意味
        }
        else if (eNum == 2)
        {
            this.wordNamehira.text = "[アンドロイド]";
            this.wordName.text = this.wordButtonNamea2.text;//単語の名前
            this.wordMean.text = "　Google社が開発したスマートフォン用のOS．iOSに比べて安全性が低く，コンピュータウイルスに感染する恐れがあるが，自分の好みに環境をカスタマイズすることが可能であるため，自由度が高く，また色々なアプリケーションのインストールが可能である．";//単語の意味
        }
        else if (eNum == 3)
        {
            this.wordNamehira.text = "[エーブイアイ]";
            this.wordName.text = this.wordButtonNamea3.text;//単語の名前
            this.wordMean.text = "　｢Audio" + space + "Video" + space + "Interleave｣の略称．Microsoft社が開発した，動画のファイル形式．同社のWindows" + space + "Media" + space + "Player，5KPlayerなどの様々なソフトウェアに対応しているが，Windowsのバージョンによっては，再生できない場合がある．";//単語の意味
        }
        else if (eNum == 4)
        {
            this.wordNamehira.text = "[ビービーエス]";
            this.wordName.text = this.wordButtonNamea4.text;//単語の名前
            this.wordMean.text = "　｢Bulletin" + space + "Board" + space + "System｣の略称．ネットワーク上の掲示板の役割を持つWebページ．電子掲示板．自由に参加・投稿することができ，コミュニケーションをとる事ができる．また，投稿した内容は，時系列に沿って表示され，閲覧することもできる．";//単語の意味
        }
        else if (eNum == 5)
        {
            this.wordNamehira.text = "[ビーシーシーキノウ]";
            this.wordName.text = this.wordButtonNamea5.text;//単語の名前
            this.wordMean.text = "　｢Blind" + space + "Carbon" + space + "Copy｣の略称．複数人にメールを一斉送信する際に，CC欄に表示されている受信者らのメールアドレスを受信者側では受取人以外のメールアドレスを非表示にする機能．";//単語の意味
        }
        else if (eNum == 6)
        {
            this.wordNamehira.text = "[ビーツービー]";
            this.wordName.text = this.wordButtonNamea6.text;//単語の名前
            this.wordMean.text = "　｢Business" + space + "to" + space + "Business｣の略称．電子市場や電子調達のような企業間で行われる取引形態．B2Bとも表記する．";//単語の意味
        }
        else if (eNum == 7)
        {
            this.wordNamehira.text = "[ビーツーシー]";
            this.wordName.text = this.wordButtonNamea7.text;//単語の名前
            this.wordMean.text = "　｢Business" + space + "to" + space + "Consumer｣の略称．Amazonや楽天市場のような企業と消費者で行われる取引形態．B2Cとも表記する．";//単語の意味
        }
        else if (eNum == 8)
        {
            this.wordNamehira.text = "[シーシーラン]";
            this.wordName.text = this.wordButtonNamea8.text;//単語の名前
            this.wordMean.text = "　｢Carbon" + space + "Copy｣の略称．メールを一斉，かつ複数人に送るとき，その受信者側のメールアドレスを表記する欄．受信したメールには受信者全員のメールアドレスが表記され個人情報の漏洩になる場合があるので，使用する際は必ずBCC機能を使う必要がある．";//単語の意味
        }
        else if (eNum == 9)
        {
            this.wordNamehira.text = "[シーツーシー]";
            this.wordName.text = this.wordButtonNamea9.text;//単語の名前
            this.wordMean.text = "　｢Consumer" + space + "to" + space + "Consumer｣の略称．メルカリやオンラインオークションのような消費者間で行われる取引形態．C2Cとも表記する．";//単語の意味
        }
        else if (eNum == 10)
        {
            this.wordNamehira.text = "[ディーエヌエヌ]";
            this.wordName.text = this.wordButtonNamea10.text;//単語の名前
            this.wordMean.text = "　｢Domain" + space + "Name" + space + "System｣の略称．TCP/IP上でドメイン名やホスト名，IPアドレスの対応づけを管理するシステム．IPアドレスは数字の羅列であるため人には扱いにくく，それを解消するためにわかりやすい文字列であるドメイン名に文字解決をする際に対応させる処理を行うのがDNSである．";//単語の意味
        }
        else if (eNum == 11)
        {
            this.wordNamehira.text = "[ギフ/ジフ]";
            this.wordName.text = this.wordButtonNamea11.text;//単語の名前
            this.wordMean.text = "　画像データのファイル形式の1つ．256色での表示，透明色の実現，また複数枚の画像を連結，つまり，パラパラ漫画の要領でアニメーションの作成ができる，などの特徴を有する．";//単語の意味
        }
        else if (eNum == 12)
        {
            this.wordNamehira.text = "[エイチティーティーピー]";
            this.wordName.text = this.wordButtonNamea12.text;//単語の名前
            this.wordMean.text = "　｢Hyper" + space + "Text" + space + "Transfer" + space + "Protocol｣の略称．サーバとクライアントの間でのデータの送受信の際に使われる通信プロトコル．データの送受信のみの数少ない処理で行われるため，処理が非常に速い．";//単語の意味
        }
        else if (eNum == 13)
        {
            this.wordNamehira.text = "[アイシータグ]";
            this.wordName.text = this.wordButtonNamea13.text;//単語の名前
            this.wordMean.text = "　ICチップを内蔵し，情報を微量の電波によってやり取りを可能とする技術．形状は様々あり，SuicaやPASMOなどのカード型や，キーホルダー型，コイン型がある．なお，ICとは，｢Integrated" + space + "Cricuit｣の略称で，集積回路という意味である．";//単語の意味
        }
        else if (eNum == 14)
        {
            this.wordNamehira.text = "[アイオ－エス]";
            this.wordName.text = this.wordButtonNamea14.text;//単語の名前
            this.wordMean.text = "　Apple社が開発したOS．iPhone，iPad，iPod" + space + "touchなどに搭載されている．Androidに比べて安全性が高いため，コンピュータウイルスに感染する恐れがほとんどない．しかし，そのために操作をかなり制御されるため，自由にカスタムアイズできない上にインストールするアプリが制限されることがある．";//単語の意味
        }
        else if (eNum == 15)
        {
            this.wordNamehira.text = "[アイピー]";
            this.wordName.text = this.wordButtonNamea15.text;//単語の名前
            this.wordMean.text = "　｢Internet" + space + "Protocol｣の略称．複数のネットワークを繋ぎ合わせ相互の通信を可能とする通信プロコルの1つ．識別番号であるIPアドレスを割り当て，宛先や送信元に指定して通信を行う．";//単語の意味
        }
        else if (eNum == 16)
        {
            this.wordNamehira.text = "[アイピーアドレス]";
            this.wordName.text = this.wordButtonNamea16.text;//単語の名前
            this.wordMean.text = "　パソコンやネット機器を識別するための番号．グローバルIPアドレスと，プライベートIPアドレスの2種類がある．";//単語の意味
        }
        else if (eNum == 17)
        {
            this.wordNamehira.text = "[アイティ]";
            this.wordName.text = this.wordButtonNamea17.text;//単語の名前
            this.wordMean.text = "　｢Information" + space + "Technology｣の略称．コンピュータやデータ通信での情報に関する技術の総称．";//単語の意味
        }
        else if (eNum == 18)
        {
            this.wordNamehira.text = "[ジェーペグ]";
            this.wordName.text = this.wordButtonNamea18.text;//単語の名前
            this.wordMean.text = "　｢Joint" + space + "Photographic" + space + "Experts" + space + "Group｣の略称．画像データのファイル形式の1つ．人の目では違いを認識できない色，また透明色を使わないため，画質の劣化はするが容量は軽いのが特徴である．";//単語の意味
        }
        else if (eNum == 19)
        {
            this.wordNamehira.text = "[ラン]";
            this.wordName.text = this.wordButtonNamea19.text;//単語の名前
            this.wordMean.text = "　｢Local" + space + "Area" + space + "Network｣の略称．限られた範囲内でのコンピュータや通信機器，相互にデータ通信ができるネットワーク．通信ケーブルを用いた｢有線LAN｣と，電波を用いて無線で接続をする｢無線LAN｣の2種類の接続方法がある．";//単語の意味
        }
        else if (eNum == 20)
        {
            this.wordNamehira.text = "[リナックス/ライナックス]";
            this.wordName.text = this.wordButtonNamea20.text;//単語の名前
            this.wordMean.text = "　サーバを中心とした，その他スマートフォンやテレビなど，幅広い種類のハードウェアに採用されているOS．他のOSに比べ，余計な機能がないため，軽快に動作することができる．また，誰でも自由にカスタマイズして良いため，自分好みの機能にすることができる．";//単語の意味
        }
        else if (eNum == 21)
        {
            this.wordNamehira.text = "[マックオーエステン]";
            this.wordName.text = this.wordButtonNamea21.text;//単語の名前
            this.wordMean.text = "　Apple社が開発したMacのOS．現在バージョン10.12までリリースしていて，10.8以前はネコ科の名前，それ以降はカリフォルニア州の地名からコードネームが付けられている．";//単語の意味
        }
        else if (eNum == 22)
        {
            this.wordNamehira.text = "[エムピースリー]";
            this.wordName.text = this.wordButtonNamea22.text;//単語の名前
            this.wordMean.text = "　｢MPEG" + space + "Audio" + space + "Layer-3｣の略称．音声データのファイル形式の1つ．人の感じにくい音を省くため，音質の劣化はするがサイズの圧縮をすることができる．また，著作権保護機能がないため，CDのデータをコピーして配布・交換する行為が問題となっている．";//単語の意味
        }
        else if (eNum == 23)
        {
            this.wordNamehira.text = "[エムペグ]";
            this.wordName.text = this.wordButtonNamea23.text;//単語の名前
            this.wordMean.text = "　｢MPEG｣(Moving" + space + "Picture" + space + "Experts" + space + "Group)の規格に沿って音声・動画データを変換したファイル拡張子．主に，テレビ・DVDで扱われている．";//単語の意味
        }
        else if (eNum == 24)
        {
            this.wordNamehira.text = "[エムオーブイ/モブ]";
            this.wordName.text = this.wordButtonNamea24.text;//単語の名前
            this.wordMean.text = "　Apple社の開発した動画編集ソフト｢Quick" + space + "Time" + space + "Player｣で扱われるファイル形式．高い互換性を持つため，マルチプラットフォーム対応であり，またサイズが小さい．";//単語の意味
        }
        else if (eNum == 25)
        {
            this.wordNamehira.text = "[オーエス]";
            this.wordName.text = this.wordButtonNamea25.text;//単語の名前
            this.wordMean.text = "　｢Operating" + space + "System｣の略称．システム全体を管理するソフトウェアで，人で例えると脳に相当する．有名なものは，パソコン向けのOSであるWindowsシリーズ，Mac" + space + "OS" + space + "Xシリーズ，スマートフォン向けのOSは，Android，iOSがある．";//単語の意味
        }
        else if (eNum == 26)
        {
            this.wordNamehira.text = "[ペング/ピーエヌジー]";
            this.wordName.text = this.wordButtonNamea26.text;//単語の名前
            this.wordMean.text = "　｢Portable" + space + "Network" + space + "Graphics｣の略称．画像データのファイル形式の1つ．透明を表示するのに最も適している．";//単語の意味
        }
        else if (eNum == 27)
        {
            this.wordNamehira.text = "[エスエヌエス]";
            this.wordName.text = this.wordButtonNamea27.text;//単語の名前
            this.wordMean.text = "　｢Social" + space + "Networking" + space + "Service｣の略称．趣味や嗜好を通じて交流することのできるWebサイト．基本的な機能は，プロフィール公開，メッセージの送受信，ブログ，検索などがあり，これを利用することで交流を広げることができる．しかし，住所公開や顔写真を載せるなどの利用をすると個人情報の漏洩に繋がるため，気を付けなければならない．";//単語の意味
        }
        else if (eNum == 28)
        {
            this.wordNamehira.text = "[ティーシーピー]";
            this.wordName.text = this.wordButtonNamea28.text;//単語の名前
            this.wordMean.text = "　｢Transmission" + space + "Control" + space + "Protocol｣の略称．IPを基盤としている通信プロトコル．IP，HTTPなどを橋渡しする機能を持ち，運ぶデータを識別し，ソフトウェアに分けることができる．";//単語の意味
        }
        else if (eNum == 29)
        {
            this.wordNamehira.text = "[ユーアルエル]";
            this.wordName.text = this.wordButtonNamea29.text;//単語の名前
            this.wordMean.text = "　｢Uniform" + space + "Resource" + space + "Locator｣の略称．インターネット上の情報の位置を示す．一般的にはアドレスと呼ぶことが多い．";//単語の意味
        }
        else if (eNum == 30)
        {
            this.wordNamehira.text = "[ワン]";
            this.wordName.text = this.wordButtonNamea30.text;//単語の名前
            this.wordMean.text = "　｢Wide" + space + "Area" + space + "Network｣の略称．LANどうしが結合し，より規模が大きくなったネットワーク．また，世界規模で実現しているWANをインターネットと呼ぶ．";//単語の意味
        }
        else if (eNum == 31)
        {
            this.wordNamehira.text = "[ウェブ/ウェーブ/ワブ]";
            this.wordName.text = this.wordButtonNamea31.text;//単語の名前
            this.wordMean.text = "　｢Waveform" + space + "Audio" + space + "File" + space + "Format｣の略称．Windowsが標準対応している音声データのファイル形式の1つ．圧縮されないため，ファイルサイズは大きいが，音質は音楽CDとほぼ同じである．";//単語の意味
        }
        else if (eNum == 32)
        {
            this.wordNamehira.text = "[ウェブ]";
            this.wordName.text = this.wordButtonNamea32.text;//単語の名前
            this.wordMean.text = "　インターネット上の文章や画像．動画などのデータを閲覧できるシステム．また閲覧だけでなく，公開や配布もできる．";//単語の意味
        }
        else if (eNum == 33)
        {
            this.wordNamehira.text = "[ウェブサーバ]";
            this.wordName.text = this.wordButtonNamea33.text;//単語の名前
            this.wordMean.text = "　Webページの表示を利用者側のコンピュータに提供するサーバ，またコンピュータ．";//単語の意味
        }
        else if (eNum == 34)
        {//修正予定
            this.wordNamehira.text = "[ウインドウズ]";
            this.wordName.text = this.wordButtonNamea34.text;//単語の名前
            this.wordMean.text = "　Microsoft社が開発したOS．MsWindows正式名称．";//単語の意味
        }
        else if (eNum == 35)
        {
            this.wordNamehira.text = "[ウインドウズフォン]";
            this.wordName.text = this.wordButtonNamea35.text;//単語の名前
            this.wordMean.text = "　Microsoft社が開発した，スマートフォン向けのOS．iOS，Androidとは異なる独自のホーム画面，ボタン配置(ユーザーインタフェイス)を施しており，誰でも扱いやすい仕様にはなっているが，市場に出るのが遅すぎたため，iOSとAndroidに比べてあまり採用されていない．";//単語の意味
        }

        houseRule();
        this.wordPanel.SetActive(true);
        selectA.panelOn();
    }

    public void openWordPanel(int wNum)
    {
        this.wordPanel.SetActive(true);

        selectA.panelOn();
        if (wNum == 1)
        {
            this.wordNamehira.text = "[あくせすけん]";
            this.wordName.text = this.wordButtonName1.text;//単語の名前
            this.wordMean.text = "　ファイルやフィルダ，また周辺機器などの利用する権限．";//単語の意味
        }
        else if (wNum == 2)
        {
            this.wordNamehira.text = "[あくせすせいぎょ]";
            this.wordName.text = this.wordButtonName2.text;//単語の名前
            this.wordMean.text = "　複数人でコンピュータを利用する時，特定の利用者のみにアクセス権を与え，扱えるようにすること．";//単語の意味
        }else if (wNum == 3)
        {
            this.wordNamehira.text = "[あっぷでーと]";
            this.wordName.text = this.wordButtonName3.text;//単語の名前
            this.wordMean.text = "　ソフトウェアの機能やセキュリティを最新の状態にすること．バグの解消やセキュリティの強化になるので，定期的にした方が良い．";//単語の意味
        }else if(wNum == 4)
        {
            this.wordNamehira.text = "[あっぷろーど]";
            this.wordName.text = this.wordButtonName4.text;//単語の名前
            this.wordMean.text = "　ネットワークを通して，別のコンピュータにデータを送信すること．ダウンロードの対義語である．";//単語の意味
        }
        else if (wNum == 5)
        {
            this.wordNamehira.text = "[あどいん]";
            this.wordName.text = this.wordButtonName5.text;//単語の名前
            this.wordMean.text = "　コンピュータや周辺機器に機能を追加すること．｢アドオン｣ともいう．";//単語の意味
        }
        else if (wNum == 6)
        {
            this.wordNamehira.text = "[あどみにすとれーた]";
            this.wordName.text = this.wordButtonName6.text;//単語の名前
            this.wordMean.text = "　アクセス権の設定，またそれを実行するための権限を持つ管理者．";//単語の意味
        }
        else if (wNum == 7)
        {
            this.wordNamehira.text = "[あんごうか]";
            this.wordName.text = this.wordButtonName7.text;//単語の名前
            this.wordMean.text = "　ネットワークを通して，データのやり取りをする際に，盗み見やデータの改ざんを防ぐために，他者から扱われないようにデータ変換をすること．";//単語の意味
        }
        else if (wNum == 8)
        {
            this.wordNamehira.text = "[いしょうけん]";
            this.wordName.text = this.wordButtonName8.text;//単語の名前
            this.wordMean.text = "　知的財産権の1つ．新規性・また創作性のある物の形状・模様・色彩といったデザインを独占することのできる権利．";//単語の意味
        }
        else if (wNum == 9)
        {
            this.wordNamehira.text = "[いんたーねっと]";
            this.wordName.text = this.wordButtonName9.text;//単語の名前
            this.wordMean.text = "　コンピュータや通信機器を相互に繋いだ，ネットワークの事．略称で「ネット」ともいう．";//単語の意味
        }
        else if (wNum == 10)
        {
            this.wordNamehira.text = "[かおもじ]";
            this.wordName.text = this.wordButtonName10.text;//単語の名前
            this.wordMean.text = "　表情を表した記号・文字の組み合わせ．文章中に用いることで，意味を伝えやすくする手法．";//単語の意味
        }
        else if (wNum == 11)
        {
            this.wordNamehira.text = "[かぎ]";
            this.wordName.text = this.wordButtonName11.text;//単語の名前
            this.wordMean.text = "　データの暗号化を行う際の手順の方式．";//単語の意味
        }
        else if (wNum == 12)
        {
            this.wordNamehira.text = "[かくうせいきゅう]";
            this.wordName.text = this.wordButtonName12.text;//単語の名前
            this.wordMean.text = "　身に覚えのない，また実在しない請求．";//単語の意味
        }
        else if (wNum == 13)
        {
            this.wordNamehira.text = "[きしゅいぞんもじ]";
            this.wordName.text = this.wordButtonName13.text;//単語の名前
            this.wordMean.text = "　使用しているソフトウェア，またはハードウェアによっては，正しく表示されない特殊文字の総称．環境依存文字ともいう． ";//単語の意味
        }
        else if (wNum == 14)
        {
            this.wordNamehira.text = "[くらいあんと]";
            this.wordName.text = this.wordButtonName14.text;//単語の名前
            this.wordMean.text = "　クライアントサーバシステムにおいて，サーバにサービスの依頼を行い，サービスを受けるコンピュータ．";//単語の意味
        }
        else if (wNum == 15)
        {
            this.wordNamehira.text = "[くらいあんとさーばしすてむ]";
            this.wordName.text = this.wordButtonName15.text;//単語の名前
            this.wordMean.text = "　データを提供するサーバと，データを要求するクライアントに分けて，役割を分散して処理を行う仕組み．";//単語の意味
        }
        else if (wNum == 16)
        {
            this.wordNamehira.text = "[くらっかー]";
            this.wordName.text = this.wordButtonName16.text;//単語の名前
            this.wordMean.text = "　他のコンピュータやネットワークに侵入し，データの改ざんや消去など悪質な行為をする者．一般的に｢ハッカー｣は，この意味で多く用いられているが，異なるものである．";//単語の意味
        }
        else if (wNum == 17)
        {
            this.wordNamehira.text = "[くらっきんぐ]";
            this.wordName.text = this.wordButtonName17.text;//単語の名前
            this.wordMean.text = "　他のコンピュータやネットワークに侵入し，データの改ざんや消去など悪質な行為．一般的に｢ハッキング｣は，この意味で多く用いられているが，異なるものである．";//単語の意味
        }
        else if (wNum == 18)
        {
            this.wordNamehira.text = "[ぐろーばるあいぴーあどれす]";
            this.wordName.text = this.wordButtonName18.text;//単語の名前
            this.wordMean.text = "　ネット接続しているコンピュータが持つ世界で1つだけの番号．";//単語の意味
        }
        else if (wNum == 19)
        {
            this.wordNamehira.text = "[こじんじょうほう]";
            this.wordName.text = this.wordButtonName19.text;//単語の名前
            this.wordMean.text = "　氏名・生年月日・パスワードなどの個人を特定することができる情報．";//単語の意味
        }
        else if (wNum == 20)
        {
            this.wordNamehira.text = "[こめんときのう]";
            this.wordName.text = this.wordButtonName20.text;//単語の名前
            this.wordMean.text = "　記事・投稿などに対して意見をネットワーク上に記す機能．";//単語の意味
        }
        else if (wNum == 21)
        {
            this.wordNamehira.text = "[こんてんつふぃるたりんぐ]";
            this.wordName.text = this.wordButtonName21.text;//単語の名前
            this.wordMean.text = "　インターネット上の情報を受信する際に問題があった場合，その問題の部分を拒否・遮断する技術．具体的には，ブラックリスト方式やホワイトリスト方式がある．";//単語の意味
        }
        else if (wNum == 22)
        {
            this.wordNamehira.text = "[こんぴゅーたういるす]";
            this.wordName.text = this.wordButtonName22.text;//単語の名前
            this.wordMean.text = "　マルウェアの1つ．他のプログラムに感染して，不正・有害な処理を行うプログラムの事を指す・";//単語の意味
        }
        else if (wNum == 23)
        {
            this.wordNamehira.text = "[さいばーはんざい]";
            this.wordName.text = this.wordButtonName23.text;//単語の名前
            this.wordMean.text = "　ネットワーク上で行われる犯罪の総称．ネット犯罪ともいわれ，具体的には,不正アクセスや，著作権法違反，詐欺などがある．";//単語の意味
        }
        else if (wNum == 24)
        {
            this.wordNamehira.text = "[ざんぞんせい]";
            this.wordName.text = this.wordButtonName24.text;//単語の名前
            this.wordMean.text = "　情報の特徴の1つ．他者に渡っても自分の手元には残る性質．";//単語の意味
        }
        else if (wNum == 25)
        {
            this.wordNamehira.text = "[さーば]";
            this.wordName.text = this.wordButtonName25.text;//単語の名前
            this.wordMean.text = "　クライアントサーバシステムにおいて，クライアントからサービスの要求を受け，それに応じる機能．";//単語の意味
        }
        else if (wNum == 26)
        {
            this.wordNamehira.text = "[さんぎょうざいさんけん]";
            this.wordName.text = this.wordButtonName26.text;//単語の名前
            this.wordMean.text = "　知的財産権の1つ．発明や企業を表すロゴマーク，物の形状やデザインなどを独占することのできる権利．特許権・実用新案権・意匠権・商標権の4つの権利の総称．";//単語の意味
        }
        else if (wNum == 27)
        {
            this.wordNamehira.text = "[じつようしんあんけん]";
            this.wordName.text = this.wordButtonName27.text;//単語の名前
            this.wordMean.text = "  産業財産権の1つ．物の形状や構造，などの考案を独占することのできる権利．特許庁に出願し，登録することで発生し，保護期間は出願から最長10年とされている．";//単語の意味
        }
        else if (wNum == 28)
        {
            this.wordNamehira.text = "[じゆうりようまーく]";
            this.wordName.text = this.wordButtonName28.text;//単語の名前
            this.wordMean.text = "　著作物を使って良いと著作者の意思を表示するためのシール．これには3種類あり，｢プリントアウト・コピー・無料配布｣OKマークと，｢障害者のための非営利目的利用｣OKマーク，｢学校教育のための非営利目的利用｣OKマークがある．";//単語の意味
        }
        else if (wNum == 29)
        {
            this.wordNamehira.text = "[しょうひょうけん]";
            this.wordName.text = this.wordButtonName29.text;//単語の名前
            this.wordMean.text = "　産業財産権の1つ．他社との区別をするための文字，図形，色彩などいわゆるロゴマークのような企業を象徴するものを対象とし，それを独占することのできる権利．特許庁に出願することで保護の対象となり，その期間は登録から原則10年とされているが，更新も可能である．";//単語の意味
        }
        else if (wNum == 30)
        {
            this.wordNamehira.text = "[じょうほう]";
            this.wordName.text = this.wordButtonName30.text;//単語の名前
            this.wordMean.text = "　物事の事実を目的応じて整理したもの．";//単語の意味
        }
        else if (wNum == 31)
        {
            this.wordNamehira.text = "[じょうほうかでん]";
            this.wordName.text = this.wordButtonName31.text;//単語の名前
            this.wordMean.text = "　通信機能を持った家電製品の総称．スマートフォン，またデジタル技術の発展により，ユビキタスコンピューティングの実現に必要な技術とされている．";//単語の意味
        }
        else if (wNum == 32)
        {
            this.wordNamehira.text = "[すけあうぇあ]";
            this.wordName.text = this.wordButtonName32.text;//単語の名前
            this.wordMean.text = "　マルウェアの1つで，正当なセキュリティソフトを装い，コンピュータにウイルスが感染しているなどと嘘のメッセージを画面上に表示し，そこから個人情報を盗んだり，危険なプログラムを侵入させるソフトウェア．回避するには，このようなメッセージが出てもクリックしないことが大事である．ローグウェアとも呼ばれる．";//単語の意味
        }
        else if (wNum == 33)
        {
            this.wordNamehira.text = "[すぱいうぇあ]";
            this.wordName.text = this.wordButtonName33.text;//単語の名前
            this.wordMean.text = "　マルウェアの1つで，ユーザの行動や個人情報を外部に送信するソフ悪質なトウェア．キーボード・マウスの操作やWebページの閲覧履歴などが対象で，得られたデータは，マーケティングのデータとして扱われることもある．";//単語の意味
        }
        else if (wNum == 34)
        {
            this.wordNamehira.text = "[せきゅりてぃ]";
            this.wordName.text = this.wordButtonName34.text;//単語の名前
            this.wordMean.text = "　外部による個人情報の漏洩やデータの破損・改ざんなどから技術的に保護し，これらの脅威を排除すること．方法としては，セキュリティソフトのインストール・ソフトウェアのアップデートが挙げられる．";//単語の意味
        }
        else if (wNum == 35)
        {
            this.wordNamehira.text = "[せきゅりてぃそふと]";
            this.wordName.text = this.wordButtonName35.text;//単語の名前
            this.wordMean.text = "　外部による個人情報の漏洩やデータの破損・改ざんなどからコンピュータを守り，安全性を高めるソフトウェアの総称．有名なものは，Norton，McAfee，ESETなどがある．";//単語の意味
        }
        else if (wNum == 36)
        {
            this.wordNamehira.text = "[せきゅりてぃほーる";
            this.wordName.text = this.wordButtonName36.text;//単語の名前
            this.wordMean.text = "　ソフトウェアの不具合や設計上のミスなどの欠陥部分，いわゆるソフトウェアの脆弱性のことである．これにより，クラッキングやコンピュータウイルスが感染する危険性がある．";//単語の意味
        }
        else if (wNum == 37)
        {
            this.wordNamehira.text = "[せきゅりてぃぽりしー]";
            this.wordName.text = this.wordButtonName37.text;//単語の名前
            this.wordMean.text = "　企業や学校などの組織全体が情報セキュリティに関する基本方針のことをいい，情報をどのような脅威からどのように守るかを具体的にまとめた考え方．";//単語の意味
        }
        else if (wNum == 38)
        {
            this.wordNamehira.text = "[そーしゃる・えんじにありんぐ]";
            this.wordName.text = this.wordButtonName38.text;//単語の名前
            this.wordMean.text = "　パスワードや個人情報といった機密情報を人の心理的ミスを利用して盗む行為．手口としては，情報が載っている媒体(紙・デジタルデータなど)を見つけ，また管理人になりすましユーザから盗み出すケースなどある．";//単語の意味
        }
        else if (wNum == 39)
        {
            this.wordNamehira.text = "[そふとうぇあ]";
            this.wordName.text = this.wordButtonName39.text;//単語の名前
            this.wordMean.text = "　コンピュータを動かすために何らかの処理を行うプログラムの総称．単にソフト，アプリなどと呼ばれることもある．";//単語の意味
        }
        else if (wNum == 40)
        {
            this.wordNamehira.text = "[だうんろーど]";
            this.wordName.text = this.wordButtonName40.text;//単語の名前
            this.wordMean.text = "  ネットワークを通して，コンピュータにデータを受信すること．アップロードの対義語である．";//単語の意味
        }
        else if (wNum == 41)
        {
            this.wordNamehira.text = "[ちしき]";
            this.wordName.text = this.wordButtonName41.text;//単語の名前
            this.wordMean.text = "　情報を分析し，物事の原因に基づく認識のこと．これを蓄積し発揮することで，新たなデータを得られるようになる．";//単語の意味
        }
        else if (wNum == 42)
        {
            this.wordNamehira.text = "[ちてきざいさんけん]";
            this.wordName.text = this.wordButtonName42.text;//単語の名前
            this.wordMean.text = "　ネット上の画像や情報・音楽などの知的価値のある無形のものを無断に利用されないように，保護するために創作者に与えられる権利．これを大きく分けると，著作権・産業財産権・その他の権利となる．";//単語の意味
        }
        else if (wNum == 43)
        {
            this.wordNamehira.text = "[ちょさくけん]";
            this.wordName.text = this.wordButtonName43.text;//単語の名前
            this.wordMean.text = "　知的財産権の1つであり，絵や音楽，小説や映像などといった著作物の無断利用から保護し，文化の発展に寄与することを目的とする権利．著作物が創作された時点で発生し，出願などの手続きの必要はない．保護期間は，著作者の死後50年とされている．";//単語の意味
        }
        else if (wNum == 44)
        {
            this.wordNamehira.text = "[ちょさくざいさんけん]";
            this.wordName.text = this.wordButtonName44.text;//単語の名前
            this.wordMean.text = "　創造者である著作者の著作物から発生する経済的利益を守る権利．一般的に言われる著作権は，これにあたる．";//単語の意味
        }
        else if (wNum == 45)
        {
            this.wordNamehira.text = "[ちょさくじんかくけん]";
            this.wordName.text = this.wordButtonName45.text;//単語の名前
            this.wordMean.text = "著作者の名誉や精神的保護をする権利．作品の公表するにあたって，著作者の名前の公表をどうするか，また内容の改変・一部切り取りなどを禁止にすることで，著作者の名誉を保護している．";//単語の意味
        }
        else if (wNum == 46)
        {
            this.wordNamehira.text = "[ちょさくりんせつけん]";
            this.wordName.text = this.wordButtonName46.text;//単語の名前
            this.wordMean.text = "　著作者ではなく，著作物の伝達をする実演家や，レコード製作者，放送事業などに認められる権利．伝達する際に上で必要な権利であり，自動的に付与される．";//単語の意味
        }
        else if (wNum == 47)
        {
            this.wordNamehira.text = "[つうしんぷろとこる]";
            this.wordName.text = this.wordButtonName47.text;//単語の名前
            this.wordMean.text = "  コンピュータ同士の通信に関する取り決め・手順を定めたもの．Webページ閲覧の場合は，HTTPを利用しており，これはTCPとIPを使用している．";//単語の意味
        }
        else if (wNum == 48)
        {
            this.wordNamehira.text = "[てくのいぞんしょう]";
            this.wordName.text = this.wordButtonName48.text;//単語の名前
            this.wordMean.text = "　インターネットや，メールの送受信，ゲームアプリなどに過度に依存する精神的な病気．コンピュータに没頭しすぎると起こる病気で，睡眠時間の短縮，また睡眠の質が悪くことがあり不眠症に繋がる恐れがある．";//単語の意味
        }
        else if (wNum == 49)
        {
            this.wordNamehira.text = "[てくのすとれす]";
            this.wordName.text = this.wordButtonName49.text;//単語の名前
            this.wordMean.text = "　コンピュータを扱うことで原因が生じる病気の総称．コンピュータ環境に適応できないことで不安に陥るテクノ不安症と，コンピュータに没頭しすぎると起きるテクノ依存症の2種類がある．";//単語の意味
        }
        else if (wNum == 50)
        {
            this.wordNamehira.text = "[てくのふあんしょう]";
            this.wordName.text = this.wordButtonName50.text;//単語の名前
            this.wordMean.text = "　コンピュータ環境に適応できないことが原因で起きる病気．高度情報化社会である現在，コンピュータを使う機会が増え，操作に慣れずストレスを感じることから体調を崩すことがある．";//単語の意味
        }
        else if (wNum == 51)
        {
            this.wordNamehira.text = "[でーた]";
            this.wordName.text = this.wordButtonName51.text;//単語の名前
            this.wordMean.text = "　物事の事実を人に伝わるように文字や記号に変換した表現．また，これを目的に応じて整理したものを情報という．";//単語の意味
        }
        else if (wNum == 52)
        {
            this.wordNamehira.text = "[でーたべーす]";
            this.wordName.text = this.wordButtonName52.text;//単語の名前
            this.wordMean.text = "　複数の主体で検索，共有など容易にできるように管理されたデータの集合体．情報を整理し管理することで，組織内で効率よく共有・利用することが可能となる．";//単語の意味
        }
        else if (wNum == 53)
        {
            this.wordNamehira.text = "[でんししょうとりひき]";
            this.wordName.text= this.wordButtonName53.text;//単語の名前
            this.wordMean.text = "　ネットワークを介して行う商取引の総称．その形態は，BtoB．BtoC，CtoCなど様々ある．また，EC(Electronic Commerce)ともよぶ．";//単語の意味
        }
        else if (wNum == 54)
        {
            this.wordNamehira.text = "[でんしすかし]";
            this.wordName.text = this.wordButtonName54.text;//単語の名前
            this.wordMean.text = "　画像や音楽などのデジタルコンテンツに情報を埋め込む技術．情報を埋め込んだデータを電子透かし検出ソフトにかけると，埋め込んだ情報を表示することができる．これにより，コピーした回数や改ざんされた箇所などを知ることができる．";//単語の意味
        }
        else if (wNum == 55)
        {
            this.wordNamehira.text = "[でんぱせい]";
            this.wordName.text = this.wordButtonName55.text;//単語の名前
            this.wordMean.text = "  情報の特徴の1つであり，短時間で伝わり，また広めることができる性質．";//単語の意味
        }
        else if (wNum == 56)
        {
            this.wordNamehira.text = "[てんぷふぁいる]";
            this.wordName.text = this.wordButtonName56.text;//単語の名前
            this.wordMean.text = "　メールのような文章と同時に送られる画像・音楽といったファイルのことを言う．送ると側と受け取り側でコンピュータの環境が違うため，正しく表示されない場合があり，気を付けなくてはならない．";//単語の意味
        }
        else if (wNum == 57)
        {
            this.wordNamehira.text = "[とくめい]";
            this.wordName.text = this.wordButtonName57.text;//単語の名前
            this.wordMean.text = "　対象の人物の実名・正体を明かさない事で特定ができないこと．この性質を利用し，なりすまし行為や悪質なコメントによる誹謗・中傷が横行し，社会的な問題となっている．";//単語の意味
        }
        else if (wNum == 58)
        {
            this.wordNamehira.text = "[とっきょけん]";
            this.wordName.text = this.wordButtonName58.text;//単語の名前
            this.wordMean.text = "　知的財産権の1つであり，新しい発明をした者に決められて期間だけその発明を独占することのできる権利．特許庁に出願し，登録することで発生し，保護期間は出願から20年とされている．";//単語の意味
        }
        else if (wNum == 59)
        {
            this.wordNamehira.text = "[どめいんめい]";
            this.wordName.text = this.wordButtonName59.text;//単語の名前
            this.wordMean.text = "　インターネット上の住所を表すIPアドレスを理解しやすいように変換した文字列．URLやメールアドレスの一部に使われている．";//単語の意味
        }
        else if (wNum == 60)
        {
            this.wordNamehira.text = "[なまえかいけつ]";
            this.wordName.text = this.wordButtonName60.text;//単語の名前
            this.wordMean.text = "　数字の羅列であるIPアドレスをわかりやすくするため，文字列のドレイン名に変換する手段．";//単語の意味
        }
        else if (wNum == 61)
        {
            this.wordNamehira.text = "[ねちけっと]";
            this.wordName.text = this.wordButtonName61.text;//単語の名前
            this.wordMean.text = "　ネットワークとエチケットを合わせた造語で，ネット上のエチケットのことを言う．ネットマナー・ネチケとも呼ばれる．具体的には，機種依存文字の使用を控えることや，個人情報の流出・プライバシーの侵害をしない，荒らしをしないことが挙げられる．";//単語の意味
        }
        else if (wNum == 62)
        {
            this.wordNamehira.text = "[のいまんがたこんぴゅーた]";
            this.wordName.text = this.wordButtonName62.text;//単語の名前
            this.wordMean.text = "　プログラムをデータとして記憶し，これを順番に読み込んで実行するコンピュータ．ジョン・フォン・ノイマンによって開発されたコンピュータで，現在でもほとんどのコンピュータが採用している．";//単語の意味
        }
        else if (wNum == 63)
        {
            this.wordNamehira.text = "[ぱすわーど]";
            this.wordName.text = this.wordButtonName63.text;//単語の名前
            this.wordMean.text = "　ある機能・サービスを使用する際に認証を得るための文字，または数字，記号で構成された文字列．設定をするときは，第三者に解かれないように文字数を多くしたり，特殊文字を入れたりして難解にすることが大事である．";//単語の意味
        }
        else if (wNum == 64)
        {
            this.wordNamehira.text = "[はっかー]";
            this.wordName.text = this.wordButtonName64.text;//単語の名前
            this.wordMean.text = "　コンピュータ関する技術・知識が精通している人のこと．クラッカーとしてよく使われるが，ハッカーの場合は，悪質な行為は含まれないので異なるものである．";//単語の意味
        }
        else if (wNum == 65)
        {
            this.wordNamehira.text = "[はっきんぐ]";
            this.wordName.text = this.wordButtonName65.text;//単語の名前
            this.wordMean.text = "　高い技術力を駆使して，コンピュータやインターネットのシステムを操作すること．不正アクセスなどの悪質な行為を一般的には，ハッキングという場合はあるが，ハッキングは悪質な行為を含まないので，この場合はクラッキングと表現する方が正しい．";//単語の意味
        }
        else if (wNum == 66)
        {
            this.wordNamehira.text = "[はーどうぇあ]";
            this.wordName.text = this.wordButtonName66.text;//単語の名前
            this.wordMean.text = "　コンピュータを構成している，CPUや，メモリ，キーボードなどの形のある装置の総称．";//単語の意味
        }
        else if (wNum == 67)
        {
            this.wordNamehira.text = "[ひらぶん]";
            this.wordName.text = this.wordButtonName67.text;//単語の名前
            this.wordMean.text = "　暗号化される前のデータ．｢へいぶん｣とも読む．";//単語の意味
        }
        else if (wNum == 68)
        {
            this.wordNamehira.text = "[ふくごう]";
            this.wordName.text = this.wordButtonName68.text;//単語の名前
            this.wordMean.text = "　暗号化を行ったデータを元に戻し，人が読める状態に戻すこと．暗号化が複雑である分，復号化に時間がかかる．";//単語の意味
        }
        else if (wNum == 69)
        {
            this.wordNamehira.text = "[ふくせいけん]";
            this.wordName.text = this.wordButtonName69.text;//単語の名前
            this.wordMean.text = "　著作財産権の1つ．著作物を複製する権利．市販のCDやDVDをコピーして，友人に配布すると複製権の侵害となるが，自分や自分の家族などの狭い範囲である私的複製の場合は著作権の例外であり，認められている．しかし，私的複製でも，公衆に設置されている複製機の使用や，コピーガードを回避しての複製，違法ダウンロードなどは違法行為にあたる．";//単語の意味
        }
        else if (wNum == 70)
        {
            this.wordNamehira.text = "[ふくせいせい]";
            this.wordName.text = this.wordButtonName70.text;//単語の名前
            this.wordMean.text = "  情報の特徴の1つであり，短時間で多くの複製を可能とする性質．";//単語の意味
        }
        else if (wNum == 71)
        {
            this.wordNamehira.text = "[ふせいあくせす]";
            this.wordName.text = this.wordButtonName71.text;//単語の名前
            this.wordMean.text = "　本来利用する権限のないコンピュータネットワークの操作，また扱う権限のない情報の改ざんや削除をすること．原因は，ユーザIDやパスワードなどの個人情報漏洩と，セキュリティホールからの侵入によるものがある．";//単語の意味
        }
        else if (wNum == 72)
        {
            this.wordNamehira.text = "[ぶんさんしょり]";
            this.wordName.text = this.wordButtonName72.text;//単語の名前
            this.wordMean.text = "　複数のコンピュータにそれぞれ役割を与えて，分散して処理を行うこと．単独で処理を行うより，分割して処理を行うため，処理時間の短縮を可能としている．";//単語の意味
        }
        else if (wNum == 73)
        {
            this.wordNamehira.text = "[ふぁいる]";
            this.wordName.text = this.wordButtonName73.text;//単語の名前
            this.wordMean.text = "　パソコンでデータを扱うときの単位．また，データをまとめたもののこと．";//単語の意味
        }
        else if (wNum == 74)
        {
            this.wordNamehira.text = "[ふぁいるけいしき]";
            this.wordName.text = this.wordButtonName74.text;//単語の名前
            this.wordMean.text = "　ファイルの種類の事．同じ音楽や画像でも，ソフトウェア固有のものや国際規格のものがある．それを区別するためにファイル名の後に拡張子がついている．";//単語の意味
        }
        else if (wNum == 75)
        {
            this.wordNamehira.text = "[ふぁいるさーば]";
            this.wordName.text = this.wordButtonName75.text;//単語の名前
            this.wordMean.text = "　ネットワーク上でファイルを他のコンピュータと共有することで，外部からの利用が可能であるコンピュータ．ファイルの保存先が共有されることから，データの統合や管理を容易になり，またバックアップのために使用することもある．";//単語の意味
        }
        else if (wNum == 76)
        {
            this.wordNamehira.text = "[ぷらいべーとあいぴーあどれす]";
            this.wordName.text = this.wordButtonName76.text;//単語の名前
            this.wordMean.text = "　ルータとパソコン間，またはパソコンとパソコンの間のような限定された範囲のみ使用できる番号．限定された範囲であるため，他のネットワークに同じプライベートIPアドレスが存在する場合がある．";//単語の意味
        }
        else if (wNum == 77)
        {
            this.wordNamehira.text = "[ぷらぐいん]";
            this.wordName.text = this.wordButtonName77.text;//単語の名前
            this.wordMean.text = "　ソフトウェアに機能を追加するプログラムのこと．単体では動かないため，対象のソフトウェアに追加しなければならない．";//単語の意味
        }
        else if (wNum == 78)
        {
            this.wordNamehira.text = "[ぶらっくりすとほうしき]";
            this.wordName.text = this.wordButtonName78.text;//単語の名前
            this.wordMean.text = "　問題のあるサイトを登録することで，それの閲覧を不可能にするフィルタリングの1つ．インターネット上には，有益な情報もあれば，アダルトサイトなどの子供には見せたくないものもある．そのような情報を選別することで，有益な情報のみを得ることができる．";//単語の意味
        }
        else if (wNum == 79)
        {
            this.wordNamehira.text = "[フリーウェア]";
            this.wordName.text = this.wordButtonName79.text;//単語の名前
            this.wordMean.text = "　ネットワーク上で，無料で提供されているソフトウェア．無料ではあるが，著作権が存在するため，配布・データの改変を行う場合は，提示されている使用条件に従う必要がある．類義語でシェアウェアという言葉があるが，これには試用期間が存在し，過ぎると有料となる．";//単語の意味
        }
        else if (wNum == 80)
        {
            this.wordNamehira.text = "[ぶろぐ]";
            this.wordName.text = this.wordButtonName80.text;//単語の名前
            this.wordMean.text = "  投稿した記事を時系列に沿って表示するWebサイトの総称．ウェブとログを一語にした造語｢ウェブログ｣の略称である．";//単語の意味
        }
        else if (wNum == 81)
        {
            this.wordNamehira.text = "[ほわいとりうとほうしき]";
            this.wordName.text = this.wordButtonName81.text;//単語の名前
            this.wordMean.text = "　問題の無いサイトを登録することで，それ以外を閲覧できなくするフィルタリングの1つ．安全性をほぼ確実に確保できるが，対象のサイトのみに限られてしまうため，利便性を失う欠点がある．";//単語の意味
        }
        else if (wNum == 82)
        {
            this.wordNamehira.text = "[まるうぇあ]";
            this.wordName.text = this.wordButtonName82.text;//単語の名前
            this.wordMean.text = "　コンピュータに勝手に入り込み，データの消去や改ざん，また転送など悪質な動作を行うソフトウェアの総称．コンピュータウイルスや，ワーム，スパイウェアなど様々な種類があり，セキュリティソフトやこまめにソフトウェアのアップデートを行うことで侵入を防ぐことができる．";//単語の意味
        }
        else if (wNum == 83)
        {
            this.wordNamehira.text = "[めーるさーば]";
            this.wordName.text = this.wordButtonName83.text;//単語の名前
            this.wordMean.text = "　自分のネットワーク内の電子メールの送受信をするためのサーバ，また行うコンピュータ．";//単語の意味
        }
        else if (wNum == 84)
        {
            this.wordNamehira.text = "[もじばけ]";
            this.wordName.text = this.wordButtonName84.text;//単語の名前
            this.wordMean.text = "　コンピュータ上で正しく文字が表示されない現象．対応していない特殊文字・絵文字，つまり機種依存文字を使用することで起こるので，ネチケット上使用を控えた方が良いとされている．";//単語の意味
        }
        else if (wNum == 85)
        {
            this.wordNamehira.text = "[ゆーざあいでぃ]";
            this.wordName.text = this.wordButtonName85.text;//単語の名前
            this.wordMean.text = "　ネットワーク上にログイン，サービスを受ける際に利用者を識別するための文字列．IDは，｢Identifier｣の略称である．";//単語の意味
        }
        else if (wNum == 86)
        {
            this.wordNamehira.text = "[ゆびきたすしゃかい]";
            this.wordName.text = this.wordButtonName86.text;//単語の名前
            this.wordMean.text = "　｢いつでも，どこでも，何でも，誰でも｣がネットワークに繋がることで，生活を豊かにする社会．｢いつでも・どこでも｣は，時間，場所を限定されないことの意味で，｢何でも，誰でも｣とは，パソコンやスマートフォン，また情報家電などあらゆるものでネットワークを利用して，物同士，人同士，また人と物が繋がることができることである．";//単語の意味
        }
        else if (wNum == 87)
        {
            this.wordNamehira.text = "[わーむ]";
            this.wordName.text = this.wordButtonName87.text;//単語の名前
            this.wordMean.text = "　マルウェアの1種．単独で存在し，自己増殖を行うことで他のデバイスに感染する悪質なソフトウェアである．感染すると，驚異的な速度で自己増殖を行うことから，ハードディスクの容量を使い尽くしたり，メモリを占拠することからパソコンの処理速度が低下，最悪の場合停止する恐れがある．";//単語の意味
        }
        else if (wNum == 88)
        {
            this.wordNamehira.text = "[りれーしきこんぴゅーた]";
            this.wordName.text = this.wordButtonName88.text;//単語の名前
            this.wordMean.text = "　電子回路の組み合わせにより計算を可能としたコンピュータ．当時は，第一次世界大戦後であり，軍事的需要が高いことから，完全な計算を行うコンピュータが求められ，開発された．";//単語の意味
        }
        else if (wNum == 89)
        {
            this.wordNamehira.text = "[ろぐあうと]";
            this.wordName.text = this.wordButtonName89.text;//単語の名前
            this.wordMean.text = "　アクセスしているサービスやコンピュータの接続を切ること．「ログオフ」ともいう．";//単語の意味
        }
        else if (wNum == 90)
        {
            this.wordNamehira.text = "[ろぐいん]";
            this.wordName.text = this.wordButtonName90.text;//単語の名前
            this.wordMean.text = "　ユーザIDやパスワードを利用し，利用者を識別・認識することで対象のサービスやコンピュータにアクセスする操作のこと．ログオンともいう．";//単語の意味
        }
        houseRule();
    }


    public void houseRule()
    {
        var generator = new TextGenerator();
        var warps = ",.[]{}()?!，．「」｛｝（）［］？！";
        generator.Populate(wordMean.text, wordMean.GetGenerationSettings(wordMean.GetComponent<RectTransform>().sizeDelta));
        var lines = generator.lines;
        for (var i = 1; i < lines.Count; ++i)
        {
            if (warps.Contains(wordMean.text[lines[i].startCharIdx]))
            {
                wordMean.text = wordMean.text.Insert(lines[i].startCharIdx - 1, System.Environment.NewLine);
                break;
            }
        }
    }




    public void closeWordPanel()
    {
        this.wordPanel.SetActive(false);
    }
}
