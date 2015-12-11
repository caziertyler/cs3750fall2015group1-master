using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubMenuScript : MonoBehaviour {

    // Use this for initialization
    public Canvas attackMenu;
    public Button attackText;
    public Canvas runeMenu;
    public Button runesText;
    public GameObject runeAttackMenu;
 
    void Start () {
        attackMenu = attackMenu.GetComponent<Canvas>();
        runeMenu = runeMenu.GetComponent<Canvas>();
        attackMenu.enabled = false;
        runeMenu.enabled = false;
	}

    public void attackPress()
    {
        runeMenu.enabled = false;
        attackMenu.enabled = true;
        attackText.enabled = false;
        runesText.enabled = true;
        runeAttackMenu.SetActive(false);
    }

    public void runesPress()
    {
        attackText.enabled = true;
        attackMenu.enabled = false;
        runeMenu.enabled = true;
        runesText.enabled = false;
        runeAttackMenu.SetActive(false);
    }

    public void runePress()
    {
        attackText.enabled = true;
        attackMenu.enabled = false;
        runeMenu.enabled = true;
        runesText.enabled = false;
        runeAttackMenu.SetActive(true);
    }

    public void buttonPress()
    {
        runeAttackMenu.SetActive(false);
        runeMenu.enabled = false;
        attackMenu.enabled = false;
        attackText.enabled = true;
        runesText.enabled = true;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
