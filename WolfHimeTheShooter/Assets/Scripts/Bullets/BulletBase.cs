using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WolfHime
{
    [RequireComponent(typeof(Collider2D))]
    public class BulletBase : MonoBehaviour
    {

        public float Damage;
        public float Speed;
        public Vector2 Direction;
        public float ShootSpeed;
        public GameObject hitExpFX;
        public float hitExpRate;
        protected void FixedUpdate()
        {
            this.transform.Translate(Direction * Time.deltaTime * Speed);
        }

        protected void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                Ihurt hurt = collision.GetComponent<Ihurt>();
                if (hurt != null)
                    hurt.TakeHurt(this.Damage);
                if (hitExpFX != null)
                {
                    int random = Random.Range(0, 100);
                    if(random<(hitExpRate*100))
                        Instantiate(hitExpFX).transform.position = this.transform.position;
                }
                Destroy(this.gameObject);
            }
        }
    }

}
