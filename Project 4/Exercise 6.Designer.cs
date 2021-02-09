namespace Project_4
{
    partial class frmExercise_6
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue5 = new System.Windows.Forms.TextBox();
            this.txtValue4 = new System.Windows.Forms.TextBox();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.txtValue6 = new System.Windows.Forms.TextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(23, 49);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOTTO";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(58, 109);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(51, 20);
            this.txtValue1.TabIndex = 2;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(115, 109);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(57, 20);
            this.txtValue2.TabIndex = 3;
            // 
            // txtValue5
            // 
            this.txtValue5.Location = new System.Drawing.Point(326, 109);
            this.txtValue5.Name = "txtValue5";
            this.txtValue5.Size = new System.Drawing.Size(51, 20);
            this.txtValue5.TabIndex = 4;
            // 
            // txtValue4
            // 
            this.txtValue4.Location = new System.Drawing.Point(256, 109);
            this.txtValue4.Name = "txtValue4";
            this.txtValue4.Size = new System.Drawing.Size(64, 20);
            this.txtValue4.TabIndex = 5;
            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(189, 109);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(61, 20);
            this.txtValue3.TabIndex = 6;
            // 
            // txtValue6
            // 
            this.txtValue6.Location = new System.Drawing.Point(397, 109);
            this.txtValue6.Name = "txtValue6";
            this.txtValue6.Size = new System.Drawing.Size(55, 20);
            this.txtValue6.TabIndex = 8;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(271, 179);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 9;
            this.btnSpin.Text = "SPIN";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Stop Spin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmExercise_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.txtValue6);
            this.Controls.Add(this.txtValue3);
            this.Controls.Add(this.txtValue4);
            this.Controls.Add(this.txtValue5);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Name = "frmExercise_6";
            this.Text = "Exercise_6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtValue5;
        private System.Windows.Forms.TextBox txtValue4;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.TextBox txtValue6;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button button1;
    }
}