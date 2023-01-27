using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    // [SerializeField] private Transform resapawnPoint;

    public void onTriggerEnter(Collider other)
    {
        // player.transform.position = resapawnPoint.transform.position;
        SceneManager.LoadScene(1);
    }
}
