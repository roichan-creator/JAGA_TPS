namespace JAGA_TPS
{
    partial class DataTPS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTPS));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            lblNamaTPS = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            lblLokasiTPS = new Label();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblVolume = new Label();
            label6 = new Label();
            lblJadwal = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flyStatus = new FlowLayoutPanel();
            pictureBoxStatus = new PictureBox();
            lblStatus = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label10 = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flyStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStatus).BeginInit();
            flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flowLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(186, 26, 26);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(12, 295);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(227, 241, 231);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 1;
            label1.Text = "TPS-ID: MM-01C";
            // 
            // lblNamaTPS
            // 
            lblNamaTPS.AutoSize = true;
            lblNamaTPS.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaTPS.Location = new Point(4, 30);
            lblNamaTPS.Margin = new Padding(4, 0, 4, 0);
            lblNamaTPS.Name = "lblNamaTPS";
            lblNamaTPS.Size = new Size(435, 38);
            lblNamaTPS.TabIndex = 2;
            lblNamaTPS.Text = "TPS Sentral Komersial & Kantin A";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(lblLokasiTPS);
            flowLayoutPanel2.Location = new Point(4, 68);
            flowLayoutPanel2.Margin = new Padding(4, 0, 4, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(340, 43);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLokasiTPS
            // 
            lblLokasiTPS.Anchor = AnchorStyles.Left;
            lblLokasiTPS.AutoSize = true;
            lblLokasiTPS.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLokasiTPS.ForeColor = Color.FromArgb(63, 73, 67);
            lblLokasiTPS.Location = new Point(49, 9);
            lblLokasiTPS.Margin = new Padding(4, 0, 4, 0);
            lblLokasiTPS.Name = "lblLokasiTPS";
            lblLokasiTPS.Size = new Size(287, 25);
            lblLokasiTPS.TabIndex = 3;
            lblLokasiTPS.Text = "Zona Industri Barat, Jalur Logistik 3";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(18, 30, 24);
            label3.Location = new Point(4, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 2;
            label3.Text = "Volume Keterisian TPS";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(label1);
            flowLayoutPanel3.Controls.Add(lblNamaTPS);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(19, 22);
            flowLayoutPanel3.Margin = new Padding(4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(443, 111);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Left;
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(lblVolume);
            flowLayoutPanel4.Location = new Point(4, 25);
            flowLayoutPanel4.Margin = new Padding(4);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(402, 65);
            flowLayoutPanel4.TabIndex = 5;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVolume.ForeColor = Color.Red;
            lblVolume.Location = new Point(212, 0);
            lblVolume.Margin = new Padding(4, 0, 4, 0);
            lblVolume.Name = "lblVolume";
            lblVolume.Padding = new Padding(60, 0, 0, 0);
            lblVolume.Size = new Size(186, 65);
            lblVolume.TabIndex = 6;
            lblVolume.Text = "88%";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(63, 73, 67);
            label6.Location = new Point(4, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 6;
            label6.Text = "Jadwal Rutin:";
            // 
            // lblJadwal
            // 
            lblJadwal.Anchor = AnchorStyles.Left;
            lblJadwal.AutoSize = true;
            lblJadwal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJadwal.ForeColor = Color.FromArgb(63, 73, 67);
            lblJadwal.Location = new Point(4, 25);
            lblJadwal.Margin = new Padding(4, 0, 4, 0);
            lblJadwal.Name = "lblJadwal";
            lblJadwal.Size = new Size(193, 25);
            lblJadwal.TabIndex = 7;
            lblJadwal.Text = "Setiap Selasa && Jumat";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Anchor = AnchorStyles.Left;
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(label6);
            flowLayoutPanel5.Controls.Add(lblJadwal);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(529, 32);
            flowLayoutPanel5.Margin = new Padding(4);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(201, 50);
            flowLayoutPanel5.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 250, 245);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.1181946F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8818035F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel5, 1, 0);
            tableLayoutPanel1.Location = new Point(19, 164);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tableLayoutPanel1.Size = new Size(772, 115);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // flyStatus
            // 
            flyStatus.Anchor = AnchorStyles.Right;
            flyStatus.AutoSize = true;
            flyStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flyStatus.BackColor = Color.FromArgb(255, 225, 222);
            flyStatus.Controls.Add(pictureBoxStatus);
            flyStatus.Controls.Add(lblStatus);
            flyStatus.Location = new Point(188, 4);
            flyStatus.Margin = new Padding(4);
            flyStatus.Name = "flyStatus";
            flyStatus.Size = new Size(104, 36);
            flyStatus.TabIndex = 10;
            // 
            // pictureBoxStatus
            // 
            pictureBoxStatus.Image = (Image)resources.GetObject("pictureBoxStatus.Image");
            pictureBoxStatus.Location = new Point(4, 4);
            pictureBoxStatus.Margin = new Padding(4);
            pictureBoxStatus.Name = "pictureBoxStatus";
            pictureBoxStatus.Size = new Size(22, 28);
            pictureBoxStatus.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxStatus.TabIndex = 0;
            pictureBoxStatus.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(186, 26, 26);
            lblStatus.Location = new Point(34, 7);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 21);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Bahaya";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Anchor = AnchorStyles.Right;
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.BackColor = Color.FromArgb(227, 241, 231);
            flowLayoutPanel7.Controls.Add(pictureBox3);
            flowLayoutPanel7.Controls.Add(button1);
            flowLayoutPanel7.Location = new Point(4, 48);
            flowLayoutPanel7.Margin = new Padding(4);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(288, 50);
            flowLayoutPanel7.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(4, 4);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(227, 241, 231);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(63, 73, 67);
            button1.Location = new Point(56, 6);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(228, 37);
            button1.TabIndex = 12;
            button1.Text = "Ajukan Pengangkutan";
            button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(63, 73, 67);
            label10.Location = new Point(204, 102);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 21);
            label10.TabIndex = 12;
            label10.Text = "Lihat Detail";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel8.Controls.Add(flyStatus);
            flowLayoutPanel8.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel8.Controls.Add(label10);
            flowLayoutPanel8.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel8.Location = new Point(517, 22);
            flowLayoutPanel8.Margin = new Padding(4);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(296, 123);
            flowLayoutPanel8.TabIndex = 13;
            // 
            // DataTPS
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel8);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(4);
            Name = "DataTPS";
            Size = new Size(828, 295);
            Load += DataTPS_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flyStatus.ResumeLayout(false);
            flyStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStatus).EndInit();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label lblNamaTPS;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lblLokasiTPS;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label lblVolume;
        private Label label6;
        private Label lblJadwal;
        private FlowLayoutPanel flowLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flyStatus;
        private PictureBox pictureBoxStatus;
        private Label lblStatus;
        private FlowLayoutPanel flowLayoutPanel7;
        private PictureBox pictureBox3;
        private Button button1;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel8;
    }
}
