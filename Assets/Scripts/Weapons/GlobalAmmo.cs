using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
  public static int M4A1Ammo;
  public GameObject ammoDisplay;

    // Update is called once per frame
    void Update()
    {
    ammoDisplay.GetComponent<Text>().text = "" + M4A1Ammo;
    }
}
