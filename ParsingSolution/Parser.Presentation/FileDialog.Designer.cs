namespace Parser.Presentation
{
    partial class FileDialog
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtUpload1 = new System.Windows.Forms.TextBox();
            this.lblUpload1 = new System.Windows.Forms.Label();
            this.btnUpload1 = new System.Windows.Forms.Button();
            this.btnUpload2 = new System.Windows.Forms.Button();
            this.lblUpload2 = new System.Windows.Forms.Label();
            this.txtUpload2 = new System.Windows.Forms.TextBox();
            this.btnUpload3 = new System.Windows.Forms.Button();
            this.Upload3 = new System.Windows.Forms.Label();
            this.txtUpload3 = new System.Windows.Forms.TextBox();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtUpload1
            // 
            this.txtUpload1.AllowDrop = true;
            this.txtUpload1.BackColor = System.Drawing.SystemColors.Info;
            this.txtUpload1.Location = new System.Drawing.Point(132, 25);
            this.txtUpload1.Name = "txtUpload1";
            this.txtUpload1.Size = new System.Drawing.Size(300, 20);
            this.txtUpload1.TabIndex = 0;
            // 
            // lblUpload1
            // 
            this.lblUpload1.AutoSize = true;
            this.lblUpload1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpload1.Location = new System.Drawing.Point(20, 28);
            this.lblUpload1.Name = "lblUpload1";
            this.lblUpload1.Size = new System.Drawing.Size(87, 13);
            this.lblUpload1.TabIndex = 1;
            this.lblUpload1.Text = "Text Source 1";
            // 
            // btnUpload1
            // 
            this.btnUpload1.Location = new System.Drawing.Point(457, 23);
            this.btnUpload1.Name = "btnUpload1";
            this.btnUpload1.Size = new System.Drawing.Size(75, 23);
            this.btnUpload1.TabIndex = 2;
            this.btnUpload1.Text = "Select";
            this.btnUpload1.UseVisualStyleBackColor = true;
            // 
            // btnUpload2
            // 
            this.btnUpload2.Location = new System.Drawing.Point(457, 60);
            this.btnUpload2.Name = "btnUpload2";
            this.btnUpload2.Size = new System.Drawing.Size(75, 23);
            this.btnUpload2.TabIndex = 5;
            this.btnUpload2.Text = "Select";
            this.btnUpload2.UseVisualStyleBackColor = true;
            // 
            // lblUpload2
            // 
            this.lblUpload2.AutoSize = true;
            this.lblUpload2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpload2.Location = new System.Drawing.Point(20, 65);
            this.lblUpload2.Name = "lblUpload2";
            this.lblUpload2.Size = new System.Drawing.Size(87, 13);
            this.lblUpload2.TabIndex = 4;
            this.lblUpload2.Text = "Text Source 2";
            // 
            // txtUpload2
            // 
            this.txtUpload2.AllowDrop = true;
            this.txtUpload2.BackColor = System.Drawing.SystemColors.Info;
            this.txtUpload2.Location = new System.Drawing.Point(132, 62);
            this.txtUpload2.Name = "txtUpload2";
            this.txtUpload2.Size = new System.Drawing.Size(300, 20);
            this.txtUpload2.TabIndex = 3;
            // 
            // btnUpload3
            // 
            this.btnUpload3.Location = new System.Drawing.Point(457, 97);
            this.btnUpload3.Name = "btnUpload3";
            this.btnUpload3.Size = new System.Drawing.Size(75, 23);
            this.btnUpload3.TabIndex = 8;
            this.btnUpload3.Text = "Select";
            this.btnUpload3.UseVisualStyleBackColor = true;
            // 
            // Upload3
            // 
            this.Upload3.AutoSize = true;
            this.Upload3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload3.Location = new System.Drawing.Point(20, 102);
            this.Upload3.Name = "Upload3";
            this.Upload3.Size = new System.Drawing.Size(87, 13);
            this.Upload3.TabIndex = 7;
            this.Upload3.Text = "Text Source 3";
            // 
            // txtUpload3
            // 
            this.txtUpload3.AllowDrop = true;
            this.txtUpload3.BackColor = System.Drawing.SystemColors.Info;
            this.txtUpload3.Location = new System.Drawing.Point(132, 99);
            this.txtUpload3.Name = "txtUpload3";
            this.txtUpload3.Size = new System.Drawing.Size(300, 20);
            this.txtUpload3.TabIndex = 6;
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnUpload3);
            this.gbInput.Controls.Add(this.Upload3);
            this.gbInput.Controls.Add(this.txtUpload3);
            this.gbInput.Controls.Add(this.btnUpload2);
            this.gbInput.Controls.Add(this.lblUpload2);
            this.gbInput.Controls.Add(this.txtUpload2);
            this.gbInput.Controls.Add(this.btnUpload1);
            this.gbInput.Controls.Add(this.lblUpload1);
            this.gbInput.Controls.Add(this.txtUpload1);
            this.gbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(548, 138);
            this.gbInput.TabIndex = 9;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input files";
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.Location = new System.Drawing.Point(469, 185);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 12;
            this.btnOutput.Text = "Select";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Output Directory";
            // 
            // txtOutput
            // 
            this.txtOutput.AllowDrop = true;
            this.txtOutput.BackColor = System.Drawing.SystemColors.Info;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(144, 187);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(300, 20);
            this.txtOutput.TabIndex = 10;
            // 
            // FileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(594, 248);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.gbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FileDialog";
            this.ShowIcon = false;
            this.Text = "JSON Converter";
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtUpload1;
        private System.Windows.Forms.Label lblUpload1;
        private System.Windows.Forms.Button btnUpload1;
        private System.Windows.Forms.Button btnUpload2;
        private System.Windows.Forms.Label lblUpload2;
        private System.Windows.Forms.TextBox txtUpload2;
        private System.Windows.Forms.Button btnUpload3;
        private System.Windows.Forms.Label Upload3;
        private System.Windows.Forms.TextBox txtUpload3;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

