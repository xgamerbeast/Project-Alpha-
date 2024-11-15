using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xBound = 5.0f;
    private GameManager gameManager;


    void Start()
    {
        // Find and assign the GameManager object
        gameManager = FindObjectOfType<GameManager>();
    }


    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // Restrict player movement within bounds
        float clampedX = Mathf.Clamp(transform.position.x, -xBound, xBound);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meteor"))
        {
            gameManager.GameOver ();
        }
        
    }
  }