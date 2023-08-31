using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MazeClear : MonoBehaviour
{
    public bool isMaze1;
    public bool isMaze2;
    public bool isMaze3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.name == "Player")
        {
            Debug.Log("Player entered finish line");
            if(isMaze1)
            {
                SceneManager.LoadScene("Maze 2");
            }
            if(isMaze2)
            {
                SceneManager.LoadScene("Maze 3");
            }
            if(isMaze3)
            {
                SceneManager.LoadScene("Deadend");
            }
        }
    }
}
