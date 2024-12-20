using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotate : MonoBehaviour
{
    public Vector3 initialRotation; // 起始旋轉角度
    public float rotationSpeed = 25.0f; // 旋轉速度
    private float currentZAngle;     // 當前Z軸旋轉角度
    private bool isIncreasing = true; // 是否角度正在增加

    // Start is called before the first frame update
    void Start()
    {
        // 設置物體的初始旋轉角度
        transform.rotation = Quaternion.Euler(initialRotation);
        rotationSpeed = 25.0f; // 這裡設置初始旋轉速度
        // 初始化Z軸的角度為初始設定的值
        currentZAngle = initialRotation.z;
    }
    void Update()
    {
        // 根據方向更新當前Z軸角度
        if (isIncreasing)
        {
            currentZAngle += rotationSpeed * Time.deltaTime;
            if (currentZAngle >= 0f)
            {
                currentZAngle = 0f;
                isIncreasing = false; // 方向改變
            }
        }
        else
        {
            currentZAngle -= rotationSpeed * Time.deltaTime;
            if (currentZAngle <= -90f)
            {
                currentZAngle = -90f;
                isIncreasing = true; // 方向改變
            }
        }

        // 更新物體的旋轉，保持X和Y軸不變，僅修改Z軸
        transform.rotation = Quaternion.Euler(initialRotation.x, initialRotation.y+90, currentZAngle);
    }
}
