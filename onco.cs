using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onco : MonoBehaviour
{

    // Start is called before the first frame update
   public void OnCollisionEnter(Collision target){
    if(target.gameObject.CompareTag("Player")){
        gameObject.SetActive(false);
    }
   }
}
