namespace RoketTelemetre
{
    partial class Arayuz
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arayuz));
            this.hud = new Simple_HUD.HUD_Basic();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sayac_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roket_gps_irtifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roket_enlem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roket_boylam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorev_yuku_gps_irtifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorev_yuku_enlem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorev_yuku_boylam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kademe_irtifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kademe_enlem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kademe_boylam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll_Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitch_Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yaw_Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceleration_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceleration_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceleration_Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaman_sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.veriEnlemRoket = new System.Windows.Forms.Label();
            this.veriRoketBoylam = new System.Windows.Forms.Label();
            this.veriIrtifaPayload = new System.Windows.Forms.Label();
            this.labelTakimID = new System.Windows.Forms.Label();
            this.labelSayac = new System.Windows.Forms.Label();
            this.labelIrtifa = new System.Windows.Forms.Label();
            this.labelRoketGPSIrtifa = new System.Windows.Forms.Label();
            this.labelRoketEnlem = new System.Windows.Forms.Label();
            this.labelRoketBoylam = new System.Windows.Forms.Label();
            this.labelGorevYukuGPSIrtifa = new System.Windows.Forms.Label();
            this.labelGorevYukuEnlem = new System.Windows.Forms.Label();
            this.labelGorevYukuBoylam = new System.Windows.Forms.Label();
            this.veriID = new System.Windows.Forms.Label();
            this.veriSayac = new System.Windows.Forms.Label();
            this.veriIrtifa = new System.Windows.Forms.Label();
            this.veriIrtifaGPSRoket = new System.Windows.Forms.Label();
            this.veriEnlemPayload = new System.Windows.Forms.Label();
            this.veriBoylamPayload = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.veriKademeBoylam = new System.Windows.Forms.Label();
            this.labelKademeBoylam = new System.Windows.Forms.Label();
            this.veriKademeEnlem = new System.Windows.Forms.Label();
            this.labelKademeEnlem = new System.Windows.Forms.Label();
            this.veriKademeIrtifa = new System.Windows.Forms.Label();
            this.labelKademeIrtifa = new System.Windows.Forms.Label();
            this.veriZaman = new System.Windows.Forms.Label();
            this.labelZaman = new System.Windows.Forms.Label();
            this.veriCrc = new System.Windows.Forms.Label();
            this.veriDurum = new System.Windows.Forms.Label();
            this.veriAcc_x = new System.Windows.Forms.Label();
            this.veriYaw = new System.Windows.Forms.Label();
            this.veriPitch = new System.Windows.Forms.Label();
            this.veriRoll = new System.Windows.Forms.Label();
            this.veriAngle = new System.Windows.Forms.Label();
            this.veriAcc_z = new System.Windows.Forms.Label();
            this.veriAcc_y = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.giden_2 = new System.Windows.Forms.Label();
            this.giden2 = new System.Windows.Forms.Label();
            this.giden_1 = new System.Windows.Forms.Label();
            this.giden1 = new System.Windows.Forms.Label();
            this.gelen_2 = new System.Windows.Forms.Label();
            this.gelen2 = new System.Windows.Forms.Label();
            this.gelen_1 = new System.Windows.Forms.Label();
            this.gelen1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grafikGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPortKapat = new System.Windows.Forms.Button();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblBaud = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnVericiSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVericiConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSerialPortReceive = new System.Windows.Forms.ComboBox();
            this.cmbReceiveStopBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbReceiveParityBits = new System.Windows.Forms.ComboBox();
            this.cmbReceiveDatabits = new System.Windows.Forms.ComboBox();
            this.cmbReceiveBaudrate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btnVericiKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // hud
            // 
            this.hud.Airspeed = 100F;
            this.hud.Altitude = 500F;
            this.hud.Heading = 0F;
            this.hud.Location = new System.Drawing.Point(12, 19);
            this.hud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hud.Name = "hud";
            this.hud.Pitch = 0F;
            this.hud.Roll = 0F;
            this.hud.Size = new System.Drawing.Size(391, 382);
            this.hud.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.hud);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 401);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "hud ekranı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 426);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(456, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sayac_,
            this.Altitude,
            this.roket_gps_irtifa,
            this.roket_enlem,
            this.roket_boylam,
            this.gorev_yuku_gps_irtifa,
            this.gorev_yuku_enlem,
            this.gorev_yuku_boylam,
            this.kademe_irtifa,
            this.kademe_enlem,
            this.kademe_boylam,
            this.Roll_Angle,
            this.Pitch_Angle,
            this.Yaw_Angle,
            this.Acceleration_X,
            this.Acceleration_Y,
            this.Acceleration_Z,
            this.aci,
            this.durum,
            this.crc,
            this.zaman_sn});
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(894, 123);
            this.dataGridView2.TabIndex = 5;
            // 
            // sayac_
            // 
            this.sayac_.HeaderText = "Sayaç";
            this.sayac_.MinimumWidth = 6;
            this.sayac_.Name = "sayac_";
            this.sayac_.Width = 125;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "İrtifa [m]";
            this.Altitude.MinimumWidth = 6;
            this.Altitude.Name = "Altitude";
            this.Altitude.Width = 125;
            // 
            // roket_gps_irtifa
            // 
            this.roket_gps_irtifa.HeaderText = "Roket GPS İrtifa [m]";
            this.roket_gps_irtifa.MinimumWidth = 6;
            this.roket_gps_irtifa.Name = "roket_gps_irtifa";
            this.roket_gps_irtifa.Width = 125;
            // 
            // roket_enlem
            // 
            this.roket_enlem.HeaderText = "Roket Enlem";
            this.roket_enlem.MinimumWidth = 6;
            this.roket_enlem.Name = "roket_enlem";
            this.roket_enlem.Width = 125;
            // 
            // roket_boylam
            // 
            this.roket_boylam.HeaderText = "Roket Boylam";
            this.roket_boylam.MinimumWidth = 6;
            this.roket_boylam.Name = "roket_boylam";
            this.roket_boylam.Width = 125;
            // 
            // gorev_yuku_gps_irtifa
            // 
            this.gorev_yuku_gps_irtifa.HeaderText = "Görev Yükü GPS İrtifa [m]";
            this.gorev_yuku_gps_irtifa.MinimumWidth = 6;
            this.gorev_yuku_gps_irtifa.Name = "gorev_yuku_gps_irtifa";
            this.gorev_yuku_gps_irtifa.Width = 125;
            // 
            // gorev_yuku_enlem
            // 
            this.gorev_yuku_enlem.HeaderText = "Görev Yükü Enlem ";
            this.gorev_yuku_enlem.MinimumWidth = 6;
            this.gorev_yuku_enlem.Name = "gorev_yuku_enlem";
            this.gorev_yuku_enlem.Width = 125;
            // 
            // gorev_yuku_boylam
            // 
            this.gorev_yuku_boylam.HeaderText = "Görev Yükü Boylam";
            this.gorev_yuku_boylam.MinimumWidth = 6;
            this.gorev_yuku_boylam.Name = "gorev_yuku_boylam";
            this.gorev_yuku_boylam.Width = 125;
            // 
            // kademe_irtifa
            // 
            this.kademe_irtifa.HeaderText = "Kademe İrtifa [m]";
            this.kademe_irtifa.MinimumWidth = 6;
            this.kademe_irtifa.Name = "kademe_irtifa";
            this.kademe_irtifa.Width = 125;
            // 
            // kademe_enlem
            // 
            this.kademe_enlem.HeaderText = "Kademe Enlem";
            this.kademe_enlem.MinimumWidth = 6;
            this.kademe_enlem.Name = "kademe_enlem";
            this.kademe_enlem.Width = 125;
            // 
            // kademe_boylam
            // 
            this.kademe_boylam.HeaderText = "Kademe Boylam";
            this.kademe_boylam.MinimumWidth = 6;
            this.kademe_boylam.Name = "kademe_boylam";
            this.kademe_boylam.Width = 125;
            // 
            // Roll_Angle
            // 
            this.Roll_Angle.HeaderText = "Jiroskop X [°]";
            this.Roll_Angle.MinimumWidth = 6;
            this.Roll_Angle.Name = "Roll_Angle";
            this.Roll_Angle.Width = 125;
            // 
            // Pitch_Angle
            // 
            this.Pitch_Angle.HeaderText = "Jiroskop Y [°]";
            this.Pitch_Angle.MinimumWidth = 6;
            this.Pitch_Angle.Name = "Pitch_Angle";
            this.Pitch_Angle.Width = 125;
            // 
            // Yaw_Angle
            // 
            this.Yaw_Angle.HeaderText = "Jiroskop Z [°]";
            this.Yaw_Angle.MinimumWidth = 6;
            this.Yaw_Angle.Name = "Yaw_Angle";
            this.Yaw_Angle.Width = 125;
            // 
            // Acceleration_X
            // 
            this.Acceleration_X.HeaderText = "İvme X [m/s^2]";
            this.Acceleration_X.MinimumWidth = 6;
            this.Acceleration_X.Name = "Acceleration_X";
            this.Acceleration_X.Width = 125;
            // 
            // Acceleration_Y
            // 
            this.Acceleration_Y.HeaderText = "İvme Y [m/s^2]";
            this.Acceleration_Y.MinimumWidth = 6;
            this.Acceleration_Y.Name = "Acceleration_Y";
            this.Acceleration_Y.Width = 125;
            // 
            // Acceleration_Z
            // 
            this.Acceleration_Z.HeaderText = "İvme Z [m/s^2]";
            this.Acceleration_Z.MinimumWidth = 6;
            this.Acceleration_Z.Name = "Acceleration_Z";
            this.Acceleration_Z.Width = 125;
            // 
            // aci
            // 
            this.aci.HeaderText = "Açı [°]";
            this.aci.MinimumWidth = 6;
            this.aci.Name = "aci";
            this.aci.Width = 125;
            // 
            // durum
            // 
            this.durum.HeaderText = "Durum";
            this.durum.MinimumWidth = 6;
            this.durum.Name = "durum";
            this.durum.Width = 125;
            // 
            // crc
            // 
            this.crc.HeaderText = "CRC";
            this.crc.MinimumWidth = 6;
            this.crc.Name = "crc";
            this.crc.Width = 125;
            // 
            // zaman_sn
            // 
            this.zaman_sn.HeaderText = "Zaman (s)";
            this.zaman_sn.MinimumWidth = 6;
            this.zaman_sn.Name = "zaman_sn";
            this.zaman_sn.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // veriEnlemRoket
            // 
            this.veriEnlemRoket.AutoSize = true;
            this.veriEnlemRoket.Location = new System.Drawing.Point(142, 176);
            this.veriEnlemRoket.Name = "veriEnlemRoket";
            this.veriEnlemRoket.Size = new System.Drawing.Size(80, 16);
            this.veriEnlemRoket.TabIndex = 7;
            this.veriEnlemRoket.Text = "enlemRoket";
            // 
            // veriRoketBoylam
            // 
            this.veriRoketBoylam.AutoSize = true;
            this.veriRoketBoylam.Location = new System.Drawing.Point(142, 214);
            this.veriRoketBoylam.Name = "veriRoketBoylam";
            this.veriRoketBoylam.Size = new System.Drawing.Size(83, 16);
            this.veriRoketBoylam.TabIndex = 8;
            this.veriRoketBoylam.Text = "roketBoylam";
            // 
            // veriIrtifaPayload
            // 
            this.veriIrtifaPayload.AutoSize = true;
            this.veriIrtifaPayload.Location = new System.Drawing.Point(144, 252);
            this.veriIrtifaPayload.Name = "veriIrtifaPayload";
            this.veriIrtifaPayload.Size = new System.Drawing.Size(82, 16);
            this.veriIrtifaPayload.TabIndex = 9;
            this.veriIrtifaPayload.Text = "irtifaPayload";
            // 
            // labelTakimID
            // 
            this.labelTakimID.AutoSize = true;
            this.labelTakimID.Location = new System.Drawing.Point(6, 24);
            this.labelTakimID.Name = "labelTakimID";
            this.labelTakimID.Size = new System.Drawing.Size(64, 16);
            this.labelTakimID.TabIndex = 10;
            this.labelTakimID.Text = "Takım ID:";
            // 
            // labelSayac
            // 
            this.labelSayac.AutoSize = true;
            this.labelSayac.Location = new System.Drawing.Point(6, 62);
            this.labelSayac.Name = "labelSayac";
            this.labelSayac.Size = new System.Drawing.Size(49, 16);
            this.labelSayac.TabIndex = 11;
            this.labelSayac.Text = "Sayac:";
            // 
            // labelIrtifa
            // 
            this.labelIrtifa.AutoSize = true;
            this.labelIrtifa.Location = new System.Drawing.Point(6, 100);
            this.labelIrtifa.Name = "labelIrtifa";
            this.labelIrtifa.Size = new System.Drawing.Size(34, 16);
            this.labelIrtifa.TabIndex = 12;
            this.labelIrtifa.Text = "İrtifa:";
            // 
            // labelRoketGPSIrtifa
            // 
            this.labelRoketGPSIrtifa.AutoSize = true;
            this.labelRoketGPSIrtifa.Location = new System.Drawing.Point(6, 138);
            this.labelRoketGPSIrtifa.Name = "labelRoketGPSIrtifa";
            this.labelRoketGPSIrtifa.Size = new System.Drawing.Size(104, 16);
            this.labelRoketGPSIrtifa.TabIndex = 13;
            this.labelRoketGPSIrtifa.Text = "Roket GPS İrtifa:";
            // 
            // labelRoketEnlem
            // 
            this.labelRoketEnlem.AutoSize = true;
            this.labelRoketEnlem.Location = new System.Drawing.Point(6, 176);
            this.labelRoketEnlem.Name = "labelRoketEnlem";
            this.labelRoketEnlem.Size = new System.Drawing.Size(87, 16);
            this.labelRoketEnlem.TabIndex = 14;
            this.labelRoketEnlem.Text = "Roket Enlem:";
            // 
            // labelRoketBoylam
            // 
            this.labelRoketBoylam.AutoSize = true;
            this.labelRoketBoylam.Location = new System.Drawing.Point(6, 214);
            this.labelRoketBoylam.Name = "labelRoketBoylam";
            this.labelRoketBoylam.Size = new System.Drawing.Size(95, 16);
            this.labelRoketBoylam.TabIndex = 15;
            this.labelRoketBoylam.Text = "Roket Boylam:";
            // 
            // labelGorevYukuGPSIrtifa
            // 
            this.labelGorevYukuGPSIrtifa.AutoSize = true;
            this.labelGorevYukuGPSIrtifa.Location = new System.Drawing.Point(6, 252);
            this.labelGorevYukuGPSIrtifa.Name = "labelGorevYukuGPSIrtifa";
            this.labelGorevYukuGPSIrtifa.Size = new System.Drawing.Size(138, 16);
            this.labelGorevYukuGPSIrtifa.TabIndex = 16;
            this.labelGorevYukuGPSIrtifa.Text = "Görev Yükü GPS İrtifa:";
            // 
            // labelGorevYukuEnlem
            // 
            this.labelGorevYukuEnlem.AutoSize = true;
            this.labelGorevYukuEnlem.Location = new System.Drawing.Point(6, 290);
            this.labelGorevYukuEnlem.Name = "labelGorevYukuEnlem";
            this.labelGorevYukuEnlem.Size = new System.Drawing.Size(121, 16);
            this.labelGorevYukuEnlem.TabIndex = 17;
            this.labelGorevYukuEnlem.Text = "Görev Yükü Enlem:";
            // 
            // labelGorevYukuBoylam
            // 
            this.labelGorevYukuBoylam.AutoSize = true;
            this.labelGorevYukuBoylam.Location = new System.Drawing.Point(6, 328);
            this.labelGorevYukuBoylam.Name = "labelGorevYukuBoylam";
            this.labelGorevYukuBoylam.Size = new System.Drawing.Size(132, 16);
            this.labelGorevYukuBoylam.TabIndex = 18;
            this.labelGorevYukuBoylam.Text = "Görev Yükü Boylam: ";
            // 
            // veriID
            // 
            this.veriID.AutoSize = true;
            this.veriID.Location = new System.Drawing.Point(142, 24);
            this.veriID.Name = "veriID";
            this.veriID.Size = new System.Drawing.Size(20, 16);
            this.veriID.TabIndex = 19;
            this.veriID.Text = "ID";
            // 
            // veriSayac
            // 
            this.veriSayac.AutoSize = true;
            this.veriSayac.Location = new System.Drawing.Point(142, 62);
            this.veriSayac.Name = "veriSayac";
            this.veriSayac.Size = new System.Drawing.Size(44, 16);
            this.veriSayac.TabIndex = 20;
            this.veriSayac.Text = "sayac";
            // 
            // veriIrtifa
            // 
            this.veriIrtifa.AutoSize = true;
            this.veriIrtifa.Location = new System.Drawing.Point(142, 100);
            this.veriIrtifa.Name = "veriIrtifa";
            this.veriIrtifa.Size = new System.Drawing.Size(31, 16);
            this.veriIrtifa.TabIndex = 21;
            this.veriIrtifa.Text = "irtifa";
            // 
            // veriIrtifaGPSRoket
            // 
            this.veriIrtifaGPSRoket.AutoSize = true;
            this.veriIrtifaGPSRoket.Location = new System.Drawing.Point(142, 138);
            this.veriIrtifaGPSRoket.Name = "veriIrtifaGPSRoket";
            this.veriIrtifaGPSRoket.Size = new System.Drawing.Size(95, 16);
            this.veriIrtifaGPSRoket.TabIndex = 22;
            this.veriIrtifaGPSRoket.Text = "irtifaGPSRoket";
            // 
            // veriEnlemPayload
            // 
            this.veriEnlemPayload.AutoSize = true;
            this.veriEnlemPayload.Location = new System.Drawing.Point(142, 290);
            this.veriEnlemPayload.Name = "veriEnlemPayload";
            this.veriEnlemPayload.Size = new System.Drawing.Size(95, 16);
            this.veriEnlemPayload.TabIndex = 23;
            this.veriEnlemPayload.Text = "enlemPayload";
            // 
            // veriBoylamPayload
            // 
            this.veriBoylamPayload.AutoSize = true;
            this.veriBoylamPayload.Location = new System.Drawing.Point(144, 328);
            this.veriBoylamPayload.Name = "veriBoylamPayload";
            this.veriBoylamPayload.Size = new System.Drawing.Size(103, 16);
            this.veriBoylamPayload.TabIndex = 24;
            this.veriBoylamPayload.Text = "boylamPayload";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.veriKademeBoylam);
            this.groupBox2.Controls.Add(this.labelKademeBoylam);
            this.groupBox2.Controls.Add(this.veriKademeEnlem);
            this.groupBox2.Controls.Add(this.labelKademeEnlem);
            this.groupBox2.Controls.Add(this.veriKademeIrtifa);
            this.groupBox2.Controls.Add(this.labelKademeIrtifa);
            this.groupBox2.Controls.Add(this.veriZaman);
            this.groupBox2.Controls.Add(this.labelZaman);
            this.groupBox2.Controls.Add(this.veriCrc);
            this.groupBox2.Controls.Add(this.veriDurum);
            this.groupBox2.Controls.Add(this.veriAcc_x);
            this.groupBox2.Controls.Add(this.veriYaw);
            this.groupBox2.Controls.Add(this.veriPitch);
            this.groupBox2.Controls.Add(this.veriRoll);
            this.groupBox2.Controls.Add(this.veriAngle);
            this.groupBox2.Controls.Add(this.veriAcc_z);
            this.groupBox2.Controls.Add(this.veriAcc_y);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.btnDurdur);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.btnBaslat);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.veriBoylamPayload);
            this.groupBox2.Controls.Add(this.veriEnlemPayload);
            this.groupBox2.Controls.Add(this.veriIrtifaGPSRoket);
            this.groupBox2.Controls.Add(this.veriIrtifa);
            this.groupBox2.Controls.Add(this.veriSayac);
            this.groupBox2.Controls.Add(this.veriID);
            this.groupBox2.Controls.Add(this.labelGorevYukuBoylam);
            this.groupBox2.Controls.Add(this.labelGorevYukuEnlem);
            this.groupBox2.Controls.Add(this.labelGorevYukuGPSIrtifa);
            this.groupBox2.Controls.Add(this.labelRoketBoylam);
            this.groupBox2.Controls.Add(this.labelRoketEnlem);
            this.groupBox2.Controls.Add(this.labelRoketGPSIrtifa);
            this.groupBox2.Controls.Add(this.labelIrtifa);
            this.groupBox2.Controls.Add(this.labelSayac);
            this.groupBox2.Controls.Add(this.labelTakimID);
            this.groupBox2.Controls.Add(this.veriIrtifaPayload);
            this.groupBox2.Controls.Add(this.veriRoketBoylam);
            this.groupBox2.Controls.Add(this.veriEnlemRoket);
            this.groupBox2.Location = new System.Drawing.Point(433, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 437);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alıcı Test";
            // 
            // veriKademeBoylam
            // 
            this.veriKademeBoylam.AutoSize = true;
            this.veriKademeBoylam.Location = new System.Drawing.Point(378, 88);
            this.veriKademeBoylam.Name = "veriKademeBoylam";
            this.veriKademeBoylam.Size = new System.Drawing.Size(103, 16);
            this.veriKademeBoylam.TabIndex = 50;
            this.veriKademeBoylam.Text = "kademeBoylam";
            // 
            // labelKademeBoylam
            // 
            this.labelKademeBoylam.AutoSize = true;
            this.labelKademeBoylam.Location = new System.Drawing.Point(253, 88);
            this.labelKademeBoylam.Name = "labelKademeBoylam";
            this.labelKademeBoylam.Size = new System.Drawing.Size(110, 16);
            this.labelKademeBoylam.TabIndex = 49;
            this.labelKademeBoylam.Text = "Kademe Boylam:";
            // 
            // veriKademeEnlem
            // 
            this.veriKademeEnlem.AutoSize = true;
            this.veriKademeEnlem.Location = new System.Drawing.Point(378, 56);
            this.veriKademeEnlem.Name = "veriKademeEnlem";
            this.veriKademeEnlem.Size = new System.Drawing.Size(95, 16);
            this.veriKademeEnlem.TabIndex = 48;
            this.veriKademeEnlem.Text = "kademeEnlem";
            // 
            // labelKademeEnlem
            // 
            this.labelKademeEnlem.AutoSize = true;
            this.labelKademeEnlem.Location = new System.Drawing.Point(253, 56);
            this.labelKademeEnlem.Name = "labelKademeEnlem";
            this.labelKademeEnlem.Size = new System.Drawing.Size(102, 16);
            this.labelKademeEnlem.TabIndex = 47;
            this.labelKademeEnlem.Text = "Kademe Enlem:";
            // 
            // veriKademeIrtifa
            // 
            this.veriKademeIrtifa.AutoSize = true;
            this.veriKademeIrtifa.Location = new System.Drawing.Point(378, 24);
            this.veriKademeIrtifa.Name = "veriKademeIrtifa";
            this.veriKademeIrtifa.Size = new System.Drawing.Size(82, 16);
            this.veriKademeIrtifa.TabIndex = 46;
            this.veriKademeIrtifa.Text = "irtifaKademe";
            // 
            // labelKademeIrtifa
            // 
            this.labelKademeIrtifa.AutoSize = true;
            this.labelKademeIrtifa.Location = new System.Drawing.Point(253, 24);
            this.labelKademeIrtifa.Name = "labelKademeIrtifa";
            this.labelKademeIrtifa.Size = new System.Drawing.Size(119, 16);
            this.labelKademeIrtifa.TabIndex = 45;
            this.labelKademeIrtifa.Text = "Kademe GPS İrtifa:";
            // 
            // veriZaman
            // 
            this.veriZaman.AutoSize = true;
            this.veriZaman.Location = new System.Drawing.Point(144, 364);
            this.veriZaman.Name = "veriZaman";
            this.veriZaman.Size = new System.Drawing.Size(47, 16);
            this.veriZaman.TabIndex = 44;
            this.veriZaman.Text = "zaman";
            // 
            // labelZaman
            // 
            this.labelZaman.AutoSize = true;
            this.labelZaman.Location = new System.Drawing.Point(14, 364);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(49, 16);
            this.labelZaman.TabIndex = 43;
            this.labelZaman.Text = "Zaman";
            // 
            // veriCrc
            // 
            this.veriCrc.AutoSize = true;
            this.veriCrc.Location = new System.Drawing.Point(336, 376);
            this.veriCrc.Name = "veriCrc";
            this.veriCrc.Size = new System.Drawing.Size(25, 16);
            this.veriCrc.TabIndex = 42;
            this.veriCrc.Text = "crc";
            // 
            // veriDurum
            // 
            this.veriDurum.AutoSize = true;
            this.veriDurum.Location = new System.Drawing.Point(334, 344);
            this.veriDurum.Name = "veriDurum";
            this.veriDurum.Size = new System.Drawing.Size(44, 16);
            this.veriDurum.TabIndex = 41;
            this.veriDurum.Text = "durum";
            // 
            // veriAcc_x
            // 
            this.veriAcc_x.AutoSize = true;
            this.veriAcc_x.Location = new System.Drawing.Point(334, 216);
            this.veriAcc_x.Name = "veriAcc_x";
            this.veriAcc_x.Size = new System.Drawing.Size(42, 16);
            this.veriAcc_x.TabIndex = 40;
            this.veriAcc_x.Text = "acc_x";
            // 
            // veriYaw
            // 
            this.veriYaw.AutoSize = true;
            this.veriYaw.Location = new System.Drawing.Point(334, 184);
            this.veriYaw.Name = "veriYaw";
            this.veriYaw.Size = new System.Drawing.Size(31, 16);
            this.veriYaw.TabIndex = 39;
            this.veriYaw.Text = "yaw";
            // 
            // veriPitch
            // 
            this.veriPitch.AutoSize = true;
            this.veriPitch.Location = new System.Drawing.Point(334, 152);
            this.veriPitch.Name = "veriPitch";
            this.veriPitch.Size = new System.Drawing.Size(35, 16);
            this.veriPitch.TabIndex = 38;
            this.veriPitch.Text = "pitch";
            // 
            // veriRoll
            // 
            this.veriRoll.AutoSize = true;
            this.veriRoll.Location = new System.Drawing.Point(334, 120);
            this.veriRoll.Name = "veriRoll";
            this.veriRoll.Size = new System.Drawing.Size(25, 16);
            this.veriRoll.TabIndex = 37;
            this.veriRoll.Text = "roll";
            // 
            // veriAngle
            // 
            this.veriAngle.AutoSize = true;
            this.veriAngle.Location = new System.Drawing.Point(336, 312);
            this.veriAngle.Name = "veriAngle";
            this.veriAngle.Size = new System.Drawing.Size(41, 16);
            this.veriAngle.TabIndex = 36;
            this.veriAngle.Text = "angle";
            // 
            // veriAcc_z
            // 
            this.veriAcc_z.AutoSize = true;
            this.veriAcc_z.Location = new System.Drawing.Point(334, 280);
            this.veriAcc_z.Name = "veriAcc_z";
            this.veriAcc_z.Size = new System.Drawing.Size(42, 16);
            this.veriAcc_z.TabIndex = 35;
            this.veriAcc_z.Text = "acc_z";
            // 
            // veriAcc_y
            // 
            this.veriAcc_y.AutoSize = true;
            this.veriAcc_y.Location = new System.Drawing.Point(334, 248);
            this.veriAcc_y.Name = "veriAcc_y";
            this.veriAcc_y.Size = new System.Drawing.Size(43, 16);
            this.veriAcc_y.TabIndex = 34;
            this.veriAcc_y.Text = "acc_y";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(253, 376);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "CRC:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(253, 344);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 32;
            this.label20.Text = "Durum:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(253, 312);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 16);
            this.label21.TabIndex = 31;
            this.label21.Text = "Açı:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(253, 280);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 16);
            this.label22.TabIndex = 30;
            this.label22.Text = "İvme Z:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(253, 248);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 16);
            this.label23.TabIndex = 29;
            this.label23.Text = "İvme Y:";
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(80, 391);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(65, 23);
            this.btnDurdur.TabIndex = 29;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(253, 216);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 16);
            this.label24.TabIndex = 28;
            this.label24.Text = "İvme X:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(253, 184);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 16);
            this.label25.TabIndex = 27;
            this.label25.Text = "Jiroskop Z:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(253, 152);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 16);
            this.label26.TabIndex = 26;
            this.label26.Text = "Jiroskop Y:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(253, 120);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 16);
            this.label27.TabIndex = 25;
            this.label27.Text = "Jiroskop X:";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(6, 391);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(68, 23);
            this.btnBaslat.TabIndex = 28;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(151, 391);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 30;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.giden_2);
            this.groupBox3.Controls.Add(this.giden2);
            this.groupBox3.Controls.Add(this.giden_1);
            this.groupBox3.Controls.Add(this.giden1);
            this.groupBox3.Controls.Add(this.gelen_2);
            this.groupBox3.Controls.Add(this.gelen2);
            this.groupBox3.Controls.Add(this.gelen_1);
            this.groupBox3.Controls.Add(this.gelen1);
            this.groupBox3.Location = new System.Drawing.Point(12, 636);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 171);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terminal";
            // 
            // giden_2
            // 
            this.giden_2.AutoSize = true;
            this.giden_2.Location = new System.Drawing.Point(102, 132);
            this.giden_2.Name = "giden_2";
            this.giden_2.Size = new System.Drawing.Size(106, 16);
            this.giden_2.TabIndex = 50;
            this.giden_2.Text = "Giden İlk 39 Byte";
            // 
            // giden2
            // 
            this.giden2.AutoSize = true;
            this.giden2.Location = new System.Drawing.Point(19, 132);
            this.giden2.Name = "giden2";
            this.giden2.Size = new System.Drawing.Size(62, 16);
            this.giden2.TabIndex = 49;
            this.giden2.Text = "GİDEN 2:";
            // 
            // giden_1
            // 
            this.giden_1.AutoSize = true;
            this.giden_1.Location = new System.Drawing.Point(102, 100);
            this.giden_1.Name = "giden_1";
            this.giden_1.Size = new System.Drawing.Size(106, 16);
            this.giden_1.TabIndex = 48;
            this.giden_1.Text = "Giden İlk 39 Byte";
            // 
            // giden1
            // 
            this.giden1.AutoSize = true;
            this.giden1.Location = new System.Drawing.Point(19, 100);
            this.giden1.Name = "giden1";
            this.giden1.Size = new System.Drawing.Size(62, 16);
            this.giden1.TabIndex = 47;
            this.giden1.Text = "GİDEN 1:";
            // 
            // gelen_2
            // 
            this.gelen_2.AutoSize = true;
            this.gelen_2.Location = new System.Drawing.Point(102, 65);
            this.gelen_2.Name = "gelen_2";
            this.gelen_2.Size = new System.Drawing.Size(117, 16);
            this.gelen_2.TabIndex = 46;
            this.gelen_2.Text = "Gelen Son 39 Byte";
            // 
            // gelen2
            // 
            this.gelen2.AutoSize = true;
            this.gelen2.Location = new System.Drawing.Point(19, 65);
            this.gelen2.Name = "gelen2";
            this.gelen2.Size = new System.Drawing.Size(65, 16);
            this.gelen2.TabIndex = 45;
            this.gelen2.Text = "GELEN 2:";
            // 
            // gelen_1
            // 
            this.gelen_1.AutoSize = true;
            this.gelen_1.Location = new System.Drawing.Point(102, 36);
            this.gelen_1.Name = "gelen_1";
            this.gelen_1.Size = new System.Drawing.Size(106, 16);
            this.gelen_1.TabIndex = 44;
            this.gelen_1.Text = "Gelen İlk 39 Byte";
            // 
            // gelen1
            // 
            this.gelen1.AutoSize = true;
            this.gelen1.Location = new System.Drawing.Point(19, 36);
            this.gelen1.Name = "gelen1";
            this.gelen1.Size = new System.Drawing.Size(65, 16);
            this.gelen1.TabIndex = 43;
            this.gelen1.Text = "GELEN 1:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(12, 473);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(906, 157);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Veri Kaydı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafikGoster,
            this.hakkındaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grafikGoster
            // 
            this.grafikGoster.Name = "grafikGoster";
            this.grafikGoster.Size = new System.Drawing.Size(103, 24);
            this.grafikGoster.Text = "İrtifa Grafiği";
            // 
            // hakkındaToolStripMenuItem1
            // 
            this.hakkındaToolStripMenuItem1.Name = "hakkındaToolStripMenuItem1";
            this.hakkındaToolStripMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.hakkındaToolStripMenuItem1.Text = "Hakkında";
            this.hakkındaToolStripMenuItem1.Click += new System.EventHandler(this.hakkındaToolStripMenuItem1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPortKapat);
            this.groupBox5.Controls.Add(this.lblSerialPort);
            this.groupBox5.Controls.Add(this.btnConnect);
            this.groupBox5.Controls.Add(this.lblStopBits);
            this.groupBox5.Controls.Add(this.cmbSerialPort);
            this.groupBox5.Controls.Add(this.cmbStopBits);
            this.groupBox5.Controls.Add(this.lblParity);
            this.groupBox5.Controls.Add(this.cmbParity);
            this.groupBox5.Controls.Add(this.cmbDataBits);
            this.groupBox5.Controls.Add(this.cmbBaud);
            this.groupBox5.Controls.Add(this.lblDataBits);
            this.groupBox5.Controls.Add(this.lblBaud);
            this.groupBox5.Location = new System.Drawing.Point(930, 538);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 269);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alıcı Ayarları";
            // 
            // btnPortKapat
            // 
            this.btnPortKapat.Location = new System.Drawing.Point(161, 222);
            this.btnPortKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnPortKapat.Name = "btnPortKapat";
            this.btnPortKapat.Size = new System.Drawing.Size(79, 28);
            this.btnPortKapat.TabIndex = 38;
            this.btnPortKapat.Text = "Port Kapat";
            this.btnPortKapat.UseVisualStyleBackColor = true;
            this.btnPortKapat.Click += new System.EventHandler(this.btnPortKapat_Click);
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(7, 64);
            this.lblSerialPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(69, 16);
            this.lblSerialPort.TabIndex = 36;
            this.lblSerialPort.Text = "Serial Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(80, 223);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 28);
            this.btnConnect.TabIndex = 37;
            this.btnConnect.Text = "Port Aç";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(7, 197);
            this.lblStopBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(57, 16);
            this.lblStopBits.TabIndex = 35;
            this.lblStopBits.Text = "StopBits";
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(80, 57);
            this.cmbSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(160, 24);
            this.cmbSerialPort.TabIndex = 36;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cmbStopBits.Location = new System.Drawing.Point(80, 190);
            this.cmbStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(160, 24);
            this.cmbStopBits.TabIndex = 35;
            this.cmbStopBits.Text = "One";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(7, 164);
            this.lblParity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(41, 16);
            this.lblParity.TabIndex = 34;
            this.lblParity.Text = "Parity";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Ode",
            "Even",
            "Mark",
            "Space"});
            this.cmbParity.Location = new System.Drawing.Point(80, 156);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(160, 24);
            this.cmbParity.TabIndex = 34;
            this.cmbParity.Text = "None";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(80, 123);
            this.cmbDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(160, 24);
            this.cmbDataBits.TabIndex = 33;
            this.cmbDataBits.Text = "8";
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(80, 90);
            this.cmbBaud.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(160, 24);
            this.cmbBaud.TabIndex = 32;
            this.cmbBaud.Text = "19200";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(7, 131);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(61, 16);
            this.lblDataBits.TabIndex = 33;
            this.lblDataBits.Text = "Data Bits";
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(7, 98);
            this.lblBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(39, 16);
            this.lblBaud.TabIndex = 32;
            this.lblBaud.Text = "Baud";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnVericiKapat);
            this.groupBox6.Controls.Add(this.btnVericiSend);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.btnVericiConnect);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.cmbSerialPortReceive);
            this.groupBox6.Controls.Add(this.cmbReceiveStopBits);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.cmbReceiveParityBits);
            this.groupBox6.Controls.Add(this.cmbReceiveDatabits);
            this.groupBox6.Controls.Add(this.cmbReceiveBaudrate);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(1193, 538);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(264, 269);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Verici Ayarları";
            // 
            // btnVericiSend
            // 
            this.btnVericiSend.Enabled = false;
            this.btnVericiSend.Location = new System.Drawing.Point(178, 230);
            this.btnVericiSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnVericiSend.Name = "btnVericiSend";
            this.btnVericiSend.Size = new System.Drawing.Size(79, 28);
            this.btnVericiSend.TabIndex = 38;
            this.btnVericiSend.Text = "Gönder";
            this.btnVericiSend.UseVisualStyleBackColor = true;
            this.btnVericiSend.Click += new System.EventHandler(this.btnVericiSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Serial Port";
            // 
            // btnVericiConnect
            // 
            this.btnVericiConnect.Location = new System.Drawing.Point(10, 230);
            this.btnVericiConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnVericiConnect.Name = "btnVericiConnect";
            this.btnVericiConnect.Size = new System.Drawing.Size(79, 28);
            this.btnVericiConnect.TabIndex = 37;
            this.btnVericiConnect.Text = "Port Aç";
            this.btnVericiConnect.UseVisualStyleBackColor = true;
            this.btnVericiConnect.Click += new System.EventHandler(this.btnVericiConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "StopBits";
            // 
            // cmbSerialPortReceive
            // 
            this.cmbSerialPortReceive.FormattingEnabled = true;
            this.cmbSerialPortReceive.Location = new System.Drawing.Point(80, 57);
            this.cmbSerialPortReceive.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSerialPortReceive.Name = "cmbSerialPortReceive";
            this.cmbSerialPortReceive.Size = new System.Drawing.Size(160, 24);
            this.cmbSerialPortReceive.TabIndex = 36;
            // 
            // cmbReceiveStopBits
            // 
            this.cmbReceiveStopBits.FormattingEnabled = true;
            this.cmbReceiveStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cmbReceiveStopBits.Location = new System.Drawing.Point(80, 190);
            this.cmbReceiveStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReceiveStopBits.Name = "cmbReceiveStopBits";
            this.cmbReceiveStopBits.Size = new System.Drawing.Size(160, 24);
            this.cmbReceiveStopBits.TabIndex = 35;
            this.cmbReceiveStopBits.Text = "One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Parity";
            // 
            // cmbReceiveParityBits
            // 
            this.cmbReceiveParityBits.FormattingEnabled = true;
            this.cmbReceiveParityBits.Items.AddRange(new object[] {
            "None",
            "Ode",
            "Even",
            "Mark",
            "Space"});
            this.cmbReceiveParityBits.Location = new System.Drawing.Point(80, 156);
            this.cmbReceiveParityBits.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReceiveParityBits.Name = "cmbReceiveParityBits";
            this.cmbReceiveParityBits.Size = new System.Drawing.Size(160, 24);
            this.cmbReceiveParityBits.TabIndex = 34;
            this.cmbReceiveParityBits.Text = "None";
            // 
            // cmbReceiveDatabits
            // 
            this.cmbReceiveDatabits.FormattingEnabled = true;
            this.cmbReceiveDatabits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cmbReceiveDatabits.Location = new System.Drawing.Point(80, 123);
            this.cmbReceiveDatabits.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReceiveDatabits.Name = "cmbReceiveDatabits";
            this.cmbReceiveDatabits.Size = new System.Drawing.Size(160, 24);
            this.cmbReceiveDatabits.TabIndex = 33;
            this.cmbReceiveDatabits.Text = "8";
            // 
            // cmbReceiveBaudrate
            // 
            this.cmbReceiveBaudrate.FormattingEnabled = true;
            this.cmbReceiveBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbReceiveBaudrate.Location = new System.Drawing.Point(80, 90);
            this.cmbReceiveBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReceiveBaudrate.Name = "cmbReceiveBaudrate";
            this.cmbReceiveBaudrate.Size = new System.Drawing.Size(160, 24);
            this.cmbReceiveBaudrate.TabIndex = 32;
            this.cmbReceiveBaudrate.Text = "19200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Data Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Baud";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.label42);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.label45);
            this.groupBox7.Controls.Add(this.label46);
            this.groupBox7.Controls.Add(this.label47);
            this.groupBox7.Controls.Add(this.label48);
            this.groupBox7.Controls.Add(this.label49);
            this.groupBox7.Controls.Add(this.label50);
            this.groupBox7.Controls.Add(this.label51);
            this.groupBox7.Controls.Add(this.label52);
            this.groupBox7.Controls.Add(this.label53);
            this.groupBox7.Controls.Add(this.label54);
            this.groupBox7.Controls.Add(this.label55);
            this.groupBox7.Controls.Add(this.label56);
            this.groupBox7.Controls.Add(this.label57);
            this.groupBox7.Controls.Add(this.label58);
            this.groupBox7.Location = new System.Drawing.Point(940, 31);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(485, 437);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Verici Test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "kademeBoylam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Kademe Boylam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "kademeEnlem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Kademe Enlem:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "irtifaKademe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Kademe GPS İrtifa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "zaman";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "Zaman";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(336, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 16);
            this.label14.TabIndex = 42;
            this.label14.Text = "crc";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(334, 344);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "durum";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(334, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "acc_x";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(334, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 16);
            this.label17.TabIndex = 39;
            this.label17.Text = "yaw";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(334, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 16);
            this.label18.TabIndex = 38;
            this.label18.Text = "pitch";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(334, 120);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 16);
            this.label28.TabIndex = 37;
            this.label28.Text = "roll";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(336, 312);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 16);
            this.label29.TabIndex = 36;
            this.label29.Text = "angle";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(334, 280);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 16);
            this.label30.TabIndex = 35;
            this.label30.Text = "acc_z";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(334, 248);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(43, 16);
            this.label31.TabIndex = 34;
            this.label31.Text = "acc_y";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(253, 376);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(38, 16);
            this.label32.TabIndex = 33;
            this.label32.Text = "CRC:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(253, 344);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(49, 16);
            this.label33.TabIndex = 32;
            this.label33.Text = "Durum:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(253, 312);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(29, 16);
            this.label34.TabIndex = 31;
            this.label34.Text = "Açı:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(253, 280);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 16);
            this.label35.TabIndex = 30;
            this.label35.Text = "İvme Z:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(253, 248);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(51, 16);
            this.label36.TabIndex = 29;
            this.label36.Text = "İvme Y:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(253, 216);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(50, 16);
            this.label37.TabIndex = 28;
            this.label37.Text = "İvme X:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(253, 184);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 16);
            this.label38.TabIndex = 27;
            this.label38.Text = "Jiroskop Z:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(253, 152);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(74, 16);
            this.label39.TabIndex = 26;
            this.label39.Text = "Jiroskop Y:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(253, 120);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(73, 16);
            this.label40.TabIndex = 25;
            this.label40.Text = "Jiroskop X:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(144, 328);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(103, 16);
            this.label41.TabIndex = 24;
            this.label41.Text = "boylamPayload";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(142, 290);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(95, 16);
            this.label42.TabIndex = 23;
            this.label42.Text = "enlemPayload";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(142, 138);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(95, 16);
            this.label43.TabIndex = 22;
            this.label43.Text = "irtifaGPSRoket";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(142, 100);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(31, 16);
            this.label44.TabIndex = 21;
            this.label44.Text = "irtifa";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(142, 62);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(44, 16);
            this.label45.TabIndex = 20;
            this.label45.Text = "sayac";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(142, 24);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(20, 16);
            this.label46.TabIndex = 19;
            this.label46.Text = "ID";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 328);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(132, 16);
            this.label47.TabIndex = 18;
            this.label47.Text = "Görev Yükü Boylam: ";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 290);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(121, 16);
            this.label48.TabIndex = 17;
            this.label48.Text = "Görev Yükü Enlem:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 252);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(138, 16);
            this.label49.TabIndex = 16;
            this.label49.Text = "Görev Yükü GPS İrtifa:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 214);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(95, 16);
            this.label50.TabIndex = 15;
            this.label50.Text = "Roket Boylam:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 176);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(87, 16);
            this.label51.TabIndex = 14;
            this.label51.Text = "Roket Enlem:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 138);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(104, 16);
            this.label52.TabIndex = 13;
            this.label52.Text = "Roket GPS İrtifa:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(6, 100);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(34, 16);
            this.label53.TabIndex = 12;
            this.label53.Text = "İrtifa:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 62);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(49, 16);
            this.label54.TabIndex = 11;
            this.label54.Text = "Sayac:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 24);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(64, 16);
            this.label55.TabIndex = 10;
            this.label55.Text = "Takım ID:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(144, 252);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(82, 16);
            this.label56.TabIndex = 9;
            this.label56.Text = "irtifaPayload";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(142, 214);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(83, 16);
            this.label57.TabIndex = 8;
            this.label57.Text = "roketBoylam";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(142, 176);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(80, 16);
            this.label58.TabIndex = 7;
            this.label58.Text = "enlemRoket";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(1449, 61);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(439, 370);
            this.zedGraphControl1.TabIndex = 51;
            // 
            // btnVericiKapat
            // 
            this.btnVericiKapat.Enabled = false;
            this.btnVericiKapat.Location = new System.Drawing.Point(97, 230);
            this.btnVericiKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnVericiKapat.Name = "btnVericiKapat";
            this.btnVericiKapat.Size = new System.Drawing.Size(79, 28);
            this.btnVericiKapat.TabIndex = 39;
            this.btnVericiKapat.Text = "Port Kapat";
            this.btnVericiKapat.UseVisualStyleBackColor = true;
            this.btnVericiKapat.Click += new System.EventHandler(this.btnVericiKapat_Click);
            // 
            // Arayuz
            // 
            this.ClientSize = new System.Drawing.Size(1924, 836);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Arayuz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private Simple_HUD.HUD_Basic hud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label veriEnlemRoket;
        private System.Windows.Forms.Label veriRoketBoylam;
        private System.Windows.Forms.Label veriIrtifaPayload;
        private System.Windows.Forms.Label labelTakimID;
        private System.Windows.Forms.Label labelSayac;
        private System.Windows.Forms.Label labelIrtifa;
        private System.Windows.Forms.Label labelRoketGPSIrtifa;
        private System.Windows.Forms.Label labelRoketEnlem;
        private System.Windows.Forms.Label labelRoketBoylam;
        private System.Windows.Forms.Label labelGorevYukuGPSIrtifa;
        private System.Windows.Forms.Label labelGorevYukuEnlem;
        private System.Windows.Forms.Label labelGorevYukuBoylam;
        private System.Windows.Forms.Label veriID;
        private System.Windows.Forms.Label veriSayac;
        private System.Windows.Forms.Label veriIrtifa;
        private System.Windows.Forms.Label veriIrtifaGPSRoket;
        private System.Windows.Forms.Label veriEnlemPayload;
        private System.Windows.Forms.Label veriBoylamPayload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem grafikGoster;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.Label veriCrc;
        private System.Windows.Forms.Label veriDurum;
        private System.Windows.Forms.Label veriAcc_x;
        private System.Windows.Forms.Label veriYaw;
        private System.Windows.Forms.Label veriPitch;
        private System.Windows.Forms.Label veriAngle;
        private System.Windows.Forms.Label veriAcc_z;
        private System.Windows.Forms.Label veriAcc_y;
        private System.Windows.Forms.Label veriZaman;
        private System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.Label veriRoll;
        private System.Windows.Forms.Label giden_2;
        private System.Windows.Forms.Label giden2;
        private System.Windows.Forms.Label giden_1;
        private System.Windows.Forms.Label giden1;
        private System.Windows.Forms.Label gelen_2;
        private System.Windows.Forms.Label gelen2;
        private System.Windows.Forms.Label gelen_1;
        private System.Windows.Forms.Label gelen1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnVericiSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVericiConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSerialPortReceive;
        private System.Windows.Forms.ComboBox cmbReceiveStopBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbReceiveParityBits;
        private System.Windows.Forms.ComboBox cmbReceiveDatabits;
        private System.Windows.Forms.ComboBox cmbReceiveBaudrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPortKapat;
        private System.Windows.Forms.Label veriKademeIrtifa;
        private System.Windows.Forms.Label labelKademeIrtifa;
        private System.Windows.Forms.Label veriKademeEnlem;
        private System.Windows.Forms.Label labelKademeEnlem;
        private System.Windows.Forms.Label veriKademeBoylam;
        private System.Windows.Forms.Label labelKademeBoylam;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayac_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn roket_gps_irtifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn roket_enlem;
        private System.Windows.Forms.DataGridViewTextBoxColumn roket_boylam;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorev_yuku_gps_irtifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorev_yuku_enlem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorev_yuku_boylam;
        private System.Windows.Forms.DataGridViewTextBoxColumn kademe_irtifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kademe_enlem;
        private System.Windows.Forms.DataGridViewTextBoxColumn kademe_boylam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll_Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitch_Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yaw_Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceleration_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceleration_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceleration_Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn aci;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn crc;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaman_sn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btnVericiKapat;
    }
}

