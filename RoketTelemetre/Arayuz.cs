using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using ZedGraph;


namespace RoketTelemetre
{
    public partial class Arayuz : Form
    {

        int satir = 0;
        int kontrol = 0;
        int kontrol_gonder = 0;
        float[] irtifa = new float[10000];
        float[] zaman = new float[10000];
        float hiz_x, hiz_y, hiz_z;
        float hiz;
        string[] ports = SerialPort.GetPortNames();
        byte[] olusturalacak_paket = new byte[78];
        byte[] irtifa_byte;
        byte[] roketGPSirtifa_byte;
        byte[] roketEnlem_byte;
        byte[] roketBoylam_byte;
        byte[] gorevYukuGPSirtifa_byte;
        byte[] gorevYukuEnlem_byte;
        byte[] gorevYukuBoylam_byte;
        byte[] kademeGPSirtifa_byte;
        byte[] kademeEnlem_byte;
        byte[] kademeBoylam_byte;
        byte[] jiroskopX_byte;
        byte[] jiroskopY_byte;
        byte[] jiroskopZ_byte;
        byte[] ivmeX_byte;
        byte[] ivmeY_byte;
        byte[] ivmeZ_byte;
        byte[] aci_byte;
        byte durum_byte;


        //A;zaman_194593[0];takim_ID_0.00[1];sayac_0.00[2];irtifa_3000.00[3];roketgpsirtifa_3500.00[4];
        //roketenlem_33.00[5];roketboylam_44.00[6];GorevYukuGPSIrtifa_2000.00[7];GorevYukuEnlem_36.00[8];
        //GorevYukuBoylam_35.00[9];jiroskop_X_1.00[10];jiroskop_Y_2.00[11];jiroskop_Z_3.00[12];ivme_x_0.10[13];
        //ivme_y_0.20[14];ivme_z_0.30[15];aci_0.40[16];durum_1[17];crc_0.00[18];B

        SerialPort myPort;
        SerialPort senderPort;
        GraphPane grafik;
        LineItem egri1;
        PointPairList veri = new PointPairList();

