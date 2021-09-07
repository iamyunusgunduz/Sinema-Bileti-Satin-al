﻿using CinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketSalesAutomation
{
    public partial class Form2 : Form
    {
        public Form2(List<Movie> _movies, Form1 _form1)
        {
            InitializeComponent();
            movies = _movies;
            form1 = _form1;

        }


        List<Movie> movies;
        Form1 form1;
        Movie selectedMovie;
        Session selectedSession;

        public void ListDetail(int movieIndex, string _time, string _date)
        {
            selectedMovie = movies[movieIndex];
            selectedSession = selectedMovie.sessions.Find(s => s.date == _date && s.time == _time);
            lblTime.Text = $"{_date}-{_time}";
            lblMinute.Text = selectedMovie.minute;
            lblPrice.Text = selectedMovie.price.ToString() + " tl";
            pictureboxSelectedPicture.Image = Image.FromFile(selectedMovie.picturePath);
            lblCategory.Text = selectedMovie.category.ToString();
            CheckChairStatus();
        }
        private void CheckChairStatus()
        {
            foreach (Control item in grbChairs.Controls)
            {
                if (item is Button)
                {
                    string row = item.Tag.ToString();
                    string number = item.Text;
                    item.Enabled = true;
                    foreach (Chair chair in selectedSession.chairs)
                    {

                        if (chair.row==row && chair.number==number)
                        {

                            if (chair.status)
                            {
                                item.BackColor = Color.DarkRed;
                                item.Enabled = false;

                            }
                            else
                            {
                                item.BackColor = Color.LightGreen;
                            }
                            break;
                        }


                    }

                }
            }
        }
        List<Chair> chairs = new List<Chair>();

        private void button24_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string row = button.Tag.ToString();
            string number = button.Text;
            Chair chair = selectedSession.chairs.Find(c => c.row==row && c.number==number );
            if (button.BackColor.Name !="Blue")
            {
                chairs.Add(chair);
                button.BackColor = Color.Blue;

            }
            else
            {
                chairs.Remove(chair);
                button.BackColor = Color.LightGreen;
            }

                
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (chairs.Count==0)
            {
                MessageBox.Show("koltuk seçilmedi !");
                return;
            }
            Sales sales = new Sales();
            sales.movieName = selectedMovie.movieName;
            sales.count = chairs.Count;
            sales.sessionTime = $"{selectedSession.date}-{selectedSession.time}";
            sales.totalPrice = calculatePrice();
            foreach (Chair chair in chairs)
            {
                chair.status = true;

            }



            MessageBox.Show(sales.ToString());

            ChangePage();
        }
        private void ChangePage ()
        {
            rbLarge.Checked = rbMedium.Checked = rbSmall.Checked = false;
            chairs.Clear();
            this.Hide();
            form1.Show();

        }

        private Decimal calculatePrice()
        {
            decimal price = (selectedMovie.price * chairs.Count);
            if (rbSmall.Checked)
            {
                price += 3*(chairs.Count);
            }
            else if (rbMedium.Checked)
            {
                price += 6 * (chairs.Count);
            }
            else if (rbLarge.Checked)
            {
                price += 9 * (chairs.Count);
            }
            return price;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangePage();
        }
    }
}

    