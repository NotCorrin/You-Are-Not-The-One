using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region Managers
    [SerializeField] TheManager theManager;
    #endregion

    void Start()
    {
        #region GetComponents
        theManager = GetComponent<TheManager>();
        #endregion
    }

    void Update()
    {

    }
}
