using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferrari_8_Automobile_con_cambio_automatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CloseForms();
            var rispExt = MessageBox.Show("Utilizzare cambio automatico?", "Cambio Automatico", MessageBoxButtons.YesNo);
            if (rispExt == DialogResult.Yes)
            {
                OpenForm<FormAutomatico>();
            }
            else
            {
                OpenForm<FormSequenziale>();
            }
        }
        private void OpenForm<MyForm>() where MyForm : Form, new()
        {
            Form viewedForm;
            viewedForm = panelForm.Controls.OfType<MyForm>().FirstOrDefault();
            if (viewedForm == null)
            {
                viewedForm = new MyForm();
                viewedForm.TopLevel = false;
                viewedForm.FormBorderStyle = FormBorderStyle.None;
                viewedForm.Dock = DockStyle.Fill;
                panelForm.Controls.Add(viewedForm);
                panelForm.Tag = viewedForm;
                viewedForm.Show();
                viewedForm.BringToFront();
            }
            else
            {
                viewedForm.BringToFront();
            }
        }
        private void CloseForms()
        {
            Form[] forms = new Form[panelForm.Controls.Count];
            for (int i = 0; i < panelForm.Controls.Count; i++)
            {
                forms[i] = panelForm.Controls[i] as Form;
            }
            foreach (Form form in forms)
            {
                form.Close();
            }
        }
    }
}
