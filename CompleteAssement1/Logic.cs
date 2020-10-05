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
        int shells = 0;
        int prospect = 2;


        public void GunShootBt()
        {
            //Shoot at head, if shells is in the barrel else it will just Rotate
            if (shells == 5)
            {
                MessageBox.Show("You are dead!");
            }
            else
            {
                MessageBox.Show("The revolver just rotated");
                shells = shells + 1;
            }
        }

        public void ShootAwayBt()
        {
            //if i have any Possibility

            
            if (prospect > 0)
            {
                if (shells == 5)
                {
                   
                    MessageBox.Show("You survived");

                }
                else
                {
                    MessageBox.Show("The revolver just rotated");
                    shells = shells + 1;
                   
                }
               

            }
            //If I don't get any Possibility last
            else
            {
                MessageBox.Show("You are dead!");

            }

            prospect = prospect - 1;
        }


        public void Spinbt()
            //Spin the Revolver to get a Random position 
        {
            Random rand = new Random();
            shells = rand.Next(0, 6);
            MessageBox.Show("Gun Spinning");


        }

        public void ScoreBox()
            //Score can show in box if win/loss
        {
            

        }
        private static int AddNumber(int v1, object n1, int v2, object n2)
            {
                int output = v1 + v2;
                return output;
            }

       

       


        public void LoadBt()
            //Just Rotate the gun for Loading
        {
            shells = 0;
            MessageBox.Show("Gun Rotated");
        }
    }
}









