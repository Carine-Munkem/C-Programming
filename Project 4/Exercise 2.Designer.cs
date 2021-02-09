namespace Project_4
{
    partial class frmExercise_2
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
            this.btnType = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboContinent = new System.Windows.Forms.ComboBox();
            this.cboAgeGroup = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SpectatorOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(276, 347);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(75, 23);
            this.btnType.TabIndex = 0;
            this.btnType.Text = "Type";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(400, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboContinent
            // 
            this.cboContinent.FormattingEnabled = true;
            this.cboContinent.Items.AddRange(new object[] {
            "Africa",
            "America",
            "Europe"});
            this.cboContinent.Location = new System.Drawing.Point(313, 138);
            this.cboContinent.Name = "cboContinent";
            this.cboContinent.Size = new System.Drawing.Size(121, 21);
            this.cboContinent.TabIndex = 2;
            // 
            // cboAgeGroup
            // 
            this.cboAgeGroup.FormattingEnabled = true;
            this.cboAgeGroup.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Pensioner"});
            this.cboAgeGroup.Location = new System.Drawing.Point(313, 178);
            this.cboAgeGroup.Name = "cboAgeGroup";
            this.cboAgeGroup.Size = new System.Drawing.Size(121, 21);
            this.cboAgeGroup.TabIndex = 3;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(313, 224);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(121, 21);
            this.cboGender.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Continent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Spectator Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Spectator Type";
            // 
            // SpectatorOutput
            // 
            this.SpectatorOutput.Location = new System.Drawing.Point(313, 270);
            this.SpectatorOutput.Name = "SpectatorOutput";
            this.SpectatorOutput.Size = new System.Drawing.Size(100, 20);
            this.SpectatorOutput.TabIndex = 11;
            // 
            // frmExercise_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.SpectatorOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.cboAgeGroup);
            this.Controls.Add(this.cboContinent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnType);
            this.Name = "frmExercise_2";
            this.Text = "Exercise_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboContinent;
        private System.Windows.Forms.ComboBox cboAgeGroup;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SpectatorOutput;
    }
}