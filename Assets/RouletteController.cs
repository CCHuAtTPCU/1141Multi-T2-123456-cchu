using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 旋轉速度

    void Start()
    {
        // 設定target frame rate = 60 FPS
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 設定旋轉速度
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // 旋轉處理
        transform.Rotate(0, 0, this.rotSpeed);

        // 減速處理
        this.rotSpeed *= 0.95f;
    }
}
