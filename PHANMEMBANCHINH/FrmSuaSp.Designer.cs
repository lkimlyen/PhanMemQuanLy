namespace PHANMEMBANCHINH
{
    partial class FrmSuaSp
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
            System.Windows.Forms.Label iDSPLabel;
            System.Windows.Forms.Label tenSanPhamLabel;
            System.Windows.Forms.Label donGiaLabel;
            System.Windows.Forms.Label donViTinhLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuaSp));
            this.iDSPTextBox = new System.Windows.Forms.TextBox();
            this.tenSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.donGiaTextBox = new System.Windows.Forms.TextBox();
            this.donViTinhTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iDSPLabel = new System.Windows.Forms.Label();
            tenSanPhamLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            donViTinhLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iDSPLabel
            // 
            iDSPLabel.AutoSize = true;
            iDSPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDSPLabel.ForeColor = System.Drawing.Color.DimGray;
            iDSPLabel.Location = new System.Drawing.Point(33, 56);
            iDSPLabel.Name = "iDSPLabel";
            iDSPLabel.Size = new System.Drawing.Size(109, 20);
            iDSPLabel.TabIndex = 1;
            iDSPLabel.Text = "Mã sản phẩm:";
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.AutoSize = true;
            tenSanPhamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenSanPhamLabel.ForeColor = System.Drawing.Color.DimGray;
            tenSanPhamLabel.Location = new System.Drawing.Point(33, 96);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new System.Drawing.Size(114, 20);
            tenSanPhamLabel.TabIndex = 3;
            tenSanPhamLabel.Text = "Tên sản phẩm:";
            tenSanPhamLabel.Click += new System.EventHandler(this.tenSanPhamLabel_Click);
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            donGiaLabel.ForeColor = System.Drawing.Color.DimGray;
            donGiaLabel.Location = new System.Drawing.Point(33, 136);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(68, 20);
            donGiaLabel.TabIndex = 5;
            donGiaLabel.Text = "Đơn giá:";
            // 
            // donViTinhLabel
            // 
            donViTinhLabel.AutoSize = true;
            donViTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            donViTinhLabel.ForeColor = System.Drawing.Color.DimGray;
            donViTinhLabel.Location = new System.Drawing.Point(33, 176);
            donViTinhLabel.Name = "donViTinhLabel";
            donViTinhLabel.Size = new System.Drawing.Size(87, 20);
            donViTinhLabel.TabIndex = 7;
            donViTinhLabel.Text = "Đơn vị tính:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            label1.Location = new System.Drawing.Point(141, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(183, 25);
            label1.TabIndex = 1;
            label1.Text = "SỬA SẢN PHẨM";
            // 
            // iDSPTextBox
            // 
            this.iDSPTextBox.Enabled = false;
            this.iDSPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDSPTextBox.Location = new System.Drawing.Point(159, 56);
            this.iDSPTextBox.Name = "iDSPTextBox";
            this.iDSPTextBox.Size = new System.Drawing.Size(299, 26);
            this.iDSPTextBox.TabIndex = 2;
            // 
            // tenSanPhamTextBox
            // 
            this.tenSanPhamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSanPhamTextBox.Location = new System.Drawing.Point(159, 94);
            this.tenSanPhamTextBox.MaxLength = 255;
            this.tenSanPhamTextBox.Name = "tenSanPhamTextBox";
            this.tenSanPhamTextBox.Size = new System.Drawing.Size(299, 26);
            this.tenSanPhamTextBox.TabIndex = 4;
            // 
            // donGiaTextBox
            // 
            this.donGiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGiaTextBox.Location = new System.Drawing.Point(159, 132);
            this.donGiaTextBox.MaxLength = 14;
            this.donGiaTextBox.Name = "donGiaTextBox";
            this.donGiaTextBox.Size = new System.Drawing.Size(299, 26);
            this.donGiaTextBox.TabIndex = 6;
            this.donGiaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dg);
            // 
            // donViTinhTextBox
            // 
            this.donViTinhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donViTinhTextBox.Location = new System.Drawing.Point(159, 170);
            this.donViTinhTextBox.MaxLength = 8;
            this.donViTinhTextBox.Name = "donViTinhTextBox";
            this.donViTinhTextBox.Size = new System.Drawing.Size(299, 26);
            this.donViTinhTextBox.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(263, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(115, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmSuaSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 291);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(label1);
            this.Controls.Add(iDSPLabel);
            this.Controls.Add(this.iDSPTextBox);
            this.Controls.Add(tenSanPhamLabel);
            this.Controls.Add(this.tenSanPhamTextBox);
            this.Controls.Add(donGiaLabel);
            this.Controls.Add(this.donGiaTextBox);
            this.Controls.Add(donViTinhLabel);
            this.Controls.Add(this.donViTinhTextBox);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSuaSp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSuaSp_FormClosing);
            this.Load += new System.EventHandler(this.FrmSuaSp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iDSPTextBox;
        private System.Windows.Forms.TextBox tenSanPhamTextBox;
        private System.Windows.Forms.TextBox donGiaTextBox;
        private System.Windows.Forms.TextBox donViTinhTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}