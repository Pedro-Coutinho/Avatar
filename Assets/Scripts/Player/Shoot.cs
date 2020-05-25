﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
            FindObjectOfType<AudioManager>().Play("Shoot");
        }
    }
    void shoot ()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
