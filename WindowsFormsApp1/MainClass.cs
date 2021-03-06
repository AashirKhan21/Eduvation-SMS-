﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    // Class For Get the path of the Folder
    class MainClass
    {
        eduvationdbDataContext eduvationdb = new eduvationdbDataContext();
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //Staff Login
        private static int staffID;
        private static string staffName;
        private static string staffRole;
        //Encapsulation
        // Set private fields to public by using properties(getter,setter)

        public static int STAFFID
        {
            get
            {
                return staffID;
            }
            private set
            {
                staffID = value;
            }
        }

        public static string STAFFNAME
        {
            get
            {
                return staffName;
            }
            private set
            {
                staffName = value;
            }
        }

        public static string STAFFROLE
        {
            get
            {
                return staffRole;
            }
            private set
            {
                staffRole = value;
            }
        }

        bool check;
        public bool GetStaffLogin(string username, string password)
        {
            var result = eduvationdb.st_getStaffLoginDetails(username, password);
            foreach (var item in result)
            {
                if (item.Name == null || item.Name == "")
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }

                STAFFID = item.Staff_ID;
                STAFFNAME = item.Name;
                STAFFROLE = item.Role;
            }
            return check;
        }

        //Method for SNO
        public static void SNo(DataGridView gridview, string colname)
        {
            int count = 0;
            foreach (DataGridViewRow row in gridview.Rows)
            {
                count++;
                row.Cells[colname].Value = count;
            }
        }
        // Method For Open and Close Form Window you have to give three parameters here
        // Opening Win , Closing Win and Parent Win which we also called MDI


        public static void ShowWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }

        // Method For Showing Message Box instead of using default method of Message box we create
        // method where we just pass the caption, message, and type

        public static DialogResult MSGBox(string msg, string caption, string type)
        {
            if (type == "Success") // If the message result is success we return this
            {
                return MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else  // If the message result is error then return this
            {
                return MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Disable Method

        // Method for Reset Disable so here we pass a container or panel so all the control in that 
        // container is reset and disable.

        public static void reset_disable(Panel panel) // panel means that container
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = false;
                    comboBox.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = false;
                    radioButton.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = false;
                    checkBox.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = false;
                    dateTimePicker.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = false;
                }
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = null;
                }
            }
        }

        //Now we create method for the Disable where we pass the container or panel as an argument
        //Container is Diable

        public static void Disable(Panel panel) // panel means that container
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = false;

                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = false;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = false;
                }
            }
        }

        //Enable Method

        // Method for Reset & Enable so here we pass a container or panel so all the control in that 
        // container is reset and enable.

        public static void reset_enable(Panel panel) // panel means that container
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = true;
                    comboBox.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = true;
                    radioButton.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = true;
                    checkBox.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = true;
                    dateTimePicker.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                }
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = null;
                }
            }
        }

        public static void reset_enable(GroupBox groupBox) // Enable reset With groupbox as parameter 
        {
            foreach (Control c in groupBox.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = true;
                    comboBox.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = true;
                    radioButton.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = true;
                    checkBox.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = true;
                    dateTimePicker.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                }
            }
        }

        //Now we create method for the Enable where we pass the container or panel as an argument
        //Container is Enable

        public static void Enable(Panel panel) // panel means that container
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = true;

                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = true;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                }
            }
        }
    }

}
