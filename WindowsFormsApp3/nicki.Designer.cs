namespace WindowsFormsApp3
{
    partial class nicki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerWhite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerBlack = new System.Windows.Forms.TextBox();
            this.checkPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerWhite
            // 
            this.playerWhite.Location = new System.Drawing.Point(430, 25);
            this.playerWhite.Name = "playerWhite";
            this.playerWhite.Size = new System.Drawing.Size(116, 20);
            this.playerWhite.TabIndex = 0;
            this.playerWhite.Text = "zawodnik 1";
            this.playerWhite.TextChanged += new System.EventHandler(this.playerWhite_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj nick gracza grającego białymi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Podaj nick gracza grającego czarnymi";
            // 
            // playerBlack
            // 
            this.playerBlack.Location = new System.Drawing.Point(430, 73);
            this.playerBlack.Name = "playerBlack";
            this.playerBlack.Size = new System.Drawing.Size(116, 20);
            this.playerBlack.TabIndex = 2;
            this.playerBlack.Text = "zawodnik 2";
            // 
            // checkPlayers
            // 
            this.checkPlayers.Location = new System.Drawing.Point(205, 125);
            this.checkPlayers.Name = "checkPlayers";
            this.checkPlayers.Size = new System.Drawing.Size(144, 23);
            this.checkPlayers.TabIndex = 4;
            this.checkPlayers.Text = "Zacznij partie";
            this.checkPlayers.UseVisualStyleBackColor = true;
            this.checkPlayers.Click += new System.EventHandler(this.checkPlayers_Click);
            // 
            // nicki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 161);
            this.Controls.Add(this.checkPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerBlack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerWhite);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nicki";
            this.Text = "nicki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerWhite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerBlack;
        public System.Windows.Forms.Button checkPlayers;
    }
}