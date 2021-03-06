﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WolfHime.Item
{
    [RequireComponent(typeof(Collider2D))]
    public class ItemBase : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                GotByPlayer();
                Destroy(this.gameObject);
            }
        }

        protected virtual void GotByPlayer()
        {
            
        }
    }

}
