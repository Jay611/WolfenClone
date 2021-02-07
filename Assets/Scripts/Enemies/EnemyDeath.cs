using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
  public int enemyHealth = 20;
  public bool enemyDeath = false;
  public GameObject enemyAI;
  public GameObject theEnemy;

  void DamageEnemy(int damageAmount)
  {
    enemyHealth -= damageAmount;
  }
  void Update()
  {
    if (enemyHealth <= 0 && enemyDeath == false)
    {
      enemyDeath = true;
      theEnemy.GetComponent<Animator>().Play("Death");
      enemyAI.SetActive(false);
    }
  }
}
