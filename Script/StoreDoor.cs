using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreDoor : MonoBehaviour
{
    public string nomeDaCena;
    public Collider2D coll;

     void Start()
    {
        //Collider Detection On
        coll = GetComponent<Collider2D>();
        coll.isTrigger = true;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            
            SceneManager.LoadScene(nomeDaCena);
        }
            
    }
    void Update()
    {
        
    }
}
