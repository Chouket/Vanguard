﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    static private InputManager instance = null;
    static public InputManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = Instantiate(Resources.Load("Prefabs/Manager/InputManager")) as GameObject;
                instance = obj.GetComponent<InputManager>();
            }
            return instance;
        }
    }

    void Start ()
    {
	
	}


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            InitRayCast();
    }

    private void InitRayCast()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            //Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
            //  Debug.Log("LayerMask name: " + LayerMask.LayerToName(hit.collider.gameObject.layer));
            if (LayerMask.LayerToName(hit.collider.gameObject.layer) == "Card")
            {
                hit.collider.gameObject.GetComponent<BaseCard>().CardSelect();

            }
        }
    }
}
