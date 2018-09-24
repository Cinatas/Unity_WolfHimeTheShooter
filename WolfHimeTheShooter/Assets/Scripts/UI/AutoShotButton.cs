using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WolfHime.UI
{
    public class AutoShotButton : MonoBehaviour
    {
        Button btn;

        private void Awake()
        {
            btn = this.GetComponent<Button>();
        }

        // Use this for initialization
        void Start()
        {
            btn.onClick.AddListener(() =>
            {
                UImanager._Instance.OnSwitchAutoShotButtonClick();
            });
        }
    }

}
