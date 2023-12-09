using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    [SerializeField] CharacterController _characterController;
    [SerializeField] float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!_characterController)
        {
            Debug.Log("No character controller to control!");
            return;
        }

        Vector3 forwardDirection = this.transform.forward;
        Vector3 rightDirection = this.transform.right;
        Vector3 movementDirection = rightDirection * Input.GetAxis("Horizontal") + forwardDirection * Input.GetAxis("Vertical");
        movementDirection = movementDirection.normalized;
        movementDirection.y = 0;
        _characterController.Move(movementDirection * _speed);
    }
}
