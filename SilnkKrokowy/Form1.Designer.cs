namespace SilnkKrokowy
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
            this.enablebtn = new System.Windows.Forms.Button();
            this.disablebtn = new System.Windows.Forms.Button();
            this.stepLeftbtn = new System.Windows.Forms.Button();
            this.stepRightbtn = new System.Windows.Forms.Button();
            this.degreeTB = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // enablebtn
            // 
            this.enablebtn.Location = new System.Drawing.Point(45, 22);
            this.enablebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enablebtn.Name = "enablebtn";
            this.enablebtn.Size = new System.Drawing.Size(110, 45);
            this.enablebtn.TabIndex = 0;
            this.enablebtn.Text = "połącz";
            this.enablebtn.UseVisualStyleBackColor = true;
            this.enablebtn.Click += new System.EventHandler(this.enablebtn_Click);
            // 
            // disablebtn
            // 
            this.disablebtn.Location = new System.Drawing.Point(236, 22);
            this.disablebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disablebtn.Name = "disablebtn";
            this.disablebtn.Size = new System.Drawing.Size(120, 41);
            this.disablebtn.TabIndex = 1;
            this.disablebtn.Text = "odłącz";
            this.disablebtn.UseVisualStyleBackColor = true;
            this.disablebtn.Click += new System.EventHandler(this.disablebtn_Click);
            // 
            // stepLeftbtn
            // 
            this.stepLeftbtn.Enabled = false;
            this.stepLeftbtn.Location = new System.Drawing.Point(36, 129);
            this.stepLeftbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stepLeftbtn.Name = "stepLeftbtn";
            this.stepLeftbtn.Size = new System.Drawing.Size(119, 58);
            this.stepLeftbtn.TabIndex = 2;
            this.stepLeftbtn.Text = "krok w lewo";
            this.stepLeftbtn.UseVisualStyleBackColor = true;
            this.stepLeftbtn.Click += new System.EventHandler(this.stepLeftbtn_Click);
            // 
            // stepRightbtn
            // 
            this.stepRightbtn.Enabled = false;
            this.stepRightbtn.Location = new System.Drawing.Point(243, 129);
            this.stepRightbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stepRightbtn.Name = "stepRightbtn";
            this.stepRightbtn.Size = new System.Drawing.Size(122, 52);
            this.stepRightbtn.TabIndex = 3;
            this.stepRightbtn.Text = "krok w prawo";
            this.stepRightbtn.UseVisualStyleBackColor = true;
            this.stepRightbtn.Click += new System.EventHandler(this.stepRightbtn_Click);
            // 
            // degreeTB
            // 
            this.degreeTB.Location = new System.Drawing.Point(44, 156);
            this.degreeTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degreeTB.Name = "degreeTB";
            this.degreeTB.Size = new System.Drawing.Size(10, 26);
            this.degreeTB.TabIndex = 4;
            this.degreeTB.Text = "30";
            this.degreeTB.TextChanged += new System.EventHandler(this.degreeTB_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(515, 63);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(219, 69);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Szybkość obortu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(515, 178);
            this.trackBar2.Maximum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(219, 69);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wybór osi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.stepRightbtn);
            this.Controls.Add(this.stepLeftbtn);
            this.Controls.Add(this.disablebtn);
            this.Controls.Add(this.enablebtn);
            this.Controls.Add(this.degreeTB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "te";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enablebtn;
        private System.Windows.Forms.Button disablebtn;
        private System.Windows.Forms.Button stepLeftbtn;
        private System.Windows.Forms.Button stepRightbtn;
        private System.Windows.Forms.TextBox degreeTB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

