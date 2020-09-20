namespace hnib
{
    partial class Hnibuv
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
            this.components = new System.ComponentModel.Container();
            this.TxtTL = new System.Windows.Forms.TextBox();
            this.BtnKetnoi = new System.Windows.Forms.Button();
            this.BtnNgatKN = new System.Windows.Forms.Button();
            this.LbStatus = new System.Windows.Forms.Label();
            this.CboCom = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TxtTL
            // 
            this.TxtTL.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTL.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTL.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtTL.Location = new System.Drawing.Point(161, 155);
            this.TxtTL.Multiline = true;
            this.TxtTL.Name = "TxtTL";
            this.TxtTL.Size = new System.Drawing.Size(196, 74);
            this.TxtTL.TabIndex = 0;
            this.TxtTL.Text = "0";
            this.TxtTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnKetnoi
            // 
            this.BtnKetnoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKetnoi.Location = new System.Drawing.Point(151, 79);
            this.BtnKetnoi.Name = "BtnKetnoi";
            this.BtnKetnoi.Size = new System.Drawing.Size(96, 32);
            this.BtnKetnoi.TabIndex = 1;
            this.BtnKetnoi.Text = "Kết nối";
            this.BtnKetnoi.UseVisualStyleBackColor = true;
            this.BtnKetnoi.Click += new System.EventHandler(this.BtnKetnoi_Click);
            // 
            // BtnNgatKN
            // 
            this.BtnNgatKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNgatKN.Location = new System.Drawing.Point(253, 79);
            this.BtnNgatKN.Name = "BtnNgatKN";
            this.BtnNgatKN.Size = new System.Drawing.Size(121, 32);
            this.BtnNgatKN.TabIndex = 1;
            this.BtnNgatKN.Text = "Ngắt kết nối";
            this.BtnNgatKN.UseVisualStyleBackColor = true;
            this.BtnNgatKN.Click += new System.EventHandler(this.BtnNgatKN_Click);
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStatus.ForeColor = System.Drawing.Color.Maroon;
            this.LbStatus.Location = new System.Drawing.Point(306, 250);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(51, 16);
            this.LbStatus.TabIndex = 2;
            this.LbStatus.Text = "Status";
            // 
            // CboCom
            // 
            this.CboCom.FormattingEnabled = true;
            this.CboCom.Location = new System.Drawing.Point(151, 24);
            this.CboCom.Name = "CboCom";
            this.CboCom.Size = new System.Drawing.Size(223, 21);
            this.CboCom.TabIndex = 3;
            this.CboCom.SelectedIndexChanged += new System.EventHandler(this.CboCom_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Hnibuv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 297);
            this.Controls.Add(this.CboCom);
            this.Controls.Add(this.LbStatus);
            this.Controls.Add(this.BtnNgatKN);
            this.Controls.Add(this.BtnKetnoi);
            this.Controls.Add(this.TxtTL);
            this.Name = "Hnibuv";
            this.Text = "Hnibuv";
            this.Load += new System.EventHandler(this.Hnibuv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTL;
        private System.Windows.Forms.Button BtnKetnoi;
        private System.Windows.Forms.Button BtnNgatKN;
        private System.Windows.Forms.Label LbStatus;
        private System.Windows.Forms.ComboBox CboCom;
        private System.Windows.Forms.Timer timer1;
    }
}