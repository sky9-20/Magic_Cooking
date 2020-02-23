using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnMouseDown_plus_w : MonoBehaviour
{
    //足す・引く値をインスペクター上で指定
    public int plus = 1;
    public int minus = 0;

    //Judgeがアタッチされたオブジェクトを指定
    GameObject judger;
    
    // Start is called before the first frame update
    void Start()
    {
       judger = GameObject.Find("Judger");
       //Debug.Log(judger);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        //ループ用の変数を定義
        int p = plus;
        int m = minus;

        //+,-値が0になるまでJudgeで足す、引く
        while (p != 0)
        {
            judger.GetComponent<Judge>().Pw1();
            --p;
            
        }

        while (m != 0)
        {
            judger.GetComponent<Judge>().Mw1();
            ++m;
        }

        this.gameObject.SetActive(false);
    }
}
