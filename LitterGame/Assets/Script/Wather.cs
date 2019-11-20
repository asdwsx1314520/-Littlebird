/// <summary>
/// 水管
/// </summary>
public class Wather : BackgroundObject
{
    public void Start()
    {
        Invoke("destroyMyself", deathTime);
    }

    public void Update()
    {
        move(mySelf, speed);
    }
}
