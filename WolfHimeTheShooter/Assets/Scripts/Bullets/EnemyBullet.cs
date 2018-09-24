using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WolfHime.Enemy
{
    public class EnemyBullet : MonoBehaviour
    {
        public Vector2 Direction;
        public float speed;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {
            this.transform.Translate(Direction * speed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                GameManager._Instance.HurtPlayer();
                Destroy(this.gameObject);
            }
        }
    }

}
