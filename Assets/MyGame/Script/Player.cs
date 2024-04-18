using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace kienIT.DefenseGame {
    public class Player : MonoBehaviour
    {
        [SerializeField] float atkRate;
        private Animator anim;
        private bool isAttack;
        private float currentAttack;
        public float health = 100f;
        public bool isDead;

        // Start is called before the first frame update
        private void Awake()
        {
            currentAttack = atkRate;
        }
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            
            if (Input.GetMouseButtonDown(0) && !isAttack)
            {
                if (anim != null)
                {
                    anim.SetBool(Const.Attack_anim, true);
                    isAttack = true;
                }
            }
            if (currentAttack >= 0)
            {
                currentAttack -= Time.deltaTime;
                if (currentAttack <= 0)
                {
                    isAttack = false;
                    currentAttack = atkRate;
                }
            }

        }
        public void ResetAttack()
        {
            if (anim != null)
            {
                anim.SetBool(Const.Attack_anim, false);
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(Const.EnemyWeapon_tag) && !isDead) 
            {
                Debug.Log("da va cham");
                anim.SetTrigger(Const.Dead_anim);
                isDead = true;
            }
        }

    }
}
