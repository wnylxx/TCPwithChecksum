using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TCPClient
{


    public partial class Form1 : Form
    {

        private TcpClient _tcpClient;
        private NetworkStream _networkStream;

        private int panTiltX = 0;
        private int panTiltY = 0;
        private float zoom = 0.0f;
        private int volume = 10;

        public Form1()
        {
            InitializeComponent();
            UpdateConnectionStatus(false);
        }

        private void UpdateConnectionStatus(bool isConnected)
        {
            lblConnectionStatus.Text = isConnected ? "연결 상태: 연결됨" : "연결 상태: 끊어짐";
            lblConnectionStatus.ForeColor = isConnected ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _tcpClient = new TcpClient("127.0.0.1", 5000);
                _networkStream = _tcpClient.GetStream();
                UpdateConnectionStatus(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버 연결 실패: " + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (_networkStream != null)
            {
                _networkStream.Close();
                _tcpClient.Close();
            }
            UpdateConnectionStatus(false);
        }

        private void UpdateLabels()
        {
            lblPanTilt.Text = $"팬틸트: ({panTiltX}, {panTiltY})";
            lblZoom.Text = $"줌: {zoom}";
            lblVolume.Text = $"볼룸: {volume}";
        }



    }
}
