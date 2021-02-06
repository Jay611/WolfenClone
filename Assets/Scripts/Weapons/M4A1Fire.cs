using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4A1Fire : MonoBehaviour
{
  public GameObject theM4A1;
  public GameObject muzzleFlash;
  public AudioSource gunFire;
  public bool isFiring = false;

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      if (isFiring == false)
      {
        StartCoroutine(FireM4A1());
      }
    }
  }

  IEnumerator FireM4A1()
  {
    isFiring = true;
    theM4A1.GetComponent<Animator>().Play("M4A1Fire");
    muzzleFlash.SetActive(true);
    gunFire.Play();
    yield return new WaitForSeconds(0.05f);
    muzzleFlash.SetActive(false);
    yield return new WaitForSeconds(0.45f);
    theM4A1.GetComponent<Animator>().Play("New State");
    isFiring = false;
  }
}
