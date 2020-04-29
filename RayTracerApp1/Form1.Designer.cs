namespace RayTracerApp1
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
            this.picScene = new System.Windows.Forms.PictureBox();
            this.cmdAddSphere = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lbFixRadius = new System.Windows.Forms.Label();
            this.lbFixSphereX = new System.Windows.Forms.Label();
            this.lbFixSphereY = new System.Windows.Forms.Label();
            this.lbFixSphereZ = new System.Windows.Forms.Label();
            this.lbFixSphereColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmdColor = new System.Windows.Forms.Button();
            this.cmdStartRayTracing = new System.Windows.Forms.Button();
            this.cmdStopRayTracing = new System.Windows.Forms.Button();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.lbProgress = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdDeleteSphere = new System.Windows.Forms.Button();
            this.grbSphere = new System.Windows.Forms.GroupBox();
            this.cmdEditSphere = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSaveSceneSettings = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picScene)).BeginInit();
            this.grbSphere.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picScene
            // 
            this.picScene.Location = new System.Drawing.Point(4, 3);
            this.picScene.Name = "picScene";
            this.picScene.Size = new System.Drawing.Size(418, 392);
            this.picScene.TabIndex = 0;
            this.picScene.TabStop = false;
            // 
            // cmdAddSphere
            // 
            this.cmdAddSphere.Location = new System.Drawing.Point(39, 163);
            this.cmdAddSphere.Name = "cmdAddSphere";
            this.cmdAddSphere.Size = new System.Drawing.Size(130, 30);
            this.cmdAddSphere.TabIndex = 1;
            this.cmdAddSphere.Text = "Add Sphere";
            this.cmdAddSphere.UseVisualStyleBackColor = true;
            this.cmdAddSphere.Click += new System.EventHandler(this.cmdAddSphere_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(69, 23);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 2;
            this.txtRadius.Validating += new System.ComponentModel.CancelEventHandler(this.txtRadius_Validating);
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(69, 107);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 22);
            this.txtZ.TabIndex = 4;
            this.txtZ.Validating += new System.ComponentModel.CancelEventHandler(this.txtZ_Validating);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(69, 79);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 5;
            this.txtY.Validating += new System.ComponentModel.CancelEventHandler(this.txtY_Validating);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(69, 51);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 6;
            this.txtX.Validating += new System.ComponentModel.CancelEventHandler(this.txtX_Validating);
            // 
            // lbFixRadius
            // 
            this.lbFixRadius.AutoSize = true;
            this.lbFixRadius.Location = new System.Drawing.Point(11, 23);
            this.lbFixRadius.Name = "lbFixRadius";
            this.lbFixRadius.Size = new System.Drawing.Size(52, 17);
            this.lbFixRadius.TabIndex = 7;
            this.lbFixRadius.Text = "Radius";
            // 
            // lbFixSphereX
            // 
            this.lbFixSphereX.AutoSize = true;
            this.lbFixSphereX.Location = new System.Drawing.Point(42, 52);
            this.lbFixSphereX.Name = "lbFixSphereX";
            this.lbFixSphereX.Size = new System.Drawing.Size(21, 17);
            this.lbFixSphereX.TabIndex = 8;
            this.lbFixSphereX.Text = "X ";
            // 
            // lbFixSphereY
            // 
            this.lbFixSphereY.AutoSize = true;
            this.lbFixSphereY.Location = new System.Drawing.Point(42, 81);
            this.lbFixSphereY.Name = "lbFixSphereY";
            this.lbFixSphereY.Size = new System.Drawing.Size(21, 17);
            this.lbFixSphereY.TabIndex = 9;
            this.lbFixSphereY.Text = "Y ";
            // 
            // lbFixSphereZ
            // 
            this.lbFixSphereZ.AutoSize = true;
            this.lbFixSphereZ.Location = new System.Drawing.Point(44, 108);
            this.lbFixSphereZ.Name = "lbFixSphereZ";
            this.lbFixSphereZ.Size = new System.Drawing.Size(17, 17);
            this.lbFixSphereZ.TabIndex = 10;
            this.lbFixSphereZ.Text = "Z";
            // 
            // lbFixSphereColor
            // 
            this.lbFixSphereColor.AutoSize = true;
            this.lbFixSphereColor.Location = new System.Drawing.Point(20, 138);
            this.lbFixSphereColor.Name = "lbFixSphereColor";
            this.lbFixSphereColor.Size = new System.Drawing.Size(41, 17);
            this.lbFixSphereColor.TabIndex = 11;
            this.lbFixSphereColor.Text = "Color";
            // 
            // cmdColor
            // 
            this.cmdColor.Location = new System.Drawing.Point(175, 131);
            this.cmdColor.Name = "cmdColor";
            this.cmdColor.Size = new System.Drawing.Size(130, 30);
            this.cmdColor.TabIndex = 13;
            this.cmdColor.Text = "Pick Color";
            this.cmdColor.UseVisualStyleBackColor = true;
            this.cmdColor.Click += new System.EventHandler(this.cmdColor_Click);
            // 
            // cmdStartRayTracing
            // 
            this.cmdStartRayTracing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdStartRayTracing.Location = new System.Drawing.Point(7, 442);
            this.cmdStartRayTracing.Name = "cmdStartRayTracing";
            this.cmdStartRayTracing.Size = new System.Drawing.Size(130, 30);
            this.cmdStartRayTracing.TabIndex = 14;
            this.cmdStartRayTracing.Text = "Start Ray Tracing";
            this.cmdStartRayTracing.UseVisualStyleBackColor = true;
            this.cmdStartRayTracing.Click += new System.EventHandler(this.cmdStartRayTracing_Click);
            // 
            // cmdStopRayTracing
            // 
            this.cmdStopRayTracing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdStopRayTracing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdStopRayTracing.Location = new System.Drawing.Point(143, 442);
            this.cmdStopRayTracing.Name = "cmdStopRayTracing";
            this.cmdStopRayTracing.Size = new System.Drawing.Size(130, 30);
            this.cmdStopRayTracing.TabIndex = 15;
            this.cmdStopRayTracing.Text = "Stop Ray Tracing";
            this.cmdStopRayTracing.UseVisualStyleBackColor = true;
            this.cmdStopRayTracing.Click += new System.EventHandler(this.cmdStopRayTracing_Click);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(742, 428);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(46, 17);
            this.lbProgress.TabIndex = 16;
            this.lbProgress.Text = "label6";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(311, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(473, 132);
            this.listBox1.TabIndex = 17;
            // 
            // cmdDeleteSphere
            // 
            this.cmdDeleteSphere.Location = new System.Drawing.Point(654, 161);
            this.cmdDeleteSphere.Name = "cmdDeleteSphere";
            this.cmdDeleteSphere.Size = new System.Drawing.Size(130, 30);
            this.cmdDeleteSphere.TabIndex = 18;
            this.cmdDeleteSphere.Text = "Delete Sphere";
            this.cmdDeleteSphere.UseVisualStyleBackColor = true;
            this.cmdDeleteSphere.Click += new System.EventHandler(this.cmdDeleteSphere_Click);
            // 
            // grbSphere
            // 
            this.grbSphere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSphere.Controls.Add(this.txtX);
            this.grbSphere.Controls.Add(this.cmdEditSphere);
            this.grbSphere.Controls.Add(this.txtColor);
            this.grbSphere.Controls.Add(this.lbFixSphereZ);
            this.grbSphere.Controls.Add(this.cmdDeleteSphere);
            this.grbSphere.Controls.Add(this.txtRadius);
            this.grbSphere.Controls.Add(this.listBox1);
            this.grbSphere.Controls.Add(this.lbFixSphereColor);
            this.grbSphere.Controls.Add(this.cmdColor);
            this.grbSphere.Controls.Add(this.lbFixRadius);
            this.grbSphere.Controls.Add(this.txtY);
            this.grbSphere.Controls.Add(this.cmdAddSphere);
            this.grbSphere.Controls.Add(this.lbFixSphereY);
            this.grbSphere.Controls.Add(this.txtZ);
            this.grbSphere.Controls.Add(this.lbFixSphereX);
            this.grbSphere.Location = new System.Drawing.Point(499, 13);
            this.grbSphere.Name = "grbSphere";
            this.grbSphere.Size = new System.Drawing.Size(790, 211);
            this.grbSphere.TabIndex = 19;
            this.grbSphere.TabStop = false;
            this.grbSphere.Text = "Sphere";
            // 
            // cmdEditSphere
            // 
            this.cmdEditSphere.Location = new System.Drawing.Point(518, 161);
            this.cmdEditSphere.Name = "cmdEditSphere";
            this.cmdEditSphere.Size = new System.Drawing.Size(130, 30);
            this.cmdEditSphere.TabIndex = 19;
            this.cmdEditSphere.Text = "Edit Sphere";
            this.cmdEditSphere.UseVisualStyleBackColor = true;
            this.cmdEditSphere.Click += new System.EventHandler(this.cmdEditSphere_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(69, 135);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 22);
            this.txtColor.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdSaveSceneSettings);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(499, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 170);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scene Settings";
            // 
            // cmdSaveSceneSettings
            // 
            this.cmdSaveSceneSettings.Location = new System.Drawing.Point(503, 126);
            this.cmdSaveSceneSettings.Name = "cmdSaveSceneSettings";
            this.cmdSaveSceneSettings.Size = new System.Drawing.Size(130, 30);
            this.cmdSaveSceneSettings.TabIndex = 23;
            this.cmdSaveSceneSettings.Text = "Save";
            this.cmdSaveSceneSettings.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(397, 133);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Z";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(268, 134);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(139, 134);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Camera Position  X";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(397, 105);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Z";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(268, 106);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(139, 106);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Y";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(397, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Z";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(268, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Light Direction  X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Light Position   X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Canvas Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canvas   Width";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picScene);
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 358);
            this.panel1.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.cmdStopRayTracing);
            this.groupBox2.Controls.Add(this.cmdStartRayTracing);
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 491);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdClose.Location = new System.Drawing.Point(1111, 500);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(130, 30);
            this.cmdClose.TabIndex = 23;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 571);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbSphere);
            this.Controls.Add(this.lbProgress);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picScene)).EndInit();
            this.grbSphere.ResumeLayout(false);
            this.grbSphere.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picScene;
        private System.Windows.Forms.Button cmdAddSphere;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lbFixRadius;
        private System.Windows.Forms.Label lbFixSphereX;
        private System.Windows.Forms.Label lbFixSphereY;
        private System.Windows.Forms.Label lbFixSphereZ;
        private System.Windows.Forms.Label lbFixSphereColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button cmdColor;
        private System.Windows.Forms.Button cmdStartRayTracing;
        private System.Windows.Forms.Button cmdStopRayTracing;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdDeleteSphere;
        private System.Windows.Forms.GroupBox grbSphere;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button cmdEditSphere;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdSaveSceneSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdClose;
    }
}

