using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int HP = 3;
    Animator enemyAnim;
    public AudioSource hitSound;
    public static int total = 3;

    void Start()
    {
        Debug.Log(total);
        enemyAnim = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("weapon")) {
            hitSound.Play();
            other.GetComponent<Collider>().enabled = false;
            HP--;
            if(HP<=0){
                GetComponent<Collider>().enabled = false;
                enemyAnim.Play("Die");
                total--;
                Debug.Log(total);
            }
            else{
                enemyAnim.Play("Get Hit", -1, 0f);
            }
        }
    }

    public void remove(){
        transform.gameObject.SetActive(false);
    } 
}
