using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;
namespace WolfHime.Enemy
{
    public class EnemyBase : MonoBehaviour,Ihurt
    {
        public float Hp;
        public UnityAction OnDieAction;
        public GameObject destroyFX;

        SpriteRenderer spRender;

        private void Awake()
        {
            spRender = this.GetComponent<SpriteRenderer>();
        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Die()
        {
            Instantiate(destroyFX).transform.position = this.transform.position;
            if (OnDieAction != null)
                OnDieAction();

            Destroy(this.gameObject);
        }

        public void TakeHurt(float damage)
        {
            this.Hp -= damage;
            if (this.Hp < 0)
                Die();
        }

    }

}
