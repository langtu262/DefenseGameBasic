using kienIT.DefenseGame;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.WSA;
namespace kienIT.DefenseGame
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] float timeCreate;
        [SerializeField] Enemy[] enemyPrefabs;
        private bool isDead;

        private int m_score;

        public int Score
        {
            get { return m_score; }
            set { m_score = value; }
        }
        void Start()
        {
            StartCoroutine(CreateEnemy());
        }
        IEnumerator CreateEnemy()
        {
            while (isDead == false)
            {
                if (enemyPrefabs != null && enemyPrefabs.Length > 0)
                {
                    int RandIdx = Random.Range(0, enemyPrefabs.Length);
                    Enemy enemyPrefab = enemyPrefabs[RandIdx];
                    if (enemyPrefab != null)
                    {
                        Instantiate(enemyPrefab, new Vector3(7, 1, 0), Quaternion.identity);
                    }
                }
                yield return new WaitForSeconds(timeCreate);
            }
        }
        
    }
}
