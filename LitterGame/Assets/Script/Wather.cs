/// <summary>
/// 水管
/// </summary>
public class Wather : BackgroundObject
{
    public void Start()
    {
        
    }

    public void Update()
    {
        move(mySelf, gm.speed_w);
    }

    //離開畫面才刪除
    //物件上需要有Mesh Renderer
    private void OnBecameInvisible()
    {
        //等待幾秒刪除
        Invoke("destroyMyself", deathTime);
    }

    //相機看到時呼叫
    private void OnBecameVisible()
    {
        
    }


}
