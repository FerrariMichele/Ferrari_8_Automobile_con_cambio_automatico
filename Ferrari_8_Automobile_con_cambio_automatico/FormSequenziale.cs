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
    public partial class FormSequenziale : Form
    {
        Automobile Auto;
        public FormSequenziale()
        {
            InitializeComponent();
            Auto = new Automobile();
        }

        private void buttonFreno_Click(object sender, EventArgs e)
        {
            Auto.Frena();
            AggiornaUI();
        }
        private void buttonAcceleratore_Click(object sender, EventArgs e)
        {
            Auto.Accelera();
            AggiornaUI();
        }
        private void buttonUpShift_Click(object sender, EventArgs e)
        {
            Auto.AumentaMarcia();
            AggiornaUI();
        }
        private void buttonDownShift_Click(object sender, EventArgs e)
        {
            Auto.DiminuisciMarcia();
            AggiornaUI();
        }
        private void buttonAccensione_Click(object sender, EventArgs e)
        {
            Auto.Accendi();
            AggiornaUI();
        }
        private void AggiornaUI()
        {
            labelVelocita.Text = (Auto.Velocita).ToString();
            labelGiri.Text = (Auto.GiriMinuto).ToString();
            if (Auto.Accesa) labelOnOff.Text = "On";
            else labelOnOff.Text = "Off";
            labelMarcia.Text = (Auto.Marce).ToString();
        }
    }
}
