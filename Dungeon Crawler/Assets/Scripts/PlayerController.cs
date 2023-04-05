using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;
    private bool isMoving;
    public GameObject westStart;
    public GameObject southStart;
    public GameObject eastStart;
    public GameObject northStart;
    private bool reachedCenter;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        this.isMoving = false;
        //this.reachedCenter = false;
        if(!MasterData.whereDidIComeFrom.Equals("?"))
        {
            
            if(MasterData.whereDidIComeFrom.Equals("north"))
            {
                this.gameObject.transform.position = this.southStart.transform.position;
                this.rb.AddForce(Vector3.forward * 150.0f);
            }
            else if(MasterData.whereDidIComeFrom.Equals("south"))
            {
                this.gameObject.transform.position = this.northStart.transform.position;
                this.rb.AddForce(Vector3.back * 150.0f);
            }
            else if (MasterData.whereDidIComeFrom.Equals("east"))
            {
                this.gameObject.transform.position = this.westStart.transform.position;
                this.rb.AddForce(Vector3.right * 150.0f);
            }
            else if (MasterData.whereDidIComeFrom.Equals("west"))
            {
                this.gameObject.transform.position = this.eastStart.transform.position;
                this.rb.AddForce(Vector3.left * 150.0f);
            }
            //this.gameObject.transform.position = this.westStart.transform.position;
        }
        /*if(MasterData.whereDidIComeFrom.Equals("west"))
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
        }*/

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("center"))
        {
            this.rb.velocity = Vector3.zero;
            this.rb.angularVelocity = Vector3.zero;
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Exit") && MasterData.isExiting)
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
        else if(other.gameObject.CompareTag("Exit") && !MasterData.isExiting)
        {
            MasterData.isExiting = true;
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

        /*if (this.transform.position == new Vector3(0, 0.5f, 0) && !this.reachedCenter && true)
        {
            this.rb.velocity = new Vector3(0,0,0);
            this.isMoving = false;
            this.reachedCenter = true;
            print("works");
        }
        Vector3 spaceInbetween = new Vector3(0,0,0);
        if(this.reachedCenter == false && reachedCenter == false)*/
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
            //this.rb.MovePosition(new Vector3(0,0.5f,0));
            //this.rb.AddForce(new Vector3(0, 0.5f, 0) * Time.deltaTime);


        }
        /*else
        {
            this.rb.velocity = Vector3.zero;
        }*/
    }
}