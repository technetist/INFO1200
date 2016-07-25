using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //create class called vehicle
        class Vehicle
        {
            public Vehicle()
            {
                //I have no idea what I'm doing... Set these values to the text boxes
                string doorCount = txtBoxDoorCount;
                string engineSound = txtBoxEngineSound;
            }
            //methods
            public virtual string Move() { return "We are moving"; }
            public virtual string Stop() { return "We are stopped"; }
        }
        //create derived class called car
        class Car : Vehicle
        {
            public Car()
            {
                base.doorCount = "4";
                base.engineSound = "rrrrrr";
            }
            public override string Move()
            {
                return "vrumm";
            }
            //new roadtrip method
            string roadtrip()
            {
                return "Not a care in the world";
            }
        }
        //create derived class called Airplane
        class Airplane : Vehicle
        {
            public Airplane()
            {
                base.doorCount = "1";
                base.engineSound = "whiiirl";
            }
            public override string Stop()
            {
                return "shreeech";
            }
            //new cruising method
            string cruising()
            {
                return "Floating on the clouds";
            }
        }
        
    }
}
