using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///第一人称摄像头的视角
/// <summary>

public class cameramove : MonoBehaviour
{
    public float rotateSpeed = 1;
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        //鼠标没动时，不调用保持原样
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
        //左右旋转需要沿世界坐标
        this.transform.Rotate(0, x, 0,Space.World);
    }
}
