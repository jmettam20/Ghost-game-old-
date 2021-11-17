using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormScript : MonoBehaviour
{

    public int health = 5;

    public float speed;

    public Transform[] moveSpots;
    private int radomSpot;
    public float startWaitTime; 

    private float waitTime;

    private float lastY;
    private float lastX;

    private Animator animator;

    public int moveRange;

    public Transform[] sequence1; 
    

    Transform NextPos;
    int NextPosIndex; 


    void Start() {
        waitTime = startWaitTime; 
        radomSpot = Random.Range(0,moveSpots.Length);
        animator = GetComponent<Animator>();
        NextPos = sequence1[0];
        radomSpot = Random.Range(0, 1);
    }
    void EarlyUpdate() {
        checkPosition();

        
    }

    void Update()
    {

        healthCheck();

        animation();

       

        squareSequence(); 
    }

    void healthCheck()
    {
        if (health <= 0)
        {

            PlayerLevel.instance.AddXP(10);
            Destroy(this.gameObject);
        }
    }

    void checkPosition() {
        lastY = transform.position.y;
        lastX = transform.position.x;

    }

    void squareSequence() {
        if (transform.position == NextPos.position)
        {
            NextPosIndex++;
            if (NextPosIndex >= sequence1.Length)
            {
                NextPosIndex = 0;
            }
            NextPos = sequence1[NextPosIndex];
        }
        else {
            transform.position = Vector3.MoveTowards(transform.position,NextPos.position,speed*Time.deltaTime);
        }
    }

   

    void animation() {

        animator.SetBool("Walking", true);


        if (NextPos.position.y > transform.position.y)
        {
            animator.SetFloat("MoveY", 1);
            animator.SetFloat("MoveX", 0);
        }
       

        if (NextPos.position.y < transform.position.y)
        {
            animator.SetFloat("MoveY", -1);
            animator.SetFloat("MoveX", 0);
        }
        

        if (NextPos.position.x > transform.position.x)
        {
            animator.SetFloat("MoveX", 1);
            animator.SetFloat("MoveY", 0);
        }
        

        if (NextPos.position.x < transform.position.x)
        {
            animator.SetFloat("MoveX", -1);
            animator.SetFloat("MoveY", 0);
        }
 
    }
}
