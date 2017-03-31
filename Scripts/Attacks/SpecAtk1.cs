using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecAtk1 : Move {
    [SerializeField]
    public Animator Spec1ATK;
    [SerializeField]
    public string anim;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void Spec1() {
        Spec1ATK.Play(anim);


    }
}
