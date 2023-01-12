using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChecPoint : MonoBehaviour
{
    //public GameObject flag;
    //Vector3 spawnPoint;
    private SaveManager saveManager;
    
    // Start is called before the first frame update
    void Start()
    {
        //spawnPoint = gameObject.transform.position;
        saveManager = GameObject.Find("Player").GetComponent<SaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("CheckPoint"))
        {
            Debug.Log("Bandera");
            //spawnPoint = flag.transform.position;
            saveManager.Bandera();
        }
    }
}
