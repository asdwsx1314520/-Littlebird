using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //應用程式

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int number;

    [Header("最佳分數")]
    public int nowNumber;

    [Header("水管")]
    public GameObject papi;

    [Header("結算畫面")]
    public GameObject onFinally;

    [Header("水管速度")]
    public float speed_w;

    [Header("地板移動速度")]
    public float speed_p;

    [Header("ui分數")]
    public Text number_text;

    [Header("ui最佳分數")]
    public Text nowNumber_text;

    /// <summary>
    /// 增加分數
    /// </summary>
    /// <param name="value">要給的數值</param>
    public void addNumber(int value)
    {
        number += value;
        number_text.text = "" + number;

        heightNumber();
    }

    /// <summary>
    /// 最佳分數設定
    /// </summary>
    /// <param name="value">最佳數值</param>
    public void heightNumber()
    {
        if(number > nowNumber)
        {
            PlayerPrefs.SetInt("最佳分數", number);
        }
    }

    /// <summary>
    /// 水管生成
    /// </summary>
    public void born()
    {
        float point_y = Random.Range(1.0f, 2.5f);

        Vector2 v2 = new Vector2(5, point_y);

        //identity 等於0
        Instantiate(papi, v2, Quaternion.identity);
    }

    public void gameOver()
    {
        onFinally.SetActive(true);

        //水管停止生成
        CancelInvoke("born");

        speed_w = 0;
        speed_p = 0;
    }

    public void Start()
    {
        //設定解析度
        Screen.SetResolution(768, 1024, false);

        //born();
        InvokeRepeating("born", 0, 2);

        //紀錄
        nowNumber = PlayerPrefs.GetInt("最佳分數");
        nowNumber_text.text = "" + nowNumber;
    }

    /// <summary>
    /// 重來
    /// </summary>
    public void onRegame()
    {
        print("重來");

        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// 結束遊戲
    /// </summary>
    public void onExit()
    {
        print("結束遊戲");

        Application.Quit();
    }
    
}
