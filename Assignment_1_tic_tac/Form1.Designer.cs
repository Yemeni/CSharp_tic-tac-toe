namespace Assignment_1_tic_tac
{
    partial class mainForm
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
            this.coord_0_0 = new System.Windows.Forms.Button();
            this.coord_0_1 = new System.Windows.Forms.Button();
            this.coord_0_2 = new System.Windows.Forms.Button();
            this.coord_1_2 = new System.Windows.Forms.Button();
            this.coord_1_1 = new System.Windows.Forms.Button();
            this.coord_1_0 = new System.Windows.Forms.Button();
            this.coord_2_2 = new System.Windows.Forms.Button();
            this.coord_2_1 = new System.Windows.Forms.Button();
            this.coord_2_0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coord_0_0
            // 
            this.coord_0_0.Location = new System.Drawing.Point(12, 12);
            this.coord_0_0.Name = "coord_0_0";
            this.coord_0_0.Size = new System.Drawing.Size(75, 75);
            this.coord_0_0.TabIndex = 0;
            this.coord_0_0.Text = "button1";
            this.coord_0_0.UseVisualStyleBackColor = true;
            // 
            // coord_0_1
            // 
            this.coord_0_1.Location = new System.Drawing.Point(93, 12);
            this.coord_0_1.Name = "coord_0_1";
            this.coord_0_1.Size = new System.Drawing.Size(75, 75);
            this.coord_0_1.TabIndex = 1;
            this.coord_0_1.Text = "button2";
            this.coord_0_1.UseVisualStyleBackColor = true;
            // 
            // coord_0_2
            // 
            this.coord_0_2.Location = new System.Drawing.Point(174, 12);
            this.coord_0_2.Name = "coord_0_2";
            this.coord_0_2.Size = new System.Drawing.Size(75, 75);
            this.coord_0_2.TabIndex = 2;
            this.coord_0_2.Text = "button3";
            this.coord_0_2.UseVisualStyleBackColor = true;
            // 
            // coord_1_2
            // 
            this.coord_1_2.Location = new System.Drawing.Point(174, 93);
            this.coord_1_2.Name = "coord_1_2";
            this.coord_1_2.Size = new System.Drawing.Size(75, 75);
            this.coord_1_2.TabIndex = 5;
            this.coord_1_2.Text = "button4";
            this.coord_1_2.UseVisualStyleBackColor = true;
            // 
            // coord_1_1
            // 
            this.coord_1_1.Location = new System.Drawing.Point(93, 93);
            this.coord_1_1.Name = "coord_1_1";
            this.coord_1_1.Size = new System.Drawing.Size(75, 75);
            this.coord_1_1.TabIndex = 4;
            this.coord_1_1.Text = "button5";
            this.coord_1_1.UseVisualStyleBackColor = true;
            // 
            // coord_1_0
            // 
            this.coord_1_0.Location = new System.Drawing.Point(12, 93);
            this.coord_1_0.Name = "coord_1_0";
            this.coord_1_0.Size = new System.Drawing.Size(75, 75);
            this.coord_1_0.TabIndex = 3;
            this.coord_1_0.Text = "button6";
            this.coord_1_0.UseVisualStyleBackColor = true;
            // 
            // coord_2_2
            // 
            this.coord_2_2.Location = new System.Drawing.Point(174, 174);
            this.coord_2_2.Name = "coord_2_2";
            this.coord_2_2.Size = new System.Drawing.Size(75, 75);
            this.coord_2_2.TabIndex = 8;
            this.coord_2_2.Text = "button7";
            this.coord_2_2.UseVisualStyleBackColor = true;
            // 
            // coord_2_1
            // 
            this.coord_2_1.Location = new System.Drawing.Point(93, 174);
            this.coord_2_1.Name = "coord_2_1";
            this.coord_2_1.Size = new System.Drawing.Size(75, 75);
            this.coord_2_1.TabIndex = 7;
            this.coord_2_1.Text = "button8";
            this.coord_2_1.UseVisualStyleBackColor = true;
            // 
            // coord_2_0
            // 
            this.coord_2_0.Location = new System.Drawing.Point(12, 174);
            this.coord_2_0.Name = "coord_2_0";
            this.coord_2_0.Size = new System.Drawing.Size(75, 75);
            this.coord_2_0.TabIndex = 6;
            this.coord_2_0.Text = "button9";
            this.coord_2_0.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(270, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Turn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(328, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player 0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coord_2_2);
            this.Controls.Add(this.coord_2_1);
            this.Controls.Add(this.coord_2_0);
            this.Controls.Add(this.coord_1_2);
            this.Controls.Add(this.coord_1_1);
            this.Controls.Add(this.coord_1_0);
            this.Controls.Add(this.coord_0_2);
            this.Controls.Add(this.coord_0_1);
            this.Controls.Add(this.coord_0_0);
            this.Name = "mainForm";
            this.Text = "TicTacToe by Mr. 61510145";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button coord_0_0;
        private System.Windows.Forms.Button coord_0_1;
        private System.Windows.Forms.Button coord_0_2;
        private System.Windows.Forms.Button coord_1_2;
        private System.Windows.Forms.Button coord_1_1;
        private System.Windows.Forms.Button coord_1_0;
        private System.Windows.Forms.Button coord_2_2;
        private System.Windows.Forms.Button coord_2_1;
        private System.Windows.Forms.Button coord_2_0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

