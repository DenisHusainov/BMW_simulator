using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroung : MonoBehaviour
{
    [SerializeField] private Material[] _skyMaterials;

    private void Awake()
    {
        GetComponent<Skybox>().material = _skyMaterials[Random.Range(0, _skyMaterials.Length)];
    }



}
