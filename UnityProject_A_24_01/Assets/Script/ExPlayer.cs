using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                   

public class ExPlayer : MonoBehaviour
{
    public int Hp = 100;
    public Text TextUI = null;

    // Update is called once per frame
    void Update()
    {
        TextUI.text = Hp.ToString();    

        if (Input.GetMouseButtonDown(0)) 
        {
            Hp -= 10;                  
            if (Hp <= 0)                 
            {
                TextUI.text = Hp.ToString();   
                Destroy(gameObject);     
            }
        }
    }
}
