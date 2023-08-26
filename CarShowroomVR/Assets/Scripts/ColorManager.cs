using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public MeshRenderer[] renders;

    public MeshRenderer[] rendersGlass;

    public MeshRenderer[] rendersDetails;

    // Second Option for Details [Car Orignial Seats, Car Original Mirrors, Car Side Bars]
    public MeshRenderer[] rendersSeatColor;
    public MeshRenderer[] rendersMirrorsColor;
    public MeshRenderer[] rendersSideBarsColor;

    public MeshRenderer[] rendersLines;
    public MeshRenderer[] rendersLightsColor;



    public MeshRenderer[] rendersTaxiYellowBase;
    public MeshRenderer[] rendersTaxiYellowRoof;
    public MeshRenderer[] rendersTaxiBlackBase;
    public MeshRenderer[] rendersTaxiOrangeColor;

    public MeshRenderer[] rendersPickup;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void ChangeColorBase(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rend in renders)
        {
            rend.material.color = receivedColor.heldColor;
        }
    }

    public void ChangeColorGlass(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendG in rendersGlass)
        {
            rendG.material.color = receivedColor.heldColor;
        }
    }

    public void ChangeColorDetails(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendD in rendersDetails)
        {
            rendD.material.color = receivedColor.heldColor;
        }
    }


    public void ChangeColorLines(ColorHolder receivedColor)
    {
        foreach(MeshRenderer rendL in rendersLines)
        {
            rendL.material.color = receivedColor.heldColor;
            
        }


    }

    // This is for Taxi
    public void ChangeColorTaxiYellowBase(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendT1 in rendersTaxiYellowBase)
        {
            rendT1.material.color = receivedColor.TaxiYellowBaseColor;

        }
    }

    public void ChangeColorTaxiYellowRoof(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendT2 in rendersTaxiYellowRoof)
        {
            rendT2.material.color = receivedColor.TaxiYellowRoofColor;

        }
    }
    public void ChangeColorTaxiBlackBase(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendT3 in rendersTaxiBlackBase)
        {
            rendT3.material.color = receivedColor.TaxiBlackBaseColor;

        }
    }
    public void ChangeColorTaxiOrangeColor(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendT4 in rendersTaxiOrangeColor)
        {
            rendT4.material.color = receivedColor.TaxiOrangeColor;

        }
    }

    // Car Light
    public void ChangeColorLightsColor(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendLight in rendersLightsColor)
        {
            rendLight.material.color = receivedColor.heldColor;

        }
    }
    // Second Option for Details [Car Orignial Seats]
    public void ChangeColorSeatColor(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendSeat in rendersSeatColor) //PT = Pickup Trunk
        {
            rendSeat.material.color = receivedColor.heldColor;

        }
    }

    // Second Option for Details [Car Orignial Mirrors]
    public void ChangeColorMirrorsColor(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendMirror in rendersMirrorsColor) //PT = Pickup Trunk
        {
            rendMirror.material.color = receivedColor.heldColor;

        }
    }
    // Second Option for Details [Car Orignial Side Bars]
    public void ChangeColorSideBarsColor(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendSB in rendersSideBarsColor)
        {
            rendSB.material.color = receivedColor.heldColor;

        }
    }
    // This is for Pickup
    public void ChangeColorPickupColor(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendPT in rendersPickup) //PT = Pickup Trunk
        {
            rendPT.material.color = receivedColor.PickupColor;

        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
