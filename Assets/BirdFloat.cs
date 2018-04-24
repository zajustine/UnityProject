using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdFloat : MonoBehaviour {

    public float speed;
    
    private int coins;
    public Text text;   

    void Start()
    {
        coins = 0;
        updateCounter();
    }

    void Update() {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        GetComponent<Rigidbody2D>().AddForce(direction * speed);

      
    }

    void OnParticleCollision(GameObject other)
    {
        //if (other.CompareTag("coins"))
          //  Destroy(other.gameObject);
        coins++;
        updateCounter();

    }

    void updateCounter()
    {
        text.text = "score: " + coins;
    }
}
