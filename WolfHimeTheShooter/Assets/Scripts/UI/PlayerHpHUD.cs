using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace WolfHime.UI
{
    public class PlayerHpHUD : MonoBehaviour
    {
        public int HpImgForNum;
        Image hpImg;
        private void Awake()
        {
            hpImg = this.GetComponent<Image>();
        }
        // Update is called once per frame
        void Update()
        {
            if (GameManager._Instance.PlayerHp >= HpImgForNum)
                hpImg.enabled = true;
            else
                hpImg.enabled = false;
        }
    }

}
