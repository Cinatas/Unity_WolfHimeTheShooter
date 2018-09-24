using HedgehogTeam.EasyTouch;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WolfHime
{
    public class Player : MonoBehaviour
    {

        public static Player _Instance = null;
        QuickSwipe swipe;

        public Vector2 MinPos;
        public Vector2 MaxPos;

        bool autoShoot = true;

        BulletWeapon weapon;
        Coroutine ShootCoroutine;
        GameObject destroyFX;

        private void Awake()
        {
            _Instance = this;
            swipe = this.GetComponent<QuickSwipe>();
        }

        // Use this for initialization
        void Start()
        {
            swipe.onSwipeAction.AddListener(SwipeToMove);
            weapon = this.GetComponent<BulletWeapon>();
            ShootCoroutine = StartCoroutine(AutoShoot());
        }

        private void Update()
        {
            
        }

        void Move(Vector2 pos)
        {
            this.transform.position += new Vector3(pos.x, pos.y, 0);
        }

        void Restrict()
        {
            if (this.transform.position.x < MinPos.x)
                this.transform.position = new Vector3(MinPos.x, this.transform.position.y, this.transform.position.z);
            if (this.transform.position.x > MaxPos.x)
                this.transform.position = new Vector3(MaxPos.x, this.transform.position.y, this.transform.position.z);

            if (this.transform.position.y < MinPos.y)
                this.transform.position = new Vector3(this.transform.position.x, MinPos.y, this.transform.position.z);
            if (this.transform.position.y > MaxPos.y)
                this.transform.position = new Vector3(this.transform.position.x, MaxPos.y, this.transform.position.z);
        }

        void SwipeToMove(Gesture ges)
        {
            Move(ges.deltaPosition * 0.01f);
            Restrict();
        }

        IEnumerator AutoShoot()
        {
            while (true)
            {
                Shoot();
                yield return new WaitForSeconds(1f / weapon.shootSpeed);
            }
        }

        void Shoot()
        {
            if (weapon == null)
                return;
            weapon.Fire();
        }

        

        public bool SwitchAutoShot()
        {
            if (autoShoot)
            {
                autoShoot = false;
                StopCoroutine(ShootCoroutine);
            }
            else
            {
                autoShoot = true;
                ShootCoroutine = StartCoroutine(AutoShoot());
            }

            return autoShoot;
        }
        public void Boom()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Enemy") || collision.CompareTag("Killer"))
            {
                GameManager._Instance.HurtPlayer();
            }
        }

        public void Die()
        {
            Instantiate(destroyFX).transform.position = this.transform.position;
            Destroy(this.gameObject);
        }

    }

}
