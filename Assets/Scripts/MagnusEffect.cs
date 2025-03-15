using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Kick();
        }

        ApplyMagnusEffect();
    }
    void Kick() 
    {
        // ให้บอลเคลื่อนที่ไปข้างหน้าพร้อมกับการหมุน
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }


    void ApplyMagnusEffect()
    {
        //คำนวณแรงแมกนัสจาก Cross Product ของความเร็วและการหมุน
        Vector3 magnusForce  = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
            
         //apply magnus force to the ball-RB 
         rb.AddForce(magnusForce, ForceMode.Force); //ทำให้ลูกบอลโค้ง
    }
}
