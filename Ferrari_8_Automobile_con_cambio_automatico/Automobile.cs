using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari_8_Automobile_con_cambio_automatico
{
    class Automobile
    {
        protected bool _accesa;
        protected int _velocita;
        protected int _giriMinuto;
        protected int _marce;

        public double[,] rapporti = new double [,] 
        { 
            { 4, 3.5, 2.5, 1.8, 1.3, 1.0, 0.8 },
            { 20, 20, 40, 60, 90, 130, 180 },
        };

        public Automobile() 
        { 
            _accesa = false;
            _velocita = 0;
            _giriMinuto = 0;
            _marce = 0;
        }

        public bool Accesa
        {
            get { return _accesa; }
            set { _accesa = value; }
        }
        public int Velocita
        { 
            get { return _velocita; }
            set { _velocita = value; }
        }
        public int GiriMinuto
        { 
            get { return _giriMinuto; }
            set { _giriMinuto = value; }
        }
        public int Marce
        {
            get { return _marce; }
            set { _marce = value; }
        }
        public void Accendi()
        {
            if (Velocita == 0 && Marce == 0)
            {
                Accesa = !Accesa;
            }
        }
        public void Accelera()
        {
            if (Accesa && Marce > 0 && Velocita < rapporti[1, Marce])
            {
                GiriMinuto += 500;
                Velocita = CalcolaVelocita();
            }
            if (Accesa && Marce == -1 && Velocita < rapporti[1, 0])
            {
                GiriMinuto += 500;
                Velocita = CalcolaVelocita();
            }
        }
        public void Frena()
        {
            if (Accesa && Marce > 1 && Velocita > rapporti[1, Marce - 1])
            {
                GiriMinuto -= 500;
                Velocita = CalcolaVelocita();
            }
            if (Accesa && Marce == -1)
            {
                GiriMinuto -= 500;
                if (GiriMinuto < 0)
                    GiriMinuto = 0;
                Velocita = CalcolaVelocita();
            }
            if (Accesa && Marce == 1 && Velocita > 0)
            {
                GiriMinuto -= 500;
                if (GiriMinuto < 0)
                    GiriMinuto = 0;
                Velocita = CalcolaVelocita();
            }
        }
        public void AumentaMarcia()
        {
            if (Accesa && Marce < 6)
            {
                Marce++;
                GiriMinuto = CalcolaGiriMin();
            }
        }
        public void DiminuisciMarcia()
        {
            if (Accesa && Marce > -1)
            {
                if (Marce == 1)
                {
                    if (Velocita != 0)
                    {
                        return;
                    }
                    else
                    {
                        Marce--;
                        return;
                    }
                }
                if (Marce > 1 && Velocita <= rapporti[1, Marce - 1] || Marce == 0)
                {
                    Marce--;
                    GiriMinuto = CalcolaGiriMin();
                }
            }
        }
        public int CalcolaVelocita()
        {
            double rapportoTrans;
            if (Marce == -1)
            {
                rapportoTrans = rapporti[0, 0];
            }
            else
            {
                rapportoTrans = rapporti[0, Marce];
            }
            return (int)(GiriMinuto / (rapportoTrans * 60) * 3.6);
        }
        public int CalcolaGiriMin()
        {
            double rapportoTrans;
            if (Marce == -1)
            {
                rapportoTrans = rapporti[0, 0];
            }
            else
            {
                rapportoTrans = rapporti[0, Marce];
            }
            return (int)(Velocita / 3.6 * rapportoTrans * 60);
        }
    }
}
