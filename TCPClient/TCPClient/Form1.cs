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
using System.IO;

namespace TCPClient
{


    public partial class Form1 : Form
    {

        private TcpClient _tcpClient;
        private NetworkStream _networkStream;
        private string serverIP = "127.0.0.1"; // 서버 IP
        private int serverPort = 5000; 

        private int panTiltX = 0;
        private int panTiltY = 0;
        private double zoom = 0.0;
        private int volume = 10;

        public Form1()
        {
            InitializeComponent();
            UpdateConnectionStatus(false);
            UpdateLabels();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _tcpClient = new TcpClient(serverIP, serverPort);
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




        private void UpdateConnectionStatus(bool isConnected)
        {
            lblConnectionStatus.Text = isConnected ? "연결 상태: 연결됨" : "연결 상태: 끊어짐";
            lblConnectionStatus.ForeColor = isConnected ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        private void UpdateLabels()
        {
            lblPanTilt.Text = $"팬틸트: ({panTiltX}, {panTiltY})";
            lblZoom.Text = $"줌: {zoom}";
            lblVolume.Text = $"볼룸: {volume}";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panTiltY++;
            SendCommand(1,1);
        }


        

        private void btnDown_Click(object sender, EventArgs e)
        {
            panTiltY--;
            SendCommand(1, -1);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            panTiltX--;
            SendCommand(1, -2);

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            panTiltX++;
            SendCommand(1, 2);
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (zoom < 1.0) zoom += 0.1;
            SendCommand(2, 1);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (zoom > 0.0) zoom -= 0.1;
            SendCommand(2, -1);
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            volume += 1; 
            SendCommand(3, 1);
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            volume -= 1;
            SendCommand(3, -1);
        }

        private void SendCommand(byte command, int action)
        {
            if (_networkStream == null || _tcpClient == null || !_tcpClient.Connected )
            {
                MessageBox.Show("서버에 연결되지 않았습니다.");
                return;
            }

            try
            {
                byte[] packet = { command, (byte)action, 0xFF };
                _networkStream.Write(packet, 0, packet.Length);

                byte[] buffer = new byte[256];
                int bytesRead = _networkStream.Read(buffer, 0, buffer.Length);
                string response= Encoding.UTF8.GetString(buffer, 0, bytesRead);

                MessageBox.Show("서버 응답: " + response);
            }

            catch (Exception ex)
            {
                MessageBox.Show("데이터 전송 실패: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_networkStream != null) _networkStream.Close();
            if (_tcpClient != null) _tcpClient.Close();
        }

    }
}
