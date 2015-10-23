namespace Assignment_1_tic_tac
{
    partial class ConditionWindow
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.checkBoxPlayerStart2 = new System.Windows.Forms.CheckBox();
            this.labelFirstMove = new System.Windows.Forms.Label();
            this.checkBoxPlayerStart1 = new System.Windows.Forms.CheckBox();
            this.comboBoxPlayerMarker2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPlayerMarker1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConditionsIntroduction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.buttonStartGame.Location = new System.Drawing.Point(59, 169);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(214, 80);
            this.buttonStartGame.TabIndex = 17;
            this.buttonStartGame.Text = "START !";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // checkBoxPlayerStart2
            // 
            this.checkBoxPlayerStart2.AutoSize = true;
            this.checkBoxPlayerStart2.Location = new System.Drawing.Point(59, 136);
            this.checkBoxPlayerStart2.Name = "checkBoxPlayerStart2";
            this.checkBoxPlayerStart2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPlayerStart2.TabIndex = 16;
            this.checkBoxPlayerStart2.UseVisualStyleBackColor = true;
            this.checkBoxPlayerStart2.CheckedChanged += new System.EventHandler(this.checkBoxPlayerStart2_CheckedChanged);
            // 
            // labelFirstMove
            // 
            this.labelFirstMove.AutoSize = true;
            this.labelFirstMove.Location = new System.Drawing.Point(19, 73);
            this.labelFirstMove.Name = "labelFirstMove";
            this.labelFirstMove.Size = new System.Drawing.Size(55, 13);
            this.labelFirstMove.TabIndex = 15;
            this.labelFirstMove.Text = "First move";
            // 
            // checkBoxPlayerStart1
            // 
            this.checkBoxPlayerStart1.AutoSize = true;
            this.checkBoxPlayerStart1.Checked = true;
            this.checkBoxPlayerStart1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlayerStart1.Location = new System.Drawing.Point(59, 98);
            this.checkBoxPlayerStart1.Name = "checkBoxPlayerStart1";
            this.checkBoxPlayerStart1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPlayerStart1.TabIndex = 14;
            this.checkBoxPlayerStart1.UseVisualStyleBackColor = true;
            this.checkBoxPlayerStart1.CheckedChanged += new System.EventHandler(this.checkBoxPlayerStart1_CheckedChanged);
            // 
            // comboBoxPlayerMarker2
            // 
            this.comboBoxPlayerMarker2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxPlayerMarker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxPlayerMarker2.FormattingEnabled = true;
            this.comboBoxPlayerMarker2.ItemHeight = 18;
            this.comboBoxPlayerMarker2.Items.AddRange(new object[] {
            "X",
            "O"});
            this.comboBoxPlayerMarker2.Location = new System.Drawing.Point(228, 129);
            this.comboBoxPlayerMarker2.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxPlayerMarker2.Name = "comboBoxPlayerMarker2";
            this.comboBoxPlayerMarker2.Size = new System.Drawing.Size(44, 26);
            this.comboBoxPlayerMarker2.TabIndex = 13;
            this.comboBoxPlayerMarker2.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayerMarker2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(79, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Player 2 Marker :";
            // 
            // comboBoxPlayerMarker1
            // 
            this.comboBoxPlayerMarker1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxPlayerMarker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxPlayerMarker1.FormattingEnabled = true;
            this.comboBoxPlayerMarker1.ItemHeight = 18;
            this.comboBoxPlayerMarker1.Items.AddRange(new object[] {
            "X",
            "O"});
            this.comboBoxPlayerMarker1.Location = new System.Drawing.Point(229, 91);
            this.comboBoxPlayerMarker1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxPlayerMarker1.Name = "comboBoxPlayerMarker1";
            this.comboBoxPlayerMarker1.Size = new System.Drawing.Size(44, 26);
            this.comboBoxPlayerMarker1.TabIndex = 11;
            this.comboBoxPlayerMarker1.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayerMarker1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(79, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player 1 Marker :";
            // 
            // labelConditionsIntroduction
            // 
            this.labelConditionsIntroduction.AutoSize = true;
            this.labelConditionsIntroduction.Font = new System.Drawing.Font("Mistral", 20F);
            this.labelConditionsIntroduction.Location = new System.Drawing.Point(53, 23);
            this.labelConditionsIntroduction.Name = "labelConditionsIntroduction";
            this.labelConditionsIntroduction.Size = new System.Drawing.Size(104, 33);
            this.labelConditionsIntroduction.TabIndex = 9;
            this.labelConditionsIntroduction.Text = "Tic Tac Toe";
            // 
            // ConditionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.checkBoxPlayerStart2);
            this.Controls.Add(this.labelFirstMove);
            this.Controls.Add(this.checkBoxPlayerStart1);
            this.Controls.Add(this.comboBoxPlayerMarker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPlayerMarker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelConditionsIntroduction);
            this.Name = "ConditionWindow";
            this.Text = "ConditionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.CheckBox checkBoxPlayerStart2;
        private System.Windows.Forms.Label labelFirstMove;
        private System.Windows.Forms.CheckBox checkBoxPlayerStart1;
        private System.Windows.Forms.ComboBox comboBoxPlayerMarker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPlayerMarker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConditionsIntroduction;
    }
}