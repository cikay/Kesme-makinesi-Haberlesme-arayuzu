namespace Kesme_makinesi_haberleşme_arayüzü
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
            this.btnCut = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbCntInfo = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btn25mm = new System.Windows.Forms.Button();
            this.btn100mm = new System.Windows.Forms.Button();
            this.btn75mm = new System.Windows.Forms.Button();
            this.btn150mm = new System.Windows.Forms.Button();
            this.btn200mm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn50mm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCut
            // 
            this.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCut.Location = new System.Drawing.Point(62, 88);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(80, 39);
            this.btnCut.TabIndex = 0;
            this.btnCut.Text = "Kesme";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            this.btnCut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCut_MouseClickDown);
            this.btnCut.MouseLeave += new System.EventHandler(this.btnCut_MouseClickLeaveOrUp);
            this.btnCut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCut_MouseClickLeaveOrUp);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(179, 88);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(86, 39);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = "İleri";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            this.btnForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseClickDown);
            this.btnForward.MouseLeave += new System.EventHandler(this.btnForward_MouseClickLeaveOrUp);
            this.btnForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseClickLeaveOrUp);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(305, 88);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 39);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBack_Click);
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseClickDown);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseClickLeaveOrUp);
            this.btnBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseClickLeaveOrUp);
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnConnect.BackColor = System.Drawing.Color.Blue;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(616, 66);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(139, 47);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Makineye bağlanın";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbCntInfo
            // 
            this.lbCntInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbCntInfo.AutoSize = true;
            this.lbCntInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbCntInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCntInfo.Location = new System.Drawing.Point(525, 32);
            this.lbCntInfo.Name = "lbCntInfo";
            this.lbCntInfo.Size = new System.Drawing.Size(185, 20);
            this.lbCntInfo.TabIndex = 4;
            this.lbCntInfo.Text = "Makineye bağlı değilsiniz!";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnDisconnect.BackColor = System.Drawing.Color.Gray;
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnDisconnect.ForeColor = System.Drawing.Color.DimGray;
            this.btnDisconnect.Location = new System.Drawing.Point(466, 66);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(117, 47);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Bağlatıyı kesin";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btn25mm
            // 
            this.btn25mm.Location = new System.Drawing.Point(14, 23);
            this.btn25mm.Name = "btn25mm";
            this.btn25mm.Size = new System.Drawing.Size(92, 40);
            this.btn25mm.TabIndex = 7;
            this.btn25mm.Text = "25 mm";
            this.btn25mm.UseVisualStyleBackColor = true;
            this.btn25mm.Click += new System.EventHandler(this.btn25mm_Click);
            this.btn25mm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn25mm_MouseClickDown);
            this.btn25mm.MouseLeave += new System.EventHandler(this.btn25mm_MouseClickLeaveOrUp);
            this.btn25mm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn25mm_MouseClickLeaveOrUp);
            // 
            // btn100mm
            // 
            this.btn100mm.Location = new System.Drawing.Point(14, 85);
            this.btn100mm.Name = "btn100mm";
            this.btn100mm.Size = new System.Drawing.Size(92, 40);
            this.btn100mm.TabIndex = 7;
            this.btn100mm.Text = "100 mm";
            this.btn100mm.UseVisualStyleBackColor = true;
            this.btn100mm.Click += new System.EventHandler(this.btn100mm_Click);
            this.btn100mm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn100mm_MouseClickDown);
            this.btn100mm.MouseLeave += new System.EventHandler(this.btn100mm_MouseClickLeaveOrUp);
            this.btn100mm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn100mm_MouseClickLeaveOrUp);
            // 
            // btn75mm
            // 
            this.btn75mm.Location = new System.Drawing.Point(262, 23);
            this.btn75mm.Name = "btn75mm";
            this.btn75mm.Size = new System.Drawing.Size(92, 40);
            this.btn75mm.TabIndex = 7;
            this.btn75mm.Text = "75 mm";
            this.btn75mm.UseVisualStyleBackColor = true;
            this.btn75mm.Click += new System.EventHandler(this.btn75mm_Click);
            this.btn75mm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn75mm_MouseClickDown);
            this.btn75mm.MouseLeave += new System.EventHandler(this.btn75mm_MouseClickLeaveOrUp);
            this.btn75mm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn75mm_MouseClickLeaveOrUp);
            // 
            // btn150mm
            // 
            this.btn150mm.Location = new System.Drawing.Point(137, 85);
            this.btn150mm.Name = "btn150mm";
            this.btn150mm.Size = new System.Drawing.Size(92, 40);
            this.btn150mm.TabIndex = 7;
            this.btn150mm.Text = "150 mm";
            this.btn150mm.UseVisualStyleBackColor = true;
            this.btn150mm.Click += new System.EventHandler(this.btn150mm_Click);
            this.btn150mm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn150mm_MouseClickDown);
            this.btn150mm.MouseLeave += new System.EventHandler(this.btn150mm_MouseClickLeaveOrUp);
            this.btn150mm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn150mm_MouseClickLeaveOrUp);
            // 
            // btn200mm
            // 
            this.btn200mm.Location = new System.Drawing.Point(262, 85);
            this.btn200mm.Name = "btn200mm";
            this.btn200mm.Size = new System.Drawing.Size(92, 40);
            this.btn200mm.TabIndex = 7;
            this.btn200mm.Text = "200 mm";
            this.btn200mm.UseVisualStyleBackColor = true;
            this.btn200mm.Click += new System.EventHandler(this.btn200mm_Click);
            this.btn200mm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn200mm_MouseClickDown);
            this.btn200mm.MouseLeave += new System.EventHandler(this.btn200mm_MouseClickLeaveOrUp);
            this.btn200mm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn200mm_MouseClickLeaveOrUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn50mm);
            this.panel1.Controls.Add(this.btn75mm);
            this.panel1.Controls.Add(this.btn200mm);
            this.panel1.Controls.Add(this.btn25mm);
            this.panel1.Controls.Add(this.btn150mm);
            this.panel1.Controls.Add(this.btn100mm);
            this.panel1.Location = new System.Drawing.Point(43, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 144);
            this.panel1.TabIndex = 9;
            // 
            // btn50mm
            // 
            this.btn50mm.Location = new System.Drawing.Point(137, 23);
            this.btn50mm.Name = "btn50mm";
            this.btn50mm.Size = new System.Drawing.Size(92, 40);
            this.btn50mm.TabIndex = 7;
            this.btn50mm.Text = "50 mm";
            this.btn50mm.UseVisualStyleBackColor = true;
            this.btn50mm.Click += new System.EventHandler(this.btn50mm_Click);
            this.btn50mm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn50mm_MouseClickDown);
            this.btn50mm.MouseLeave += new System.EventHandler(this.btn50mm_MouseClickLeaveOrUp);
            this.btn50mm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn50mm_MouseClickLeaveOrUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bant boyu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lbCntInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnCut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbCntInfo;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btn25mm;
        private System.Windows.Forms.Button btn100mm;
        private System.Windows.Forms.Button btn75mm;
        private System.Windows.Forms.Button btn150mm;
        private System.Windows.Forms.Button btn200mm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn50mm;
    }
}

