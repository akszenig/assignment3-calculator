# Assignment 3 – Basic Unit Testing

This repository contains solutions for **Assignment 3**, which is divided into two main parts involving C# programming and Unit Testing with NUnit.

## Project Overview

### Part 1: Shapes Project
A console application that calculates the **Area** and **Volume** for various geometric shapes. It includes an interface-based architecture and comprehensive unit tests.

* **Supported Shapes:** Sphere, Cylinder, Cube, Rectangle.
* **Key Features:**
    * Implementation of `IShape` interface.
    * Handling of 3D shapes (Volume & Area) and 2D shapes (Area only).
    * Unit tests covering calculation logic.

### Part 2: Calculator
A basic calculator implementation focusing on arithmetic operations and test coverage.

---

## Project Structure

The repository is organized into the following directories:

### Part 1 Files (Shapes)
* `tutorialPart1/` – Main console application containing shape logic (Sphere, Cube, etc.).
* `tutorialPart1_Tests/` – NUnit test project for validating shape calculations.

### Part 2 Files (Calculator)
* `Assignment/` – Calculator implementation code.
* `Assignment.Tests/` – NUnit tests for the calculator.

---

## Technologies Used
* **Language:** C#
* **Framework:** .NET
* **Testing Framework:** NUnit
* **IDE:** JetBrains Rider

---

## How to Run

### Prerequisites
* .NET SDK installed.
* JetBrains Rider (recommended) or Visual Studio.

### Steps to Run Tests
1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/akszenig/assignment3-calculator.git](https://github.com/akszenig/assignment3-calculator.git)
    ```
2.  Open the solution/folder in **JetBrains Rider**.
3.  **Build the solution** to restore dependencies.
4.  Open the **Unit Tests** window (usually at the bottom or via `View > Tool Windows > Unit Tests`).
5.  Click **Run All Tests**.

You should see passing tests for both the **Shapes Project** (Part 1) and the **Calculator** (Part 2).
