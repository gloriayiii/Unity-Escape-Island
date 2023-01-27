using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject player;
    public Animator enemyAnimator;
    public float damage = 20f;
    bool follow = false;
    public float distance;
    // [SerializeField] public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection (Vector3.forward),out hit,distance))
        {
            if(hit.transform.gameObject == player)
            {
                follow = true;            
                Debug.Log("detect");
            }
            
        }
        else
        {
            // Debug.Log("No detect");
        }
        if(follow)
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().destination = player.transform.position;
            enemyAnimator.SetBool("isRunning",true);
            // if(GetComponent<UnityEngine.AI.NavMeshAgent>().velocity.magnitude > 1)
            // {
            //     enemyAnimator.SetBool("isRunning",true);
            // }
            // else
            // {
            //     enemyAnimator.SetBool("isRunning",false);
            // }
        }
        else
        {
            enemyAnimator.SetBool("isRunning",false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == player)
        {
            Debug.Log("Player hit!");
            player.GetComponent<PlayerManager>().Hit(damage);
        }
    }
}
