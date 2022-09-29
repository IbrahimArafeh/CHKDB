namespace WaitQuery
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQueryString = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCol1 = new System.Windows.Forms.TextBox();
            this.txtCol2 = new System.Windows.Forms.TextBox();
            this.txtCol3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.txtWaitingMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRunType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRunQuery = new System.Windows.Forms.RichTextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSpName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.Location = new System.Drawing.Point(286, 471);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(142, 25);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Show Message";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQueryString
            // 
            this.txtQueryString.Location = new System.Drawing.Point(44, 54);
            this.txtQueryString.Name = "txtQueryString";
            this.txtQueryString.Size = new System.Drawing.Size(662, 57);
            this.txtQueryString.TabIndex = 4;
            this.txtQueryString.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Query";
            // 
            // txtCol1
            // 
            this.txtCol1.Location = new System.Drawing.Point(8, 13);
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.Size = new System.Drawing.Size(100, 23);
            this.txtCol1.TabIndex = 7;
            // 
            // txtCol2
            // 
            this.txtCol2.Location = new System.Drawing.Point(258, 13);
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.Size = new System.Drawing.Size(100, 23);
            this.txtCol2.TabIndex = 8;
            // 
            // txtCol3
            // 
            this.txtCol3.Location = new System.Drawing.Point(497, 13);
            this.txtCol3.Name = "txtCol3";
            this.txtCol3.Size = new System.Drawing.Size(100, 23);
            this.txtCol3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cb2);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Controls.Add(this.txtCol3);
            this.panel1.Controls.Add(this.txtCol2);
            this.panel1.Controls.Add(this.txtCol1);
            this.panel1.Location = new System.Drawing.Point(44, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 47);
            this.panel1.TabIndex = 10;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cb2.Location = new System.Drawing.Point(386, 13);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(81, 23);
            this.cb2.TabIndex = 13;
            // 
            // cb1
            // 
            this.cb1.DisplayMember = "1";
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cb1.Location = new System.Drawing.Point(142, 13);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(71, 23);
            this.cb1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Check Columns Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Repeat If has";
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 15;
            this.lbResult.Location = new System.Drawing.Point(42, 509);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(663, 109);
            this.lbResult.TabIndex = 1;
            // 
            // txtWaitingMin
            // 
            this.txtWaitingMin.Location = new System.Drawing.Point(379, 415);
            this.txtWaitingMin.Name = "txtWaitingMin";
            this.txtWaitingMin.Size = new System.Drawing.Size(100, 23);
            this.txtWaitingMin.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Repeat After";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Milliseconds";
            // 
            // cbRunType
            // 
            this.cbRunType.FormattingEnabled = true;
            this.cbRunType.Items.AddRange(new object[] {
            "Query",
            "Stored Procedure"});
            this.cbRunType.Location = new System.Drawing.Point(109, 308);
            this.cbRunType.Name = "cbRunType";
            this.cbRunType.Size = new System.Drawing.Size(187, 23);
            this.cbRunType.TabIndex = 17;
            this.cbRunType.SelectedIndexChanged += new System.EventHandler(this.cbRunType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Run The";
            // 
            // txtRunQuery
            // 
            this.txtRunQuery.Location = new System.Drawing.Point(274, 7);
            this.txtRunQuery.Name = "txtRunQuery";
            this.txtRunQuery.Size = new System.Drawing.Size(370, 61);
            this.txtRunQuery.TabIndex = 19;
            this.txtRunQuery.Text = "";
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(8, 13);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 23);
            this.txtVal1.TabIndex = 7;
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(168, 13);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 23);
            this.txtVal2.TabIndex = 8;
            // 
            // txtVal3
            // 
            this.txtVal3.Location = new System.Drawing.Point(322, 13);
            this.txtVal3.Name = "txtVal3";
            this.txtVal3.Size = new System.Drawing.Size(100, 23);
            this.txtVal3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.txtVal3);
            this.panel2.Controls.Add(this.txtVal2);
            this.panel2.Controls.Add(this.txtVal1);
            this.panel2.Location = new System.Drawing.Point(44, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 47);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.txtSpName);
            this.panel3.Controls.Add(this.txtRunQuery);
            this.panel3.Location = new System.Drawing.Point(45, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 77);
            this.panel3.TabIndex = 21;
            // 
            // txtSpName
            // 
            this.txtSpName.Location = new System.Drawing.Point(274, 16);
            this.txtSpName.Name = "txtSpName";
            this.txtSpName.Size = new System.Drawing.Size(370, 23);
            this.txtSpName.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(45, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 71);
            this.panel4.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 630);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbRunType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWaitingMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQueryString);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Label lblMsg;
        private Button btn_Do;
        private ListBox lblRes;
        private Label lblms;
        private Button button1;
        private RichTextBox txtQueryString;
        private Label label1;
        private TextBox txtCol1;
        private TextBox txtCol2;
        private TextBox txtCol3;
        private Panel panel1;
        private Label label2;
        private ComboBox cb2;
        private ComboBox cb1;
        private Label label3;
        private ListBox lbResult;
        private TextBox txtWaitingMin;
        private Label label4;
        private Label label5;
        private ComboBox cbRunType;
        private Label label6;
        private RichTextBox txtRunQuery;
        private TextBox txtVal1;
        private TextBox txtVal2;
        private TextBox txtVal3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtSpName;
    }
}