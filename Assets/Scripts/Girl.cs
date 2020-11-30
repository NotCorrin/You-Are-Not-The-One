using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    #region Values
    [SerializeField] string girlName;
    public bool selected;
    #endregion

    void Start()
    {
        #region 
        selected = false;
        #endregion
    }

    void Update()
    {
        
    }
} 