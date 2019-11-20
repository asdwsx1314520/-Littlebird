using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int number;

    [Header("最佳分數")]
    public int nowNumber;

    [Header("水管")]
    public Object papi;

    /// <summary>
    /// 增加分數
    /// </summary>
    /// <param name="value">要給的數值</param>
    public void addNumber(int value)
    {

    }

    /// <summary>
    /// 最佳分數
    /// </summary>
    /// <param name="value">最佳數值</param>
    public void heightNumber(int value)
    {

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

    public void Start()
    {
        //born();
        InvokeRepeating("born", 0, 2);
    }

    
}
