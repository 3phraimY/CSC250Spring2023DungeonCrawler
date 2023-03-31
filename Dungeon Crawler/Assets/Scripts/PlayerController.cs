using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(MasterData.moveYet == false)
            {
                this.rb.AddForce(this.northExit.transform.position * movementSpeed);
                MasterData.moveYet = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (MasterData.moveYet == false)
            {
                this.rb.AddForce(this.southExit.transform.position * movementSpeed);
                MasterData.moveYet = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (MasterData.moveYet == false)
            {
                this.rb.AddForce(this.westExit.transform.position * movementSpeed);
                MasterData.moveYet = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (MasterData.moveYet == false)
            {
                this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
                MasterData.moveYet = true;
            }
        }
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //MasterData.count++;
            //SceneManager.LoadScene("DungeonRoom");
        }
    }
}
