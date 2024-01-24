using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class QuarterView : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Vector3 _location;

    private void Update()
    {
        transform.position = _target.position + _offset;
        transform.localRotation = Quaternion.Euler(_location);
    }
}
