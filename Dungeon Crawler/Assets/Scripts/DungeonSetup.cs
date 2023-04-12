using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit, southExit, eastExit, westExit;
    public bool northOn, southOn, eastOn, westOn;

    // Start is called before the first frame update
    void Start()
    {
        MasterData.setupDungeon();
        //Debug.Log(MasterData.p.getCurrentRoom().getName());
        northOn = MasterData.p.getCurrentRoom().hasExit("north");
        southOn = MasterData.p.getCurrentRoom().hasExit("south");
        eastOn = MasterData.p.getCurrentRoom().hasExit("east");
        westOn = MasterData.p.getCurrentRoom().hasExit("west");
        this.northExit.SetActive(northOn);
        this.southExit.SetActive(southOn);
        this.eastExit.SetActive(eastOn);
        this.westExit.SetActive(westOn);
        MasterData.setupDungeon();
    }

    // Update is called once per frame
    void Update()
    {

    }
}