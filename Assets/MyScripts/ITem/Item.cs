using System;
/// <summary>
///
/// </summary>
[Serializable]  
class Item
{

    public Item(int id, float ridius, float integral)
    {
        id = this.id;
        ridius = this.radius;
        integral = this.integral;

    }
    public Item()
    {
        
    }
    public int id;
    public string imageName;    //图片ID
    public float radius = 0;    //元素的半径
    public float integral = 0;  //元素这个元素的基础积分
}
