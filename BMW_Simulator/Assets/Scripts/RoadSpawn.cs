using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Road _roadPrefab;

    private List<Road> _spawnedroads = new List<Road>(); 

    private void Spawner()
    {
        var newroad = Instantiate(_roadPrefab);
        newroad.transform.position = _spawnedroads[_spawnedroads.Count - 1]._end.position - newroad._begin.position;
        _spawnedroads.Add(newroad);
    }

}
