using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
namespace kienIT.DefenseGame {
    public class Enemy : MonoBehaviour
    {
        [SerializeField] float speed;
        [SerializeField] float atkDistance;
        private Rigidbody2D rb;
        private Animator anim;
        private Player player;
        private bool isDead;
        private GameManager m_gm;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            m_gm = FindObjectOfType<GameManager>();
        }
        // Start is called before the first frame update
        void Start()
        {
            player = FindObjectOfType<Player>();
        }

        // Update is called once per frame
        void Update()
        {
            if (rb == null || player == null) return;
            if (Vector2.Distance(player.transform.position, transform.position) <= atkDistance && !isDead)
            {
                rb.velocity = Vector2.zero;
                anim.SetBool(Const.Attack_anim, true);
            }
            else if(!isDead) 
            {
                anim.SetBool(Const.Attack_anim, false);
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
         //   Debug.Log(_Gm.Score);
        }
        public void Die()
        {
            if (anim != null)
            {
                anim.SetTrigger(Const.Dead_anim);
                isDead = true;
                if(m_gm != null)
                {
                    m_gm.Score++;
                }
                Destroy(gameObject,1);
            }
        }
    }
}
