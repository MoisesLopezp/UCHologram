using UnityEngine;

public class SCR_LeapGeastures : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void Shot()
    {
        anim.SetTrigger("Fall");
        Debug.Log("hay me cai ");
    }

    public void Wave()
    {
        anim.SetTrigger("Wave");
        Debug.Log("holi");
    }

    public void no()
    {
        anim.SetTrigger("Shake");
        Debug.Log("nel kernell");
    }
}