using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float raidus = 10f;

    public void Init(string newNameConstuctor)
    {
        string shape2 = "Circle";
        shape2 = newNameConstuctor;
    }
    public override float CalculateArea()
    {
        float answer = (float)(raidus * raidus * 3.14);
        return answer;
    }
    public virtual void Resize()
    {
        Debug.Log($"Resize{shapeName}");
    }
    public void Draw()
    {
        int sizeShape = 2;
        Debug.Log($"{shapeName} side{sizeShape}");

    }
}
