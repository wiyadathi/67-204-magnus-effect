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
        // ���������͹���仢�ҧ˹�Ҿ�����Ѻ�����ع
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }


    void ApplyMagnusEffect()
    {
        //�ӹǳ�ç�����ʨҡ Cross Product �ͧ����������С����ع
        Vector3 magnusForce  = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
            
         //apply magnus force to the ball-RB 
         rb.AddForce(magnusForce, ForceMode.Force); //������١�����
    }
}
