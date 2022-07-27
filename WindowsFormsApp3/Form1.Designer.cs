namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelH = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_7 = new System.Windows.Forms.Label();
            this.label_8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timerWhite = new System.Windows.Forms.Timer(this.components);
            this.timerBlack = new System.Windows.Forms.Timer(this.components);
            this.labelTimeBlack = new System.Windows.Forms.Label();
            this.labelTimeWhite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WhoOnMove = new System.Windows.Forms.Label();
            this.LastMoveWhiteAft = new System.Windows.Forms.Label();
            this.LastMoveWhitePrev = new System.Windows.Forms.Label();
            this.BlackGoto = new System.Windows.Forms.Label();
            this.WhiteGoTo = new System.Windows.Forms.Label();
            this.LastMoveBlackAft = new System.Windows.Forms.Label();
            this.LastMoveBlackPrev = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.hittedBlackFigures = new System.Windows.Forms.Label();
            this.hittedWhiteFigures = new System.Windows.Forms.Label();
            this.hittedWhiteFigures2 = new System.Windows.Forms.Label();
            this.hittedBlackFigures2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(44, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.labelH, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelG, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelF, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelE, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelD, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelA, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 545);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 32);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // labelH
            // 
            this.labelH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelH.Location = new System.Drawing.Point(437, 0);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(59, 32);
            this.labelH.TabIndex = 7;
            this.labelH.Text = "H";
            this.labelH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelG
            // 
            this.labelG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelG.Location = new System.Drawing.Point(375, 0);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(56, 32);
            this.labelG.TabIndex = 6;
            this.labelG.Text = "G";
            this.labelG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelF
            // 
            this.labelF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelF.Location = new System.Drawing.Point(313, 0);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(56, 32);
            this.labelF.TabIndex = 5;
            this.labelF.Text = "F";
            this.labelF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelE
            // 
            this.labelE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelE.Location = new System.Drawing.Point(251, 0);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(56, 32);
            this.labelE.TabIndex = 4;
            this.labelE.Text = "E";
            this.labelE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelD
            // 
            this.labelD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelD.Location = new System.Drawing.Point(189, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(56, 32);
            this.labelD.TabIndex = 3;
            this.labelD.Text = "D";
            this.labelD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelC
            // 
            this.labelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelC.Location = new System.Drawing.Point(127, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(56, 32);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "C";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB
            // 
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelB.Location = new System.Drawing.Point(65, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(56, 32);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "B";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            this.labelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelA.Location = new System.Drawing.Point(3, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(56, 32);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label_1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label_2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label_3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label_4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label_5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_8, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(41, 500);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label_1
            // 
            this.label_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_1.Location = new System.Drawing.Point(3, 434);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(35, 66);
            this.label_1.TabIndex = 10;
            this.label_1.Text = "1";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_2
            // 
            this.label_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_2.Location = new System.Drawing.Point(3, 372);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(35, 62);
            this.label_2.TabIndex = 9;
            this.label_2.Text = "2";
            this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_3
            // 
            this.label_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_3.Location = new System.Drawing.Point(3, 310);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(35, 62);
            this.label_3.TabIndex = 8;
            this.label_3.Text = "3";
            this.label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_4
            // 
            this.label_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_4.Location = new System.Drawing.Point(3, 248);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(35, 62);
            this.label_4.TabIndex = 7;
            this.label_4.Text = "4";
            this.label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_5
            // 
            this.label_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_5.Location = new System.Drawing.Point(3, 186);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(35, 62);
            this.label_5.TabIndex = 6;
            this.label_5.Text = "5";
            this.label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_6
            // 
            this.label_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_6.Location = new System.Drawing.Point(3, 124);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(35, 62);
            this.label_6.TabIndex = 5;
            this.label_6.Text = "6";
            this.label_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_7
            // 
            this.label_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_7.Location = new System.Drawing.Point(3, 62);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(35, 62);
            this.label_7.TabIndex = 4;
            this.label_7.Text = "7";
            this.label_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_8
            // 
            this.label_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_8.Location = new System.Drawing.Point(3, 0);
            this.label_8.Name = "label_8";
            this.label_8.Size = new System.Drawing.Size(35, 62);
            this.label_8.TabIndex = 1;
            this.label_8.Text = "8";
            this.label_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(262, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "pozycja startowa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.startingPosition);
            // 
            // timerWhite
            // 
            this.timerWhite.Tick += new System.EventHandler(this.timerWhite_Tick);
            // 
            // timerBlack
            // 
            this.timerBlack.Tick += new System.EventHandler(this.timerBlack_Tick);
            // 
            // labelTimeBlack
            // 
            this.labelTimeBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeBlack.Location = new System.Drawing.Point(599, 113);
            this.labelTimeBlack.Name = "labelTimeBlack";
            this.labelTimeBlack.Size = new System.Drawing.Size(56, 25);
            this.labelTimeBlack.TabIndex = 7;
            this.labelTimeBlack.Text = ".";
            this.labelTimeBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeWhite
            // 
            this.labelTimeWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeWhite.Location = new System.Drawing.Point(599, 472);
            this.labelTimeWhite.Name = "labelTimeWhite";
            this.labelTimeWhite.Size = new System.Drawing.Size(56, 25);
            this.labelTimeWhite.TabIndex = 8;
            this.labelTimeWhite.Text = ".";
            this.labelTimeWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(560, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Czas białych";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(560, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Czas czarnych";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WhoOnMove
            // 
            this.WhoOnMove.AutoSize = true;
            this.WhoOnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WhoOnMove.Location = new System.Drawing.Point(584, 263);
            this.WhoOnMove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WhoOnMove.Name = "WhoOnMove";
            this.WhoOnMove.Size = new System.Drawing.Size(0, 24);
            this.WhoOnMove.TabIndex = 12;
            // 
            // LastMoveWhiteAft
            // 
            this.LastMoveWhiteAft.AutoSize = true;
            this.LastMoveWhiteAft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastMoveWhiteAft.Location = new System.Drawing.Point(675, 332);
            this.LastMoveWhiteAft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastMoveWhiteAft.Name = "LastMoveWhiteAft";
            this.LastMoveWhiteAft.Size = new System.Drawing.Size(0, 24);
            this.LastMoveWhiteAft.TabIndex = 15;
            // 
            // LastMoveWhitePrev
            // 
            this.LastMoveWhitePrev.AutoSize = true;
            this.LastMoveWhitePrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastMoveWhitePrev.Location = new System.Drawing.Point(584, 332);
            this.LastMoveWhitePrev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastMoveWhitePrev.Name = "LastMoveWhitePrev";
            this.LastMoveWhitePrev.Size = new System.Drawing.Size(0, 24);
            this.LastMoveWhitePrev.TabIndex = 16;
            // 
            // BlackGoto
            // 
            this.BlackGoto.AutoSize = true;
            this.BlackGoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlackGoto.Location = new System.Drawing.Point(628, 198);
            this.BlackGoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BlackGoto.Name = "BlackGoto";
            this.BlackGoto.Size = new System.Drawing.Size(0, 24);
            this.BlackGoto.TabIndex = 17;
            // 
            // WhiteGoTo
            // 
            this.WhiteGoTo.AutoSize = true;
            this.WhiteGoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WhiteGoTo.Location = new System.Drawing.Point(628, 332);
            this.WhiteGoTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WhiteGoTo.Name = "WhiteGoTo";
            this.WhiteGoTo.Size = new System.Drawing.Size(0, 24);
            this.WhiteGoTo.TabIndex = 18;
            // 
            // LastMoveBlackAft
            // 
            this.LastMoveBlackAft.AutoSize = true;
            this.LastMoveBlackAft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastMoveBlackAft.Location = new System.Drawing.Point(675, 199);
            this.LastMoveBlackAft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastMoveBlackAft.Name = "LastMoveBlackAft";
            this.LastMoveBlackAft.Size = new System.Drawing.Size(0, 24);
            this.LastMoveBlackAft.TabIndex = 13;
            // 
            // LastMoveBlackPrev
            // 
            this.LastMoveBlackPrev.AutoSize = true;
            this.LastMoveBlackPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastMoveBlackPrev.Location = new System.Drawing.Point(584, 198);
            this.LastMoveBlackPrev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastMoveBlackPrev.Name = "LastMoveBlackPrev";
            this.LastMoveBlackPrev.Size = new System.Drawing.Size(0, 24);
            this.LastMoveBlackPrev.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown1.Location = new System.Drawing.Point(505, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ile czasu za ruch:";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Chess", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test.Location = new System.Drawing.Point(248, 604);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(31, 23);
            this.test.TabIndex = 21;
            this.test.Text = "O";
            this.test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hittedBlackFigures
            // 
            this.hittedBlackFigures.AutoSize = true;
            this.hittedBlackFigures.Font = new System.Drawing.Font("Chess", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hittedBlackFigures.Location = new System.Drawing.Point(555, 535);
            this.hittedBlackFigures.Name = "hittedBlackFigures";
            this.hittedBlackFigures.Size = new System.Drawing.Size(0, 23);
            this.hittedBlackFigures.TabIndex = 22;
            this.hittedBlackFigures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hittedWhiteFigures
            // 
            this.hittedWhiteFigures.AutoSize = true;
            this.hittedWhiteFigures.Font = new System.Drawing.Font("Chess", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hittedWhiteFigures.Location = new System.Drawing.Point(555, 9);
            this.hittedWhiteFigures.Name = "hittedWhiteFigures";
            this.hittedWhiteFigures.Size = new System.Drawing.Size(0, 23);
            this.hittedWhiteFigures.TabIndex = 23;
            // 
            // hittedWhiteFigures2
            // 
            this.hittedWhiteFigures2.AutoSize = true;
            this.hittedWhiteFigures2.Font = new System.Drawing.Font("Chess", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hittedWhiteFigures2.Location = new System.Drawing.Point(555, 35);
            this.hittedWhiteFigures2.Name = "hittedWhiteFigures2";
            this.hittedWhiteFigures2.Size = new System.Drawing.Size(0, 23);
            this.hittedWhiteFigures2.TabIndex = 25;
            // 
            // hittedBlackFigures2
            // 
            this.hittedBlackFigures2.AutoSize = true;
            this.hittedBlackFigures2.Font = new System.Drawing.Font("Chess", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hittedBlackFigures2.Location = new System.Drawing.Point(555, 570);
            this.hittedBlackFigures2.Name = "hittedBlackFigures2";
            this.hittedBlackFigures2.Size = new System.Drawing.Size(0, 23);
            this.hittedBlackFigures2.TabIndex = 26;
            this.hittedBlackFigures2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 657);
            this.Controls.Add(this.hittedBlackFigures2);
            this.Controls.Add(this.hittedWhiteFigures2);
            this.Controls.Add(this.hittedWhiteFigures);
            this.Controls.Add(this.hittedBlackFigures);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.WhiteGoTo);
            this.Controls.Add(this.BlackGoto);
            this.Controls.Add(this.LastMoveWhitePrev);
            this.Controls.Add(this.LastMoveWhiteAft);
            this.Controls.Add(this.LastMoveBlackPrev);
            this.Controls.Add(this.LastMoveBlackAft);
            this.Controls.Add(this.WhoOnMove);
            this.Controls.Add(this.labelTimeWhite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTimeBlack);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(754, 820);
            this.MinimumSize = new System.Drawing.Size(529, 696);
            this.Name = "Form1";
            this.Text = "l";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.Label label_7;
        private System.Windows.Forms.Label label_8;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerWhite;
        private System.Windows.Forms.Timer timerBlack;
        private System.Windows.Forms.Label labelTimeBlack;
        private System.Windows.Forms.Label labelTimeWhite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WhoOnMove;
        private System.Windows.Forms.Label LastMoveWhiteAft;
        private System.Windows.Forms.Label LastMoveWhitePrev;
        private System.Windows.Forms.Label BlackGoto;
        private System.Windows.Forms.Label WhiteGoTo;
        private System.Windows.Forms.Label LastMoveBlackAft;
        private System.Windows.Forms.Label LastMoveBlackPrev;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label hittedWhiteFigures;
        private System.Windows.Forms.Label hittedBlackFigures;
        private System.Windows.Forms.Label hittedWhiteFigures2;
        private System.Windows.Forms.Label hittedBlackFigures2;
    }
}

