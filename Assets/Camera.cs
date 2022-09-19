using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{   
    public float sensitivity;
    public float rotateHorizontal,rotateVertical;

    private void Update() {

        rotateHorizontal = rotateHorizontal + Input.GetAxis ("Mouse X");
        rotateVertical = rotateVertical - Input.GetAxis ("Mouse Y");
        
        transform.eulerAngles = new Vector3(rotateVertical*1, rotateHorizontal*1,0f);

    }
}
