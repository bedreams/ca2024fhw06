using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotate : MonoBehaviour
{
    public Vector3 initialRotation; // �_�l���ਤ��
    public float rotationSpeed = 25.0f; // ����t��
    private float currentZAngle;     // ��eZ�b���ਤ��
    private bool isIncreasing = true; // �O�_���ץ��b�W�[

    // Start is called before the first frame update
    void Start()
    {
        // �]�m���骺��l���ਤ��
        transform.rotation = Quaternion.Euler(initialRotation);
        rotationSpeed = 25.0f; // �o�̳]�m��l����t��
        // ��l��Z�b�����׬���l�]�w����
        currentZAngle = initialRotation.z;
    }
    void Update()
    {
        // �ھڤ�V��s��eZ�b����
        if (isIncreasing)
        {
            currentZAngle += rotationSpeed * Time.deltaTime;
            if (currentZAngle >= 0f)
            {
                currentZAngle = 0f;
                isIncreasing = false; // ��V����
            }
        }
        else
        {
            currentZAngle -= rotationSpeed * Time.deltaTime;
            if (currentZAngle <= -90f)
            {
                currentZAngle = -90f;
                isIncreasing = true; // ��V����
            }
        }

        // ��s���骺����A�O��X�MY�b���ܡA�ȭק�Z�b
        transform.rotation = Quaternion.Euler(initialRotation.x, initialRotation.y+90, currentZAngle);
    }
}
