using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WolfHime;
public class UImanager : MonoBehaviour {
    public static UImanager _Instance = null;
    WolfHime.GameManager manager = null;



    private void Awake()
    {
        _Instance = this;
        manager = WolfHime.GameManager._Instance;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnSwitchAutoShotButtonClick()
    {
        WolfHime.GameManager._Instance.SwitchAutoShot();
    }

    public void OnBoomButtonClick()
    {
        WolfHime.GameManager._Instance.Boom();
    }
}
