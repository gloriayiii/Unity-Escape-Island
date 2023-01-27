using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float health = 100;
    // Start is called before the first frame update
    // public Text healthText;
    // [SerializeField] private Transform player;
    public static bool gameover;
    public GameObject GameoverPanel;
    public GameObject wolf1;
    public GameObject wolf2;
    public GameObject wolf3;
    public void Hit(float damage)
    {
        health -= damage;
        // healthText.text = "Health " + health.ToString();
        if(health<100)
        {
            gameover = true;
            GameoverPanel.SetActive(true);
            Destroy(wolf1);
            Destroy(wolf2);
            Destroy(wolf3);
            health = 100;
            // SceneManager.LoadScene(0);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

}
