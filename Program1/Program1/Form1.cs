/*
 * IF THERE IS AN ERROR IN THE FORM LAYOUT, CHANGE RESOLUTION TO 100%
 K9195
 CIS 199-02
 Sept 23rd, 2019
 Program 1
 This program will take various inputs from the user based on room characteristics and return a calculation
 that gives an exact and recommended amount of paint needed to paint aformentioned room
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //allows for changing the form color
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightYellow;
            
        }
        //will intitiate the calculations from the different inputs provided by the user
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double length,                   //length of walls in feet
                   height,                   //height of walls in feet
                   surfaceArea,              //is the multiplication of the height and length variables
                   saRemainder,              //this is the surface area less the windows and doors
                   paintExact;               //the exact amount of paint required with the each paint bucket covering 400 sqft
            int doors,                       //amount of doors in room
                coats,                       //number of coats desired by user
                recommend,                   //this is the math.ceiling based off the recommend variable calculation
                windows;                     //the number of windows as provided by the user
            const int DOOR_SA = 21;          //constant for how many feet a typical door removes from the overall length of a room
            const int WINDOW_SA = 12;        //constant for how many feet a typical window removes from the overall length of a room
            const double BUCKET_AMOUNT = 400;//the typical amount of sqft a paint bucket covers

            //the parsing of strings to doubles and int 
            length = double.Parse(lengthTxt.Text);
            height = double.Parse(heightTxt.Text);
            doors = int.Parse(doorTxt.Text);
            windows = int.Parse(windowTxt.Text);
            coats = int.Parse(coatsTxt.Text);

            //calculations
            surfaceArea = length * height;
            saRemainder = surfaceArea - ((doors*DOOR_SA) + (windows*WINDOW_SA));
            paintExact = (saRemainder * coats) / BUCKET_AMOUNT;
            recommend = (int)Math.Ceiling(paintExact);
            //outputs
            outputExact.Text = $"{paintExact:f1}";
            outputRec.Text = $"{recommend}";











        }
        //the clear button to clear all text boxes and replace the cursor to the top text box
        private void ClrBtn_Click(object sender, EventArgs e)
        {
            lengthTxt.Clear();
            heightTxt.Clear();
            doorTxt.Clear();
            windowTxt.Clear();
            coatsTxt.Clear();
            lengthTxt.Focus();


        }
    }
}
