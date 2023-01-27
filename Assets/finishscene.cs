using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishscene : MonoBehaviour
{
    public GameObject GameWinPanel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FinishCut());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator FinishCut()
    {
        Debug.Log("test5");
        yield return new WaitForSeconds(5f);
        Debug.Log("test3");
        GameWinPanel.SetActive(true);
        Debug.Log("test4");
    }
}
