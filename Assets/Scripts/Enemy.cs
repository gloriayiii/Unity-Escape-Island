using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private UnityEngine.AI.NavMeshAgent enemy;

    public Transform PlayerTarget;

    void Start()
    {
        enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(PlayerTarget.position);
    }
}
