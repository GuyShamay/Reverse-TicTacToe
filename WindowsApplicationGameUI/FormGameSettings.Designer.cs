namespace WindowsApplicationGameUI
{
    public partial class FormGameSettings
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
            this.m_CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.m_LabelPlayers = new System.Windows.Forms.Label();
            this.m_LabelPlayer1 = new System.Windows.Forms.Label();
            this.m_LabelPlayer2 = new System.Windows.Forms.Label();
            this.m_TextBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.m_TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.m_LabelBoardSize = new System.Windows.Forms.Label();
            this.m_LabelColumns = new System.Windows.Forms.Label();
            this.m_LabelRows = new System.Windows.Forms.Label();
            this.m_NumericRows = new System.Windows.Forms.NumericUpDown();
            this.m_NumericCols = new System.Windows.Forms.NumericUpDown();
            this.m_ButtonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumericRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumericCols)).BeginInit();
            this.SuspendLayout();
            // 
            // m_CheckBoxPlayer2
            // 
            this.m_CheckBoxPlayer2.AutoSize = true;
            this.m_CheckBoxPlayer2.Location = new System.Drawing.Point(59, 125);
            this.m_CheckBoxPlayer2.Name = "m_CheckBoxPlayer2";
            this.m_CheckBoxPlayer2.Size = new System.Drawing.Size(28, 27);
            this.m_CheckBoxPlayer2.TabIndex = 1;
            this.m_CheckBoxPlayer2.UseVisualStyleBackColor = true;
            this.m_CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
            // 
            // m_LabelPlayers
            // 
            this.m_LabelPlayers.AutoSize = true;
            this.m_LabelPlayers.Location = new System.Drawing.Point(26, 33);
            this.m_LabelPlayers.Name = "m_LabelPlayers";
            this.m_LabelPlayers.Size = new System.Drawing.Size(90, 25);
            this.m_LabelPlayers.TabIndex = 1;
            this.m_LabelPlayers.Text = "Players:";
            // 
            // m_LabelPlayer1
            // 
            this.m_LabelPlayer1.AutoSize = true;
            this.m_LabelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelPlayer1.Location = new System.Drawing.Point(54, 73);
            this.m_LabelPlayer1.Name = "m_LabelPlayer1";
            this.m_LabelPlayer1.Size = new System.Drawing.Size(97, 25);
            this.m_LabelPlayer1.TabIndex = 2;
            this.m_LabelPlayer1.Text = "Player 1:";
            // 
            // m_LabelPlayer2
            // 
            this.m_LabelPlayer2.AutoSize = true;
            this.m_LabelPlayer2.Location = new System.Drawing.Point(104, 125);
            this.m_LabelPlayer2.Name = "m_LabelPlayer2";
            this.m_LabelPlayer2.Size = new System.Drawing.Size(97, 25);
            this.m_LabelPlayer2.TabIndex = 3;
            this.m_LabelPlayer2.Text = "Player 2:";
            // 
            // m_TextBoxPlayer1
            // 
            this.m_TextBoxPlayer1.Location = new System.Drawing.Point(218, 70);
            this.m_TextBoxPlayer1.Name = "m_TextBoxPlayer1";
            this.m_TextBoxPlayer1.Size = new System.Drawing.Size(199, 31);
            this.m_TextBoxPlayer1.TabIndex = 0;
            // 
            // m_TextBoxPlayer2
            // 
            this.m_TextBoxPlayer2.Enabled = false;
            this.m_TextBoxPlayer2.Location = new System.Drawing.Point(218, 122);
            this.m_TextBoxPlayer2.Name = "m_TextBoxPlayer2";
            this.m_TextBoxPlayer2.Size = new System.Drawing.Size(199, 31);
            this.m_TextBoxPlayer2.TabIndex = 2;
            this.m_TextBoxPlayer2.Text = "(Computer)";
            // 
            // m_LabelBoardSize
            // 
            this.m_LabelBoardSize.AutoSize = true;
            this.m_LabelBoardSize.Location = new System.Drawing.Point(26, 202);
            this.m_LabelBoardSize.Name = "m_LabelBoardSize";
            this.m_LabelBoardSize.Size = new System.Drawing.Size(123, 25);
            this.m_LabelBoardSize.TabIndex = 6;
            this.m_LabelBoardSize.Text = "Board Size:";
            // 
            // m_LabelColumns
            // 
            this.m_LabelColumns.AutoSize = true;
            this.m_LabelColumns.Location = new System.Drawing.Point(265, 254);
            this.m_LabelColumns.Name = "m_LabelColumns";
            this.m_LabelColumns.Size = new System.Drawing.Size(61, 25);
            this.m_LabelColumns.TabIndex = 7;
            this.m_LabelColumns.Text = "Cols:";
            // 
            // m_LabelRows
            // 
            this.m_LabelRows.AutoSize = true;
            this.m_LabelRows.Location = new System.Drawing.Point(54, 254);
            this.m_LabelRows.Name = "m_LabelRows";
            this.m_LabelRows.Size = new System.Drawing.Size(71, 25);
            this.m_LabelRows.TabIndex = 8;
            this.m_LabelRows.Text = "Rows:";
            // 
            // m_NumericRows
            // 
            this.m_NumericRows.Location = new System.Drawing.Point(132, 252);
            this.m_NumericRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.m_NumericRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.m_NumericRows.Name = "m_NumericRows";
            this.m_NumericRows.Size = new System.Drawing.Size(84, 31);
            this.m_NumericRows.TabIndex = 3;
            this.m_NumericRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_NumericRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // m_NumericCols
            // 
            this.m_NumericCols.Location = new System.Drawing.Point(333, 252);
            this.m_NumericCols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.m_NumericCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.m_NumericCols.Name = "m_NumericCols";
            this.m_NumericCols.Size = new System.Drawing.Size(84, 31);
            this.m_NumericCols.TabIndex = 4;
            this.m_NumericCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_NumericCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // m_ButtonStart
            // 
            this.m_ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_ButtonStart.Location = new System.Drawing.Point(31, 303);
            this.m_ButtonStart.Name = "m_ButtonStart";
            this.m_ButtonStart.Size = new System.Drawing.Size(386, 49);
            this.m_ButtonStart.TabIndex = 5;
            this.m_ButtonStart.Text = "Start";
            this.m_ButtonStart.UseVisualStyleBackColor = true;
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 403);
            this.Controls.Add(this.m_ButtonStart);
            this.Controls.Add(this.m_NumericCols);
            this.Controls.Add(this.m_NumericRows);
            this.Controls.Add(this.m_LabelRows);
            this.Controls.Add(this.m_LabelColumns);
            this.Controls.Add(this.m_LabelBoardSize);
            this.Controls.Add(this.m_TextBoxPlayer2);
            this.Controls.Add(this.m_TextBoxPlayer1);
            this.Controls.Add(this.m_LabelPlayer2);
            this.Controls.Add(this.m_LabelPlayer1);
            this.Controls.Add(this.m_LabelPlayers);
            this.Controls.Add(this.m_CheckBoxPlayer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.m_NumericRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumericCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox m_CheckBoxPlayer2;
        private System.Windows.Forms.Label m_LabelPlayers;
        private System.Windows.Forms.Label m_LabelPlayer1;
        private System.Windows.Forms.Label m_LabelPlayer2;
        private System.Windows.Forms.TextBox m_TextBoxPlayer1;
        private System.Windows.Forms.TextBox m_TextBoxPlayer2;
        private System.Windows.Forms.Label m_LabelBoardSize;
        private System.Windows.Forms.Label m_LabelColumns;
        private System.Windows.Forms.Label m_LabelRows;
        private System.Windows.Forms.NumericUpDown m_NumericRows;
        private System.Windows.Forms.NumericUpDown m_NumericCols;
        private System.Windows.Forms.Button m_ButtonStart;
    }
}