namespace calcolatrice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonUguale = new System.Windows.Forms.Button();
            this.labelOperazioneAttiva = new System.Windows.Forms.Label();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.labelMemoria = new System.Windows.Forms.Label();
            this.labelCronologia = new System.Windows.Forms.Label();
            this.buttonPiu = new System.Windows.Forms.Button();
            this.buttonMeno = new System.Windows.Forms.Button();
            this.buttonPer = new System.Windows.Forms.Button();
            this.buttonDiviso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonPercentuale = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonCambioSegno = new System.Windows.Forms.Button();
            this.buttonVirgola = new System.Windows.Forms.Button();
            this.buttonCM = new System.Windows.Forms.Button();
            this.buttonRM = new System.Windows.Forms.Button();
            this.buttonMMeno = new System.Windows.Forms.Button();
            this.buttonMPiu = new System.Windows.Forms.Button();
            this.buttonSM = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonQuadrato = new System.Windows.Forms.Button();
            this.buttonCubo = new System.Windows.Forms.Button();
            this.buttonPotenzaXy = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button13 = new System.Windows.Forms.Button();
            this.labelOrario = new System.Windows.Forms.Label();
            this.timerOrario = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonUguale
            // 
            this.buttonUguale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonUguale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUguale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUguale.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUguale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUguale.Location = new System.Drawing.Point(387, 456);
            this.buttonUguale.Name = "buttonUguale";
            this.buttonUguale.Size = new System.Drawing.Size(50, 50);
            this.buttonUguale.TabIndex = 0;
            this.buttonUguale.Text = "=";
            this.buttonUguale.UseVisualStyleBackColor = false;
            this.buttonUguale.Click += new System.EventHandler(this.buttonUguale_Click);
            // 
            // labelOperazioneAttiva
            // 
            this.labelOperazioneAttiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelOperazioneAttiva.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOperazioneAttiva.Location = new System.Drawing.Point(163, 38);
            this.labelOperazioneAttiva.Name = "labelOperazioneAttiva";
            this.labelOperazioneAttiva.Size = new System.Drawing.Size(274, 25);
            this.labelOperazioneAttiva.TabIndex = 1;
            this.labelOperazioneAttiva.Text = "labelOperazioneAttiva";
            // 
            // labelDisplay
            // 
            this.labelDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDisplay.Location = new System.Drawing.Point(163, 63);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(274, 112);
            this.labelDisplay.TabIndex = 2;
            this.labelDisplay.Text = "labelDisplay";
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelMemoria
            // 
            this.labelMemoria.BackColor = System.Drawing.Color.Orange;
            this.labelMemoria.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMemoria.Location = new System.Drawing.Point(464, 38);
            this.labelMemoria.Name = "labelMemoria";
            this.labelMemoria.Size = new System.Drawing.Size(274, 25);
            this.labelMemoria.TabIndex = 3;
            this.labelMemoria.Text = "labelMemoria";
            this.labelMemoria.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCronologia
            // 
            this.labelCronologia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCronologia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCronologia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelCronologia.Location = new System.Drawing.Point(464, 63);
            this.labelCronologia.Name = "labelCronologia";
            this.labelCronologia.Size = new System.Drawing.Size(274, 443);
            this.labelCronologia.TabIndex = 4;
            this.labelCronologia.Text = "labelCronologia";
            this.labelCronologia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonPiu
            // 
            this.buttonPiu.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonPiu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPiu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPiu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPiu.Location = new System.Drawing.Point(387, 400);
            this.buttonPiu.Name = "buttonPiu";
            this.buttonPiu.Size = new System.Drawing.Size(50, 50);
            this.buttonPiu.TabIndex = 5;
            this.buttonPiu.Text = "+";
            this.buttonPiu.UseVisualStyleBackColor = false;
            this.buttonPiu.Click += new System.EventHandler(this.buttonPiu_Click);
            // 
            // buttonMeno
            // 
            this.buttonMeno.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonMeno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMeno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMeno.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMeno.Location = new System.Drawing.Point(387, 344);
            this.buttonMeno.Name = "buttonMeno";
            this.buttonMeno.Size = new System.Drawing.Size(50, 50);
            this.buttonMeno.TabIndex = 6;
            this.buttonMeno.Text = "-";
            this.buttonMeno.UseVisualStyleBackColor = false;
            this.buttonMeno.Click += new System.EventHandler(this.buttonMeno_Click);
            // 
            // buttonPer
            // 
            this.buttonPer.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonPer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPer.Location = new System.Drawing.Point(387, 289);
            this.buttonPer.Name = "buttonPer";
            this.buttonPer.Size = new System.Drawing.Size(50, 50);
            this.buttonPer.TabIndex = 7;
            this.buttonPer.Text = "x";
            this.buttonPer.UseVisualStyleBackColor = false;
            this.buttonPer.Click += new System.EventHandler(this.buttonPer_Click);
            // 
            // buttonDiviso
            // 
            this.buttonDiviso.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDiviso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiviso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDiviso.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDiviso.Location = new System.Drawing.Point(387, 234);
            this.buttonDiviso.Name = "buttonDiviso";
            this.buttonDiviso.Size = new System.Drawing.Size(50, 50);
            this.buttonDiviso.TabIndex = 8;
            this.buttonDiviso.Text = ":";
            this.buttonDiviso.UseVisualStyleBackColor = false;
            this.buttonDiviso.Click += new System.EventHandler(this.buttonDiviso_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(219, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(275, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(331, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(219, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(275, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(331, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(219, 289);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(275, 289);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(331, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(275, 456);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 18;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.BtnNumeriClick);
            // 
            // buttonPercentuale
            // 
            this.buttonPercentuale.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonPercentuale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPercentuale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPercentuale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPercentuale.Location = new System.Drawing.Point(331, 233);
            this.buttonPercentuale.Name = "buttonPercentuale";
            this.buttonPercentuale.Size = new System.Drawing.Size(50, 50);
            this.buttonPercentuale.TabIndex = 19;
            this.buttonPercentuale.Text = "%";
            this.buttonPercentuale.UseVisualStyleBackColor = false;
            this.buttonPercentuale.Click += new System.EventHandler(this.buttonPercentuale_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonC.Location = new System.Drawing.Point(275, 233);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(50, 50);
            this.buttonC.TabIndex = 20;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCE.Location = new System.Drawing.Point(219, 233);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(50, 50);
            this.buttonCE.TabIndex = 21;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonCambioSegno
            // 
            this.buttonCambioSegno.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCambioSegno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCambioSegno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCambioSegno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCambioSegno.Location = new System.Drawing.Point(331, 456);
            this.buttonCambioSegno.Name = "buttonCambioSegno";
            this.buttonCambioSegno.Size = new System.Drawing.Size(50, 50);
            this.buttonCambioSegno.TabIndex = 22;
            this.buttonCambioSegno.Text = "+/-";
            this.buttonCambioSegno.UseVisualStyleBackColor = false;
            this.buttonCambioSegno.Click += new System.EventHandler(this.buttonCambioSegno_Click);
            // 
            // buttonVirgola
            // 
            this.buttonVirgola.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonVirgola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVirgola.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVirgola.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVirgola.Location = new System.Drawing.Point(219, 456);
            this.buttonVirgola.Name = "buttonVirgola";
            this.buttonVirgola.Size = new System.Drawing.Size(50, 50);
            this.buttonVirgola.TabIndex = 23;
            this.buttonVirgola.Text = ",";
            this.buttonVirgola.UseVisualStyleBackColor = false;
            this.buttonVirgola.Click += new System.EventHandler(this.buttonVirgola_Click);
            // 
            // buttonCM
            // 
            this.buttonCM.BackColor = System.Drawing.Color.Peru;
            this.buttonCM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCM.Enabled = false;
            this.buttonCM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCM.Location = new System.Drawing.Point(163, 196);
            this.buttonCM.Name = "buttonCM";
            this.buttonCM.Size = new System.Drawing.Size(50, 31);
            this.buttonCM.TabIndex = 24;
            this.buttonCM.Text = "CM";
            this.buttonCM.UseVisualStyleBackColor = false;
            this.buttonCM.Click += new System.EventHandler(this.buttonCM_Click);
            // 
            // buttonRM
            // 
            this.buttonRM.BackColor = System.Drawing.Color.Peru;
            this.buttonRM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRM.Enabled = false;
            this.buttonRM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRM.Location = new System.Drawing.Point(219, 196);
            this.buttonRM.Name = "buttonRM";
            this.buttonRM.Size = new System.Drawing.Size(50, 31);
            this.buttonRM.TabIndex = 25;
            this.buttonRM.Text = "RM";
            this.buttonRM.UseVisualStyleBackColor = false;
            this.buttonRM.Click += new System.EventHandler(this.buttonRM_Click);
            // 
            // buttonMMeno
            // 
            this.buttonMMeno.BackColor = System.Drawing.Color.Peru;
            this.buttonMMeno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMMeno.Enabled = false;
            this.buttonMMeno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMMeno.Location = new System.Drawing.Point(275, 196);
            this.buttonMMeno.Name = "buttonMMeno";
            this.buttonMMeno.Size = new System.Drawing.Size(50, 31);
            this.buttonMMeno.TabIndex = 26;
            this.buttonMMeno.Text = "M-";
            this.buttonMMeno.UseVisualStyleBackColor = false;
            this.buttonMMeno.Click += new System.EventHandler(this.buttonMMeno_Click);
            // 
            // buttonMPiu
            // 
            this.buttonMPiu.BackColor = System.Drawing.Color.Peru;
            this.buttonMPiu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMPiu.Enabled = false;
            this.buttonMPiu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMPiu.Location = new System.Drawing.Point(331, 196);
            this.buttonMPiu.Name = "buttonMPiu";
            this.buttonMPiu.Size = new System.Drawing.Size(50, 31);
            this.buttonMPiu.TabIndex = 27;
            this.buttonMPiu.Text = "M+";
            this.buttonMPiu.UseVisualStyleBackColor = false;
            this.buttonMPiu.Click += new System.EventHandler(this.buttonMPiu_Click);
            // 
            // buttonSM
            // 
            this.buttonSM.BackColor = System.Drawing.Color.Orange;
            this.buttonSM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSM.Location = new System.Drawing.Point(387, 196);
            this.buttonSM.Name = "buttonSM";
            this.buttonSM.Size = new System.Drawing.Size(50, 31);
            this.buttonSM.TabIndex = 28;
            this.buttonSM.Text = "SM";
            this.buttonSM.UseVisualStyleBackColor = false;
            this.buttonSM.Click += new System.EventHandler(this.buttonSM_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBackspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackspace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackspace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBackspace.Location = new System.Drawing.Point(163, 233);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(50, 50);
            this.buttonBackspace.TabIndex = 29;
            this.buttonBackspace.Text = "⌫";
            this.buttonBackspace.UseVisualStyleBackColor = false;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonQuadrato
            // 
            this.buttonQuadrato.BackColor = System.Drawing.Color.Gold;
            this.buttonQuadrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuadrato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuadrato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuadrato.Location = new System.Drawing.Point(163, 289);
            this.buttonQuadrato.Name = "buttonQuadrato";
            this.buttonQuadrato.Size = new System.Drawing.Size(50, 50);
            this.buttonQuadrato.TabIndex = 30;
            this.buttonQuadrato.Text = "X²";
            this.buttonQuadrato.UseVisualStyleBackColor = false;
            this.buttonQuadrato.Click += new System.EventHandler(this.buttonQuadrato_Click);
            // 
            // buttonCubo
            // 
            this.buttonCubo.BackColor = System.Drawing.Color.Gold;
            this.buttonCubo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCubo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCubo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCubo.Location = new System.Drawing.Point(163, 344);
            this.buttonCubo.Name = "buttonCubo";
            this.buttonCubo.Size = new System.Drawing.Size(50, 50);
            this.buttonCubo.TabIndex = 31;
            this.buttonCubo.Text = "X³";
            this.buttonCubo.UseVisualStyleBackColor = false;
            this.buttonCubo.Click += new System.EventHandler(this.buttonCubo_Click);
            // 
            // buttonPotenzaXy
            // 
            this.buttonPotenzaXy.BackColor = System.Drawing.Color.Gold;
            this.buttonPotenzaXy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPotenzaXy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPotenzaXy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPotenzaXy.Location = new System.Drawing.Point(163, 400);
            this.buttonPotenzaXy.Name = "buttonPotenzaXy";
            this.buttonPotenzaXy.Size = new System.Drawing.Size(50, 50);
            this.buttonPotenzaXy.TabIndex = 32;
            this.buttonPotenzaXy.Text = "Xʸ";
            this.buttonPotenzaXy.UseVisualStyleBackColor = false;
            this.buttonPotenzaXy.Click += new System.EventHandler(this.buttonPotenzaXy_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPi.Location = new System.Drawing.Point(163, 456);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(50, 50);
            this.buttonPi.TabIndex = 33;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = false;
            this.buttonPi.Click += new System.EventHandler(this.buttonPi_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.PapayaWhip;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button13.Location = new System.Drawing.Point(55, 38);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 36;
            this.button13.Text = "☼";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // labelOrario
            // 
            this.labelOrario.AutoSize = true;
            this.labelOrario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelOrario.Location = new System.Drawing.Point(55, 91);
            this.labelOrario.Name = "labelOrario";
            this.labelOrario.Size = new System.Drawing.Size(84, 20);
            this.labelOrario.TabIndex = 37;
            this.labelOrario.Text = "labelOrario";
            // 
            // timerOrario
            // 
            this.timerOrario.Enabled = true;
            this.timerOrario.Interval = 1000;
            this.timerOrario.Tick += new System.EventHandler(this.timerOrario_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(833, 566);
            this.Controls.Add(this.labelOrario);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonPotenzaXy);
            this.Controls.Add(this.buttonCubo);
            this.Controls.Add(this.buttonQuadrato);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonSM);
            this.Controls.Add(this.buttonMPiu);
            this.Controls.Add(this.buttonMMeno);
            this.Controls.Add(this.buttonRM);
            this.Controls.Add(this.buttonCM);
            this.Controls.Add(this.buttonVirgola);
            this.Controls.Add(this.buttonCambioSegno);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonPercentuale);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDiviso);
            this.Controls.Add(this.buttonPer);
            this.Controls.Add(this.buttonMeno);
            this.Controls.Add(this.buttonPiu);
            this.Controls.Add(this.labelCronologia);
            this.Controls.Add(this.labelMemoria);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.labelOperazioneAttiva);
            this.Controls.Add(this.buttonUguale);
            this.Name = "Form1";
            this.Text = "Calcolatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonUguale;
        private Label labelOperazioneAttiva;
        private Label labelDisplay;
        private Label labelMemoria;
        private Label labelCronologia;
        private Button buttonPiu;
        private Button buttonMeno;
        private Button buttonPer;
        private Button buttonDiviso;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button buttonPercentuale;
        private Button buttonC;
        private Button buttonCE;
        private Button buttonCambioSegno;
        private Button buttonVirgola;
        private Button buttonCM;
        private Button buttonRM;
        private Button buttonMMeno;
        private Button buttonMPiu;
        private Button buttonSM;
        private Button buttonBackspace;
        private Button buttonQuadrato;
        private Button buttonCubo;
        private Button buttonPotenzaXy;
        private Button buttonPi;
        private System.Windows.Forms.Timer timer1;
        private Button button13;
        private Label labelOrario;
        private System.Windows.Forms.Timer timerOrario;
    }
}