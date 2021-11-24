using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Road[] _roadPrefab;
    [SerializeField] private Road _firstPrefab;

    private List<Road> Spawnedroads = new List<Road>();

    private void Start()
    {
        Spawnedroads.Add(_firstPrefab);
    }

    private void Update()
    {
        if (_player.transform.position.z > Spawnedroads[Spawnedroads.Count - 1]._end.position.z - 10)
        {
            Spawner();
        }
    }


    private void Spawner()
    {
        var newroad = Instantiate(_roadPrefab[0]); 
        newroad.transform.position = Spawnedroads[Spawnedroads.Count - 1]._end.position - newroad._begin.localPosition;
        Spawnedroads.Add(newroad);

        if (Spawnedroads.Count > 30)
        {
            Debug.Log("Destroy");
            Destroy(Spawnedroads[0].gameObject);
            Spawnedroads.RemoveAt(0);
        }
    }

}
