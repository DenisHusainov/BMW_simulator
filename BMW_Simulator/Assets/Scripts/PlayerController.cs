using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rd;
    [SerializeField] private float _speed = default;
    [SerializeField] private float _turnSpeed = default;
    [SerializeField] private Button _rightArrow;
    [SerializeField] private Button _leftArrow;


    private void Awake()
    {
        _rd = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rd.AddForce(Vector3.right * _turnSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rd.AddForce(Vector3.left * _turnSpeed);
        }
    }
    private void FixedUpdate()
    {
        _rd.AddForce(Vector3.forward * _speed * Time.fixedDeltaTime);
        Move();
    }

    public void Move()
    {
        
    }

    
}