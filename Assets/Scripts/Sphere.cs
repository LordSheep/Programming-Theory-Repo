using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        shapeName = "Sphere";
        shapeColor = "Red";
    }

    protected override void DisplayText() // POLYMORPHISM // ABSTRACTION
    {
        printedText.text = "I am a red sphere and I have no faces";
    }
}
