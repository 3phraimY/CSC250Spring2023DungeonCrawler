using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RefereeController : MonoBehaviour
{
    private Monster theMonster;
    public GameObject playerGO;
    public GameObject monsterGO;
    public TextMeshProUGUI monsterNameSB;
    public TextMeshProUGUI playerNameSB;
    public TextMeshProUGUI monsterSB;
    public TextMeshProUGUI playerSB;
    private DeathMatch theMatch;

    // Start is called before the first frame update
    void Start()
    {
        this.theMonster = new Monster("goblin");
        this.theMatch = new DeathMatch(MasterData.p, this.theMonster, this.playerGO, this.monsterGO);
        this.monsterNameSB.text = this.theMonster.getName();
        this.playerNameSB.text = MasterData.p.getName();
        StartCoroutine(this.theMatch.fight());       
    }

    // Update is called once per frame
    void Update()
    {
        this.monsterSB.text = this.theMonster.getData();
        this.playerSB.text = MasterData.p.getData();

    }
}
