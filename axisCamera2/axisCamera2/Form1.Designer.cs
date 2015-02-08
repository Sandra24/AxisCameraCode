namespace axisCamera2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ipAdress = new System.Windows.Forms.TextBox();
            this.btnLiveView = new System.Windows.Forms.Button();
            this.amc = new AxAXISMEDIACONTROLLib.AxAxisMediaControl();
            this.amc2 = new AxAXISMEDIACONTROLLib.AxAxisMediaControl();
            this.ipAdress2 = new System.Windows.Forms.TextBox();
            this.btnLiveView2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amc2)).BeginInit();
            this.SuspendLayout();
            // 
            // ipAdress
            // 
            this.ipAdress.Location = new System.Drawing.Point(12, 8);
            this.ipAdress.Name = "ipAdress";
            this.ipAdress.Size = new System.Drawing.Size(111, 20);
            this.ipAdress.TabIndex = 0;
            // 
            // btnLiveView
            // 
            this.btnLiveView.Location = new System.Drawing.Point(198, 3);
            this.btnLiveView.Name = "btnLiveView";
            this.btnLiveView.Size = new System.Drawing.Size(97, 25);
            this.btnLiveView.TabIndex = 1;
            this.btnLiveView.Text = "Live View";
            this.btnLiveView.UseVisualStyleBackColor = true;
            this.btnLiveView.Click += new System.EventHandler(this.button1_Click);
            // 
            // amc
            // 
            this.amc.Enabled = true;
            this.amc.Location = new System.Drawing.Point(12, 46);
            this.amc.Name = "amc";
            this.amc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("amc.OcxState")));
            this.amc.Size = new System.Drawing.Size(415, 409);
            this.amc.TabIndex = 2;
            // 
            // amc2
            // 
            this.amc2.Enabled = true;
            this.amc2.Location = new System.Drawing.Point(458, 47);
            this.amc2.Name = "amc2";
            this.amc2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("amc2.OcxState")));
            this.amc2.Size = new System.Drawing.Size(409, 408);
            this.amc2.TabIndex = 3;
            // 
            // ipAdress2
            // 
            this.ipAdress2.Location = new System.Drawing.Point(458, 8);
            this.ipAdress2.Name = "ipAdress2";
            this.ipAdress2.Size = new System.Drawing.Size(109, 20);
            this.ipAdress2.TabIndex = 4;
            // 
            // btnLiveView2
            // 
            this.btnLiveView2.Location = new System.Drawing.Point(636, 8);
            this.btnLiveView2.Name = "btnLiveView2";
            this.btnLiveView2.Size = new System.Drawing.Size(99, 29);
            this.btnLiveView2.TabIndex = 5;
            this.btnLiveView2.Text = "Live View";
            this.btnLiveView2.UseVisualStyleBackColor = true;
            this.btnLiveView2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 475);
            this.Controls.Add(this.btnLiveView2);
            this.Controls.Add(this.ipAdress2);
            this.Controls.Add(this.amc2);
            this.Controls.Add(this.amc);
            this.Controls.Add(this.btnLiveView);
            this.Controls.Add(this.ipAdress);
            this.Name = "Form1";
            this.Text = "Camera View";
            ((System.ComponentModel.ISupportInitialize)(this.amc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipAdress;
        private System.Windows.Forms.Button btnLiveView;
        private AxAXISMEDIACONTROLLib.AxAxisMediaControl amc;
        private AxAXISMEDIACONTROLLib.AxAxisMediaControl amc2;
        private System.Windows.Forms.TextBox ipAdress2;
        private System.Windows.Forms.Button btnLiveView2;
    }
}

