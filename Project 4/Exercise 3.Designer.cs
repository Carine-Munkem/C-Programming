namespace Project_4
{
    partial class frmExercise_3
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
            this.lstLoop = new System.Windows.Forms.ListBox();
            this.btnLoop1 = new System.Windows.Forms.Button();
            this.btnLoop2 = new System.Windows.Forms.Button();
            this.btnLoop3 = new System.Windows.Forms.Button();
            this.btnLoop4 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOOPS";
            // 
            // lstLoop
            // 
            this.lstLoop.FormattingEnabled = true;
            this.lstLoop.Location = new System.Drawing.Point(315, 87);
            this.lstLoop.Name = "lstLoop";
            this.lstLoop.Size = new System.Drawing.Size(120, 225);
            this.lstLoop.TabIndex = 1;
            this.lstLoop.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnLoop1
            // 
            this.btnLoop1.Location = new System.Drawing.Point(208, 105);
            this.btnLoop1.Name = "btnLoop1";
            this.btnLoop1.Size = new System.Drawing.Size(75, 23);
            this.btnLoop1.TabIndex = 2;
            this.btnLoop1.Text = "Loop 1";
            this.btnLoop1.UseVisualStyleBackColor = true;
            this.btnLoop1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoop2
            // 
            this.btnLoop2.Location = new System.Drawing.Point(208, 149);
            this.btnLoop2.Name = "btnLoop2";
            this.btnLoop2.Size = new System.Drawing.Size(75, 23);
            this.btnLoop2.TabIndex = 3;
            this.btnLoop2.Text = "Loop 2";
            this.btnLoop2.UseVisualStyleBackColor = true;
            this.btnLoop2.Click += new System.EventHandler(this.btnLoop2_Click);
            // 
            // btnLoop3
            // 
            this.btnLoop3.Location = new System.Drawing.Point(208, 196);
            this.btnLoop3.Name = "btnLoop3";
            this.btnLoop3.Size = new System.Drawing.Size(75, 23);
            this.btnLoop3.TabIndex = 4;
            this.btnLoop3.Text = "Loop 3";
            this.btnLoop3.UseVisualStyleBackColor = true;
            this.btnLoop3.Click += new System.EventHandler(this.btnLoop3_Click);
            // 
            // btnLoop4
            // 
            this.btnLoop4.Location = new System.Drawing.Point(208, 247);
            this.btnLoop4.Name = "btnLoop4";
            this.btnLoop4.Size = new System.Drawing.Size(75, 23);
            this.btnLoop4.TabIndex = 5;
            this.btnLoop4.Text = "Loop 4";
            this.btnLoop4.UseVisualStyleBackColor = true;
            this.btnLoop4.Click += new System.EventHandler(this.btnLoop4_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(216, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(387, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmExercise_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoop4);
            this.Controls.Add(this.btnLoop3);
            this.Controls.Add(this.btnLoop2);
            this.Controls.Add(this.btnLoop1);
            this.Controls.Add(this.lstLoop);
            this.Controls.Add(this.label1);
            this.Name = "frmExercise_3";
            this.Text = "Exercise_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLoop;
        private System.Windows.Forms.Button btnLoop1;
        private System.Windows.Forms.Button btnLoop2;
        private System.Windows.Forms.Button btnLoop3;
        private System.Windows.Forms.Button btnLoop4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}