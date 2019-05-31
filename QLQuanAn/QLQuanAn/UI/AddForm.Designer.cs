namespace QLQuanAn.UI
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.nOH = new System.Windows.Forms.NumericUpDown();
            this.nOM = new System.Windows.Forms.NumericUpDown();
            this.nCH = new System.Windows.Forms.NumericUpDown();
            this.nCM = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbIDState = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nOH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Open time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Close time";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(466, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(101, 61);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(466, 20);
            this.txtAddr.TabIndex = 5;
            // 
            // nOH
            // 
            this.nOH.Location = new System.Drawing.Point(101, 101);
            this.nOH.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nOH.Name = "nOH";
            this.nOH.Size = new System.Drawing.Size(43, 20);
            this.nOH.TabIndex = 6;
            this.nOH.ValueChanged += new System.EventHandler(this.nOH_ValueChanged);
            // 
            // nOM
            // 
            this.nOM.Location = new System.Drawing.Point(211, 104);
            this.nOM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nOM.Name = "nOM";
            this.nOM.Size = new System.Drawing.Size(44, 20);
            this.nOM.TabIndex = 7;
            // 
            // nCH
            // 
            this.nCH.Location = new System.Drawing.Point(101, 137);
            this.nCH.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nCH.Name = "nCH";
            this.nCH.Size = new System.Drawing.Size(43, 20);
            this.nCH.TabIndex = 8;
            // 
            // nCM
            // 
            this.nCM.Location = new System.Drawing.Point(211, 137);
            this.nCM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nCM.Name = "nCM";
            this.nCM.Size = new System.Drawing.Size(44, 20);
            this.nCM.TabIndex = 9;
            this.nCM.ValueChanged += new System.EventHandler(this.nCM_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "hour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "minute";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "minute";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(177, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(543, 314);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbIDState
            // 
            this.lbIDState.AutoSize = true;
            this.lbIDState.Location = new System.Drawing.Point(34, 203);
            this.lbIDState.Name = "lbIDState";
            this.lbIDState.Size = new System.Drawing.Size(18, 13);
            this.lbIDState.TabIndex = 16;
            this.lbIDState.Text = "ID";
            this.lbIDState.Visible = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(58, 203);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(41, 13);
            this.lbID.TabIndex = 17;
            this.lbID.Text = "label10";
            this.lbID.Visible = false;
            this.lbID.Click += new System.EventHandler(this.label10_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbIDState);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nCM);
            this.Controls.Add(this.nCH);
            this.Controls.Add(this.nOM);
            this.Controls.Add(this.nOH);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nOH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.NumericUpDown nOH;
        private System.Windows.Forms.NumericUpDown nOM;
        private System.Windows.Forms.NumericUpDown nCH;
        private System.Windows.Forms.NumericUpDown nCM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbIDState;
        private System.Windows.Forms.Label lbID;
    }
}