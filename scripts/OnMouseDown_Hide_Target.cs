using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Hide_Target : MonoBehaviour
{
    public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
    GameObject hideObject;

    // Start is called before the first frame update
    void Start()
    {
        hideObject = GameObject.Find(targetObjectName);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        hideObject.SetActive(false); // 表示
    }
}
