using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

namespace RPGClasses
{
    public class GlobalMethods
    {
        public GlobalMethods()
        { }
        public void CreateDamagePopup(int damage, GameObject gameObject)
        {
            GameObject damagePrefab = (GameObject)Resources.Load("Damage");
            GameObject damageGameObject = GameObject.Instantiate(damagePrefab, new Vector3(gameObject.transform.position.x + 3, gameObject.transform.position.y), gameObject.transform.rotation) as GameObject;
            damageGameObject.GetComponent<Text>().text = damage.ToString();
        }
    }
}
