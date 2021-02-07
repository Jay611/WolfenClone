using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4A1Fire : MonoBehaviour
{
  public GameObject theM4A1;
  public GameObject muzzleFlash;
  public AudioSource gunFire;
  public bool isFiring = false;
  public AudioSource emptySound;
  public float targetDistance;
  public int damageAmount = 5;

  void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      if (GlobalAmmo.M4A1Ammo < 1)
      {
        emptySound.Play();
      }
      else
      {
        if (isFiring == false)
        {
          StartCoroutine(FireM4A1());
        }
      }
    }
  }

  IEnumerator FireM4A1()
  {
    RaycastHit theShot;
    isFiring = true;
    GlobalAmmo.M4A1Ammo--;
    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theShot))
    {
      targetDistance = theShot.distance;
      theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
    }
    theM4A1.GetComponent<Animator>().Play("M4A1Fire");
    muzzleFlash.SetActive(true);
    gunFire.Play();
    yield return new WaitForSeconds(0.05f);
    muzzleFlash.SetActive(false);
    yield return new WaitForSeconds(0.25f);
    theM4A1.GetComponent<Animator>().Play("New State");
    isFiring = false;
  }
}
