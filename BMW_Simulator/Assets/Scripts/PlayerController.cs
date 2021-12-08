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

    }

    private void FixedUpdate()
    {
        _rd.AddForce(Vector3.forward * Time.fixedDeltaTime * _speed);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.fixedDeltaTime * 20.0f);

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.fixedDeltaTime * _turnSpeed;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, 20.0f, 0.0f), Time.fixedDeltaTime * 20.0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.fixedDeltaTime * _turnSpeed;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0.0f, -20.0f, 0.0f), Time.fixedDeltaTime * 20.0f);
        }
    }

}