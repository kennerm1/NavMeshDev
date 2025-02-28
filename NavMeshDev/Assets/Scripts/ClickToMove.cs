using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    NavMeshAgent agent;

    void Start() => agent = GetComponent<NavMeshAgent>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray.origin, ray.direction, out var hitInfo))
            {
                Vector3 randomOffset = Random.insideUnitSphere * 0.5f;
                randomOffset.y = 0;
                agent.destination = hitInfo.point + randomOffset;
            }
        }
    }
}
