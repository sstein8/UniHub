using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DateTime : MonoBehaviour
{
   
    public TextMeshProUGUI TMtime;
    public TextMeshProUGUI TMdate;
    public TextMeshProUGUI TMday;
    public TextMeshProUGUI class1;
    public TextMeshProUGUI time1;
    public TextMeshProUGUI class2;
    public TextMeshProUGUI time2;
    public TextMeshProUGUI class3;
    public TextMeshProUGUI time3;
    public TextMeshProUGUI balance;


    void Start()
    {
        string time = System.DateTime.Now.ToShortTimeString();
        string date = System.DateTime.Now.ToString("MM/dd/yyyy");
        string dayOfWeek = System.DateTime.Now.ToString("dddd");
     
        TMtime.text = time;
        TMdate.text = date;
        TMday.text = dayOfWeek;
        balance.text = "$567.49";


        //-------------Schedule-----------

        string bio = "BISC 1111";
        string bioTime = "9:35am - 10:50am";

        string vr = "CSCI 3907";
        string vrTime = "2:00pm - 4:30pm";

        string math = "MATH 1231";
        string mathTime = "11:10am - 12:25pm";

        string phil = "PHIL 1062";
        string philTime = "6:10pm - 7:25pm";

        string span = "SPAN 2005";
        string spanTime = "3:00pm - 4:15pm";


        if(dayOfWeek == "Monday" || dayOfWeek == "Wednesday"){
            class1.text = bio;
            time1.text = bioTime;
            class2.text = vr;
            time2.text = vrTime;
            class3.text = "";
            time3.text = "";
        }

        if(dayOfWeek == "Tuesday" || dayOfWeek == "Thursday"){
            class1.text = math;
            time1.text = mathTime;
            class2.text = span;
            time2.text = spanTime;
            class3.text = phil;
            time3.text = philTime;
        }
        
        if(dayOfWeek == "Friday" || dayOfWeek == "Saturday" || dayOfWeek == "Sunday"){
            class1.text = "No Class Today";
            time1.text = "";
            class2.text = "";
            time2.text = "";
            class3.text = "";
            time3.text = "";

        }  
        
    }
}
