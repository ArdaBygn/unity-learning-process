public float speed =0f;
    Rigidbody rb;

    
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0,speed,0),ForceMode.Impulse);
        }
    }