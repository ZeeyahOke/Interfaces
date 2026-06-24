using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script tests the IShape interface by creating one of each shape,
// calling their methods, and printing the results to the Unity Console.
public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create one object of each shape class.
        Trapezium trapezium = new Trapezium();
        Circle circle = new Circle();
        Nonagon nonagon = new Nonagon();
 
        // --- Trapezium ---
        Debug.Log("---- Trapezium ----");
        Debug.Log("Unknown (slant) side: " + trapezium.CalculateUnknownSides());
        Debug.Log("Area: " + trapezium.CalculateArea());
        Debug.Log("Perimeter: " + trapezium.CalculatePerimeter());
 
        // --- Circle ---
        Debug.Log("---- Circle ----");
        Debug.Log("Radius: " + circle.CalculateRadius());
        Debug.Log("Area: " + circle.CalculateArea());
        Debug.Log("Perimeter (circumference): " + circle.CalculatePerimeter());
 
        // --- Nonagon ---
        Debug.Log("---- Nonagon ----");
        Debug.Log("Number of sides: " + nonagon.CalculateNumberOfSides());
        Debug.Log("Area: " + nonagon.CalculateArea());
        Debug.Log("Perimeter: " + nonagon.CalculatePerimeter());
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
    float diameter = 10f;
 
    // Unique to Circle: the radius is half the diameter.
    public float CalculateRadius()
    {
        return diameter / 2f;
    }
 
    // Area = PI x radius squared
    public float CalculateArea()
    {
        float radius = CalculateRadius();
        return Mathf.PI * radius * radius;
    }
 
    // Perimeter of a circle is its circumference = PI x diameter
    public float CalculatePerimeter()
    {
        return Mathf.PI * diameter;
    }
}

public class Nonagon : IShape
{
    // A nonagon has 9 sides. 
    int numberOfSides = 9;
    float sideLength = 4f;
 
    // Unique to Nonagon: return how many sides it has.
    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
 
    // Area of a regular polygon = (n x s^2) / (4 x tan(PI / n))
    public float CalculateArea()
    {
        return (numberOfSides * sideLength * sideLength)
               / (4f * Mathf.Tan(Mathf.PI / numberOfSides));
    }
 
    // Perimeter = number of sides x length of each side.
    public float CalculatePerimeter()
    {
        return numberOfSides * sideLength;
    }
}
