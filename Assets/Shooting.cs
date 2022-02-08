using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject cursor;
    public Transform firePoint;
    public float speed = 10f;
    
    public GameObject weaponAndHands;
    //public GameObject meleeWeapon;
    
    
    void Update()
    {
        Vector2 direction = (cursor.transform.position - firePoint.transform.position).normalized;
        
        
        if (Input.GetMouseButtonDown(0))
        {
            var bullet2 = Instantiate (bullet, transform.position, transform.rotation);
            Rigidbody2D rb = bullet2.GetComponent<Rigidbody2D>();
            rb.AddForce(direction * speed, ForceMode2D.Impulse);
            Debug.Log("shooting");
            Debug.Log(rb.gameObject.name);
        }
        
        Turning();
    }
    
    private void Turning()
    {
        
            
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 playerPos = transform.position;

        Vector2 direct = new Vector2(mousePos.x - playerPos.x, mousePos.y - playerPos.y);
        

        if (mousePos.x > playerPos.x + 0.01f)
        {
            weaponAndHands.transform.right = direct;
            return;
        }

        if (mousePos.x < playerPos.x - 0.01f)
        {
            weaponAndHands.transform.right = -direct;
            return;
        }
        
    }

}
