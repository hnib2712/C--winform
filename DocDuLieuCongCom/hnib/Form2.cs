using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace hnib
{
    public partial class Hnibuv : Form
    {
        SerialPort P = new SerialPort(); // Khai báo 1 Object SerialPort mới.
        public Hnibuv()
        {
            InitializeComponent();
            string[] Ports = SerialPort.GetPortNames();
            P.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            // Thêm toàn bộ các COM đã tìm được vào combox cbCom
            CboCom.Items.AddRange(Ports); // Sử dụng AddRange thay vì dùng foreach
            P.ReadTimeout = 500;
        }
        

        private void CboCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P.IsOpen)
            {
                P.Close(); // Nếu đang mở Port thì phải đóng lại
            }
            P.PortName = CboCom.SelectedItem.ToString(); // Gán PortName bằng COM đã chọn
        }

        private void BtnKetnoi_Click(object sender, EventArgs e)
        {
            try
            {
                P.BaudRate = 9600;
                P.DataBits = 8;
                P.Parity = Parity.None;
                P.StopBits = StopBits.One;
                P.Handshake = Handshake.None;
                //P.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");//stop bit
                //P.Parity = (Parity)Enum.Parse(typeof(Parity), "None");//Parity
                P.RtsEnable = true;
                P.DtrEnable = true;
                P.Open();
                LbStatus.Text = "Đang kết nối với cổng " + CboCom.SelectedItem.ToString();
                LbStatus.ForeColor = Color.Red;
                timer1.Interval = 100;
                timer1.Enabled = true;
                timer1.Start();
            }
            catch 
            {
                MessageBox.Show("Không kết nối được.", "Chúc may mắn lần sau", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNgatKN_Click(object sender, EventArgs e)
        {
            try
            {
                if (P.IsOpen)
                {
                    P.Close();
                    LbStatus.Text = "Đóng kết nối";
                }
            }
            catch
            {
            }
        }

        string str,data = "";
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //// Nếu cổng com đóng thì không làm gì
            //if (!P.IsOpen) return;
            ////biến data lưu dữ liệu có trên đường truyền
            //str = P.ReadExisting();
            //byte[] bytes = Encoding.Default.GetBytes(str);
            //data = Encoding.UTF8.GetString(bytes);
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Nếu cổng com đóng thì không làm gì
            if (!P.IsOpen) return;
            //biến data lưu dữ liệu có trên đường truyền
            str = P.ReadExisting();
            byte[] bytes = Encoding.Default.GetBytes(str);
            data = Encoding.UTF8.GetString(bytes);
            if (data != String.Empty)
            {
                TxtTL.Text = data;
            }
        }

        private void Hnibuv_Load(object sender, EventArgs e)
        {

        }
    }
}
