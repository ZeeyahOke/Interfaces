using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// The interface only declares the methods EVERY shape shares.
// Area and Perimeter are common to all shapes, so they belong here.
// Shape-specific methods (radius, sides, etc.) stay in their own classes.
public interface IShape
{
    float CalculateArea();
    float CalculatePerimeter();
}

public class Trapezium : IShape
{
    public void CalculateUnknownSides()
    {

    }

    public void CalculateArea()
    {

    }

    public void CalculatePerimeter()
    {
        
    }
}

public class Circle : IShape
{
    public void CalculateArea()
    {
        
    }

    public void CalculateRadius()
    {

    }

    public void CalculatePerimeter()
    {
        
    }
}

public class Nonagon : IShape
{
    int numberOfSides;

    public void CalculateArea()
    {
        
    }

    public void CalculatePerimeter()
    {
        
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}
