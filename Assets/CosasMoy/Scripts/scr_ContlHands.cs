using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ContlHands : MonoBehaviour {

    bool RH_Inclinado = false;
    bool LH_Inclinado = false;

    bool R_Pinch = false;
    bool L_Pinch = false;

    public GameObject Model;

    float Scale = 1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Set_RH_Inclinado(bool _i)
    {
        RH_Inclinado = _i;
    }
    public void Set_lH_Inclinado(bool _i)
    {
        LH_Inclinado = _i;
    }

    public void Set_RH_PINCH(bool _i)
    {
        R_Pinch = _i;
    }
    public void Set_lH_PINCH(bool _i)
    {
        L_Pinch = _i;
    }

    public void Rotate_Y(int Direction)
    {
        if ((R_Pinch && Direction == 1) || (L_Pinch && Direction == -1))
            return;

        Model.transform.Rotate(new Vector3(0f, 1f, 0f), 30 * Direction);
    }

    public void Zoom(int Dir)
    {
        if (Dir == 1 && Scale < 1.5f)
        {
            Scale += 0.1f;
        }
        if (Dir == -1 && Scale > 0.5f)
        {
            Scale -= 0.1f;
        }

        Model.transform.localScale = new Vector3(Scale, Scale, Scale);
    }

}
