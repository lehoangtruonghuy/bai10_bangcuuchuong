namespace bai10_bangcuuchuong
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
            this.lsbBCC = new System.Windows.Forms.ListBox();
            this.btnTINH = new System.Windows.Forms.Button();
            this.txtNHAP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng Cửu Chưởng";
            // 
            // lsbBCC
            // 
            this.lsbBCC.FormattingEnabled = true;
            this.lsbBCC.Location = new System.Drawing.Point(23, 149);
            this.lsbBCC.Name = "lsbBCC";
            this.lsbBCC.Size = new System.Drawing.Size(233, 290);
            this.lsbBCC.TabIndex = 1;
            // 
            // btnTINH
            // 
            this.btnTINH.Location = new System.Drawing.Point(246, 105);
            this.btnTINH.Name = "btnTINH";
            this.btnTINH.Size = new System.Drawing.Size(81, 23);
            this.btnTINH.TabIndex = 4;
            this.btnTINH.Text = "button";
            this.btnTINH.UseVisualStyleBackColor = true;

            // 
            // txtNHAP
            // 
            this.txtNHAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNHAP.Location = new System.Drawing.Point(50, 105);
            this.txtNHAP.Name = "txtNHAP";
            this.txtNHAP.Size = new System.Drawing.Size(53, 26);
            this.txtNHAP.TabIndex = 5;
            this.txtNHAP.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 451);
            this.Controls.Add(this.txtNHAP);
            this.Controls.Add(this.btnTINH);
            this.Controls.Add(this.lsbBCC);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbBCC;
        private System.Windows.Forms.Button btnTINH;
        private System.Windows.Forms.TextBox txtNHAP;
    }
}

