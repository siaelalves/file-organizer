namespace Organize
{
    partial class main
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
            this.lblPst = new System.Windows.Forms.Label();
            this.txtPrc = new System.Windows.Forms.TextBox();
            this.cmdPrc = new System.Windows.Forms.Button();
            this.cmdIn = new System.Windows.Forms.Button();
            this.lblDsc = new System.Windows.Forms.Label();
            this.lblPrg = new System.Windows.Forms.Label();
            this.rdEstaPasta = new System.Windows.Forms.RadioButton();
            this.rdSubPasta = new System.Windows.Forms.RadioButton();
            this.fldSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.lblVr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPst
            // 
            this.lblPst.AutoSize = true;
            this.lblPst.Location = new System.Drawing.Point(12, 15);
            this.lblPst.Name = "lblPst";
            this.lblPst.Size = new System.Drawing.Size(37, 13);
            this.lblPst.TabIndex = 0;
            this.lblPst.Text = "Pasta:";
            // 
            // txtPrc
            // 
            this.txtPrc.Location = new System.Drawing.Point(55, 12);
            this.txtPrc.Name = "txtPrc";
            this.txtPrc.Size = new System.Drawing.Size(248, 20);
            this.txtPrc.TabIndex = 1;
            // 
            // cmdPrc
            // 
            this.cmdPrc.Location = new System.Drawing.Point(309, 12);
            this.cmdPrc.Name = "cmdPrc";
            this.cmdPrc.Size = new System.Drawing.Size(34, 20);
            this.cmdPrc.TabIndex = 2;
            this.cmdPrc.Text = ". . .";
            this.cmdPrc.UseVisualStyleBackColor = true;
            this.cmdPrc.Click += new System.EventHandler(this.cmdPrc_Click);
            // 
            // cmdIn
            // 
            this.cmdIn.Location = new System.Drawing.Point(228, 58);
            this.cmdIn.Name = "cmdIn";
            this.cmdIn.Size = new System.Drawing.Size(75, 23);
            this.cmdIn.TabIndex = 3;
            this.cmdIn.Text = "Iniciar!";
            this.cmdIn.UseVisualStyleBackColor = true;
            this.cmdIn.Click += new System.EventHandler(this.cmdIn_Click);
            // 
            // lblDsc
            // 
            this.lblDsc.Location = new System.Drawing.Point(12, 130);
            this.lblDsc.Name = "lblDsc";
            this.lblDsc.Size = new System.Drawing.Size(331, 160);
            this.lblDsc.TabIndex = 4;
            this.lblDsc.Text = "lblDsc";
            // 
            // lblPrg
            // 
            this.lblPrg.BackColor = System.Drawing.Color.Transparent;
            this.lblPrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrg.Location = new System.Drawing.Point(15, 93);
            this.lblPrg.Name = "lblPrg";
            this.lblPrg.Size = new System.Drawing.Size(328, 23);
            this.lblPrg.TabIndex = 6;
            this.lblPrg.Text = "0 / 0 arquivos processados";
            this.lblPrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdEstaPasta
            // 
            this.rdEstaPasta.AutoSize = true;
            this.rdEstaPasta.Checked = true;
            this.rdEstaPasta.Location = new System.Drawing.Point(15, 41);
            this.rdEstaPasta.Name = "rdEstaPasta";
            this.rdEstaPasta.Size = new System.Drawing.Size(119, 17);
            this.rdEstaPasta.TabIndex = 7;
            this.rdEstaPasta.TabStop = true;
            this.rdEstaPasta.Text = "Somente esta pasta";
            this.rdEstaPasta.UseVisualStyleBackColor = true;
            // 
            // rdSubPasta
            // 
            this.rdSubPasta.AutoSize = true;
            this.rdSubPasta.Location = new System.Drawing.Point(15, 64);
            this.rdSubPasta.Name = "rdSubPasta";
            this.rdSubPasta.Size = new System.Drawing.Size(188, 17);
            this.rdSubPasta.TabIndex = 8;
            this.rdSubPasta.Text = "Esta pasta e as pastas dentro dela";
            this.rdSubPasta.UseVisualStyleBackColor = true;
            // 
            // fldSelect
            // 
            this.fldSelect.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fldSelect.SelectedPath = "C:\\Users\\siael";
            // 
            // lblVr
            // 
            this.lblVr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVr.Location = new System.Drawing.Point(12, 301);
            this.lblVr.Name = "lblVr";
            this.lblVr.Size = new System.Drawing.Size(331, 43);
            this.lblVr.TabIndex = 10;
            this.lblVr.Text = "© Copyright Siael Carvalho\r\nVersão 1.0.0.0";
            this.lblVr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVr.Click += new System.EventHandler(this.lblVr_Click);
            this.lblVr.MouseHover += new System.EventHandler(this.lblVr_MouseHover);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 353);
            this.Controls.Add(this.lblVr);
            this.Controls.Add(this.rdSubPasta);
            this.Controls.Add(this.rdEstaPasta);
            this.Controls.Add(this.lblPrg);
            this.Controls.Add(this.lblDsc);
            this.Controls.Add(this.cmdIn);
            this.Controls.Add(this.cmdPrc);
            this.Controls.Add(this.txtPrc);
            this.Controls.Add(this.lblPst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organize";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPst;
        private System.Windows.Forms.TextBox txtPrc;
        private System.Windows.Forms.Button cmdPrc;
        private System.Windows.Forms.Button cmdIn;
        private System.Windows.Forms.Label lblDsc;
        private System.Windows.Forms.Label lblPrg;
        private System.Windows.Forms.RadioButton rdEstaPasta;
        private System.Windows.Forms.RadioButton rdSubPasta;
        private System.Windows.Forms.FolderBrowserDialog fldSelect;
        private System.Windows.Forms.Label lblVr;
    }
}

