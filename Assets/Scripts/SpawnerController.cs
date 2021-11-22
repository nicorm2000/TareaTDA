using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float distance;
    [SerializeField] private GameObject spawnerPoint;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastSpawner();
    }

    private void RaycastSpawner()
    {
        RaycastHit spawn;

        if (Physics.Raycast(spawnerPoint.transform.position, spawnerPoint.transform.TransformDirection(Vector3.back), out spawn, distance))
        {
            Debug.Log("SpawnEnemies");
        };

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(spawnerPoint.transform.position, spawnerPoint.transform.TransformDirection(Vector3.back) * distance);
    }
}