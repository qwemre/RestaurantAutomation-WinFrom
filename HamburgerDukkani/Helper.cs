using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerDukkani
{
    internal class Helper
    {
        public static void Temizle2(Control.ControlCollection collection)
        {
            foreach (Control control in collection)
            {
                if(control is ListBox)
                {
                    ((ListBox)control).Items.Clear();
                }
            }
        }
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control control in collection)
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is CheckBox)
                {
                    CheckBox chk = (CheckBox)control;
                    chk.Checked = false;
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = 0;
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown nm = (NumericUpDown)control;
                    nm.Value = 1;
                }
           
                else if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Name != "kücük")
                    {
                        rb.Checked = true;
                    }
                }
                else if (control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;

                    Temizle(flowLayoutPanel.Controls);
                }
          
        }
    }
}
