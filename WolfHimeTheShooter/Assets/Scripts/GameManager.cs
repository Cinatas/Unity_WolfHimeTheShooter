using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WolfHime
{
    public class GameManager : MonoBehaviour
    {

        public static GameManager _Instance = null;

        public int BoomCount = 3;
        public bool AutoShot = true;

        public int PlayerHp = 3;

        private void Awake()
        {
            _Instance = this;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public bool SwitchAutoShot()
        {
            return Player._Instance.SwitchAutoShot();
        }

        public int Boom()
        {
            if (BoomCount > 0)
            {
                BoomCount--;
                Player._Instance.Boom();
            }
            return BoomCount;
        }

        internal void GameOver()
        {
            
        }

        public void HurtPlayer()
        {
            PlayerHp--;
            if (PlayerHp < 0)
                PlayerDie();
        }

        public void PlayerDie()
        {
            Player._Instance.Die();
            GameOver();
        }

        public void HealPlayer(int heal)
        {
            this.PlayerHp += heal;
            if (PlayerHp > 5)
                PlayerHp = 5;
        }
    }

}
