using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 6.0F;
    [SerializeField] private float _jump = 8.0F;
    [SerializeField] private float _gravity = 20.0F;
    private Vector3 _moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _moveDirection = transform.TransformDirection(_moveDirection);
            _moveDirection *= _speed;
            if (Input.GetButton("Jump"))
                _moveDirection.y = _jump;
        }

        _moveDirection.y -= _gravity * Time.deltaTime;
        controller.Move(_moveDirection * Time.deltaTime);
    }
}
