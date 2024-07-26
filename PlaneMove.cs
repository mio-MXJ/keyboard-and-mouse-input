using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///用键盘鼠标输入
/// <summary>

public class PlaneMove : MonoBehaviour
{
    public float MoveSpeed = 10;
    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        if(hor!=0||ver!=0)
        {
            Movement(hor, ver);
        }
        
    }

    private void Movement(float hor,float ver)
    {
        hor *= MoveSpeed * Time.deltaTime;
        ver *= MoveSpeed * Time.deltaTime;
        //位置的改变语句（牢计）
        this.transform.Translate(hor, 0, ver);
    }
   
}
