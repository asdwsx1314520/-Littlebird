using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pint : MonoBehaviour
{
    [Header("地板")]
    public Transform plane;

    [Header("天空")]
    public Transform sky;

    [Header("地板移動速度"),Range(0,10)]
    public float p_speed;

    [Header("天空移動速度"), Range(0, 10)]
    public float s_speed;

    /// <summary>
    /// 地版移動
    /// </summary>
    public void p_move()
    {

    }

    /// <summary>
    /// 天空移動速度
    /// </summary>
    public void s_move()
    {

    }
}
