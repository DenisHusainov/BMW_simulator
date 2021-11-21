using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rd;
    [SerializeField] private float _speed = default;
    [SerializeField] private float _turnSpeed = 10f;
    [SerializeField] private Button _rightArrow;
    [SerializeField] private Button _leftArrow;


    private void Awake()
    {
        _rd = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        _rd.AddForce(Vector3.forward * _speed * Time.fixedDeltaTime);
    }

    public void Move()
    {
        if (_rightArrow)
        {
            _rd.AddForce(Vector3.right * _turnSpeed * Time.deltaTime);
        }
        if (_leftArrow)
        {
            _rd.AddForce(Vector3.left * _turnSpeed * Time.deltaTime);
        }
    }

    
}
