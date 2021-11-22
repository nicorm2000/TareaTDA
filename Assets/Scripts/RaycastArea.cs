using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastArea : MonoBehaviour
{
    [SerializeField] float rangeOfView;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangeOfView);
    }
}
