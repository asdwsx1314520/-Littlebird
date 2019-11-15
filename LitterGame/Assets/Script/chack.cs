using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chack : MonoBehaviour
{
    [Header("跳耀高度"),Range(0,10)]
    public float jumpHeight;

    [Header("是否死亡"),Tooltip("當腳色死亡時遊戲會停止")]
    public bool isDathe;


    /// <summary>
    /// 跳耀高度
    /// </summary>
    public void jump ()
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    public void gameOver()
    {

    }

    /// <summary>
    /// 通過水管
    /// </summary>
    public void pass()
    {

    }
}
