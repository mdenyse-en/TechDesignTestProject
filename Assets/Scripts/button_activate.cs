using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_activate : MonoBehaviour
{
    [SerializeField] private Button button;
    private void OnMouseDown()
    {
        button.onClick.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
