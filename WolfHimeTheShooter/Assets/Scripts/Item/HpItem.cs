using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WolfHime.Item
{
    public class HpItem : ItemBase
    {
        public Vector2 Direction;

        private void FixedUpdate()
        {
            this.transform.Translate(Direction * Time.deltaTime*2);
            Direction += new Vector2(0, -Time.deltaTime*2);
        }

        protected override void GotByPlayer()
        {
            base.GotByPlayer();
            GameManager._Instance.HealPlayer(1);
        }
    }

}
