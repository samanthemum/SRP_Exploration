using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCameraComponent : MonoBehaviour
{
    [SerializeField] GameObject _firstPerson;
    [SerializeField] float _cameraVerticalOffset;
    Transform _cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        _cameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!_cameraTransform)
        {
            Debug.Log("Can't find camera transform");
            return;
        }

        Vector3 firstPersonPosition = _firstPerson.transform.position;
        Quaternion firstPersonRotation = _firstPerson.transform.rotation;

        // Update camera position accordingly
        _cameraTransform.position = new Vector3(firstPersonPosition.x, firstPersonPosition.y + _cameraVerticalOffset, firstPersonPosition.z);
        _cameraTransform.rotation = firstPersonRotation;
    }
}
