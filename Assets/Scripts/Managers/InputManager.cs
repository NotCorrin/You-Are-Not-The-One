using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : TheManager
{
    public enum currentCat {
        Reply,
        Cat1,
        Cat2,
        Cat3,
        Cat4,
        Cat5
    }
    


    // After 
    public void getReply(int qNum){
        
    }

    // idfk
    public List<string> getBtn(int curCat)
    {
        List<string> catagories = new List<string>();
        catagories.Add("HASHIRE SORI YO");
        catagories.Add("KAZE NO YOU NI");
        catagories.Add("TSUKIMIHARA WO");
        catagories.Add("PADORU PADORU");
        return catagories;
    }
}
