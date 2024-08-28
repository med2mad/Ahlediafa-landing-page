using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{   
    public Animator anim;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("attack1") && !anim.GetCurrentAnimatorStateInfo(0).IsName("attack2")) {return ;}

        if (other.gameObject.name=="enemy") {
            other.transform.position += new Vector3(0, 0, 30f);
        }

    }
}
