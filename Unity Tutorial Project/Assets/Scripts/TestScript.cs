using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //Editor Vairables
    [SerializeField]
    string editorString = "HELLO!!!";
    // Start is called before the first frame update
    void Start()
    {
        string firstString = "You Shall not PASS!!!";
        string secondString = "Fly, you fools...";
        string combinedString = firstString + " " + secondString;

        Debug.Log(firstString);
        Debug.Log(secondString);
        Debug.Log(combinedString);
        Debug.Log(editorString);
    }
}
