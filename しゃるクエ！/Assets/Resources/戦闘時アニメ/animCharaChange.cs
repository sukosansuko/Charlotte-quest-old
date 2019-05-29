﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animCharaChange : MonoBehaviour
{
    public Image image;
    public Sprite sp1;
    public Sprite sp2;
    public Sprite sp3;
    public Sprite sp4;
    public Sprite sp5;
    public Sprite sp6;

    public int imageCnt;

    // Start is called before the first frame update
    void Start()
    {
        imageCnt = 1;
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeImage();
        }
        switch (imageCnt)
        {
            case 1:
                image.sprite = sp1;
                break;
            case 2:
                image.sprite = sp2;
                break;
            case 3:
                image.sprite = sp3;
                break;
            case 4:
                image.sprite = sp4;
                break;
            case 5:
                image.sprite = sp5;
                break;
            case 6:
                image.sprite = sp6;
                break;
        }

        if (imageCnt > 6)
        {
            imageCnt = 1;
        }
    }

    public void ChangeImage()
    {
        imageCnt++;
    }
}
