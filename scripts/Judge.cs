using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public int SorF = 0;
    public int CorP = 0;

    public string cakeA;
    public string cakeB;
    public string cakeF;

    public string whipA;
    public string whipB;

    public string Perfect;
    public string Clear;
    public string Bad;

    GameObject cA;
    GameObject cB;
    GameObject cF;
    GameObject wA;
    GameObject wB;

    GameObject P;
    GameObject C;
    GameObject B;

    void Start()
    { // パーツを取得して非表示
        cA = GameObject.Find(cakeA);
        cA.SetActive(false);

        cB = GameObject.Find(cakeB);
        cB.SetActive(false);

        cF = GameObject.Find(cakeF);
        cF.SetActive(false);

        wA = GameObject.Find(whipA);
        wA.SetActive(false);

        wB = GameObject.Find(whipB);
        wB.SetActive(false);

        P = GameObject.Find(Perfect);
        P.SetActive(false);

        C = GameObject.Find(Clear);
        C.SetActive(false);

        B = GameObject.Find(Bad);
        B.SetActive(false);
    }
 
    //ボタン側で呼び出される、判定値を変更
    public void Pc1()
    {//+1
        SorF += 1;
        Debug.Log(SorF);
    }

    public void Mc1()
    {
        SorF -= 1;
        Debug.Log(SorF);
    }

    public void Pw1()
    {//+1
        CorP += 1;
        Debug.Log(CorP);
    }

    public void Mw1()
    {//-1
        CorP -= 1;
        Debug.Log(CorP);
    }

    void OnMouseDown()
    {
        if(SorF == 7)
        {
            cA.SetActive(true);
        }
        else if(SorF == 17)
        {
            cB.SetActive(true);
        }
        else
        {
            cF.SetActive(true);
        }

        if (CorP == 3 && (SorF == 7 || SorF == 17))
        {
            wA.SetActive(true);
            wB.SetActive(true);
            P.SetActive(true);
        }
        else if (CorP == 1 && (SorF == 7 || SorF == 17))
        {
            wA.SetActive(true);
            P.SetActive(true);
        }

        else if(CorP == 2 && (SorF == 7 || SorF == 17))
        {
            wB.SetActive(true);
            C.SetActive(true);
        }
        else
        {
            B.SetActive(true);
        }
    } 
}
