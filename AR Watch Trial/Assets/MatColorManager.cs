using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MatColorManager : MonoBehaviour
{

    public Material Band1;
    public Material Band2;
    public Material Band3;
    public Material Band4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void W1MatColorChange()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;

        if (ButtonName == "Blue")
        {
            Color MyColor = new Color();

            ColorUtility.TryParseHtmlString("#002F7B", out MyColor);
            Band1.color = MyColor;
        } else if (ButtonName == "Black")
        {
            Color MyColor = new Color();

            ColorUtility.TryParseHtmlString("#000000", out MyColor);
            Band1.color = MyColor;
        }


    }

    public void W2MatColorChange()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;

        if (ButtonName == "Red")
        {
            Color MyColor = new Color();

            ColorUtility.TryParseHtmlString("#A91400", out MyColor);
            Band2.color = MyColor;
        }
        else if (ButtonName == "Black")
        {
            Color MyColor = new Color();

            ColorUtility.TryParseHtmlString("#000000", out MyColor);
            Band2.color = MyColor;
        }


    }

    public void W3MatColorChange()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;

        if (ButtonName == "Black")
        {
            Color MyColor = new Color();

            ColorUtility.TryParseHtmlString("#000000", out MyColor);
            Band3.color = MyColor;
        }
        else if (ButtonName == "White")
        {
            Color MyColor = new Color();

            ColorUtility.TryParseHtmlString("", out MyColor);
            Band3.color = MyColor;
        }


    }

    public void W4MatColorChange()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;

        if (ButtonName == "Blue")
        {
            Color MyColor = new Color();

            ColorUtility.TryParseHtmlString("", out MyColor);
            Band4.color = MyColor;
        }
        else if (ButtonName == "White")
        {
            Color MyColor = new Color();

            ColorUtility.TryParseHtmlString("", out MyColor);
            Band4.color = MyColor;
        }


    }


}
