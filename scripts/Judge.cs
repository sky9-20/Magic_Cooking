using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public int which_cake = 0;
    public int whichi_decoration = 0;

    public string cakeA_freshcream;
    public string cakeB_chocolate;
    public string cakeZ;

    public string decorationA_banana;
    public string decorationB_strawberry;

    public string Perfect;
    public string Clear;
    public string Bad;

    GameObject cake_freshcream;
    GameObject cake_chocolate;
    GameObject cake_failed;
    GameObject banana;
    GameObject strawberry;

    GameObject P;
    GameObject C;
    GameObject B;

    void Start()
    { // パーツを取得して非表示
        cake_freshcream = GameObject.Find(cakeA_freshcream);
        cake_freshcream.SetActive(false);

        cake_chocolate = GameObject.Find(cakeB_chocolate);
        cake_chocolate.SetActive(false);

        cake_failed = GameObject.Find(cakeZ);
        cake_failed.SetActive(false);

        banana = GameObject.Find(decorationA_banana);
        banana.SetActive(false);

        strawberry = GameObject.Find(decorationB_strawberry);
        strawberry.SetActive(false);

        P = GameObject.Find(Perfect);
        P.SetActive(false);

        C = GameObject.Find(Clear);
        C.SetActive(false);

        B = GameObject.Find(Bad);
        B.SetActive(false);
    }
 
    //ボタン側で呼び出される、判定値を変更
    public void Pc1()
    {
        which_cake += 1;
        Debug.Log("which_cake: " + which_cake);
    }

    public void Pw1()
    {
        whichi_decoration += 1;
        Debug.Log("whichi_decoration: " + whichi_decoration);
    }

    
    void OnMouseDown()
    {
        if(which_cake == 7)
        {
            cake_freshcream.SetActive(true);
        }
        else if(which_cake == 17)
        {
            cake_chocolate.SetActive(true);
        }
        else
        {
            cake_failed.SetActive(true);
        }

        if (whichi_decoration == 3 && (which_cake == 7 || which_cake == 17))
        {
            banana.SetActive(true);
            strawberry.SetActive(true);
            P.SetActive(true);
        }
        else if (whichi_decoration == 1 && (which_cake == 7 || which_cake == 17))
        {
            banana.SetActive(true);
            P.SetActive(true);
        }

        else if(whichi_decoration == 2 && (which_cake == 7 || which_cake == 17))
        {
            strawberry.SetActive(true);
            C.SetActive(true);
        }
        else
        {
            B.SetActive(true);
        }
    } 
}
