using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 30f;
 
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            Debug.Log("Tang toc");
            moveSpeed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
        moveSpeed = slowSpeed;
    }
}
