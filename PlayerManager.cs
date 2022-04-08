using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PlayerManager : MonoBehaviour
{
    public float health;
    public bool dead = false;
    public Transform bullet,Muzzle,damageText;
    public float bulletSpeed;
    public Slider slider;
    bool mouseUIbutton;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue=health;
        slider.value=health;
        Muzzle = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        mouseUIbutton=EventSystem.current.currentSelectedGameObject==null;
        if(Input.GetMouseButtonDown(0)&& mouseUIbutton)
        {
            ShootBullet();
        }    
    }

    

    public void GetDamage(float damage)
    {
        Instantiate(damageText,transform.position,Quaternion.identity).GetComponent<TextMesh>().text=damage.ToString();
        if ((health - damage) >=0)
        {
            health -= damage;
            slider.value=health;
        }
        else{
            health = 0;
        }
        AmIDead();
    }

    void AmIDead()
    {
        if(health <= 0)
        {
            dead = true;
        }
    }

    void ShootBullet()
    {
        Transform tempBullet;
        tempBullet = Instantiate(bullet , Muzzle.position, Quaternion.identity);
        tempBullet.GetComponent<Rigidbody2D>().AddForce(Muzzle.forward * bulletSpeed);
    }
}
