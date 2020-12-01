using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    #region Values
    [SerializeField] string girlName;
    [SerializeField] float atheletic;
    [SerializeField] float nerdy;
    [SerializeField] float empathy;
    [SerializeField] float sensuality;

    public bool selected;
    #endregion

    void Start()
    {
        #region Initial Values
        selected = false;
        #endregion
    }

    void Update()
    {
        
    }
} 