using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WolfHime
{
    public class RollingBackground : MonoBehaviour
    {
        public float RollSpeed;
        public float reposY;
        public float originY;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            this.transform.Translate(Vector2.down * RollSpeed * Time.deltaTime,Space.World);
            if (this.transform.localPosition.y <= reposY)
            {
                this.transform.localPosition = new Vector3(this.transform.localPosition.x, originY, this.transform.localPosition.z);
            }
        }
    }

}
