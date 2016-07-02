using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayWebPageInWindowTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //This program is to test to see how to open a web page in a windows form application.
            //Future revisions will test how to give a url and search for and open it in the window,
            //how to verify that a web page actually exists before searching for and displaying it, 
            //prompting the user for a new url (next to the search box) before searching again, 
            //and password verification to log into Google (and go to the Calendar page) before displaying 
            //the Google Calendar.

            //This program will eventuallly also test to see how to open a text file or view the html of a web page.
            //I may test to see how to point and click to grab text in a tutorial that I found on the web earlier.
            //Here is the link to that four-part tutorial: http://www.codeproject.com/Articles/1041115/Webscraping-with-Csharp
            //I would like to be able to either read a text file and open it in a window within the form or a csv file,
            //open the html of a web page and show it in a window within the form, or allow the point and click method.
            //Hopefully there will be a more complex but easier to use way (one idea I thought of was using the right-click 
            //menu when creating an event to place each part in the right place)
            //Another thought in my mind when it came to this was saving it all to a CSV or a database to querry and store later
            //into the calendar.

            //The gist of this is I want to have it so that on the left side you can view the text that you're putting into the 
            //calendar, on the right will be Google Calendar, and before anything loads, there will be a login on the form which will 
            //be used to log in to Google Calendar (they should not be able to navigate to anywhere else but their google calendar (meaning 
            //there will be no search engine).

            //The login should have a search to verify that it is going only to Google Calendar.
            //This means that there should be a place to store the url.  It will verify it and then send the email and 
            //password in and verify them and then will prompt the user if there are any problems. 
            //If there aren't it will sign in, the screen will change on the right to show the calendar and the left will 
            //be ready for the user to open a file or web page html so that they can add the events.
            //The program will have an auto search for important details, however it is best to manually scrape first.

            //Later projects will include voice recognition, Amazon Echo (Alexa), actually Google API commands and etc.
            //When actually using Google API, it'd be cool to have the calendar refresh to display the changes, it'd 
            //also be cool to refresh the page to display changes when talking with Alexa and display a manual option as well.

            //These are just a bunch of ideas but nothing is really done up until this point.
        }
    }
}
