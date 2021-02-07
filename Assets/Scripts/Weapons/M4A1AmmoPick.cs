using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M4A1AmmoPick : MonoBehaviour
{
  public GameObject fakeAmmoClip;
  public AudioSource ammoPickUpSound;
  public GameObject pickUpDisplay;

  void OnTriggerEnter(Collider other)
  {
    fakeAmmoClip.SetActive(false);
    ammoPickUpSound.Play();
    GlobalAmmo.M4A1Ammo += 30;
    pickUpDisplay.SetActive(false);
    pickUpDisplay.GetComponent<Text>().text = "CLIP OF BULLETS";
    pickUpDisplay.SetActive(true);
  }
}
