
namespace Cam_Zoom
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_camurl = new System.Windows.Forms.Label();
            this.textbox_camurl = new System.Windows.Forms.TextBox();
            this.btn_compose = new System.Windows.Forms.Button();
            this.btn_con = new System.Windows.Forms.Button();
            this.btn_dcon = new System.Windows.Forms.Button();
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.btn_zoomplus = new System.Windows.Forms.Button();
            this.btn_zoommin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_camurl
            // 
            this.lbl_camurl.AutoSize = true;
            this.lbl_camurl.Location = new System.Drawing.Point(12, 16);
            this.lbl_camurl.Name = "lbl_camurl";
            this.lbl_camurl.Size = new System.Drawing.Size(68, 13);
            this.lbl_camurl.TabIndex = 0;
            this.lbl_camurl.Text = "Camera URL";
            // 
            // textbox_camurl
            // 
            this.textbox_camurl.Location = new System.Drawing.Point(97, 14);
            this.textbox_camurl.Name = "textbox_camurl";
            this.textbox_camurl.Size = new System.Drawing.Size(221, 20);
            this.textbox_camurl.TabIndex = 1;
            // 
            // btn_compose
            // 
            this.btn_compose.Location = new System.Drawing.Point(340, 10);
            this.btn_compose.Name = "btn_compose";
            this.btn_compose.Size = new System.Drawing.Size(80, 26);
            this.btn_compose.TabIndex = 2;
            this.btn_compose.Text = "Compose";
            this.btn_compose.UseVisualStyleBackColor = true;
            this.btn_compose.Click += new System.EventHandler(this.btn_compose_Click);
            // 
            // btn_con
            // 
            this.btn_con.Enabled = false;
            this.btn_con.Location = new System.Drawing.Point(97, 42);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(73, 26);
            this.btn_con.TabIndex = 4;
            this.btn_con.Text = "Connect";
            this.btn_con.UseVisualStyleBackColor = true;
            this.btn_con.Click += new System.EventHandler(this.btn_con_Click);
            // 
            // btn_dcon
            // 
            this.btn_dcon.AutoSize = true;
            this.btn_dcon.Enabled = false;
            this.btn_dcon.Location = new System.Drawing.Point(245, 42);
            this.btn_dcon.Name = "btn_dcon";
            this.btn_dcon.Size = new System.Drawing.Size(73, 26);
            this.btn_dcon.TabIndex = 5;
            this.btn_dcon.Text = "Disconnect";
            this.btn_dcon.UseVisualStyleBackColor = true;
            this.btn_dcon.Click += new System.EventHandler(this.btn_dcon_Click);
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF1.ContextMenuEnabled = true;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(12, 87);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(408, 306);
            this.videoViewerWF1.TabIndex = 6;
            this.videoViewerWF1.Text = "videoViewerWF1";
            // 
            // btn_zoomplus
            // 
            this.btn_zoomplus.Location = new System.Drawing.Point(8, 26);
            this.btn_zoomplus.Name = "btn_zoomplus";
            this.btn_zoomplus.Size = new System.Drawing.Size(73, 44);
            this.btn_zoomplus.TabIndex = 9;
            this.btn_zoomplus.Text = "zoom +";
            this.btn_zoomplus.UseVisualStyleBackColor = true;
            this.btn_zoomplus.Click += new System.EventHandler(this.btn_zoomIn_Click);
            // 
            // btn_zoommin
            // 
            this.btn_zoommin.Location = new System.Drawing.Point(204, 26);
            this.btn_zoommin.Name = "btn_zoommin";
            this.btn_zoommin.Size = new System.Drawing.Size(75, 44);
            this.btn_zoommin.TabIndex = 11;
            this.btn_zoommin.Text = "zoom -";
            this.btn_zoommin.UseVisualStyleBackColor = true;
            this.btn_zoommin.Click += new System.EventHandler(this.btn_zoomOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_zoommin);
            this.groupBox1.Controls.Add(this.btn_zoomplus);
            this.groupBox1.Location = new System.Drawing.Point(431, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 306);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.videoViewerWF1);
            this.Controls.Add(this.btn_dcon);
            this.Controls.Add(this.btn_con);
            this.Controls.Add(this.btn_compose);
            this.Controls.Add(this.textbox_camurl);
            this.Controls.Add(this.lbl_camurl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Navigation";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_camurl;
        private System.Windows.Forms.TextBox textbox_camurl;
        private System.Windows.Forms.Button btn_compose;
        private System.Windows.Forms.Button btn_con;
        private System.Windows.Forms.Button btn_dcon;
        private Ozeki.Media.VideoViewerWF videoViewerWF1;
        private System.Windows.Forms.Button btn_zoomplus;
        private System.Windows.Forms.Button btn_zoommin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}