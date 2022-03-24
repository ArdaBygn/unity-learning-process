public class PlayerController : MonoBehaviour
{
     void Start()
    {
        
    }

   
    void Update()
  {     
    if(Input.GetKey(KeyCode.W))
    {
    transform.Translate(0,0,5*Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.S))
    {
    transform.Translate(0,0,-5*Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.D))
    {
    transform.Translate(0,5*Time.deltaTime,0);
    }
    if(Input.GetKey(KeyCode.A))
    {
    transform.Translate(0,-5*Time.deltaTime,0);
    }
  }

      
}
