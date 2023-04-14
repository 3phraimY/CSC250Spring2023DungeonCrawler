using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FightSceneSetup : MonoBehaviour
{
    public TextMeshProUGUI Monster1Name, Monster1HP, Monster1AC, Monster1DMG, Monster2Name, Monster2HP, Monster2AC, Monster2DMG, PlayerName, PlayerHP, PlayerAC, PlayerDMG;
    // Start is called before the first frame update
    void Start()
    {
        this.Monster1HP.text = "HP: " + Random.Range(10, 20);
        this.Monster1AC.text = "AC: " + Random.Range(10, 17);
        this.Monster1DMG.text = "DMG: " + Random.Range(1, 5);
        this.Monster2HP.text = "HP: " + Random.Range(10, 20);
        this.Monster2AC.text = "AC: " + Random.Range(10, 17);
        this.Monster2DMG.text = "DMG: " + Random.Range(1, 5);
        this.PlayerHP.text = "HP: " + Random.Range(10, 20);
        this.PlayerAC.text = "AC: " + Random.Range(10, 17);
        this.PlayerDMG.text = "DMG: " + Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
