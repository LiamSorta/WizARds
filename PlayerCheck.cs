using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class PlayerCheck : MonoBehaviour {
    Monster[] chars;

    public Monster leftC, rightC;

    [SerializeField]
    GameObject leftUI, rightUI;

    void Start() {
        chars = GameObject.FindObjectsOfType<Monster>();
    }

    private void Update() {
        leftC = null;
        rightC = null;

        foreach (Monster g in chars) {
            if (g.Ready && g.side == -1) {
                leftC = g;
            }
            if (g.Ready && g.side == 1) {
                rightC = g;
            }
        }


        if (leftC) {
            leftUI.SetActive(false);
        } else {
            leftUI.SetActive(true);
            GameObject.FindObjectOfType<RoundManager>().P1OUCH();
        }
        if (rightC) {
            rightUI.SetActive(false);
        } else {
            rightUI.SetActive(true);
            GameObject.FindObjectOfType<RoundManager>().P2OUCH();

        }
    }
}

