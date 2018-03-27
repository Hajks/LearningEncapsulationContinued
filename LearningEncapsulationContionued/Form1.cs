using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEncapsulationContionued
{
    public partial class Form1 : Form
    {
        SecretAgent ciaAgent = new SecretAgent() { Alias = "DashMartin", Password = "wrona lata o północy", RealName = "Herb Jones" };
        EnemyAgent kgbAgent = new EnemyAgent() { Borscht = "Looking for ciaAgent", Vodka = "It's always good time to drink" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        //If class SecretAgent got public types, EnemyAgent got access to them. If type is private we gonna receive this message 
        //"'SecretAgent.RealName' is inaccessible due to its protection level"
        {
            kgbAgent.Borscht = ciaAgent.RealName;
            MessageBox.Show(kgbAgent.Borscht);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ciaAgent.Password)
            { 
            ciaAgent.AgentGreeting(textBox1.Text);
            }
            else
            {
                ciaAgent.AgentGreeting("xd");
            }
        }
    }
}
