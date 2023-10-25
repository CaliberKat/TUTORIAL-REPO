using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSDisplay : MonoBehaviour
{
    int frameCount = 0;
    Vector3 changingScale = new Vector3(1.0f,1.0f,1.0f);
    

    [SerializeField]
    string editorString = "Adventure Time";
    [SerializeField]
    float targetScale = 1.0f;
    [SerializeField]
    SpriteRenderer playerSprite;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frameCount = frameCount + 1;
        targetScale = targetScale + 0.01f;

        Debug.Log(frameCount);
        Debug.Log(targetScale);

        changingScale.x = targetScale;
        changingScale.y = targetScale;
        changingScale.z = targetScale;

        transform.localScale = changingScale;
    }
}
