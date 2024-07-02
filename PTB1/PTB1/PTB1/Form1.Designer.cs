namespace PTB1
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnclick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.kq = new System.Windows.Forms.Label();
            this.btn__giai = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Test các chức năng tự động";
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(81, 98);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(75, 23);
            this.btnclick.TabIndex = 9;
            this.btnclick.Text = "Test";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phương Trình Bậc 1";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(531, 78);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(29, 13);
            this.a.TabIndex = 11;
            this.a.Text = "Số a";
            this.a.Click += new System.EventHandler(this.label2_Click);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(531, 129);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(29, 13);
            this.b.TabIndex = 12;
            this.b.Text = "Số b";
            // 
            // kq
            // 
            this.kq.AutoSize = true;
            this.kq.Location = new System.Drawing.Point(534, 181);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(46, 13);
            this.kq.TabIndex = 13;
            this.kq.Text = "Kết Quả";
            // 
            // btn__giai
            // 
            this.btn__giai.Location = new System.Drawing.Point(632, 253);
            this.btn__giai.Name = "btn__giai";
            this.btn__giai.Size = new System.Drawing.Size(75, 23);
            this.btn__giai.TabIndex = 14;
            this.btn__giai.Text = "Giải";
            this.btn__giai.UseVisualStyleBackColor = true;
            this.btn__giai.Click += new System.EventHandler(this.btn__giai_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(607, 78);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(145, 20);
            this.txta.TabIndex = 15;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(607, 121);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(145, 20);
            this.txtb.TabIndex = 16;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(607, 173);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(181, 20);
            this.txtkq.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btn__giai);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclick);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label kq;
        private System.Windows.Forms.Button btn__giai;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtkq;
    }
}

