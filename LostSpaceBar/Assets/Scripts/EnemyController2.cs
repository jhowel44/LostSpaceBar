using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController2 : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(6);
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }
}
