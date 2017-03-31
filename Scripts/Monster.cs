using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class Monster : MonoBehaviour {

    public float healthCurrent, healthMax;

    [Range(5, 10)]
    public float power;

    [SerializeField]
    protected int mana;

    [SerializeField]
    protected Type type;

    [SerializeField]
    protected Move[] attacks;

    [SerializeField]
    public Animator anim;
    [SerializeField]
    public string animationname;
    protected int player;

    public int side;

    public bool Ready;

    public TrackableBehaviour TrackMate;

    public Slider slid;

    public void Start() {
        anim = GetComponent<Animator>();
        TrackMate = GetComponent<TrackableBehaviour>();
        Debug.Log("Boo");
        slid = GetComponentInChildren<Slider>();
        slid.maxValue = healthMax;
    }

    public void Update() {
        //if(Camera.main)
        CheckSide();
        CheckStatus();
        slid.value = healthCurrent;
        
    }

    public void TakeDamage(float damage) {
        healthCurrent -= damage;
        anim.Play(animationname);
    }

    private void CheckSide() {
        if (transform.position.x > 0) {
            side = 1;
        } else if (transform.position.x < 0) {
            side = -1;
        }
    }


    private void CheckStatus() {
        if (TrackMate.CurrentStatus == TrackableBehaviour.Status.DETECTED ||
           TrackMate.CurrentStatus == TrackableBehaviour.Status.TRACKED ||
           TrackMate.CurrentStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
            Ready = true;
        }else {
            Ready = false;
        }
    }


}


public enum Type {
    Fire, Earth, Water
}
