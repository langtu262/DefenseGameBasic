using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace kienIT.DefenseGame
{
    public class Weapon : MonoBehaviour
    {
        private Enemy enemy;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            if (collision.CompareTag(Const.Enemy_tag))
            {
                enemy = collision.GetComponent<Enemy>();
                if (enemy != null ) 
                {
                    enemy.Die();
                }
               
            }
        }
    }
}
