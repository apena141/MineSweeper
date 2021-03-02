namespace MineSweeper
{
    partial class CustomForm
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
            this.rowNumeric = new System.Windows.Forms.NumericUpDown();
            this.columnNumeric = new System.Windows.Forms.NumericUpDown();
            this.minesNumeric = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rowLabel = new System.Windows.Forms.Label();
            this.columnLabel = new System.Windows.Forms.Label();
            this.minesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minesNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // rowNumeric
            // 
            this.rowNumeric.Location = new System.Drawing.Point(76, 66);
            this.rowNumeric.Name = "rowNumeric";
            this.rowNumeric.Size = new System.Drawing.Size(137, 20);
            this.rowNumeric.TabIndex = 0;
            // 
            // columnNumeric
            // 
            this.columnNumeric.Location = new System.Drawing.Point(76, 108);
            this.columnNumeric.Name = "columnNumeric";
            this.columnNumeric.Size = new System.Drawing.Size(137, 20);
            this.columnNumeric.TabIndex = 1;
            // 
            // minesNumeric
            // 
            this.minesNumeric.Location = new System.Drawing.Point(76, 150);
            this.minesNumeric.Name = "minesNumeric";
            this.minesNumeric.Size = new System.Drawing.Size(137, 20);
            this.minesNumeric.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(50, 213);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 51);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(131, 213);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 51);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(12, 68);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(29, 13);
            this.rowLabel.TabIndex = 6;
            this.rowLabel.Text = "Row";
            // 
            // columnLabel
            // 
            this.columnLabel.AutoSize = true;
            this.columnLabel.Location = new System.Drawing.Point(12, 110);
            this.columnLabel.Name = "columnLabel";
            this.columnLabel.Size = new System.Drawing.Size(42, 13);
            this.columnLabel.TabIndex = 7;
            this.columnLabel.Text = "Column";
            // 
            // minesLabel
            // 
            this.minesLabel.AutoSize = true;
            this.minesLabel.Location = new System.Drawing.Point(12, 152);
            this.minesLabel.Name = "minesLabel";
            this.minesLabel.Size = new System.Drawing.Size(57, 13);
            this.minesLabel.TabIndex = 8;
            this.minesLabel.Text = "# of Mines";
            // 
            // CustomForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(257, 276);
            this.Controls.Add(this.minesLabel);
            this.Controls.Add(this.columnLabel);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.minesNumeric);
            this.Controls.Add(this.columnNumeric);
            this.Controls.Add(this.rowNumeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomForm";
            this.Text = "CustomForm";
            ((System.ComponentModel.ISupportInitialize)(this.rowNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minesNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown rowNumeric;
        private System.Windows.Forms.NumericUpDown columnNumeric;
        private System.Windows.Forms.NumericUpDown minesNumeric;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Label columnLabel;
        private System.Windows.Forms.Label minesLabel;
    }
}