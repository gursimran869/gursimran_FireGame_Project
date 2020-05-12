using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gursimran_FireGame_Project
{
    public partial class Form1 : Form
    {
        //instance of the random class to generate the random no 
        Random rndCls = new Random();

        int counter = 0;

        int clk = 0;

        int away = 2;

        int fr = 0;

        int []btn= { 1, 1 };

        //this method is used to find the trigger to fire and find the player is still alive or died 
        public void trigger() {
            fr = rndCls.Next(1, 6);
        }
        public Form1()
        {
            InitializeComponent();
            spin_btn.Enabled = false;
            shoot_btn.Enabled = false;
            shoot_away_btn.Enabled = false;
            Exit_reload.Enabled = false;
            trigger();
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            //load the button that is used to display the first image 
            if (btn[0]==1) {
                //off the trigger of the game to work next step 
                Load_btn.Enabled = false;
                //load the image of the gun 
                FireArea.Image = gursimran_FireGame_Project.Properties.Resources.load;
                spin_btn.Enabled = true;
                btn[0] = 0;
            }
            else {
                    
            }       
        }

        private void spin_btn_Click(object sender, EventArgs e)
        {
            //when the user click on the spin button let us verify that first is it wrking or not 
            if (btn[1]==1) {
                spin_btn.Enabled = false;
                shoot_btn.Enabled = true;
                shoot_away_btn.Enabled = true;
                btn[1] = 0;
                //Spin the gun so thus we can fire  
                FireArea.Image = gursimran_FireGame_Project.Properties.Resources.new_spin1;
            }
        }

        //this method is used to generate the sound of the fire 
        public void playSound() {
            //when the counter match with the trigger after that generate  the sound of fire 
            System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(gursimran_FireGame_Project.Properties.Resources.Winchester12_RA_The_Sun_God_1722751268);
            Sound.Play();

        }

        private void shoot_btn_Click(object sender, EventArgs e)
        {
            counter++;
            FireArea.Image = gursimran_FireGame_Project.Properties.Resources.shoot_gun;
            //generate the sound of the trigger 
            playSound();
            //check the condition when the clicks are finsih then the last term to play 
            if (counter==4)
            {
                MessageBox.Show("Player is still alive ");
                shoot_btn.Enabled = false;
                shoot_away_btn.Enabled = false;
                Exit_reload.Enabled = true;
            }
            else if (counter==fr) {
                MessageBox.Show("Player is dead ");
                shoot_btn.Enabled = false;
                shoot_away_btn.Enabled = false;
                Exit_reload.Enabled = true;

            }
            
        }

        private void shoot_away_btn_Click(object sender, EventArgs e)
        {
            FireArea.Image = gursimran_FireGame_Project.Properties.Resources.shoot_gun;
            //clount the click or counter the shoot away 
            clk = clk + 1;
            if (clk<=2) {
                playSound();
            }
            //when two cliks are done then display the player is alive 
            if (clk==2) {
                MessageBox.Show("Player is still alive  ");
                shoot_away_btn.Enabled = false;
                shoot_btn.Enabled = false;
            }
            else if (clk == fr)
            {
                MessageBox.Show("Player is dead Now ");
                shoot_away_btn.Enabled = false;
                shoot_btn.Enabled = false;

            }
            
        }

        private void Exit_reload_Click(object sender, EventArgs e)
        {
            //replay the game again 
            Application.Restart();
        }
    }
}
