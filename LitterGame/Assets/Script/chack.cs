using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chack : MonoBehaviour
{
    [Header("跳耀高度"),Range(0,10)]
    public float jumpHeight;

    [Header("是否死亡"),Tooltip("當腳色死亡時遊戲會停止")]
    public bool isDathe;

    //宣告遊戲控制器與分數畫面
    public GameObject score, onGm;

    //宣告一個鋼體物件
    public Rigidbody2D myHeor;

    //給予一個轉速
    public float angle;

    public void Update()
    {
        jump();
    }

    /// <summary>
    /// 跳耀高度
    /// </summary>
    public void jump ()
    {
        if (isDathe) return;

        //點擊滑鼠左鍵時
        if (Input.GetMouseButtonDown(0))
        {
            //開啟分數
            score.SetActive(true);
            //開啟遊戲控制器物件
            onGm.SetActive(true);
            
            //重置重力(因為由於重力會累加導致每次向上跳時阻力都不同)
            myHeor.Sleep();
            //控制重力(將重力由0改為1)
            myHeor.gravityScale = 1;
            //給予一個向上的推力
            myHeor.AddForce(new Vector2(0, jumpHeight));
        }
        //判斷角色向上與向下的關係 以改變旋轉角度(0以上為向上 0以下為向下)
        myHeor.SetRotation(angle * myHeor.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Pain")
        {
            print("腳色死亡");
            gameOver();
        }
        print(123);
    }

    /// <summary>
    /// 死亡
    /// </summary>
    public void gameOver()
    {
        isDathe = true;
    }

    /// <summary>
    /// 通過水管
    /// </summary>
    public void pass()
    {

    }
}
