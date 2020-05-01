namespace Buoi5_18DH110884_NguyenChiMy
{
    partial class bai1
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
            this.tbx = new System.Windows.Forms.TextBox();
            this.btnXuLLy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap gia tri x:";
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(90, 6);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(126, 20);
            this.tbx.TabIndex = 1;
            // 
            // btnXuLLy
            // 
            this.btnXuLLy.Location = new System.Drawing.Point(15, 169);
            this.btnXuLLy.Name = "btnXuLLy";
            this.btnXuLLy.Size = new System.Drawing.Size(201, 23);
            this.btnXuLLy.TabIndex = 2;
            this.btnXuLLy.Text = "Hien noi dung cua texbox  ";
            this.btnXuLLy.UseVisualStyleBackColor = true;
            this.btnXuLLy.Click += new System.EventHandler(this.btnXuLLy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhap gia tri y:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(90, 88);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(126, 20);
            this.txtY.TabIndex = 4;
            // 
            // bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 204);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXuLLy);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.label1);
            this.Name = "bai1";
            this.Text = "Bai 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Button btnXuLLy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY;
    }
}

