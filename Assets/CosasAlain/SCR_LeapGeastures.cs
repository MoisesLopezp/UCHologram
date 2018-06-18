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
    }

    public void Wave()
    {
        anim.SetTrigger("Wave");
    }

    public void no()
    {
        anim.SetTrigger("Shake");
    }
}