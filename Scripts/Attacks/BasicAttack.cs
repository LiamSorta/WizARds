using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : Move {

    const float baseDamage = 10;
    [SerializeField]
    public Animator basicATK;
    [SerializeField]
    public string anim;

    public void Attack() {
        if (transform.position.x < 0) {
            GameObject.FindObjectOfType<RoundManager>().P1Read(this);
        }
        if(transform.position.x > 0) {
            GameObject.FindObjectOfType<RoundManager>().P2Read(this);
        }

	}

    public void Basic() {
         basicATK.Play(anim);
        Debug.Log("BASIC");
    }

}