        public Arayuz()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            hud.Airspeed = 0;

        }
        byte check_sum_hesapla()
        {
            int check_sum = 0;
            for (int i = 4; i < 75; i++)
            {
                check_sum += olusturalacak_paket[i];
            }
            return (byte)(check_sum % 256);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kontrol == 1)
            {
                try
                {


                    string str = myPort.ReadExisting();  //ReadLine()
                    string alinanMetin = str;
                    string[] degerler = alinanMetin.Split(';');

                    olusturalacak_paket[0] = 0xFF; // Sabit
                    olusturalacak_paket[1] = 0xFF; // Sabit
                    olusturalacak_paket[2] = 0x54; // Sabit
                    olusturalacak_paket[3] = 0x52; // Sabit
                    olusturalacak_paket[4] = 0;   // Takim ID = 0
                    olusturalacak_paket[5] = 0; // Sayac degeri = 0


                    irtifa_byte = BitConverter.GetBytes(float.Parse(degerler[4], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[6] = irtifa_byte[0];
                    olusturalacak_paket[7] = irtifa_byte[1];
                    olusturalacak_paket[8] = irtifa_byte[2];
                    olusturalacak_paket[9] = irtifa_byte[3];


                    roketGPSirtifa_byte = BitConverter.GetBytes(float.Parse(degerler[5], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[10] = roketGPSirtifa_byte[0];
                    olusturalacak_paket[11] = roketGPSirtifa_byte[1];
                    olusturalacak_paket[12] = roketGPSirtifa_byte[2];
                    olusturalacak_paket[13] = roketGPSirtifa_byte[3];


                    roketEnlem_byte = BitConverter.GetBytes(float.Parse(degerler[6], System.Globalization.CultureInfo.InvariantCulture));
                    //System.Console.WriteLine(float.Parse(degerler[6], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[14] = roketEnlem_byte[0];
                    olusturalacak_paket[15] = roketEnlem_byte[1];
                    olusturalacak_paket[16] = roketEnlem_byte[2];
                    olusturalacak_paket[17] = roketEnlem_byte[3];


                    roketBoylam_byte = BitConverter.GetBytes(float.Parse(degerler[7], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[18] = roketBoylam_byte[0];
                    olusturalacak_paket[19] = roketBoylam_byte[1];
                    olusturalacak_paket[20] = roketBoylam_byte[2];
                    olusturalacak_paket[21] = roketBoylam_byte[3];



                    gorevYukuGPSirtifa_byte = BitConverter.GetBytes(float.Parse(degerler[8], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[22] = gorevYukuGPSirtifa_byte[0];
                    olusturalacak_paket[23] = gorevYukuGPSirtifa_byte[1];
                    olusturalacak_paket[24] = gorevYukuGPSirtifa_byte[2];
                    olusturalacak_paket[25] = gorevYukuGPSirtifa_byte[3];


                    gorevYukuEnlem_byte = BitConverter.GetBytes(float.Parse(degerler[9], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[26] = gorevYukuEnlem_byte[0];
                    olusturalacak_paket[27] = gorevYukuEnlem_byte[1];
                    olusturalacak_paket[28] = gorevYukuEnlem_byte[2];
                    olusturalacak_paket[29] = gorevYukuEnlem_byte[3];


                    gorevYukuBoylam_byte = BitConverter.GetBytes(float.Parse(degerler[10], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[30] = gorevYukuBoylam_byte[0];
                    olusturalacak_paket[31] = gorevYukuBoylam_byte[1];
                    olusturalacak_paket[32] = gorevYukuBoylam_byte[2];
                    olusturalacak_paket[33] = gorevYukuBoylam_byte[3];



                    kademeGPSirtifa_byte = BitConverter.GetBytes(float.Parse(degerler[11], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[34] = kademeGPSirtifa_byte[0];
                    olusturalacak_paket[35] = kademeGPSirtifa_byte[1];
                    olusturalacak_paket[36] = kademeGPSirtifa_byte[2];
                    olusturalacak_paket[37] = kademeGPSirtifa_byte[3];


                    kademeEnlem_byte = BitConverter.GetBytes(float.Parse(degerler[12], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[38] = kademeEnlem_byte[0];
                    olusturalacak_paket[39] = kademeEnlem_byte[1];
                    olusturalacak_paket[40] = kademeEnlem_byte[2];
                    olusturalacak_paket[41] = kademeEnlem_byte[3];


                    kademeBoylam_byte = BitConverter.GetBytes(float.Parse(degerler[13], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[42] = kademeBoylam_byte[0];
                    olusturalacak_paket[43] = kademeBoylam_byte[1];
                    olusturalacak_paket[44] = kademeBoylam_byte[2];
                    olusturalacak_paket[45] = kademeBoylam_byte[3];

                    jiroskopX_byte = BitConverter.GetBytes(float.Parse(degerler[14], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[46] = jiroskopX_byte[0];
                    olusturalacak_paket[47] = jiroskopX_byte[1];
                    olusturalacak_paket[48] = jiroskopX_byte[2];
                    olusturalacak_paket[49] = jiroskopX_byte[3];

                    jiroskopY_byte = BitConverter.GetBytes(float.Parse(degerler[15], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[50] = jiroskopY_byte[0];
                    olusturalacak_paket[51] = jiroskopY_byte[1];
                    olusturalacak_paket[52] = jiroskopY_byte[2];
                    olusturalacak_paket[53] = jiroskopY_byte[3];


                    jiroskopZ_byte = BitConverter.GetBytes(float.Parse(degerler[16], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[54] = jiroskopZ_byte[0];
                    olusturalacak_paket[55] = jiroskopZ_byte[1];
                    olusturalacak_paket[56] = jiroskopZ_byte[2];
                    olusturalacak_paket[57] = jiroskopZ_byte[3];


                    ivmeX_byte = BitConverter.GetBytes(float.Parse(degerler[17], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[58] = ivmeX_byte[0];
                    olusturalacak_paket[59] = ivmeX_byte[1];
                    olusturalacak_paket[60] = ivmeX_byte[2];
                    olusturalacak_paket[61] = ivmeX_byte[3];

                    ivmeY_byte = BitConverter.GetBytes(float.Parse(degerler[18], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[62] = ivmeY_byte[0];
                    olusturalacak_paket[63] = ivmeY_byte[1];
                    olusturalacak_paket[64] = ivmeY_byte[2];
                    olusturalacak_paket[65] = ivmeY_byte[3];


                    ivmeZ_byte = BitConverter.GetBytes(float.Parse(degerler[19], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[66] = ivmeZ_byte[0];
                    olusturalacak_paket[67] = ivmeZ_byte[1];
                    olusturalacak_paket[68] = ivmeZ_byte[2];
                    olusturalacak_paket[69] = ivmeZ_byte[3];

                    aci_byte = BitConverter.GetBytes(float.Parse(degerler[20], System.Globalization.CultureInfo.InvariantCulture));
                    olusturalacak_paket[70] = aci_byte[0];
                    olusturalacak_paket[71] = aci_byte[1];
                    olusturalacak_paket[72] = aci_byte[2];
                    olusturalacak_paket[73] = aci_byte[3];



                    olusturalacak_paket[74] = Convert.ToByte(Convert.ToInt32(Convert.ToSingle(degerler[21]))); //durum değeri gelecek
                    //System.Console.WriteLine(olusturalacak_paket[74]);
                    olusturalacak_paket[75] = check_sum_hesapla();
                    olusturalacak_paket[76] = 0x0D;
                    olusturalacak_paket[77] = 0x0A;


                    byte[] parca_1;
                    byte[] parca_2;
                    parca_1 = olusturalacak_paket.Take(39).ToArray();
                    parca_2 = olusturalacak_paket.Skip(39).Take(78).ToArray();
                    string s1 = BitConverter.ToString(parca_1);
                    //System.Console.WriteLine(s1);
                    string s2 = BitConverter.ToString(parca_2);
                    //System.Console.WriteLine(s2);

                    gelen_1.Text = s1;
                    gelen_2.Text = s2;


                    if (kontrol_gonder == 1)
                    {
                        senderPort.Write(s1);
                    };



                    veriZaman.Text = Convert.ToString(Convert.ToDouble(degerler[1]) / timer1.Interval);
                    veriSayac.Text = Convert.ToString(satir);
                    veriIrtifa.Text = degerler[4];
                    veriIrtifaGPSRoket.Text = degerler[5];
                    veriEnlemRoket.Text = degerler[6];
                    veriRoketBoylam.Text = degerler[7];
                    veriIrtifaPayload.Text = degerler[8];
                    veriEnlemPayload.Text = degerler[9];
                    veriBoylamPayload.Text = degerler[10];
                    veriKademeIrtifa.Text = degerler[11];
                    veriKademeEnlem.Text = degerler[12];
                    veriKademeBoylam.Text = degerler[13];
                    veriRoll.Text = degerler[14];
                    veriPitch.Text = degerler[15];
                    veriYaw.Text = degerler[16];
                    veriAcc_x.Text = degerler[17];
                    veriAcc_y.Text = degerler[18];
                    veriAcc_z.Text = degerler[19];
                    veriAngle.Text = degerler[20];
                    veriDurum.Text = degerler[21];
                    veriCrc.Text = Convert.ToString(check_sum_hesapla());

                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[satir].Cells[0].Value = Convert.ToString(satir);
                    dataGridView2.Rows[satir].Cells[1].Value = degerler[4];
                    dataGridView2.Rows[satir].Cells[2].Value = degerler[5];
                    dataGridView2.Rows[satir].Cells[3].Value = degerler[6];
                    dataGridView2.Rows[satir].Cells[4].Value = degerler[7];
                    dataGridView2.Rows[satir].Cells[5].Value = degerler[8];
                    dataGridView2.Rows[satir].Cells[6].Value = degerler[9];
                    dataGridView2.Rows[satir].Cells[7].Value = degerler[10];
                    dataGridView2.Rows[satir].Cells[8].Value = degerler[11];
                    dataGridView2.Rows[satir].Cells[9].Value = degerler[12];
                    dataGridView2.Rows[satir].Cells[10].Value = degerler[13];
                    dataGridView2.Rows[satir].Cells[11].Value = degerler[14];
                    dataGridView2.Rows[satir].Cells[12].Value = degerler[15];
                    dataGridView2.Rows[satir].Cells[13].Value = degerler[16];
                    dataGridView2.Rows[satir].Cells[14].Value = degerler[17];
                    dataGridView2.Rows[satir].Cells[15].Value = degerler[18];
                    dataGridView2.Rows[satir].Cells[16].Value = degerler[19];
                    dataGridView2.Rows[satir].Cells[17].Value = degerler[20];
                    dataGridView2.Rows[satir].Cells[18].Value = degerler[21];
                    dataGridView2.Rows[satir].Cells[19].Value = Convert.ToString(check_sum_hesapla());
                    dataGridView2.Rows[satir].Cells[20].Value = Convert.ToString(Convert.ToDouble(degerler[1]) / timer1.Interval);

                    hiz_x += (float)timer1.Interval / (float)1000 * float.Parse(degerler[17], System.Globalization.CultureInfo.InvariantCulture);
                    hiz_y += (float)timer1.Interval / (float)1000 * float.Parse(degerler[18], System.Globalization.CultureInfo.InvariantCulture);
                    hiz_z += (float)timer1.Interval / (float)1000 * float.Parse(degerler[19], System.Globalization.CultureInfo.InvariantCulture);
                    hiz = (float)Math.Sqrt(Math.Pow(hiz_x, 2) + Math.Pow(hiz_y, 2) + Math.Pow(hiz_z, 2));

                    hud.Roll = float.Parse(degerler[14], System.Globalization.CultureInfo.InvariantCulture);
                    hud.Pitch = float.Parse(degerler[15], System.Globalization.CultureInfo.InvariantCulture);
                    hud.Heading = float.Parse(degerler[16], System.Globalization.CultureInfo.InvariantCulture);
                    hud.Altitude = float.Parse(degerler[4], System.Globalization.CultureInfo.InvariantCulture);
                    hud.Airspeed = hiz;

                    zedGraphControl1.AxisChange();
                    zedGraphControl1.Invalidate();
                    zedGraphControl1.Refresh();


                    //senderPort.Write(parca_1,0, parca_1.Length);
                    //senderPort.Write(parca_2, 0, parca_2.Length);

                    //giden_1.Text = senderPort.ReadExisting();

                    satir++;
                }
                catch (Exception)
                {

                    return;
                }

            }

        }
        private void GrafikHazirla()

        {

            grafik = zedGraphControl1.GraphPane;
            grafik.Title = "irtifa – Zaman Grafiği ";
            grafik.XAxis.Title = " t(s) ";
            grafik.YAxis.Title = "metre";
            grafik.YAxis.Min = 0;
            grafik.YAxis.Max = 3000;
            egri1 = grafik.AddCurve(null, veri, Color.Red, SymbolType.None);
            egri1.Line.Width = 3;
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kontrol = 1;
        }
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            kontrol = 0;
        }
        private void btnTemizle_click(object sender, EventArgs e)
        {
            grafik.CurveList.Clear();
            veri.Clear();

        }
        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hakkinda aboutbox = new Hakkinda();
            aboutbox.Show();
        }

        private void btnPortKapat_Click(object sender, EventArgs e)
        {
            myPort.Close();
            btnConnect.Enabled = true;
        }

        private void btnVericiConnect_Click(object sender, EventArgs e)
        {
            try
            {
                senderPort = new SerialPort();
                senderPort.PortName = cmbSerialPortReceive.Text;
                senderPort.BaudRate = Convert.ToInt32(cmbReceiveBaudrate.Text);
                senderPort.DataBits = Convert.ToInt32(cmbReceiveDatabits.Text);
                senderPort.Parity = (Parity)Enum.Parse(typeof(Parity), cmbReceiveParityBits.Text);
                senderPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbReceiveStopBits.Text);
                senderPort.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (senderPort.IsOpen)
            {
                btnVericiConnect.Enabled = false;
                btnVericiKapat.Enabled = true;
                btnVericiSend.Enabled = true;
            }
        }

        private void btnVericiSend_Click(object sender, EventArgs e)
        {

            try
            {
                kontrol_gonder = 1;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Gönderilecek Port Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (senderPort.IsOpen == false)
            {
                
                MessageBox.Show("Gönderilecek Port Seçilmedi");
            }
        }

        private void btnVericiKapat_Click(object sender, EventArgs e)
        {
            senderPort.Close();
            kontrol_gonder = 0;
            if (senderPort.IsOpen == false)
            {
                btnVericiKapat.Enabled = false;
                btnVericiConnect.Enabled = true;
                btnVericiSend.Enabled = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbSerialPort.Items.AddRange(ports);
            cmbSerialPortReceive.Items.AddRange(ports);



        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                myPort = new SerialPort();
                myPort.PortName = cmbSerialPort.Text;
                myPort.BaudRate = Convert.ToInt32(cmbBaud.Text);
                myPort.DataBits = Convert.ToInt32(cmbDataBits.Text);
                myPort.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                myPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
                myPort.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (myPort.IsOpen)
            {
                btnConnect.Enabled = false;
            }
        }
    }
}
