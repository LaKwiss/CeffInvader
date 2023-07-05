namespace CeffInvader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PbxMain = new PictureBox();
            tmr = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PbxMain).BeginInit();
            SuspendLayout();
            // 
            // PbxMain
            // 
            PbxMain.Dock = DockStyle.Fill;
            PbxMain.Location = new Point(0, 0);
            PbxMain.Name = "PbxMain";
            PbxMain.Size = new Size(944, 501);
            PbxMain.TabIndex = 1;
            PbxMain.TabStop = false;
            PbxMain.Paint += PbxMain_Paint;
            // 
            // tmr
            // 
            tmr.Enabled = true;
            tmr.Interval = 1;
            tmr.Tick += tmr_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(PbxMain);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)PbxMain).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private PictureBox PbxMain;
        public System.Windows.Forms.Timer tmr;
    }
}