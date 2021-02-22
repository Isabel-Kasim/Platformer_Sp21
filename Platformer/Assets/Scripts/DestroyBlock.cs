using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyBlock : MonoBehaviour
{


    public GameObject Block;
    public TextMeshProUGUI text;
    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        Block.GetComponent<GameObject>();
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;

                if (bc != null)
                {
                    Destroy(bc.gameObject);

                    if (bc.gameObject.tag == "Question Block")
                    {
                        points++;
                        text.SetText(points.ToString());
                    }
                    
                }
            }
        }
    }

    

}
