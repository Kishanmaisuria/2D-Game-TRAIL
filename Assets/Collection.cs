using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;



public class Collection : MonoBehaviour
{

    private int Cher = 0;
    public AudioSource audioSource;



    [SerializeField] private Text CherTxt;
    [SerializeField] public AudioSource Item;






    // Start is called before the first frame update
    void Start()
    {
        
        


    }

    // Update is called once per frame
    void Update()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Reward")
        {

            Destroy(collision.gameObject);
            CherTxt.text = "Cherries:" + Cher;
            Cher += 1;
            Item.Play();

        }
        if (collision.tag == "END") 
        {
            SceneManager.LoadScene(3);
        }

        if (collision.tag == "EE")
        {
            //Deth.Play();

            SceneManager.LoadScene(3);

        }




    }
}
