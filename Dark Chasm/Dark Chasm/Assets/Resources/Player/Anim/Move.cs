using UnityEngine;
using System.Collections;

namespace RPGClasses
{
    public class Move : MonoBehaviour
    {
        Animator anim;
        bool isCharacter;
        double battleCounter = 0;
        // Use this for initialization
        void Start()
        {
            Debug.Log("I Started");
            string obj = this.name;
            if (!obj.Equals("Main Camera"))
            {
                anim = GetComponent<Animator>();
                isCharacter = true;
            }
            else
            {
                isCharacter = false;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (isCharacter)
            {
                float input_x = Input.GetAxisRaw("Horizontal");
                float input_y = Input.GetAxisRaw("Vertical");

                bool isWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;

                anim.SetBool("isWalking", isWalking);
                if (checkForBattle())
                {
                    anim.SetBool("isWalking", false);
                    battleCounter = 0;
                    StartCoroutine(startBattle());
                }
                if (isWalking)
                {
                    anim.SetFloat("x", input_x);
                    anim.SetFloat("y", input_y);

                    transform.position += new Vector3(input_x, input_y, 0).normalized * Time.deltaTime * 2;
                    
                }
            }
        }

        IEnumerator startBattle()
        {
            Session.game.location = gameObject.transform;
            ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
            MonoBehaviour moveScript = (Session.game.mainCharacter.GetComponent("Move") as MonoBehaviour);
            moveScript.enabled = false;
            yield return StartCoroutine(sf.FadeToBlack());
            Application.LoadLevel("BattleScene");
            yield return StartCoroutine(sf.FadeToClear());

        }

        bool checkForBattle()
        {
            battleCounter += .1;
            if (battleCounter > 90)
            {
                return true;
            }
            else
                return false;

        }
        void OnCollisionEnter2D(Collision2D coll)
        {

        }

        void Movement()
        {
            string obj = this.name;
            bool isCharacter = false;
            if (!obj.Equals("Main Camera"))
            {
                isCharacter = true;
                anim = GetComponent<Animator>();
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * 4f * Time.deltaTime);
                if (isCharacter)
                {
                    anim.Play("WalkingForward");
                }
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * 4f * Time.deltaTime);
                if (isCharacter)
                {
                    anim.Play("WalkingLeft");
                }
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * 4f * Time.deltaTime);
                if (isCharacter)
                {
                    anim.Play("WalkingBackwards");
                }
            }

            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * 4f * Time.deltaTime);
                if (isCharacter)
                {
                    anim.Play("WalkingRight");
                }
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                transform.Translate(Vector2.up * 4f * Time.deltaTime);
                if (isCharacter)
                {
                    anim.Play("IdleForward");
                }
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                transform.Translate(Vector2.left * 4f * Time.deltaTime);
                if (isCharacter)
                {
                    anim.Play("IdleLeft");
                }
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                transform.Translate(Vector2.down * 4f * Time.deltaTime);
                if (isCharacter)
                {
                    anim.Play("IdleBackwards");
                }
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                transform.Translate(Vector2.right * 4f * Time.deltaTime);
                if (isCharacter)
                {
                    anim.Play("IdleRight");
                }
            }

        }
    }
}
