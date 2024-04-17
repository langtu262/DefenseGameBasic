using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float atkRate;
    private Animator anim;
    private bool isAttack;
    private float currentAttack;

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
        if(currentAttack >= 0 )
        {
            currentAttack -= Time.deltaTime;
            if (currentAttack <= 0 ) 
            {
                isAttack= false;
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


}
