# C# Interfaces in Unity – IShape

A small Unity project demonstrating C# interfaces. A shared `IShape` interface is implemented by three shape classes, and their methods are tested through Unity's `Start()` method with output printed to the Console.

## What it does

- Defines an `IShape` interface holding the methods all shapes share: `CalculateArea()` and `CalculatePerimeter()`.
- Implements `IShape` in three classes, each with its own calculation logic and one shape-specific method:
  - **Trapezium** – `CalculateUnknownSides()`
  - **Circle** – `CalculateRadius()`
  - **Nonagon** – `CalculateNumberOfSides()`
- Creates one of each shape in `Start()`, calls their methods, and prints the results using `Debug.Log()`.

## How to run

1. Open the project in Unity.
2. Open the main scene.
3. Make sure the `InterfaceTestScript` is attached to a GameObject in the scene.
4. Press **Play** and check the **Console** window for the printed output.

## Project structure

```
Assets/
└── Scripts/
    └── Interfaces/
        └── InterfaceTestScript.cs
```

All code lives in `InterfaceTestScript.cs`: the interface, the three shape classes, and the test script.
