/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public int LevelToLoad;
    private gameMaster gm; 
    void Start()
    {
      gm = GameObject.FindGameObjectwithTag("GameMaster").GetComponent<gameMaster>();
    }
    void OnTriggerEnter2D(Collider2D col) {
      if (col.CompareTag("Player"))
      {
        gm. InputText.text ("[E] to Enter"); 
        if (Input.GetKeyDown("e"))
        {
          Application.LoadLevel(LevelToLoad);
        }
      }
    }
        

     void OnTriggerstay2D(Collider2D col)
     {
       if (col.CompareTag("Player"))
       {
         if (Input.GetKeyDown(""))
         {
          Application.LoadLevel(LevelToLoad);
         }
       }
     }
     void OnTriggerExit2D(Collider2D col)
     { 
         if (col.CompareTag("Player"))
         {
          gm.InputText.text - (" ");
         }
    }
  }
  */
  

