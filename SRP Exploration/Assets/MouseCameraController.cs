using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraController : MonoBehaviour
{
    [SerializeField] float _sensitivity;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float minY;
    [SerializeField] float maxY;

    float mouseX;
    float mouseY;

    // Update is called once per frame
    void Update()
    {

        mouseX += Input.GetAxis("Mouse X") * (_sensitivity * Time.deltaTime);
        mouseY -= Input.GetAxis("Mouse Y") * (_sensitivity * Time.deltaTime);
        if(mouseX > maxX)
        {
            mouseX = minX + mouseX - maxX;
        }
        else if(mouseX < minX)
        {
            mouseX = maxX + (mouseX - minX);
        }
        
        mouseY = Mathf.Clamp(mouseY, minY, maxY);
        transform.rotation = Quaternion.Euler(mouseY, mouseX, 0.0f);
    }
}
