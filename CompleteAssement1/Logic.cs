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
        int Bullet = 0;
        int Chances = 2;


        public void GunShootBt()
        {
            //If the bullet is in the barrel, shoot it at head
            if (Bullet == 5)
            {
                MessageBox.Show("You are dead!");
            }
            else
            {
                MessageBox.Show("The revolver just rotated");
                Bullet = Bullet + 1;
            }
        }

        public void ShootAwayBt()
        {
            //if I have chances
            
            if (Chances > 0)
            {
                if (Bullet == 5)
                {

                    MessageBox.Show("You survived");

                }
                else
                {
                    MessageBox.Show("The revolver just rotated");
                    Bullet = Bullet + 1;
                }
            }
            //If I don't have any chances left
            else
            {
                MessageBox.Show("You are dead!");

            }

            Chances = Chances - 1;
        }


        public void Spinbt()
        {
            Random rand = new Random();
            Bullet = rand.Next(0, 6);
            MessageBox.Show("Gun Spinning");


        }

        public void ScoreBox()
        {
            private static int AddNumber(int v1, object n1, int v2, object n2)
            {
                int output = v1 + v2;
                return output;
            }

        }

       


        public void LoadBt()
        {
            Bullet = 0;
            MessageBox.Show("Gun Rotated");
        }
    }
}









