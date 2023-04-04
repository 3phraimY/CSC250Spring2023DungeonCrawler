using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;
    private bool isMoving;
    private bool reachedCenter;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        MasterData md = new MasterData();
        this.isMoving = true;
        this.reachedCenter = false;
        if(MasterData.whereDidIComeFrom.Equals("west"))
        {
            this.transform.position = new Vector3(3.8f, 0.5f, 0);
            this.rb.MovePosition( new Vector3(0, 0.5f, 0));
        }
        if (MasterData.whereDidIComeFrom.Equals("east"))
        {
            this.transform.position = new Vector3(-3.8f, 0.5f, 0);
        }
        if (MasterData.whereDidIComeFrom.Equals("north"))
        {
            this.transform.position = new Vector3(0, 0.5f, -3.8f);
        }
        if (MasterData.whereDidIComeFrom.Equals("south"))
        {
            this.transform.position = new Vector3(0, 0.5f, 3.8f);
        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Exit"))
        {
            if (other.gameObject == this.northExit)
            {
                MasterData.whereDidIComeFrom = "north";
            }
            else if (other.gameObject == this.southExit)
            {
                MasterData.whereDidIComeFrom = "south";
            }
            else if (other.gameObject == this.eastExit)
            {
                MasterData.whereDidIComeFrom = "east";
            }
            else if (other.gameObject == this.westExit)
            {
                MasterData.whereDidIComeFrom = "west";
            }
            SceneManager.LoadScene("DungeonRoom");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed);
            this.isMoving = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.westExit.transform.position * movementSpeed);
            this.isMoving = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
            this.isMoving = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed);
            this.isMoving = true;
        }

        if (this.transform.position == new Vector3(0, 0.5f, 0) && !this.reachedCenter && true)
        {
            this.rb.velocity = new Vector3(0,0,0);
            this.isMoving = false;
            this.reachedCenter = true;
            print("works");
        }
        Vector3 spaceInbetween = new Vector3(0,0,0);
        if(this.reachedCenter == false && reachedCenter == false)
        {
          //  if(MasterData.whereDidIComeFrom == "east" || MasterData.whereDidIComeFrom == "north")
          //  {
           //     spaceInbetween = this.rb.position - new Vector3(0, 0.5f, 0);
           // }
           // else
           // {
            //    spaceInbetween = this.rb.position + new Vector3(0, 0.5f, 0);
            //}
            //this.rb.MovePosition(this.transform.position + spaceInbetween.normalized * this.movementSpeed * Time.deltaTime);
            this.rb.MovePosition(new Vector3(0,0.5f,0));
        }
    }
}