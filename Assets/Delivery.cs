using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float timeDelay = 1;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1,1);
    

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Package"  && !hasPackage)
        {
            Debug.Log("Da nhat tui hang");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, timeDelay);
        }
        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Da giao hang cho anh khach");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
        
    }
}
