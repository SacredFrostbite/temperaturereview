using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Program4A
{
    public partial class Form1 : Form
    {
        // Declarations
        int count, lowTempDay, highTempDay;
        double monthLowTemp, monthHighTemp, monthAverageTemp, total, average, highest, lowest;
        string monthName, lowTempMessage, highTempMessage, averageTempMessage, filename;
        double[] tempsArray = new double[31];
        StreamReader inputFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            string inputValue;
            lblPathName.Text = String.Empty;

            if (openFile.ShowDialog() == DialogResult.OK) // Opens and Reads Month Files
            {
                inputFile = File.OpenText(openFile.FileName);
                filename = openFile.FileName;
                lblPathName.Text = filename;
                monthName = inputFile.ReadLine();
                inputValue = inputFile.ReadLine();
                Double.TryParse(inputValue, out tempsArray[0]);
                while (!inputFile.EndOfStream)
                {
                    count++;
                    inputValue = inputFile.ReadLine();
                    Double.TryParse(inputValue, out tempsArray[count]);
                }
            }
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            FindAverage(); // Finds Average Month Temp
            FindLowest(); // Finds Lowest Array Value
            FindHighest(); // Finds Highest Array Value

            // Output for Results
            lowTempMessage = monthName + " low temperature was " + lowest + " on day " + lowTempDay;
            highTempMessage = monthName + " high temperature was " + highest + " on day " + highTempDay;
            averageTempMessage = "Average temperature for " + monthName + " was " + average;

            lblHighTemp.Text = highTempMessage;
            lblLowTemp.Text = lowTempMessage;
            lblAverageTemp.Text = averageTempMessage;
            inputFile.Close();
        }

        private void FindAverage()
        {
            for (int index = 0; index < tempsArray.Length; index++)
            {
                total += tempsArray[index];
            }
            average = (total / tempsArray.Length);
        }

        private void FindLowest()
        {
            foreach (double inputValue in tempsArray)
            {
                int index = 1;
                if (tempsArray[index] < lowest)
                {
                    lowest = tempsArray[index];
                }
                index++;
            }
        }
        private void FindHighest()
        {
            foreach (double inputValue in tempsArray)
            {
                int index = 1;
                if (tempsArray[index] > highest)
                {
                    highest = tempsArray[index];
                }
                index++;
            }
        }
    }
}
