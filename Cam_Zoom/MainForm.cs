using Ozeki.Camera;
using Ozeki.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cam_Zoom
{
    public partial class MainForm : Form
    {
        private OzekiCamera _camera;
        private DrawingImageProvider _Provider;
        private MediaConnector _connector;
        private CameraURLBuilderWF _myCameraUrlBuilder;
        private Zoom zoom;

        public MainForm()
        {
            InitializeComponent();
            _connector = new MediaConnector();
            _Provider = new DrawingImageProvider();
            videoViewerWF1.SetImageProvider(_Provider);
            _myCameraUrlBuilder = new CameraURLBuilderWF();
            zoom = new Zoom();
        }

        private void btn_compose_Click(object sender, EventArgs e)
        {
            var result = _myCameraUrlBuilder.ShowDialog();
            if (result != DialogResult.OK) return;
            textbox_camurl.Text = _myCameraUrlBuilder.CameraURL;
            btn_con.Enabled = true;
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            if (_camera != null)
            {
                _camera.CameraStateChanged -= _camera_CameraStateChanged;
                _camera.Disconnect();
                _connector.Disconnect(_camera.VideoChannel, _Provider);
                _camera.Dispose();
                _camera = null;
            }

            btn_con.Enabled = false;
            _camera = new OzekiCamera(_myCameraUrlBuilder.CameraURL);
            _camera.CameraStateChanged += _camera_CameraStateChanged;
            _connector.Connect(_camera.VideoChannel, zoom);
            _connector.Connect(zoom, _Provider);
            _camera.Start();
            videoViewerWF1.Start();
            zoom.Start();
        }

        private void btn_dcon_Click(object sender, EventArgs e)
        {
            if (_camera == null) return;
            _camera.Disconnect();
            _connector.Disconnect(_camera.VideoChannel, _Provider);
            _camera = null;
        }

        void _camera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeThread(() =>
            {
                if (e.State == CameraState.Streaming)
                    Streaming();
                if (e.State == CameraState.Disconnected)
                    Disconnect();
            });
        }

        private void Disconnect()
        {
            btn_con.Enabled = true;
            btn_dcon.Enabled = false;
        }

        private void Streaming()
        {
            btn_dcon.Enabled = true;
        }

        void InvokeThread(Action action)
        {
            BeginInvoke(action);
        }

        private void btn_zoomIn_Click(object sender, EventArgs e)
        {
            zoom.In();
        }

        private void btn_zoomOut_Click(object sender, EventArgs e)
        {
            zoom.Out();
        }

        private void btn_zoomDefault_Click(object sender, EventArgs e)
        {
            zoom.Default();
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            zoom.StopMovement();
        }

       

      
    }
}
