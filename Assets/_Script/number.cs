using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class number : MonoBehaviour {

    public int number1;
    public int number2;
    public int resultnumber;

    public string loperator;
    public float number3;

    public Image image1;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;
    public Text text11;
    public Text text12;
    public Text text13;
    public Text text14;
    public Text text15;
    public Text text16;
    public Text text17;
    public Text text18;
    public Text text19;
    public Text text20;
    public Text text21;
    public Text text22;
    public Text text23;
    public Text text24;
    public Text text25;
    public Text text26;
    public Text text27;
    public Text text28;
    public Text text29;
    public Text text30;
    public Text text31;
    public Text text32;
    public Text text33;
    public Text text34;
    public Text text35;
    public Text text36;

    public Text textr1;
    public Text textr2;
    public Text textr3;
    public Text textr4;
    public Text textr5;
    public Text textr6;

    public int num1g;
    public int num1s;
    public int num1b;
    public int num2g;
    public int num2s;
    public int num2b;

    public int resg;
    public int ress;
    public int resb;
    public int resq;
    public int resw;
    public int ressw;

    public GridLayoutGroup upgridlayout;

    public GridLayoutGroup downgridlayout;
    public GameObject upImage;
    public GameObject upImage2;
    public GameObject upImage3;

    public GameObject dowmImage;

    Vector2 x, d,rd,rx;
    Vector2 cupfont=new Vector2(180,180);
    Vector2 cdownfont = new Vector2(180, 250);
    void Start () {
        text1 = GameObject.Find("Canvas/Bg/Bg-number/Image1/Text").GetComponent<Text>();
        text2 = GameObject.Find("Canvas/Bg/Bg-number/Image2/Text").GetComponent<Text>();
        text3 = GameObject.Find("Canvas/Bg/Bg-number/Image3/Text").GetComponent<Text>();
        text4 = GameObject.Find("Canvas/Bg/Bg-number/Image4/Text").GetComponent<Text>();
        text5 = GameObject.Find("Canvas/Bg/Bg-number/Image5/Text").GetComponent<Text>();
        text6 = GameObject.Find("Canvas/Bg/Bg-number/Image6/Text").GetComponent<Text>();
        text7 = GameObject.Find("Canvas/Bg/Bg-number/Image7/Text").GetComponent<Text>();
        text8 = GameObject.Find("Canvas/Bg/Bg-number/Image8/Text").GetComponent<Text>();
        text9 = GameObject.Find("Canvas/Bg/Bg-number/Image9/Text").GetComponent<Text>();
        text10 = GameObject.Find("Canvas/Bg/Bg-number/Image10/Text").GetComponent<Text>();
        text11 = GameObject.Find("Canvas/Bg/Bg-number/Image11/Text").GetComponent<Text>();
        text12 = GameObject.Find("Canvas/Bg/Bg-number/Image12/Text").GetComponent<Text>();
        text13 = GameObject.Find("Canvas/Bg/Bg-number/Image13/Text").GetComponent<Text>();
        text14 = GameObject.Find("Canvas/Bg/Bg-number/Image14/Text").GetComponent<Text>();
        text15 = GameObject.Find("Canvas/Bg/Bg-number/Image15/Text").GetComponent<Text>();
        text16 = GameObject.Find("Canvas/Bg/Bg-number/Image16/Text").GetComponent<Text>();
        text17 = GameObject.Find("Canvas/Bg/Bg-number/Image17/Text").GetComponent<Text>();
        text18 = GameObject.Find("Canvas/Bg/Bg-number/Image18/Text").GetComponent<Text>();
        text19 = GameObject.Find("Canvas/Bg/Bg-number/Image19/Text").GetComponent<Text>();
        text20 = GameObject.Find("Canvas/Bg/Bg-number/Image20/Text").GetComponent<Text>();
        text21 = GameObject.Find("Canvas/Bg/Bg-number/Image21/Text").GetComponent<Text>();
        text22 = GameObject.Find("Canvas/Bg/Bg-number/Image22/Text").GetComponent<Text>();
        text23 = GameObject.Find("Canvas/Bg/Bg-number/Image23/Text").GetComponent<Text>();
        text24 = GameObject.Find("Canvas/Bg/Bg-number/Image24/Text").GetComponent<Text>();
        text25 = GameObject.Find("Canvas/Bg/Bg-number/Image25/Text").GetComponent<Text>();
        text26 = GameObject.Find("Canvas/Bg/Bg-number/Image26/Text").GetComponent<Text>();
        text27 = GameObject.Find("Canvas/Bg/Bg-number/Image27/Text").GetComponent<Text>();
        text28 = GameObject.Find("Canvas/Bg/Bg-number/Image28/Text").GetComponent<Text>();
        text29 = GameObject.Find("Canvas/Bg/Bg-number/Image29/Text").GetComponent<Text>();
        text30 = GameObject.Find("Canvas/Bg/Bg-number/Image30/Text").GetComponent<Text>();
        text31 = GameObject.Find("Canvas/Bg/Bg-number/Image31/Text").GetComponent<Text>();
        text32 = GameObject.Find("Canvas/Bg/Bg-number/Image32/Text").GetComponent<Text>();
        text33 = GameObject.Find("Canvas/Bg/Bg-number/Image33/Text").GetComponent<Text>();
        text34 = GameObject.Find("Canvas/Bg/Bg-number/Image34/Text").GetComponent<Text>();
        text35 = GameObject.Find("Canvas/Bg/Bg-number/Image35/Text").GetComponent<Text>();
        text36 = GameObject.Find("Canvas/Bg/Bg-number/Image36/Text").GetComponent<Text>();







        textr1 = GameObject.Find("Canvas/Bg/Bg-number (1)/Image1/Text").GetComponent<Text>();
        textr2 = GameObject.Find("Canvas/Bg/Bg-number (1)/Image2/Text").GetComponent<Text>();
        textr3 = GameObject.Find("Canvas/Bg/Bg-number (1)/Image3/Text").GetComponent<Text>();
        textr4 = GameObject.Find("Canvas/Bg/Bg-number (1)/Image4/Text").GetComponent<Text>();
        textr5 = GameObject.Find("Canvas/Bg/Bg-number (1)/Image5/Text").GetComponent<Text>();
        textr6 = GameObject.Find("Canvas/Bg/Bg-number (1)/Image6/Text").GetComponent<Text>();


        downgridlayout = GameObject.Find("Canvas/Bg/Bg-number (1)").GetComponent<GridLayoutGroup>();
        upgridlayout = GameObject.Find("Canvas/Bg/Bg-number").GetComponent<GridLayoutGroup>();
        upImage = GameObject.Find("Canvas/Bg/Bg-number/Image7");
        upImage2 = GameObject.Find("Canvas/Bg/Bg-number/Image8");
        upImage3 = GameObject.Find("Canvas/Bg/Bg-number/Image9");
        dowmImage = GameObject.Find("Canvas/Bg/Bg-number (1)/Image12");
         x = new Vector2(270, 270);
          d = new Vector2(360, 360);
        rx = new Vector2(270, 460);
        rd = new Vector2(360, 460);
        ProduceNumber();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void  ProduceNumber()
    {
        number1 = Random.Range(0, 999);
        number2= Random.Range(0, 999);
        number3 = Random.Range(1, 4);
        Debug.Log(number1 + "   " + number2 + "  " + number3);
        ProduceOperator();
        ResolveNumber();
        SetText();

    }
  
    public void ProduceOperator()
    {
       if(number3 == 1)
        {
            loperator = "+";
            resultnumber = number1 + number2;
        }
       else if (number3 == 2)
        {
            loperator = "-";
            resultnumber = number1 - number2;

        }
       else if (number3 == 3)
        {
            loperator = "*";
            resultnumber = number1 * number2;
        }
        else
        {
            loperator = "/";
            resultnumber = number1 / number2;

        }
        
        Debug.Log(number1 + "   " + number2 + "  " + loperator);
        ControlImageSize();
    }

    public void ControlImageSize()
    {
        if(loperator=="+"||loperator=="-")
        {
            if (number1 > 99 || number2 > 99)
            {
                Debug.Log("image=270,text=270/1.44");
            }
            else
            {
                Debug.Log("image=360,text=360/1.44");

            }
        }
        /*   //if (loperator == "*")
           //{
           //    if (number1 > 99 || number2 > 99)
           //    {
           //        Debug.Log("image=270,text=270/1.44");
           //    }
           //    else
           //    {
           //        Debug.Log("image=360,text=360/1.44");

           //    }
           //}
           */
    }
    public void ResolveNumber()
    {
        num1b = number1 / 100;
        num1s = (number1 - num1b * 100) / 10;
        num1g = (number1 - num1b * 100 - num1s * 10);
        num2b = number2 / 100;
        num2s = (number2 - num2b * 100) / 10;
        num2g = (number2 - num2b * 100 - num2s * 10);
        //结果的拆分

        ressw = resultnumber / 100000;
        resw = (resultnumber - ressw * 100000)/10000;
        resq =( (resultnumber - ressw * 100000) -resw* 10000)/1000;              //resultnumber / 1000;
        resb =( ((resultnumber - ressw * 100000) - resw * 10000) - resq*1000)/100;                            //(resultnumber - resq*1000)/ 100;
        ress = ((((resultnumber - ressw * 100000) - resw * 10000) - resq * 1000) -resb* 100)/10;  //(resultnumber - resq * 1000 - resb * 100) / 10;
        //resg = (resultnumber - resq * 1000 - resb * 100-ress*10);
        resg = ((((resultnumber - ressw * 100000) - resw * 10000) - resq * 1000) - resb * 100) -ress* 10;
      //  Debug.Log(ress + "  " + resg);
    }
    public void SetText()
    {
        text1.text = "";
        text2.text = "";
        text3.text = "";
        text4.text = "";
        text5.text = "";
        text6.text = "";
        text7.text = "";
        text8.text = "";
        text9.text = "";
        text10.text = "";
        text11.text = "";
        text12.text = "";
        text13.text = "";
        text14.text = "";
        text15.text = "";
        text16.text = "";
        text17.text = "";
        text18.text = "";
        text19.text = "";
        text20.text = "";
        text21.text = "";
        text22.text = "";
        text23.text = "";
        text24.text = "";
        text25.text = "";
        text26.text = "";
        text27.text = "";
        text28.text = "";
        text29.text = "";
        text30.text = "";
        text31.text = "";
        text32.text = "";
        text33.text = "";
        text34.text = "";
        text35.text = "";
        text36.text = "";

        if ((number1 > 99 || number2 > 99)&&(loperator=="+"||loperator=="-"))//270
        {
            upgridlayout.cellSize = x;
            downgridlayout.cellSize = rx;
            text1.fontSize = 200;
            text2.fontSize = 200;
            text3.fontSize = 200;
            text4.fontSize = 200;
            text5.fontSize = 200;
            text6.fontSize = 200;
            text7.fontSize = 200;
            text8.fontSize = 200;
            text9.fontSize = 200;
            upImage3.SetActive(false);
            upImage.SetActive(true);
            upImage2.SetActive(true );
        
            dowmImage.SetActive(true);
          
            textr1.fontSize = 160;
            textr2.fontSize = 160;
            textr3.fontSize = 160;
            textr4.fontSize = 160;
            textr5.fontSize = 160;
            textr6.fontSize = 160;


            text2.text = num1b+"";
            text3 .text=num1s + "";
            text4.text=num1g + "";
            text5.text = loperator;
            text6.text=num2b + "";
            text7.text = num2s + "";
            text8.text=num2g + "";


            textr1.text=ressw + "";
            textr2.text=resw + "";
            textr3.text=resq + "";
            textr4.text=resb + "";
            textr5.text = ress + "";
            textr6.text = resg + "";
        }


        if ((number1< 100 && number2 <100) && (loperator == "+" || loperator == "-"))  //360
        {
            downgridlayout.cellSize = rd;
            upgridlayout.cellSize = d;
            text2.text = num1s + "";
            text3.text = num1g + "";
            text4.text = loperator;
            text5.text = num2s + "";
            text6.text = num2g + "";
            upImage.SetActive(false);
            upImage2.SetActive(false);
            upImage3.SetActive(false);
            dowmImage.SetActive(false);

            //text7.text = ""+resb;
            //text8.text = "" + ress;
            //text9.text = "" + resg;
            textr1.fontSize = 300;
            textr2.fontSize = 300;
            textr3.fontSize = 300;

            textr1.text = "" + resb;
            textr2.text = "" + ress;
            textr3.text = "" + resg;
        }
        if ((number1 > 99 || number2 > 99) && loperator == "*" )
        {
            upgridlayout.cellSize = new Vector2(180, 180);
            downgridlayout.cellSize = new Vector2(180, 460);
            text1.fontSize = 145;
            text2.fontSize = 145;
            text3.fontSize = 145;
            text4.fontSize = 145;
            text5.fontSize = 145;
            text6.fontSize = 145;
            text7.fontSize = 145;
            text8.fontSize = 145;
            text9.fontSize = 145;
            text10.fontSize = 145;
            text11.fontSize = 145;
            text12.fontSize = 145;
            text13.fontSize = 145;
            text14.fontSize = 145;
            text15.fontSize = 145;
            text16.fontSize = 145;
            text17.fontSize = 145;
            text18.fontSize = 145;
            text19.fontSize = 145;
            text20.fontSize = 145;
            text21.fontSize = 145;
            text22.fontSize = 145;
            text23.fontSize = 145;
            text24.fontSize = 145;
            text25.fontSize = 145;
            text26.fontSize = 145;
            text27.fontSize = 145;
            text28.fontSize = 145;
            text29.fontSize = 145;
            text30.fontSize = 145;
            text31.fontSize = 145;
            text32.fontSize = 145;
            text33.fontSize = 145;
            text34.fontSize = 145;
            text35.fontSize = 145;
            text36.fontSize = 145;


            upImage3.SetActive(true);
            upImage.SetActive(true);
            upImage2.SetActive(true);

            dowmImage.SetActive(true);

            textr1.fontSize = 300;
            textr2.fontSize = 300;
            textr3.fontSize = 300;
            textr4.fontSize = 300;
            textr5.fontSize = 300;
            textr6.fontSize = 300;


            text4.text = num1b + "";
            text5.text = num1s + "";
            text6.text = num1g + "";
            text7.text = loperator;
            //    text6.text = num2b + "";
            text10.text = num2b + "";
            text11.text = num2s + "";
            text12.text = num2g + "";

            int x1 = num2g * num1g / 10;
            int x2 = (num2g * num1s + x1) / 10;
            int x3 = (num2g * num1b + x2) / 10;

            text18.text = (num1g * num2g - (x1* 10)) + "";
            text17.text = (num1s * num2g + x1) - (num1s * num2g + x1) / 10 * 10 + "";
            text16.text =( num2g * num1b + x2) - x3*10+ "";
          //  Debug.Log(text16.text + "  16    ");
            text15.text = x3 + "";        
            int y1 = num2s * num1g / 10;
            int y2 = (num2s * num1s + y1) / 10;
            int y3 = (num2s * num1b + y2) / 10;

            text23.text = (num1g * num2s - (y1 * 10)) + "";
            text22.text = (num1s * num2s + y1) - (num1s * num2s + y1) / 10 * 10 + "";
           

            text21.text = (num2s * num1b + y2) - y3 * 10 + "";
            text20.text = y3 + "";

            int z1 = num2b * num1g / 10;
            int z2 = (num2b * num1s + z1) / 10;
            int z3 = (num2b * num1b + z2) / 10;


            text28.text = (num1g * num2b - (z1 * 10)) + "";
            text27.text = (num1s * num2b + z1) - (num1s * num2b + z1) / 10 * 10 + "";
            text26.text = (num2b * num1b + z2) - z3 * 10 + "";
            text25.text = z3 + "";

            //.........
            textr1.text = ressw + "";
            textr2.text = resw + "";
            textr3.text = resq + "";
            textr4.text = resb + "";
            textr5.text = ress + "";
            textr6.text = resg + "";


        }
        if ((number1 < 100 && number2 <100) && loperator == "*")
        {
            upgridlayout.cellSize = new Vector2 (270,270);
            downgridlayout.cellSize = new Vector2(270, 460);
            text1.fontSize = 145;
            text2.fontSize = 145;
            text3.fontSize = 145;
            text4.fontSize = 145;
            text5.fontSize = 145;
            text6.fontSize = 145;
            text7.fontSize = 145;
            text8.fontSize = 145;
            text9.fontSize = 145;
            text10.fontSize = 145;
            text11.fontSize = 145;
            text12.fontSize = 145;
            text13.fontSize = 145;
            text14.fontSize = 145;
            text15.fontSize = 145;
            text16.fontSize = 145;
            text17.fontSize = 145;
            text18.fontSize = 145;
            text19.fontSize = 145;
            text20.fontSize = 145;
            text21.fontSize = 145;
            text22.fontSize = 145;
            text23.fontSize = 145;
            text24.fontSize = 145;
            text25.fontSize = 145;
            text26.fontSize = 145;
            text27.fontSize = 145;
            text28.fontSize = 145;
            text29.fontSize = 145;
            text30.fontSize = 145;
            text31.fontSize = 145;
            text32.fontSize = 145;
            text33.fontSize = 145;
            text34.fontSize = 145;
            text35.fontSize = 145;
            text36.fontSize = 145;

     
            upImage3.SetActive(true);
            upImage.SetActive(true);
            upImage2.SetActive(true);

            dowmImage.SetActive(true);

            textr1.fontSize = 300;
            textr2.fontSize = 300;
            textr3.fontSize = 300;
            textr4.fontSize = 300;
            textr5.fontSize = 300;
            textr6.fontSize = 300;


 
            text3.text = num1s + "";
            text4.text = num1g + "";
            text5.text = loperator;
        //    text6.text = num2b + "";
            text7.text = num2s + "";
            text8.text = num2g + "";

            //中间过程显示
          //  =  num2g*num1g


            text12.text = (num1g * num2g - (num1g * num2g / 10 * 10)) + "";
            text11.text = (num1s * num2g + (num1g * num2g / 10)) - (num1s * num2g + (num1g * num2g / 10)) /10*10+ "";
            text10.text = (num1s * num2g + (num1g * num2g / 10))/10+"";


            text15.text= (num1g * num2s - (num1g * num2s / 10 * 10)) + "";
            text14.text = (num1s * num2s + (num1g * num2s / 10)) - (num1s * num2s + (num1g * num2s / 10)) / 10 * 10 + "";
            text13.text= (num1s * num2s + (num1g * num2s / 10)) / 10 + "";




            textr1.text = resq + "";

            textr2.text = resb + "";
            textr3.text = ress + "";
            textr4.text = resg + "";


        }



        Debug.Log(resultnumber + "  " + ressw + "  " + resw + "  " + resq + "  " + resb + "  " + ress + "  " + resg);
    }

}
