using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(3);
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }
}
