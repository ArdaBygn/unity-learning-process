using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    void Uptade()
    {
        if(score.coinAmount<0)
        {
            score.coinAmount=0;
        }
        else if(score.coinAmount>=4){
            score.coinAmount=4;
        }
    }



     private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag=="Player"){
            hedefscore.coinAmount-=1;   
            score.coinAmount+=1;
            Destroy(gameObject);
        }
        
            
        
       
    }
}
