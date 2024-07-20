using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        shapeName = "Cylinder";
        shapeColor = "Yellow";
    }

    protected override void DisplayText() // POLYMORPHISM // ABSTRACTION
    {
        printedText.text = "I am a yellow cylinder and I have 0 faces";
    }
}
