using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FightSceneSetup : MonoBehaviour
{
    private string Monster1Name, Monster2Name, PlayerName;
    private int Monster1HP, Monster1AC, Monster1DMG, Monster2HP, Monster2AC, Monster2DMG, PlayerHP, PlayerAC, PlayerDMG;
    public TextMeshProUGUI Monster1NameGUI, Monster1HPGUI, Monster1ACGUI, Monster1DMGGUI, Monster2NameGUI, Monster2HPGUI, Monster2ACGUI, Monster2DMGGUI, PlayerNameGUI, PlayerHPGUI, PlayerACGUI, PlayerDMGGUI;
    // Start is called before the first frame update
    void Start()
    {
        this.Monster1HP =  Random.Range(10, 20);
        this.Monster1AC= Random.Range(10, 17);
        this.Monster1DMG= Random.Range(1, 5);
        this.Monster2HP= Random.Range(10, 20);
        this.Monster2AC= Random.Range(10, 17);
        this.Monster2DMG= Random.Range(1, 5);
        this.PlayerHP= Random.Range(10, 20);
        this.PlayerAC= Random.Range(10, 17);
        this.PlayerDMG= Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {

        this.Monster1HPGUI.text = "HP: " + Monster1HP;
        this.Monster1ACGUI.text = "AC: " + Monster1AC;
        this.Monster1DMGGUI.text = "DMG: " + Monster1DMG;
        this.Monster2HPGUI.text = "HP: " + Monster2HP;
        this.Monster2ACGUI.text = "AC: " + Monster2AC;
        this.Monster2DMGGUI.text = "DMG: " + Monster2DMG;
        this.PlayerHPGUI.text = "HP: " + PlayerHP;
        this.PlayerACGUI.text = "AC: " + PlayerAC;
        this.PlayerDMGGUI.text = "DMG: " + PlayerDMG;
    }
}
