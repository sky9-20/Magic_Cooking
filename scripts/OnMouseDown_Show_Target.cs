﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Show_Target : MonoBehaviour
{
    public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
    GameObject showObject;

    // Start is called before the first frame update
    void Start()
    {
        showObject = GameObject.Find(targetObjectName);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        showObject.SetActive(true); // 表示
    }
}
