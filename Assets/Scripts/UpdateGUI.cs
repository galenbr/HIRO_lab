using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;


public class UpdateGUI : MonoBehaviour
{
    TextMeshProUGUI posDisp;
    TextMeshProUGUI orDisp;
    Camera playerHead;
    Vector3 currentPos;
    Vector3 currentOr;
    public GameObject cube;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        posDisp = GameObject.Find("Positions").GetComponent<TextMeshProUGUI>();
        posDisp.text = "Test";
        orDisp = GameObject.Find("Orientations").GetComponent<TextMeshProUGUI>();
        orDisp.text = "Test";
        playerHead = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = playerHead.transform.position;
        currentOr = playerHead.transform.eulerAngles;
        posDisp.SetText("X = {0:2}\nY = {1:2}\n Z = {2:2}", currentPos[0], currentPos[1], currentPos[2]);
        orDisp.SetText("R = {0:2}\nP = {1:2}\n Y = {2:2}", currentOr[0], currentOr[1], currentOr[2]);
        cube.transform.eulerAngles = currentOr;
        // cube.transform.Rotate(currentOr*-1, Space.World);
        cube.transform.position = currentPos;
        cube.transform.Translate(Vector3.forward, Space.Self);
        sphere.transform.localPosition = currentPos*0.1f;
        sphere.transform.localEulerAngles = currentOr;
        
    }
}
