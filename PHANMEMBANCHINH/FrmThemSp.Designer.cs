namespace PHANMEMBANCHINH
{
    partial class FrmThemSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemSP));
            this.label1 = new System.Windows.Forms.Label();
            this.tenSanPhamLabel = new System.Windows.Forms.Label();
            this.donGiaLabel = new System.Windows.Forms.Label();
            this.donViTinhLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tenSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.donGiaTextBox = new System.Windows.Forms.TextBox();
            this.donViTinhTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(141, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "THÊM SẢN PHẨM";
            // 
            // tenSanPhamLabel
            // 
            this.tenSanPhamLabel.AutoSize = true;
            this.tenSanPhamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSanPhamLabel.ForeColor = System.Drawing.Color.DimGray;
            this.tenSanPhamLabel.Location = new System.Drawing.Point(33, 63);
            this.tenSanPhamLabel.Name = "tenSanPhamLabel";
            this.tenSanPhamLabel.Size = new System.Drawing.Size(114, 20);
            this.tenSanPhamLabel.TabIndex = 14;
            this.tenSanPhamLabel.Text = "Tên sản phẩm:";
            // 
            // donGiaLabel
            // 
            this.donGiaLabel.AutoSize = true;
            this.donGiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGiaLabel.ForeColor = System.Drawing.Color.DimGray;
            this.donGiaLabel.Location = new System.Drawing.Point(33, 103);
            this.donGiaLabel.Name = "donGiaLabel";
            this.donGiaLabel.Size = new System.Drawing.Size(68, 20);
            this.donGiaLabel.TabIndex = 16;
            this.donGiaLabel.Text = "Đơn giá:";
            // 
            // donViTinhLabel
            // 
            this.donViTinhLabel.AutoSize = true;
            this.donViTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donViTinhLabel.ForeColor = System.Drawing.Color.DimGray;
            this.donViTinhLabel.Location = new System.Drawing.Point(33, 143);
            this.donViTinhLabel.Name = "donViTinhLabel";
            this.donViTinhLabel.Size = new System.Drawing.Size(87, 20);
            this.donViTinhLabel.TabIndex = 18;
            this.donViTinhLabel.Text = "Đơn vị tính:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(300, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(193, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tenSanPhamTextBox
            // 
            this.tenSanPhamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSanPhamTextBox.Location = new System.Drawing.Point(159, 61);
            this.tenSanPhamTextBox.MaxLength = 255;
            this.tenSanPhamTextBox.Name = "tenSanPhamTextBox";
            this.tenSanPhamTextBox.Size = new System.Drawing.Size(299, 26);
            this.tenSanPhamTextBox.TabIndex = 15;
            // 
            // donGiaTextBox
            // 
            this.donGiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGiaTextBox.Location = new System.Drawing.Point(159, 99);
            this.donGiaTextBox.MaxLength = 9;
            this.donGiaTextBox.Name = "donGiaTextBox";
            this.donGiaTextBox.Size = new System.Drawing.Size(299, 26);
            this.donGiaTextBox.TabIndex = 17;
            this.donGiaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypressdongia);
            // 
            // donViTinhTextBox
            // 
            this.donViTinhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donViTinhTextBox.Location = new System.Drawing.Point(159, 137);
            this.donViTinhTextBox.MaxLength = 8;
            this.donViTinhTextBox.Name = "donViTinhTextBox";
            this.donViTinhTextBox.Size = new System.Drawing.Size(299, 26);
            this.donViTinhTextBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(85, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Xóa trắng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 251);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenSanPhamLabel);
            this.Controls.Add(this.tenSanPhamTextBox);
            this.Controls.Add(this.donGiaLabel);
            this.Controls.Add(this.donGiaTextBox);
            this.Controls.Add(this.donViTinhLabel);
            this.Controls.Add(this.donViTinhTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmThemSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmThemSP_FormClosing);
            this.Load += new System.EventHandler(this.FrmThemSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tenSanPhamTextBox;
        private System.Windows.Forms.TextBox donGiaTextBox;
        private System.Windows.Forms.TextBox donViTinhTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tenSanPhamLabel;
        private System.Windows.Forms.Label donGiaLabel;
        private System.Windows.Forms.Label donViTinhLabel;
    }
}