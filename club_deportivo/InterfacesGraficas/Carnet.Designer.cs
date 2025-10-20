namespace club_deportivo.InterfacesGraficas
{
    partial class frmCarnet
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
            btnImprimir = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(192, 0, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(212, 165);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(116, 38);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 215);
            Controls.Add(btnImprimir);
            Name = "frmCarnet";
            Text = "Carnet";
            ResumeLayout(false);
        }

        #endregion

        private Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}