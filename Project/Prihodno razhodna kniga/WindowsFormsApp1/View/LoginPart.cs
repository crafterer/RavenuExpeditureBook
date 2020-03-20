﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.Data.Models;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.View
{
    public partial class LoginPart : Form
    {
        public LoginPart()
        {
            InitializeComponent();
        }
        ApplicationContexts contexts = new ApplicationContexts();
        RegisterPart register = new RegisterPart();
        RevenueExpeditureBook smallshop = new RevenueExpeditureBook();
        
        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            register.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var small = "Small Shop";
            var medium = "Medium Shop";
            var large = "Large Shop";
            var pass = txtPassword.Text;
            var username = txtUsername.Text;
            var Checkpass = contexts.PersonRegisters.FirstOrDefault(x => x.Password == pass);
            var CheckUsername = contexts.PersonRegisters.FirstOrDefault(x => x.Username == username);

            var checkforBook = contexts.PersonBookTypes.FirstOrDefault(x => x.BookType == small);

            try
            {
                if (Checkpass.Password == txtPassword.Text && CheckUsername.Username == txtUsername.Text)
                {
                    if (checkforBook.BookType == "Small Shop")
                    {
                        this.Hide();
                        smallshop.Show();
                    }
                    //else if (personRegister.PersonAccountId == personAccount.Id && personAccount.BookType == "Medium Shop")
                    //{
                    //    //medium shop
                    //}
                    //else
                    //{
                    //    //large shop
                    //}
                }
            } 
            catch (Exception)
            {
                MessageBox.Show("Invalid Password or Username!");
            }
        }
    }
}
