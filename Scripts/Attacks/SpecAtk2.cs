using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecAtk2 : Move {
    [SerializeField]
    public Animator Spec2ATK;
    [SerializeField]
    public string anim;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void Spec1() {
        Spec2ATK.Play(anim);


    }
}
