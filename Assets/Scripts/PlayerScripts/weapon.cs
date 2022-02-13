using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

	public Transform firePoint;
	public GameObject bulletPrefab;

	public bool PowerActive;

	public HealthScript healthScript;
	public ScoreScript scoreScript;

	// Update is called once per frame

	void Start()
    {
		
    }

	void Update()
	{


		if( healthScript.currentHealth == 1)
        {
			PowerActive = false;
        }

		
		
            if(PowerActive && Input.GetKeyDown(KeyCode.L))
            {
				Shoot();
			}
			
		
	}




	void Shoot()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}


	public void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.collider.tag == "PowerFlower")
		{
			PowerActive = true;
			Destroy(collision.collider.gameObject);
			
		}

	
	}

}

