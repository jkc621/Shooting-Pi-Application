using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingPiFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        Color colorGreen = Color.FromName("Green");
        Color colorRed = Color.FromName("Red");

        private void btnCalculatePi_Click(object sender, EventArgs e)
        {
            double lengthOfSquare = Convert.ToDouble(textBoxLengthOfSquare.Text);
            int reps = Convert.ToInt32(textBoxNoOfReps.Text);
            int hitCounter = 0;
            double shotXCoord = 0;
            double shotYCoord = 0;

            Random r = new Random();
            Bitmap visualisation = new Bitmap(400, 400);
            pictureBoxResult.Image = visualisation;

            for (int i = 0; i < reps; i++)
            {
                double lengthFromCorner = 0;
                shotXCoord = generateRandomNoFromZero(r, lengthOfSquare);
                shotYCoord = generateRandomNoFromZero(r, lengthOfSquare);
                lengthFromCorner = Math.Pow((Math.Pow(shotXCoord, 2) + Math.Pow(shotYCoord, 2)), 0.5); //Pythagoras Theorem
                int intXCoord = (int)((shotXCoord * 300) / lengthOfSquare);
                int intYCoord = (int)((shotYCoord * 300) / lengthOfSquare);

                if (lengthFromCorner < lengthOfSquare)
                {
                    visualisation.SetPixel(intXCoord, intYCoord, colorGreen);
                    hitCounter++;
                }
                else
                {
                    visualisation.SetPixel(intXCoord, intYCoord, colorRed);
                }

                pictureBoxResult.Image = visualisation;

                
            }

            double result = (hitCounter * 4);
            result = result / reps;
            labelPiOutput.Text = result.ToString("R");
        }

        public static double generateRandomNoFromZero(Random rand, double upperLimit)
        {
            int upperLim = Convert.ToInt32(upperLimit) * 100000000;
            int intRandNo = rand.Next(0, (upperLim + 1));
            double dblRandomNo = (Convert.ToDouble(intRandNo)) / 100000000;
            return dblRandomNo;
        }
    }
}
