using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerManager : MonoBehaviour
{
    public Transform bullet,Muzzle;
    public float bulletSpeed;
   
    
    void Start()
    {
        Muzzle = transform.GetChild(0);
    }

    void Update()
    {
        float mermisayisi=score.coinAmount;
        if(Input.GetMouseButtonDown(0)&& mermisayisi>0)
        {
            ShootBullet();
            score.coinAmount--;
        }    
    }
    
    void ShootBullet()
    {
        Transform tempBullet;
        tempBullet = Instantiate(bullet , Muzzle.position, Quaternion.identity);
        tempBullet.GetComponent<Rigidbody2D>().AddForce(Muzzle.forward * bulletSpeed);
    }
}
