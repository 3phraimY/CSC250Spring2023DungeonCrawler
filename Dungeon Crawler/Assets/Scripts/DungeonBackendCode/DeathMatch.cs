using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class DeathMatch
{
    private Inhabitant dude1;
    private Inhabitant dude2;
    private GameObject dude1GO;
    private GameObject dude2GO;
    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO)
    {
        this.dude1 = dude1;
        this.dude2 = dude2;
        this.dude1GO = dude1GO;
        this.dude2GO = dude2GO;
    }
    public IEnumerator fight()
    {
        //goes back and forth having our Inhabitatnts "try" to attack each other
        // a successful attack means that a D20 is ata least as high as the target's AC
        // upon successful attack, the target's HP reduce by the attackers Attack
        // an unsuccessful attack results in no change in HP
        // go back and forth like this until an inhabitant dies
        while (this.dude1.getHP() > 0 && this.dude2.getHP() > 0)
        {
            int roll = 0;
            //dude1 attacks
            this.dude1GO.GetComponent<Renderer>().material.color = Color.red;
            yield return new WaitForSeconds(2);
            roll = UnityEngine.Random.Range(1, 21);
            if(roll > this.dude2.getAC())
            {
                this.dude2.setHP(this.dude2.getHP() - this.dude1.getDamage());
                if(this.dude2.getHP() <= 0)
                {
                    this.dude2GO.SetActive(false);
                    break;
                }
            }
            this.dude1GO.GetComponent<Renderer>().material.color = Color.white;
            //dude2 attacks
            this.dude2GO.GetComponent<Renderer>().material.color = Color.red;
            yield return new WaitForSeconds(2);
            roll = UnityEngine.Random.Range(1, 21);
            if (roll > this.dude1.getAC())
            {
                this.dude1.setHP(this.dude2.getHP() - this.dude2.getDamage());
                if (this.dude1.getHP() <= 0)
                {
                    this.dude1GO.SetActive(false);
                    break;
                }
            }
            this.dude2GO.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
