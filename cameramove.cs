using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///��һ�˳�����ͷ���ӽ�
/// <summary>

public class cameramove : MonoBehaviour
{
    public float rotateSpeed = 1;
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        //���û��ʱ�������ñ���ԭ��
        if(x!=0||y!=0)
        {
            CameraMove(x, y);
        }
        
    }
    private void CameraMove(float x,float y)
    {
        x *= rotateSpeed;
        y *= rotateSpeed;
        this.transform.Rotate(-y,0,0);
        //������ת��Ҫ����������
        this.transform.Rotate(0, x, 0,Space.World);
    }
}
