using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoundManager : MonoBehaviour {

    Move p1move, p2move;
    bool p1ready, p2ready;

    public GameObject p1r, p2r;

    Monster p1, p2;

    PlayerCheck pc;


    // Use this for initialization
    void Start() {
        pc = GameObject.FindObjectOfType<PlayerCheck>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void P1Read(Move p1Attack) {
        p1move = p1Attack;
        p1ready = true;
        p1 = pc.leftC;
        p1r.SetActive(true);
        StatusCheck();
    }

    public void P1OUCH() {
        p1move = null;
        p1ready = false;
        p1 = null;
        p1r.SetActive(false);
    }

    public void P2Read(Move p2Attack) {
        p2move = p2Attack;
        p2ready = true;
        p2 = pc.rightC;
        p2r.SetActive(true);
        StatusCheck();
    }
    public void P2OUCH() {
        p2move = null;
        p2ready = false;
        p2 = null;
        p2r.SetActive(false);
    }
    public void StatusCheck() {
        if (p1ready && p2ready) {
            if (p1move.speed > p2move.speed) {
                //p1attacks.anim0ation("Attack animation")
                p2.TakeDamage(p1.power * p1move.multiplier);
                checkIfAlive(p2);
                p1.TakeDamage(p2.power * p2move.multiplier);
                checkIfAlive(p1);

            } else if (p2move.speed >= p1move.speed) {
                //p2attacks.animation("Attack animation")
                p1.TakeDamage(p2.power * p2move.multiplier);
                checkIfAlive(p1);
                p2.TakeDamage(p1.power * p1move.multiplier);
                checkIfAlive(p2);

            }
            P1OUCH();
            P2OUCH();
        }
       
    }
    public void checkIfAlive(Monster player) {
        if (player.healthCurrent <= 0) {
            Destroy(player.gameObject);
        }
        //if p1Health.currentHealth >= 0
        //something something dead
        //else
        //mana + 20
    }
}
