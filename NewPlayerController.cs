using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D playerRigidbody;
    private Vector3 change;
    private Animator animator;

     GameObject enemy;

    public float timeLeft = .1f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        energyLanceMelee();

        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

       

        updateAnimationANDmove();

        AttackCO();
        
    }

    void updateAnimationANDmove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();

            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void MoveCharacter()
    {
        playerRigidbody.MovePosition(transform.position + change.normalized * playerSpeed * Time.deltaTime);
    }

    void energyLanceMelee()
    {
        if (GetComponent<PlayerInventory>().energy_lance_melee == true)
        {
            //Allow energy lance melee attack to be used 
            if (Input.GetKeyDown("q"))
            {






                //Atack Animation

                // playerRigidbody.constraints = RigidbodyConstraints2D.FreezePosition;

                animator.SetTrigger("energyLanceAttack");

                // playerRigidbody.constraints = RigidbodyConstraints2D.None;
                //DetectEnimiesInRange


                //Damage enemies 
                enemy.GetComponent<wormScript>().health = enemy.GetComponent<wormScript>().health - 5;

               
            }


        }
    }

    private IEnumerator AttackCO() {
        energyLanceMelee();
        yield return new WaitForSeconds(1f); 
    }

}
