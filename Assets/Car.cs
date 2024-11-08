using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    float speed = 0;
    Vector2 startPos;

    void Start() {
    }

    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition; //將點擊滑鼠時的座標記錄起來
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition; //將放開滑鼠時的座標記錄起來
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength / 500.0f; //把滑動長度轉換成初始移動速度
        }


        transform.Translate(this.speed, 0, 0);  //移動
        this.speed *= 0.98f;                    //減速
    }
}