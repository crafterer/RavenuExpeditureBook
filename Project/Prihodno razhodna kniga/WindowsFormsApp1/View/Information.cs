﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    /// <summary>
    /// Main Infromation partial class
    /// Countains methods which shows the information
    /// </summary>
    public partial class Information : Form
    {
        /// <summary>
        /// InitializeComponent constructor
        /// </summary>
        public Information()
        {
            InitializeComponent();
        }

        //Shows information in English
        private void Englishbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 - Update: Save's the current results or creates a new save file" + Environment.NewLine + "2 - Income: Аmount of cash earnerd today" + Environment.NewLine + "3 - Raw Material: Available cash for supplies" + Environment.NewLine + "4 - Expenses: Own Expenses" + Environment.NewLine + "5 - Balance: Sum of all the income and expediture" + Environment.NewLine + "6 - Counted: Daily report" + Environment.NewLine + "8 - Delete: Deletes the first save file" + Environment.NewLine + "9 - Synchronize: Takes yesterday's counted cash and put's them in the first checkout");
        }

        //Shows information in Bulgarian
        private void Bulgarian_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 - Update: Записва текущите резултати или създава нов save файл" + Environment.NewLine + "2 - Income: Сумата на спечелените пари за днес" + Environment.NewLine + "3 - Raw Material: Налични пари за припаси" + Environment.NewLine + "4 - Expenses: Собствени Разходи" + Environment.NewLine + "5 - Balance: Сума от всички приходи и разходи" + Environment.NewLine + "6 - Counted: Днешеният Отчет" + Environment.NewLine + "8 - Delete: Изтрива първия запазен файл" + Environment.NewLine + "9 - Synchronize: Взема отчета от вчерашния ден и го поставя в първата каса");
        }
    }
}
