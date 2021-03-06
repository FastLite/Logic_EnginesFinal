﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabTablet : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        //bool isKine = transform.GetComponent<Rigidbody>().isKinematic;
        if (other.CompareTag("Player") && transform.parent.GetComponent<Rigidbody>().isKinematic == false)
        {
            if(Input.GetKey(KeyCode.E))
            {
                GameManager.Instance.helpMessageTextField.gameObject.SetActive(false);
                TellScriptToDropTablet.instance.PutTabletInHand();
                GameManager.Instance.hasTablet = true;
                Destroy(transform.parent.gameObject);
            }     
        }
    }
}
