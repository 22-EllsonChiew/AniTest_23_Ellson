using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController15 : MonoBehaviour
{
    Animator playerAnim;

    public float speed;
    public float Bspeed;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playerAnim.SetBool("isStrafe", true);
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("isStrafe", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -Bspeed);
            playerAnim.SetBool("isStrafe", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("isStrafe",false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * -speed);
            playerAnim.SetBool("isStrafe", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnim.SetBool("isStrafe", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            playerAnim.SetBool("isStrafe", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("isStrafe", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetTrigger("trigAttack");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            playerAnim.SetTrigger("trigDeath");
        }
    }
}
