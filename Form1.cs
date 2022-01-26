namespace calcolatrice
{
    public partial class Form1 : Form
    {
        double risultato = 0;
        int operazione = 0;
        double valore = 0;
        bool cancella = false;
        double NMemoria = 0;
        bool temaform = false;
        bool cambioTemaForz = false;

        public Form1()
        {
            InitializeComponent();
        }


        // BOTTONE UGUALE
        private void buttonUguale_Click(object sender, EventArgs e)
        {
            switch (operazione)
            {
                case <=4:
                    operazioneAttiva();
                    break;
                case 5:
                    if (labelDisplay.Text != "")
                    {
                        double i = 0;
                        double n = risultato;
                        double j = Convert.ToDouble(labelDisplay.Text);
                        for(i=1;i<j;i++)
                        {
                            risultato = risultato * n;
                        }
                    }
                    break;
            }
            labelCronologia.Text += labelOperazioneAttiva.Text + labelDisplay.Text + " = ";
            labelDisplay.Text = Convert.ToString(risultato);
            labelCronologia.Text += risultato + "\n";;
            labelOperazioneAttiva.Text = "";
            operazione = 0;
            risultato = 0;
            cancella = false;
        }

        //FUNC SWITCH OPERAZIONI
        private double operazioneAttiva()
        {
            switch (operazione)
            {
                case 1:
                    if (labelDisplay.Text != "")
                    {
                        risultato += Convert.ToDouble(labelDisplay.Text);
                    }
                    break;
                case 2:
                    if (labelDisplay.Text != "")
                    {
                        risultato -= Convert.ToDouble(labelDisplay.Text);
                    }
                    break;
                case 3:
                    if (labelDisplay.Text != "")
                    {
                        risultato *= Convert.ToDouble(labelDisplay.Text);
                    }
                    break;
                case 4:
                    if (labelDisplay.Text != "")
                    {
                        risultato /= Convert.ToDouble(labelDisplay.Text);
                    }
                    break;
            }
            return risultato;
        }

        //BOTTONE +
        private void buttonPiu_Click(object sender, EventArgs e)
        {
            switch (operazione)
            {
                case 0:
                    if (labelDisplay.Text != "")
                    {
                        risultato += Convert.ToDouble(labelDisplay.Text);
                    }
                    break;
                case >=1:
                    operazioneAttiva();
                    break;
            }
            labelOperazioneAttiva.Text += labelDisplay.Text;
            labelOperazioneAttiva.Text += " + ";
            labelDisplay.Text = Convert.ToString(risultato);
            operazione = 1;
            cancella = false;
        }

        //BOTTONE -
        private void buttonMeno_Click(object sender, EventArgs e)
        {
            switch (operazione)
            {
                case 0:
                    if (labelDisplay.Text != "")
                    {
                        if (risultato == 0)
                        {
                            risultato = Convert.ToDouble(labelDisplay.Text);
                        }
                        else
                        {
                            risultato -= Convert.ToDouble(labelDisplay.Text);
                        }
                    }
                    break;
                case >= 1:
                    operazioneAttiva();
                    break;
            }
            operazione = 2;
            labelOperazioneAttiva.Text += labelDisplay.Text;
            labelOperazioneAttiva.Text += " - ";
            labelDisplay.Text = Convert.ToString(risultato);
            cancella = false;
        }

        //BOTTONE X
        private void buttonPer_Click(object sender, EventArgs e)
        {
            switch (operazione)
            {
                case 0:
                    if (labelDisplay.Text != "")
                    {
                        if (risultato == 0)
                        {
                            risultato = 1;
                        }
                        risultato *= Convert.ToDouble(labelDisplay.Text);
                    }
                    break;
                case >= 1:
                    operazioneAttiva();
                    break;
            }
            labelOperazioneAttiva.Text += labelDisplay.Text;
            labelOperazioneAttiva.Text += " x ";
            labelDisplay.Text = Convert.ToString(risultato);
            operazione = 3;
            cancella = false;
        }

        //BOTTONE :
        private void buttonDiviso_Click(object sender, EventArgs e)
        {
            switch (operazione)
            {
                case 0:
                    if (labelDisplay.Text != "")
                    {
                        if (risultato == 0)
                        {
                            risultato = Convert.ToDouble(labelDisplay.Text);
                        }
                        else
                        {
                            risultato /= Convert.ToDouble(labelDisplay.Text);
                        }
                    }
                    break;
                case >= 1:
                    operazioneAttiva();
                    break;
            }
            labelOperazioneAttiva.Text += labelDisplay.Text;
            labelOperazioneAttiva.Text += " ÷ ";
            labelDisplay.Text = Convert.ToString(risultato);
            operazione = 4;
            cancella = false;
        }

        //BOTTONI NUMERI
        private void BtnNumeriClick(object sender, EventArgs e)
        {
            if (cancella == false)
            {
                labelDisplay.Text = "";
                cancella = true;
            }
            labelDisplay.Text += (sender as Button).Text;
        }

        //BOTTONE ,
        private void buttonVirgola_Click(object sender, EventArgs e)
        {
            bool nVirgola = labelDisplay.Text.Contains(",");
            if (nVirgola == false)
            {
                labelDisplay.Text += ",";
            }
        }

        //BOTTONE +/-
        private void buttonCambioSegno_Click(object sender, EventArgs e)
        {
            valore = Convert.ToDouble(labelDisplay.Text);
            valore = valore * (-1);
            labelDisplay.Text = Convert.ToString(valore);
        }

        //BOTTONE %
        private void buttonPercentuale_Click(object sender, EventArgs e)
        {
            labelCronologia.Text += labelDisplay.Text;
            labelCronologia.Text += "% = ";
            valore = Convert.ToDouble(labelDisplay.Text);
            valore = valore / 100;
            labelDisplay.Text = Convert.ToString(valore);
            labelCronologia.Text += valore;
            labelCronologia.Text += "\n";
            valore = 0;
        }

        //BOTTONE C
        private void buttonC_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "";
        }

        //BOTTONE CE
        private void buttonCE_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "";
            risultato = 0;
            operazione = 0;
            labelOperazioneAttiva.Text = "";
        }

        //BOTTONE SM
        private void buttonSM_Click(object sender, EventArgs e)
        {
            NMemoria = Convert.ToDouble(labelDisplay.Text);
            buttonCM.Enabled = true;
            buttonMMeno.Enabled = true;
            buttonRM.Enabled = true;
            buttonMPiu.Enabled = true;
            buttonCM.BackColor = Color.DarkOrange;
            buttonMMeno.BackColor = Color.DarkOrange;
            buttonRM.BackColor = Color.DarkOrange;
            buttonMPiu.BackColor = Color.DarkOrange;
            labelMemoria.Text = "memoria: " + Convert.ToString(NMemoria);
        }

        //BOTTONE M+
        private void buttonMPiu_Click(object sender, EventArgs e)
        {
            risultato = NMemoria + Convert.ToDouble(labelDisplay.Text);
            labelDisplay.Text = Convert.ToString(risultato);
        }

        //BOTTONE M-
        private void buttonMMeno_Click(object sender, EventArgs e)
        {
            risultato = NMemoria - Convert.ToDouble(labelDisplay.Text);
            labelDisplay.Text = Convert.ToString(risultato);
        }

        //BOTTONE RM
        private void buttonRM_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = Convert.ToString(NMemoria);
        }

        //BOTTONE CM
        private void buttonCM_Click(object sender, EventArgs e)
        {
            NMemoria = 0;
            buttonCM.Enabled = false;
            buttonMMeno.Enabled = false;
            buttonRM.Enabled = false;
            buttonMPiu.Enabled = false;
            buttonCM.BackColor = Color.Peru;
            buttonMMeno.BackColor = Color.Peru;
            buttonRM.BackColor = Color.Peru;
            buttonMPiu.BackColor = Color.Peru;
            labelMemoria.Text = "";
        }

        //CARICAMENTO FINESTRA
        private void Form1_Load(object sender, EventArgs e)
        {
            labelDisplay.Text = "";
            labelOperazioneAttiva.Text = "";
            labelMemoria.Text = "";
            labelCronologia.Text = "";
            labelOrario.Text = "";
           
        }

        //BOTTONE BACKSPACE
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            
                if ((String.Compare(labelDisplay.Text, " ") < 0))
                {
                    labelDisplay.Text = labelDisplay.Text.Substring(0, labelDisplay.Text.Length - 1 + 1);
                }
                else
                {
                    labelDisplay.Text = labelDisplay.Text.Substring(0, labelDisplay.Text.Length - 1);
                }
        }

        //BOTTONE X2
        private void buttonQuadrato_Click(object sender, EventArgs e)
        {
            valore = Convert.ToDouble(labelDisplay.Text);
            labelCronologia.Text += labelDisplay.Text;
            labelCronologia.Text += "² = ";
            valore = valore * valore;
            labelDisplay.Text = Convert.ToString(valore);
            labelCronologia.Text += valore;
            labelCronologia.Text += "\n";
            valore = 0;
        }

        //BOTTONE X3
        private void buttonCubo_Click(object sender, EventArgs e)
        {
            valore = Convert.ToDouble(labelDisplay.Text);
            labelCronologia.Text += labelDisplay.Text;
            labelCronologia.Text += "³ = ";
            valore = valore * valore * valore;
            labelDisplay.Text = Convert.ToString(valore);
            labelCronologia.Text += valore;
            labelCronologia.Text += "\n";
            valore = 0;
        }

        //BOTTONE XY
        private void buttonPotenzaXy_Click(object sender, EventArgs e)
        {
            risultato = Convert.ToDouble(labelDisplay.Text);
            operazione = 5;
            labelOperazioneAttiva.Text += labelDisplay.Text;
            labelOperazioneAttiva.Text += "^ ";
            labelDisplay.Text = Convert.ToString(risultato);
            cancella = false;
        }

        //BOTTONE PI GRECO
        private void buttonPi_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "3,1415926535";
        }


        //TIMER CAMBIO TEMA
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now.Hour >= 18 && DateTime.Now.Minute >= 40) || DateTime.Now.Hour >= 19 ||(DateTime.Now.Hour <= 6 && DateTime.Now.Minute <= 40) || DateTime.Now.Hour <= 5)
            { 
                CambiaColore(true);
            }
            else
            {
                CambiaColore(false);
            }
        }
        //FUNC CAMBIO COLORE CON TIMER
        private void CambiaColore(bool tema)
        {
            if (tema == false)
            {
                coloreChiaro();
            }
            else if (tema == true)
            {
                coloreScuro();
            }
        }

        //BOTTONE CAMBIO TEMA
        private void button13_Click(object sender, EventArgs e)
        {
            CambiaColore();
            timer1.Enabled = false;
        }
        //FUNC CAMBIO COLORE TASTO
        private void CambiaColore()
        {
            if (temaform == false)
            {
                coloreChiaro();
            }
            else if (temaform == true)
            {
                coloreScuro();
            }
        }

        //CAMBIO COLORE IN CHIARO
        private void coloreChiaro()
        {
            this.BackColor = Color.Khaki;
            labelCronologia.BackColor = Color.WhiteSmoke;
            labelCronologia.ForeColor = Color.FromArgb(64, 64, 64);
            button13.BackColor = Color.FromArgb(64, 64, 64);
            temaform = true;
            labelOrario.ForeColor = Color.FromArgb(64, 64, 64);
            button13.Text = "○";
        }

        //CAMBIO COLORE IN SCURO
        private void coloreScuro()
        {
            this.BackColor = Color.FromArgb(26, 26, 26);
            labelCronologia.BackColor = Color.FromArgb(64, 64, 64);
            labelCronologia.ForeColor = Color.WhiteSmoke;
            button13.BackColor = Color.WhiteSmoke;
            temaform = false;
            labelOrario.ForeColor = Color.WhiteSmoke;
            button13.Text = "☼";
        }

        //LABEL ORARIO
        private void timerOrario_Tick(object sender, EventArgs e)
        {
            labelOrario.Text = DateTime.Now.Hour.ToString() + ":";
            if (DateTime.Now.Minute <10)
            {
                labelOrario.Text += "0";
            }
            labelOrario.Text += DateTime.Now.Minute.ToString() + ":";
            if (DateTime.Now.Second < 10)
            {
                labelOrario.Text += "0";
            }
            labelOrario.Text += DateTime.Now.Second.ToString();  
        }
    }
}