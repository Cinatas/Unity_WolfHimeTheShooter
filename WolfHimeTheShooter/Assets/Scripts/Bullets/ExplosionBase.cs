using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WolfHime
{
    public class ExplosionBase : MonoBehaviour
    {
        public void OnAnimationDone()
        {
            Destroy(this.gameObject);
        }      

    }

}
