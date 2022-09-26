namespace UpdateOnQueryResult
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lbReadingValues = new System.Windows.Forms.ListBox();
            this.lbResultValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(237, 41);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(284, 67);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lbReadingValues
            // 
            this.lbReadingValues.FormattingEnabled = true;
            this.lbReadingValues.Location = new System.Drawing.Point(60, 146);
            this.lbReadingValues.Name = "lbReadingValues";
            this.lbReadingValues.Size = new System.Drawing.Size(185, 264);
            this.lbReadingValues.TabIndex = 1;
            // 
            // lbResultValues
            // 
            this.lbResultValues.FormattingEnabled = true;
            this.lbResultValues.Location = new System.Drawing.Point(492, 146);
            this.lbResultValues.Name = "lbResultValues";
            this.lbResultValues.Size = new System.Drawing.Size(185, 264);
            this.lbResultValues.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultValues);
            this.Controls.Add(this.lbReadingValues);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListBox lbReadingValues;
        private System.Windows.Forms.ListBox lbResultValues;
    }
}

