using UnityEngine;

public class SCR_LeapGeastures : MonoBehaviour
{
    Animator anim;
    public Rigidbody rb;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    private void Update()
    {
        Debug.Log(rb.angularVelocity);
    }

    public void Shot()
    {
        if (rb.angularVelocity.magnitude >= 2)
            anim.SetTrigger("Fall");
        Debug.Log("hay me cai ");
    }

    public void Wave()
    {
        if (rb.angularVelocity.magnitude >= 2)
            anim.SetTrigger("Wave");

        Debug.Log("holi");
    }

    public void no()
    {
        if (rb.angularVelocity.magnitude >= 2)
            anim.SetTrigger("Shake");

        Debug.Log("nel kernell");
    }
}