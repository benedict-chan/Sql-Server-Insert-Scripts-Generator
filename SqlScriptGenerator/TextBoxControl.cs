using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SqlScriptGenerator
{
    public partial class TextBoxControl : Form
    {
        public TextBoxControl()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            txt_Detail.Text = text;
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(txt_Detail.Text, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Detail_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control)
                {
                    if (e.KeyCode == Keys.A)
                        txt_Detail.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}