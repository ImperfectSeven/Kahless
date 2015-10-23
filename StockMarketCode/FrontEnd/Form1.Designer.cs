namespace FrontEnd
{
    partial class Form1
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tb_initAmount = new System.Windows.Forms.TextBox();
            this.lbl_initAmount = new System.Windows.Forms.Label();
            this.btn_simulate = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // tb_initAmount
            // 
            this.tb_initAmount.Location = new System.Drawing.Point(12, 28);
            this.tb_initAmount.Name = "tb_initAmount";
            this.tb_initAmount.Size = new System.Drawing.Size(125, 20);
            this.tb_initAmount.TabIndex = 0;
            // 
            // lbl_initAmount
            // 
            this.lbl_initAmount.AutoSize = true;
            this.lbl_initAmount.Location = new System.Drawing.Point(9, 12);
            this.lbl_initAmount.Name = "lbl_initAmount";
            this.lbl_initAmount.Size = new System.Drawing.Size(74, 13);
            this.lbl_initAmount.TabIndex = 1;
            this.lbl_initAmount.Text = "Initial Principle";
            // 
            // btn_simulate
            // 
            this.btn_simulate.Location = new System.Drawing.Point(143, 12);
            this.btn_simulate.Name = "btn_simulate";
            this.btn_simulate.Size = new System.Drawing.Size(75, 23);
            this.btn_simulate.TabIndex = 2;
            this.btn_simulate.Text = "Simulate";
            this.btn_simulate.UseVisualStyleBackColor = true;
            this.btn_simulate.Click += new System.EventHandler(this.btn_simulate_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(143, 41);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 152);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_simulate);
            this.Controls.Add(this.lbl_initAmount);
            this.Controls.Add(this.tb_initAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox tb_initAmount;
        private System.Windows.Forms.Label lbl_initAmount;
        private System.Windows.Forms.Button btn_simulate;
        private System.Windows.Forms.Button btn_Cancel;
    }
}

