using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KienIT.Gameplay
{
    
    public class Player : MonoBehaviour

    {
        private Animator r_Anim;

        private void Awake()
        {
            r_Anim = GetComponent<Animator>();
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Input.GetMouseButtonDown(0);
            {

            }
        }
    }
}
