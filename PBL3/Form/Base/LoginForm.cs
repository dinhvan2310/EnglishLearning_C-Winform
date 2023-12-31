﻿using PBL3.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class LoginForm : Form
    {
        Form _CurrentChildForm;

        public LoginForm()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(ExternalImport.CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            StartPosition = FormStartPosition.CenterScreen;
            OpenChildForm(new FormSignIn());

        }

        #region HELPER FUNCTIONS

        public void OpenChildForm(Form childForm)
        {
            if (_CurrentChildForm != null)
            {
                _CurrentChildForm.Dispose();
            }

            _CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelBase.Controls.Add(childForm);
            panelBase.Tag = childForm;
            childForm.SendToBack();
            childForm.Show();
        }

        #endregion

        #region EVENTS

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            ExternalImport.ReleaseCapture();
            ExternalImport.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalForm.MainForm.Show();
            GlobalForm.LoginForm.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        
    }
}
