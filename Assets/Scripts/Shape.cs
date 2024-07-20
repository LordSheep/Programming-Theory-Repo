using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public abstract class Shape : MonoBehaviour // INHERITANCE
{
    // Used Dan's comment with "[field: SerializeField]" to help expose properties to inspector:
    // https://stackoverflow.com/questions/40554418/in-unity-can-i-expose-c-sharp-properties-in-the-inspector-window
    [field: SerializeField] public string shapeName { get; protected set; } // ENCAPSULATION
    [field: SerializeField] public string shapeColor { get; protected set; } // ENCAPSULATION

    [SerializeField] protected TextMeshProUGUI printedText; 

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Moused pressed");
            DisplayText();
        }
    }

    protected abstract void DisplayText(); // POLYMORPHISM // ABSTRACTION 
}
