using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KienIT.Gameplay
{

    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D speedMove;
        private Player player;
        void Start()
        {
            speedMove = GetComponent<Rigidbody2D>();
            player = FindObjectOfType<Player>();
        }

        // Update is called once per frame
        void Update()
        {
       
        }
    }
}
