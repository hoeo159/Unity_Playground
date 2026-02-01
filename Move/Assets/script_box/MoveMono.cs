using UnityEngine;
using UnityEngine.InputSystem;

public class MoveMono : MonoBehaviour
{
    public Transform childTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // childTransform = transform.GetChild(0);
        transform.position = new Vector3(0, -1, 0);
        childTransform.localPosition = new Vector3(0, 2, 0);

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current != null && Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }
        if(Keyboard.current != null && Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
        if(Keyboard.current != null && Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }
        if(Keyboard.current != null && Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
        }

    }
}
