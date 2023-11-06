using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoodDestroy : MonoBehaviour
{
    public int count;
    public Text scoreText;
    [SerializeField]
    private float delayBeforeLoading = 2f;


    private float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        scoreText.text = "Food Collected : " + count.ToString() + " / 30";

    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Foods")
        {
            FindObjectOfType<AudioManager>().Play("Food Collected");
            Destroy(collision.gameObject);
            count++;

        }
        if (collision.gameObject.name == "Hamburger (6)")
        {
            Destroy(collision.gameObject);
            count++;
            if (count >= 25)
            {
                SceneManager.LoadSceneAsync(3);
            }
            else
            {
                SceneManager.LoadSceneAsync(2);
            }




        }

    }

}
