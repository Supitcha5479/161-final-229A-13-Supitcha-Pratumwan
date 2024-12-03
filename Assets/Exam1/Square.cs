using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private float side = 50f;

    public void Init(string newNameConstuctor)
    {
        string shape1 = "Square";
        shape1 = newNameConstuctor;
    }
    public override float CalculateArea()
    {
        float answer = (float)(side * side);
        return answer;
    }
    public virtual void Resize()
    {
        Debug.Log($"Resize{shapeName}");
    }
    public void Draw()
    {
        int sizeShape = 5;
        Debug.Log($"{shapeName} side{sizeShape}");

    }

}
