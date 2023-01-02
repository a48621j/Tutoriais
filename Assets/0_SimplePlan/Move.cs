﻿using UnityEngine;

public class Move : MonoBehaviour {

    public Vector3 goal = new Vector3(5, 0, 4);
    public float speed = 0.1f;

    void Start() {
        goal = goal * 0.01f;
    }

    void Update() {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}
