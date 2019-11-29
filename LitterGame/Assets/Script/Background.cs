/// <summary>
/// 背景物件
/// </summary>
public class Background : BackgroundObject
{
    public void Update()
    {
        move(mySelf, gm.speed_p);
    }
}
