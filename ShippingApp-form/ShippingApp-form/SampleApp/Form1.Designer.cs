namespace DotNetShipping.SampleApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.Residential = new System.Windows.Forms.Label();
            this.zip_box = new System.Windows.Forms.TextBox();
            this.submit_but = new System.Windows.Forms.Button();
            this.radio_y = new System.Windows.Forms.RadioButton();
            this.radio_n = new System.Windows.Forms.RadioButton();
            this.parts = new System.Windows.Forms.DataGridView();
            this.PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reset_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination Zipcode: ";
            // 
            // Residential
            // 
            this.Residential.AutoSize = true;
            this.Residential.Location = new System.Drawing.Point(58, 49);
            this.Residential.Name = "Residential";
            this.Residential.Size = new System.Drawing.Size(62, 13);
            this.Residential.TabIndex = 1;
            this.Residential.Text = "Residential:";
            // 
            // zip_box
            // 
            this.zip_box.Location = new System.Drawing.Point(126, 16);
            this.zip_box.MaxLength = 7;
            this.zip_box.Name = "zip_box";
            this.zip_box.Size = new System.Drawing.Size(137, 20);
            this.zip_box.TabIndex = 1;
            // 
            // submit_but
            // 
            this.submit_but.Location = new System.Drawing.Point(278, 14);
            this.submit_but.Name = "submit_but";
            this.submit_but.Size = new System.Drawing.Size(75, 23);
            this.submit_but.TabIndex = 4;
            this.submit_but.Text = "Find Quote";
            this.submit_but.UseVisualStyleBackColor = true;
            this.submit_but.Click += new System.EventHandler(this.submit_but_Click);
            // 
            // radio_y
            // 
            this.radio_y.AutoSize = true;
            this.radio_y.Location = new System.Drawing.Point(126, 49);
            this.radio_y.Name = "radio_y";
            this.radio_y.Size = new System.Drawing.Size(43, 17);
            this.radio_y.TabIndex = 2;
            this.radio_y.TabStop = true;
            this.radio_y.Text = "Yes";
            this.radio_y.UseVisualStyleBackColor = true;
            // 
            // radio_n
            // 
            this.radio_n.AutoSize = true;
            this.radio_n.Location = new System.Drawing.Point(183, 49);
            this.radio_n.Name = "radio_n";
            this.radio_n.Size = new System.Drawing.Size(39, 17);
            this.radio_n.TabIndex = 3;
            this.radio_n.TabStop = true;
            this.radio_n.Text = "No";
            this.radio_n.UseVisualStyleBackColor = true;
            // 
            // parts
            // 
            this.parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PN,
            this.Quan});
            this.parts.Location = new System.Drawing.Point(15, 74);
            this.parts.Name = "parts";
            this.parts.RowHeadersWidth = 46;
            this.parts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.parts.Size = new System.Drawing.Size(338, 225);
            this.parts.TabIndex = 4;
            // 
            // PN
            // 
            this.PN.HeaderText = "Part Number";
            this.PN.Name = "PN";
            this.PN.Width = 145;
            // 
            // Quan
            // 
            this.Quan.HeaderText = "Quantity";
            this.Quan.Name = "Quan";
            this.Quan.Width = 145;
            // 
            // reset_but
            // 
            this.reset_but.Location = new System.Drawing.Point(278, 43);
            this.reset_but.Name = "reset_but";
            this.reset_but.Size = new System.Drawing.Size(75, 23);
            this.reset_but.TabIndex = 12;
            this.reset_but.TabStop = false;
            this.reset_but.Text = "Reset";
            this.reset_but.UseVisualStyleBackColor = true;
            this.reset_but.Click += new System.EventHandler(this.reset_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 310);
            this.Controls.Add(this.reset_but);
            this.Controls.Add(this.parts);
            this.Controls.Add(this.radio_n);
            this.Controls.Add(this.radio_y);
            this.Controls.Add(this.submit_but);
            this.Controls.Add(this.zip_box);
            this.Controls.Add(this.Residential);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Shipping Application";
            ((System.ComponentModel.ISupportInitialize)(this.parts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Residential;
        private System.Windows.Forms.TextBox zip_box;
        private System.Windows.Forms.Button submit_but;
        private System.Windows.Forms.RadioButton radio_y;
        private System.Windows.Forms.RadioButton radio_n;
        private System.Windows.Forms.DataGridView parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.Button reset_but;
    }
}