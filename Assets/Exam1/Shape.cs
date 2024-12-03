using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void Init(string newNameConstuctor)
    { 
        shapeName = newNameConstuctor;
    }
    public abstract float CalculateArea();
    public virtual void Resize()
    { 
        Debug.Log($"Resize{shapeName}");
    }
    public void Draw()
    { 
    }
   
}

