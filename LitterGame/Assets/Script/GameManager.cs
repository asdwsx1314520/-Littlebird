using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform pain;

    public float f_paint_speed;

    public float f_chick_jump;

    public float b_chick_death;

    public int i_win_number;

    public int i_win_bast;


    void Start()
    {
        
    }
    
    void Update()
    {
        pain.Translate(-0.01f,0,0);
    }
}
