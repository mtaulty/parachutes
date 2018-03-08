using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour, IInputClickHandler {

    public GameObject prefabToCreate;


    void Start () {
        InputManager.Instance.AddGlobalListener(this.gameObject);
	}
    public void OnInputClicked(InputClickedEventData eventData)
    {
        var newInstance = GameObject.Instantiate(this.prefabToCreate);

        newInstance.transform.position =
            Camera.main.transform.position +
            Camera.main.transform.forward * 2.0f;
    }
}
