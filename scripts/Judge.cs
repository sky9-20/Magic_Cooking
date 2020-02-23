using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    private int which_spongecake = 0;
    private int which_topping = 0;

    public string cakeA_freshcream;
    public string cakeB_chocolate;
    public string cakeZ_bad;

    public string toppingA_banana;
    public string toppingB_strawberry;

    public string Perfect;
    public string Clear;
    public string Bad;

    GameObject cake_freshcream;
    GameObject cake_chocolate;
    GameObject cake_bad;
    GameObject topping_banana;
    GameObject topping_strawberry;

    //クリア分岐ボタン
    GameObject P;
    GameObject C;
    GameObject B;

    void Start()
    { // パーツを取得して非表示
        cake_freshcream = GameObject.Find(cakeA_freshcream);
        cake_freshcream.SetActive(false);

        cake_chocolate = GameObject.Find(cakeB_chocolate);
        cake_chocolate.SetActive(false);

        cake_bad = GameObject.Find(cakeZ_bad);
        cake_bad.SetActive(false);

        topping_banana = GameObject.Find(toppingA_banana);
        topping_banana.SetActive(false);

        topping_strawberry = GameObject.Find(toppingB_strawberry);
        topping_strawberry.SetActive(false);

        P = GameObject.Find(Perfect);
        P.SetActive(false);

        C = GameObject.Find(Clear);
        C.SetActive(false);

        B = GameObject.Find(Bad);
        B.SetActive(false);

      // 判定値をリセット
        which_spongecake = 0;
        which_topping = 0;
    }
 
    //ボタン側で呼び出される、判定値を変更
    public void Pc1()
    {//+1
        which_spongecake += 1;
        //Debug.Log("which_spongecake: " + which_spongecake);
    }

    public void Mc1()
    {
        which_spongecake -= 1;
        //Debug.Log("which_spongecake: " + which_spongecake);
    }

    public void Pw1()
    {//+1
        which_topping += 1;
        //Debug.Log("which_topping: " + which_topping);
    }
        
    public void Mw1()
    {//-1
        which_topping -= 1;
        //Debug.Log("which_topping: " + which_topping);
    }

    void OnMouseDown()
    {
        if(which_spongecake == 7)
        {
            cake_freshcream.SetActive(true);
        }
        else if(which_spongecake == 17)
        {
            cake_chocolate.SetActive(true);
        }
        else
        {
            cake_bad.SetActive(true);
        }

        if (which_topping == 3 && (which_spongecake == 7 || which_spongecake == 17))
        {
            topping_banana.SetActive(true);
            topping_strawberry.SetActive(true);
            P.SetActive(true);
        }
        else if (which_topping == 1 && (which_spongecake == 7 || which_spongecake == 17))
        {
            topping_banana.SetActive(true);
            P.SetActive(true);
        }

        else if(which_topping == 2 && (which_spongecake == 7 || which_spongecake == 17))
        {
            topping_strawberry.SetActive(true);
            C.SetActive(true);
        }
        else
        {
            B.SetActive(true);
        }
    } 
}
