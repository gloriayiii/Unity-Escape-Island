using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectable : MonoBehaviour
{
    public int paddles;
    public Text collectnum;
    public AudioSource getsound;
    public GameObject GameWinPanel;
    public GameObject wolf1;
    public GameObject wolf2;
    public GameObject wolf3;
    public GameObject Finishchar;
    public GameObject FinishCam;
    public GameObject Mainchar;
    public GameObject boat;
    public GameObject destroyboat;
    public GameObject CountPanel;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "paddle")
        {
            Debug.Log("Collected!");
            paddles = paddles + 1;
            collectnum.text = "Collect number " + paddles.ToString() + "/5";
            // Col.gameObject.SetActive(false);
            getsound.Play();
            Destroy(Col.gameObject);
        }

    }

    IEnumerator FinishCut()
    {
        yield return null;
        GameWinPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(paddles == 5)
        {
            Destroy(wolf1);
            Destroy(wolf2);
            Destroy(wolf3);
            Destroy(destroyboat);
            Destroy(CountPanel);
            FinishCam.SetActive(true);
            Finishchar.SetActive(true);
            Mainchar.SetActive(false);
            boat.SetActive(true);
        }

    }

}
