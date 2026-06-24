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
    // The two parallel sides, the height, and one slanted leg.
    float parallelSideA = 8f;
    float parallelSideB = 4f;
    float height = 3f;
    float legC = 5f;
 
    // Unique to Trapezium: estimate the unknown slant leg using Pythagoras
    // (horizontal offset between the parallel sides, plus the height).
    public float CalculateUnknownSides()
    {
        float offset = parallelSideA - parallelSideB;
        return Mathf.Sqrt((offset * offset) + (height * height));
    }
 
    // Area of a trapezium = 1/2 x (sum of parallel sides) x height
    public float CalculateArea()
    {
        return 0.5f * (parallelSideA + parallelSideB) * height;
    }
 
    // Perimeter = all four sides added together.
    public float CalculatePerimeter()
    {
        float legD = CalculateUnknownSides();
        return parallelSideA + parallelSideB + legC + legD;
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
