using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedefcoin : MonoBehaviour
{ 
    void Update()
    {
        if(hedefscore.coinAmount<0)
        {
            hedefscore.coinAmount=0;
        }
        else if(hedefscore.coinAmount>=4)
        {
            hedefscore.coinAmount=4;
        }
    }

     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="coin"){
         hedefscore.coinAmount+=1;
        }
        
    }
}
