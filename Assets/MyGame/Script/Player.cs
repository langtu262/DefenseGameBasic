using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
namespace KienIT.Gameplay
{
    
    public class Player : MonoBehaviour

    {
        
        [SerializeField] float TimeAtack;
        private bool attacking = false;
        private Animator r_Anim;
        private int idAttacking;
        private float currenAttack;


        private void Awake()
        {
            r_Anim = GetComponent<Animator>();
            idAttacking = Animator.StringToHash("Attacking");
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(currenAttack);

            if (Input.GetMouseButtonDown(0) && r_Anim != null && currenAttack <= 0)
            {
                r_Anim.SetBool(idAttacking, true);
                attacking = true;
                currenAttack = TimeAtack;
            }
            
            if (currenAttack > 0)
            {
               currenAttack = currenAttack - Time.deltaTime;
            }
        }
        public void ResetAttack()
        {
            if(r_Anim != null)
            {
                r_Anim.SetBool(idAttacking, false);
            }
        }
    }
}
