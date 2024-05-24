using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KienIT.Gameplay
{

    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float speedMove;
        private Player player;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            player = FindObjectOfType<Player>();
        }

        // Update is called once per frame
        void Update()
        {
            if (rb != null)
            {
                Debug.Log("da tim thay");
                rb.velocity = new Vector2(-speedMove, rb.position.y);
            }
        }
    }
}
