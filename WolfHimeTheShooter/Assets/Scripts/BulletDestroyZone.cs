﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyZone : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        //if (collision.CompareTag("Bullet"))
        //{
        //    Destroy(collision.gameObject);
        //}
    }
}
