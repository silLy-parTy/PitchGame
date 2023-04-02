using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTorchControl : MonoBehaviour
{
    
    public  GameObject[] tourches;
    // Start is called before the first frame update
    public void RoomTourchOn()
    {
        for (int i =0;i<8; i ++)
        {
            tourches[i].GetComponent<Item>().lightOn();
        }
    }

    public void RoomTourchOff()
    {
        for (int i = 0; i < 10; i++)
        {
            tourches[i].GetComponent<Item>().lightOff();
        }
    }
}
