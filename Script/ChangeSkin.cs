using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    //Get skins animation
    public AnimatorOverrideController blue;
    public AnimatorOverrideController red;
   
    public void BlueSkin(){
        GetComponent<Animator>().runtimeAnimatorController = blue as RuntimeAnimatorController;
    }
    public void RedSkin(){
        GetComponent<Animator>().runtimeAnimatorController = red as RuntimeAnimatorController;
    }
}
