using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CentralisedPercentageScript : MonoBehaviour
{
    CityLitPercentage clp;
    RoomLitPercentage rlp;
    public int r1; public int r1t = 5; // r1 means room 1 lights that have been lit up, r1t means the room 1 total lights.
    public int r2; public int r2t = 5; // and so on
    public int r3; public int r3t = 5;
    public int r4; public int r4t = 5;
    public int r5; public int r5t = 5;
    public void Start()
    {
        r1 = 0;
        r2 = 0;
        r3 = 0;
        r4 = 0;
        r5 = 0;
    }

    void setDisplayPercentages()
    {
        string Dpercentage = (r1 / r1t + r2 / r2t + r3 / r3t + r4 / r4t).ToString();
        rlp.setText(Dpercentage);
    }



    void roomOne(int ntlu) // ntlu == new torches lit up
    {
        r1 = r1 + ntlu;
        setDisplayPercentages();
    }

    void roomTwo(int ntlu) // ntlu == new torches lit up
    {
        r2 = r2 + ntlu;
        setDisplayPercentages();
    }

    void roomThree(int ntlu) // ntlu == new torches lit up
    {
        r3 = r3 + ntlu;
        setDisplayPercentages();
    }
    void roomFour(int ntlu) // ntlu == new torches lit up
    {
        r4 = r4 + ntlu;
        setDisplayPercentages();
    }
    void roomFive(int ntlu) // ntlu == new torches lit up
    {
        r5 = r5 + ntlu;
        setDisplayPercentages();
    }


    //this function should be called whenever new things are lit up
    public void updateLightStats(int roomNum, int ntlu) // ntlu == new torches lit up
    {
        switch (roomNum)
        {
            case 1:
                roomOne(ntlu);
                break;
            case 2:
                roomTwo(ntlu);
                break;
            case 3:
                roomThree(ntlu);
                break;
            case 4:
                roomFour(ntlu);
                break;
            case 5:
                roomFive(ntlu);
                break;
        }
    }
}