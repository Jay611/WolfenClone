using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M4A1PickUp : MonoBehaviour
{
  public GameObject realM4A1;
  public GameObject fakeM4A1;
  public AudioSource M4A1PickUpSound;
  public GameObject pickUpDisplay;

  void OnTriggerEnter(Collider other)
  {
    realM4A1.SetActive(true);
    fakeM4A1.SetActive(false);
    M4A1PickUpSound.Play();
    GetComponent<BoxCollider>().enabled = false;
    pickUpDisplay.SetActive(false);
    pickUpDisplay.GetComponent<Text>().text = "M4A1";
    pickUpDisplay.SetActive(true);
  }
}
