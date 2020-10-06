using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAssement1
{
    public class LogicClass
    {
        int Shells = 0;
        int Prospect = 2;


        public void GunShootBt()
        {
            //Shoot at head, if Shells is in the barrel else it will just Rotate
            if (Shells == 5)
            {
                MessageBox.Show("You are dead!");
            }
            else
            {
                MessageBox.Show("The revolver just rotated");
                Shells = Shells + 1;
            }
        }

        public void ShootAwayBt()
        {
            //if i have any Possibility

            
            if (Prospect > 0)
            {
                if (Shells == 5)
                {
                   
                    MessageBox.Show("You survived . \nYour Score : " + Shells+ (Shells ==5 ?"\n \n You Gain" : "\n You failure"));

                }
                else
                {
                    MessageBox.Show("The revolver just rotated");
                    Shells = Shells + 1;
                   
                }
               

            }
            //If I don't get any Possibility last
            else
            {
                MessageBox.Show("You are dead!");

            }

            Prospect = Prospect - 1;
        }


        public void Spinbt()
            //Spin the Revolver to get a Random position 
        {
            Random rand = new Random();
            Shells = rand.Next(0, 6);
            MessageBox.Show("Gun Spinning");


        }

       
       

       

       


        public void LoadBt()
            //Just Rotate the gun for Loading
        {
            Shells = 0;
            MessageBox.Show("Gun Loaded");
        }
        public void PlayAgainBt()
        {
            // if You Want to Replay 
            Shells = 0;
            Prospect = 2;
            MessageBox.Show("Game begins");
        }
    }
}









