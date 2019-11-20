using UnityEngine;

public class BackgroundObject : MonoBehaviour
{
    [Header("物件")]
    public Transform mySelf;

    [Header("速度")]
    public float speed;

    [Header("死亡時間")]
    public float deathTime;

    /// <summary>
    /// 物體移動
    /// </summary>
    /// <param name="obj">要移動的物件</param>
    /// <param name="speed">移動的速度</param>
    public void move(Transform obj, float speed)
    {
        obj.Translate(-speed, 0, 0);
    }

    public void destroyMyself()
    {
        Destroy(gameObject);
    }
}
