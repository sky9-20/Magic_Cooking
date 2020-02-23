using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnMouseDown_plus_c : MonoBehaviour
{
    //足す値をインスペクター上で指定
    public int plus = 1;

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

        //+値が0になるまでJudgeで足す
        while (p != 0)
        {
            judger.GetComponent<Judge>().Pc1();
            --p;
        }
        
        this.gameObject.SetActive(false);
    }
}
