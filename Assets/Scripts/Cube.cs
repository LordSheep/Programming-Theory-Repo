using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        shapeName = "Cube";
        shapeColor = "Blue";
    }

    protected override void DisplayText() // POLYMORPHISM // ABSTRACTION
    {
        printedText.text = "I am a blue cube and I have six faces";
    }
}
