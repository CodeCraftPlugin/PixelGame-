using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource FinishSound;
    private bool finised = false;
     // Start is called before the first frame update
    private void Start()
    {
        FinishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player"&&!finised)
        {
            FinishSound.Play();
            Invoke("PassLevel", 2f);
            finised = true;
        }
        
    }
    public  void PassLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}