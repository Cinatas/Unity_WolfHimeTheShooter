using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WolfHime
{
    public class BulletWeapon : MonoBehaviour
    {

        public BulletBase bullet;
        GameObject bulletPrefab;
        public float shootSpeed;

        private void Awake()
        {
            bulletPrefab = Resources.Load<GameObject>("Bullets/BlueBullet");
            bullet = bulletPrefab.GetComponent<BulletBase>();
        }

        // Use this for initialization
        void Start()
        {

            shootSpeed = bullet.ShootSpeed;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Fire()
        {
            Instantiate(bulletPrefab).transform.position = this.transform.position;
        }
    }

}
