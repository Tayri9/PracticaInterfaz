using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{    
    public void ScaleUp()
    {
        LeanTween.scale(gameObject, new Vector3(1.2f, 1.2f, 1.2f), 0.2f);
    } 

    public void ScaleDown()
    {
        LeanTween.scale(gameObject, Vector3.one, 0.2f);
    }
}
