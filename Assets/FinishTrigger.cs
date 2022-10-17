using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{

    public GameObject playerModel;
    public GameObject youWinText;
  
    void Start()
    {
        playerModel = GameObject.FindGameObjectWithTag("Player");
        youWinText = GameObject.FindGameObjectWithTag("Finish");
        youWinText.SetActive(false); 
    }



    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            youWinText.SetActive(true);
            Debug.Log("triggered)");
        }
    }
}
