using UnityEngine;
using System.Collections;

public class AnsButtonDirector : MonoBehaviour
{
    private int shuffleNum1;
    private int shuffleNum2;
    private int shuffleNum3;
    
    private int xPos1 = 270;
    private int yPos1 = 100;
    private int yPos2 = 300;
    private int yPos3;

    private Vector3 luPos;
    private Vector3 ldPos;
    private Vector3 ruPos;
    private Vector3 rdPos;

    public GameObject answerButton1_1;
    public GameObject answerButton1_2;
    public GameObject answerButton1_3;
    public GameObject answerButton1_4;
    public GameObject answerButton2_1;
    public GameObject answerButton2_2;
    public GameObject answerButton2_3;
    public GameObject answerButton2_4;
    public GameObject answerButton3_1;
    public GameObject answerButton3_2;
    public GameObject answerButton3_3;
    public GameObject answerButton3_4;

    void Start()
    {
        /*
        luPos = this.answerButton1_1.transform.localPosition;
        ldPos = this.answerButton1_2.transform.localPosition;
        ruPos = this.answerButton1_3.transform.localPosition;
        rdPos = this.answerButton1_4.transform.localPosition;

        Debug.Log(luPos);
        Debug.Log(ldPos);
        Debug.Log(ruPos);
        Debug.Log(rdPos);
        */
    }

    public void shuffleButton()
    {
        shuffleNum1 = Random.Range(1, 25);
        shuffleNum2 = Random.Range(1, 25);
        shuffleNum3 = Random.Range(1, 25);

       
        //1
        if (shuffleNum1 == 1)
        {
            //解答ボタンの配置
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 *-1, yPos2, 0);
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0);
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);
        }
        else if (shuffleNum1 == 2)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }
        else if (shuffleNum1 == 3)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        
        else if (shuffleNum1 == 4)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2

        }
        else if (shuffleNum1 == 5)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum1 == 6)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum1 == 7)
        {
            //解答ボタンの配置
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }
        else if (shuffleNum1 == 8)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum1 == 9)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }

        else if (shuffleNum1 == 10)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum1 == 11)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum1 == 12)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum1 == 13)
        {
            //解答ボタンの配置
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }
        else if (shuffleNum1 == 14)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum1 == 15)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }

        else if (shuffleNum1 == 16)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum1 == 17)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum1 == 18)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }

        else if (shuffleNum1 == 19)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum1 == 20)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum1 == 21)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }

        else if (shuffleNum1 == 22)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum1 == 23)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum1 == 24)
        {
            this.answerButton1_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton1_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton1_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton1_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }

        
        //////////////////2///////////////////////
        if (shuffleNum2 == 1)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0);
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);
        }
        else if (shuffleNum2 == 2)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }
        else if (shuffleNum2 == 3)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }

        else if (shuffleNum2 == 4)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2

        }
        else if (shuffleNum2 == 5)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum2 == 6)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum2 == 7)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }
        else if (shuffleNum2 == 8)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum2 == 9)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }

        else if (shuffleNum2 == 10)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum2 == 11)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum2 == 12)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum2 == 13)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }
        else if (shuffleNum2 == 14)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum2 == 15)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }

        else if (shuffleNum2 == 16)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum2 == 17)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum2 == 18)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }

        else if (shuffleNum2 == 19)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum2 == 20)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum2 == 21)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }

        else if (shuffleNum2 == 22)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum2 == 23)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum2 == 24)
        {
            this.answerButton2_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton2_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton2_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton2_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        ////////////////////3/////////////////////
        if (shuffleNum3 == 1)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0);
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);
        }
        else if (shuffleNum3 == 2)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }
        else if (shuffleNum3 == 3)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }

        else if (shuffleNum3 == 4)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2

        }
        else if (shuffleNum3 == 5)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum3 == 6)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum3 == 7)
        {
            //解答ボタンの配置
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }
        else if (shuffleNum3 == 8)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum3 == 9)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }

        else if (shuffleNum3 == 10)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum3 == 11)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum3 == 12)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum3 == 13)
        {
            //解答ボタンの配置
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }
        else if (shuffleNum3 == 14)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum3 == 15)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
        }

        else if (shuffleNum3 == 16)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum3 == 17)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum3 == 18)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }

        else if (shuffleNum3 == 19)
        {
            //解答ボタンの配置
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }
        else if (shuffleNum3 == 20)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum3 == 21)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
        }

        else if (shuffleNum3 == 22)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
        else if (shuffleNum3 == 23)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
        }
        else if (shuffleNum3 == 24)
        {
            this.answerButton3_1.transform.localPosition = new Vector3(xPos1, yPos1, 0);//4
            this.answerButton3_2.transform.localPosition = new Vector3(xPos1 * -1, yPos1, 0); ;//3
            this.answerButton3_3.transform.localPosition = new Vector3(xPos1, yPos2, 0);//2
            this.answerButton3_4.transform.localPosition = new Vector3(xPos1 * -1, yPos2, 0);//1
        }
    }
}
