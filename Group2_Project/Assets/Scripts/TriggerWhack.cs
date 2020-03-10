using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWhack : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Whacked()
    {
        anim.SetTrigger("Whacked");
    }
    public void WorstWhack()
    {
        anim.SetTrigger("WorstWhack");
    }
    public void MediumWhack()
    {
        anim.SetTrigger("MediumWhack");
    }
}
