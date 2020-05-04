namespace RayTracerApp
{
    partial class frmMain
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
            this.cmdColorSphere = new System.Windows.Forms.Button();
            this.cmdStartRayTracing = new System.Windows.Forms.Button();
            this.cmdStopRayTracing = new System.Windows.Forms.Button();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.lstSphere = new System.Windows.Forms.ListBox();
            this.cmdDeleteSphere = new System.Windows.Forms.Button();
            this.grbSphereSettings = new System.Windows.Forms.GroupBox();
            this.cmdEditSphere = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.grbSceneSettings = new System.Windows.Forms.GroupBox();
            this.cmdSaveSceneSettings = new System.Windows.Forms.Button();
            this.txtSceneCameraZ = new System.Windows.Forms.TextBox();
            this.lbFixSceneCamerPositionZ = new System.Windows.Forms.Label();
            this.txtSceneCameraY = new System.Windows.Forms.TextBox();
            this.txtSceneCameraX = new System.Windows.Forms.TextBox();
            this.lbFixSceneCamerPositionY = new System.Windows.Forms.Label();
            this.lbFixSceneCameraPosition = new System.Windows.Forms.Label();
            this.txtSceneLightDirectionZ = new System.Windows.Forms.TextBox();
            this.lbFixLightDirectionZ = new System.Windows.Forms.Label();
            this.txtSceneLightDirectionY = new System.Windows.Forms.TextBox();
            this.txtSceneLightDirectionX = new System.Windows.Forms.TextBox();
            this.lbFixLightDirectionY = new System.Windows.Forms.Label();
            this.txtSceneLightPositionZ = new System.Windows.Forms.TextBox();
            this.lbFixSceneLigthtPositionZ = new System.Windows.Forms.Label();
            this.txtSceneLightPositionY = new System.Windows.Forms.TextBox();
            this.txtSceneLightPositionX = new System.Windows.Forms.TextBox();
            this.txtSceneCanvasHeight = new System.Windows.Forms.TextBox();
            this.txtSceneCanvasWidth = new System.Windows.Forms.TextBox();
            this.lbFixSceneLightDirection = new System.Windows.Forms.Label();
            this.lbFixSceneLigthtPositionY = new System.Windows.Forms.Label();
            this.lbFixSceneLightPosition = new System.Windows.Forms.Label();
            this.lbFixSceneCanvasHeight = new System.Windows.Forms.Label();
            this.lbFixSceneCanvasWidth = new System.Windows.Forms.Label();
            this.pnlScene = new System.Windows.Forms.Panel();
            this.grbRayTracing = new System.Windows.Forms.GroupBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdLoadSceneDefaults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picScene)).BeginInit();
            this.grbSphereSettings.SuspendLayout();
            this.grbSceneSettings.SuspendLayout();
            this.pnlScene.SuspendLayout();
            this.grbRayTracing.SuspendLayout();
            this.SuspendLayout();
            // 
            // picScene
            // 
            this.picScene.InitialImage = null;
            this.picScene.Location = new System.Drawing.Point(4, 3);
            this.picScene.Name = "picScene";
            this.picScene.Size = new System.Drawing.Size(418, 392);
            this.picScene.TabIndex = 0;
            this.picScene.TabStop = false;
            // 
            // cmdAddSphere
            // 
            this.cmdAddSphere.Location = new System.Drawing.Point(175, 167);
            this.cmdAddSphere.Name = "cmdAddSphere";
            this.cmdAddSphere.Size = new System.Drawing.Size(130, 30);
            this.cmdAddSphere.TabIndex = 19;
            this.cmdAddSphere.Text = "Add Sphere";
            this.cmdAddSphere.UseVisualStyleBackColor = true;
            this.cmdAddSphere.Click += new System.EventHandler(this.cmdAddSphere_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(69, 23);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 13;
            this.txtRadius.Validating += new System.ComponentModel.CancelEventHandler(this.txtRadius_Validating);
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(69, 107);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 22);
            this.txtZ.TabIndex = 16;
            this.txtZ.Validating += new System.ComponentModel.CancelEventHandler(this.txtZ_Validating);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(69, 79);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 15;
            this.txtY.Validating += new System.ComponentModel.CancelEventHandler(this.txtY_Validating);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(69, 51);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 14;
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
            // cmdColorSphere
            // 
            this.cmdColorSphere.Location = new System.Drawing.Point(175, 131);
            this.cmdColorSphere.Name = "cmdColorSphere";
            this.cmdColorSphere.Size = new System.Drawing.Size(130, 30);
            this.cmdColorSphere.TabIndex = 17;
            this.cmdColorSphere.Text = "Pick Color";
            this.cmdColorSphere.UseVisualStyleBackColor = true;
            this.cmdColorSphere.Click += new System.EventHandler(this.cmdColor_Click);
            // 
            // cmdStartRayTracing
            // 
            this.cmdStartRayTracing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdStartRayTracing.Location = new System.Drawing.Point(35, 443);
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
            this.cmdStopRayTracing.Location = new System.Drawing.Point(171, 443);
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
            // lstSphere
            // 
            this.lstSphere.FormattingEnabled = true;
            this.lstSphere.HorizontalScrollbar = true;
            this.lstSphere.ItemHeight = 16;
            this.lstSphere.Location = new System.Drawing.Point(311, 23);
            this.lstSphere.Name = "lstSphere";
            this.lstSphere.Size = new System.Drawing.Size(473, 132);
            this.lstSphere.TabIndex = 17;
            // 
            // cmdDeleteSphere
            // 
            this.cmdDeleteSphere.Location = new System.Drawing.Point(654, 167);
            this.cmdDeleteSphere.Name = "cmdDeleteSphere";
            this.cmdDeleteSphere.Size = new System.Drawing.Size(130, 30);
            this.cmdDeleteSphere.TabIndex = 22;
            this.cmdDeleteSphere.Text = "Delete Sphere";
            this.cmdDeleteSphere.UseVisualStyleBackColor = true;
            this.cmdDeleteSphere.Click += new System.EventHandler(this.cmdDeleteSphere_Click);
            // 
            // grbSphereSettings
            // 
            this.grbSphereSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSphereSettings.Controls.Add(this.txtX);
            this.grbSphereSettings.Controls.Add(this.cmdEditSphere);
            this.grbSphereSettings.Controls.Add(this.txtColor);
            this.grbSphereSettings.Controls.Add(this.lbFixSphereZ);
            this.grbSphereSettings.Controls.Add(this.cmdDeleteSphere);
            this.grbSphereSettings.Controls.Add(this.txtRadius);
            this.grbSphereSettings.Controls.Add(this.lstSphere);
            this.grbSphereSettings.Controls.Add(this.lbFixSphereColor);
            this.grbSphereSettings.Controls.Add(this.cmdColorSphere);
            this.grbSphereSettings.Controls.Add(this.lbFixRadius);
            this.grbSphereSettings.Controls.Add(this.txtY);
            this.grbSphereSettings.Controls.Add(this.cmdAddSphere);
            this.grbSphereSettings.Controls.Add(this.lbFixSphereY);
            this.grbSphereSettings.Controls.Add(this.txtZ);
            this.grbSphereSettings.Controls.Add(this.lbFixSphereX);
            this.grbSphereSettings.Location = new System.Drawing.Point(555, 13);
            this.grbSphereSettings.Name = "grbSphereSettings";
            this.grbSphereSettings.Size = new System.Drawing.Size(790, 207);
            this.grbSphereSettings.TabIndex = 19;
            this.grbSphereSettings.TabStop = false;
            this.grbSphereSettings.Text = "Sphere";
            // 
            // cmdEditSphere
            // 
            this.cmdEditSphere.Location = new System.Drawing.Point(518, 167);
            this.cmdEditSphere.Name = "cmdEditSphere";
            this.cmdEditSphere.Size = new System.Drawing.Size(130, 30);
            this.cmdEditSphere.TabIndex = 21;
            this.cmdEditSphere.Text = "Edit Sphere";
            this.cmdEditSphere.UseVisualStyleBackColor = true;
            this.cmdEditSphere.Click += new System.EventHandler(this.cmdEditSphere_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(69, 135);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 22);
            this.txtColor.TabIndex = 18;
            // 
            // grbSceneSettings
            // 
            this.grbSceneSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSceneSettings.Controls.Add(this.cmdLoadSceneDefaults);
            this.grbSceneSettings.Controls.Add(this.cmdSaveSceneSettings);
            this.grbSceneSettings.Controls.Add(this.txtSceneCameraZ);
            this.grbSceneSettings.Controls.Add(this.lbFixSceneCamerPositionZ);
            this.grbSceneSettings.Controls.Add(this.txtSceneCameraY);
            this.grbSceneSettings.Controls.Add(this.txtSceneCameraX);
            this.grbSceneSettings.Controls.Add(this.lbFixSceneCamerPositionY);
            this.grbSceneSettings.Controls.Add(this.lbFixSceneCameraPosition);
            this.grbSceneSettings.Controls.Add(this.txtSceneLightDirectionZ);
            this.grbSceneSettings.Controls.Add(this.lbFixLightDirectionZ);
            this.grbSceneSettings.Controls.Add(this.txtSceneLightDirectionY);
            this.grbSceneSettings.Controls.Add(this.txtSceneLightDirectionX);
            this.grbSceneSettings.Controls.Add(this.lbFixLightDirectionY);
            this.grbSceneSettings.Controls.Add(this.txtSceneLightPositionZ);
            this.grbSceneSettings.Controls.Add(this.lbFixSceneLigthtPositionZ);
            this.grbSceneSettings.Controls.Add(this.txtSceneLightPositionY);
            this.grbSceneSettings.Controls.Add(this.txtSceneLightPositionX);
            this.grbSceneSettings.Controls.Add(this.txtSceneCanvasHeight);
            this.grbSceneSettings.Controls.Add(this.txtSceneCanvasWidth);
            this.grbSceneSettings.Controls.Add(this.lbFixSceneLightDirection);
            this.grbSceneSettings.Controls.Add(this.lbFixSceneLigthtPositionY);
            this.grbSceneSettings.Controls.Add(this.lbFixSceneLightPosition);
            this.grbSceneSettings.Controls.Add(this.lbFixSceneCanvasHeight);
            this.grbSceneSettings.Controls.Add(this.lbFixSceneCanvasWidth);
            this.grbSceneSettings.Location = new System.Drawing.Point(555, 240);
            this.grbSceneSettings.Name = "grbSceneSettings";
            this.grbSceneSettings.Size = new System.Drawing.Size(787, 170);
            this.grbSceneSettings.TabIndex = 20;
            this.grbSceneSettings.TabStop = false;
            this.grbSceneSettings.Text = "Scene Settings";
            // 
            // cmdSaveSceneSettings
            // 
            this.cmdSaveSceneSettings.Location = new System.Drawing.Point(503, 129);
            this.cmdSaveSceneSettings.Name = "cmdSaveSceneSettings";
            this.cmdSaveSceneSettings.Size = new System.Drawing.Size(130, 30);
            this.cmdSaveSceneSettings.TabIndex = 23;
            this.cmdSaveSceneSettings.Text = "Save";
            this.cmdSaveSceneSettings.UseVisualStyleBackColor = true;
            this.cmdSaveSceneSettings.Click += new System.EventHandler(this.cmdSaveSceneSettings_Click);
            // 
            // txtSceneCameraZ
            // 
            this.txtSceneCameraZ.Location = new System.Drawing.Point(397, 133);
            this.txtSceneCameraZ.Name = "txtSceneCameraZ";
            this.txtSceneCameraZ.Size = new System.Drawing.Size(100, 22);
            this.txtSceneCameraZ.TabIndex = 12;
            // 
            // lbFixSceneCamerPositionZ
            // 
            this.lbFixSceneCamerPositionZ.AutoSize = true;
            this.lbFixSceneCamerPositionZ.Location = new System.Drawing.Point(374, 136);
            this.lbFixSceneCamerPositionZ.Name = "lbFixSceneCamerPositionZ";
            this.lbFixSceneCamerPositionZ.Size = new System.Drawing.Size(17, 17);
            this.lbFixSceneCamerPositionZ.TabIndex = 21;
            this.lbFixSceneCamerPositionZ.Text = "Z";
            // 
            // txtSceneCameraY
            // 
            this.txtSceneCameraY.Location = new System.Drawing.Point(268, 134);
            this.txtSceneCameraY.Name = "txtSceneCameraY";
            this.txtSceneCameraY.Size = new System.Drawing.Size(100, 22);
            this.txtSceneCameraY.TabIndex = 10;
            // 
            // txtSceneCameraX
            // 
            this.txtSceneCameraX.Location = new System.Drawing.Point(139, 134);
            this.txtSceneCameraX.Name = "txtSceneCameraX";
            this.txtSceneCameraX.Size = new System.Drawing.Size(100, 22);
            this.txtSceneCameraX.TabIndex = 9;
            // 
            // lbFixSceneCamerPositionY
            // 
            this.lbFixSceneCamerPositionY.AutoSize = true;
            this.lbFixSceneCamerPositionY.Location = new System.Drawing.Point(245, 137);
            this.lbFixSceneCamerPositionY.Name = "lbFixSceneCamerPositionY";
            this.lbFixSceneCamerPositionY.Size = new System.Drawing.Size(17, 17);
            this.lbFixSceneCamerPositionY.TabIndex = 18;
            this.lbFixSceneCamerPositionY.Text = "Y";
            // 
            // lbFixSceneCameraPosition
            // 
            this.lbFixSceneCameraPosition.AutoSize = true;
            this.lbFixSceneCameraPosition.Location = new System.Drawing.Point(7, 137);
            this.lbFixSceneCameraPosition.Name = "lbFixSceneCameraPosition";
            this.lbFixSceneCameraPosition.Size = new System.Drawing.Size(128, 17);
            this.lbFixSceneCameraPosition.TabIndex = 17;
            this.lbFixSceneCameraPosition.Text = "Camera Position  X";
            // 
            // txtSceneLightDirectionZ
            // 
            this.txtSceneLightDirectionZ.Location = new System.Drawing.Point(397, 105);
            this.txtSceneLightDirectionZ.Name = "txtSceneLightDirectionZ";
            this.txtSceneLightDirectionZ.Size = new System.Drawing.Size(100, 22);
            this.txtSceneLightDirectionZ.TabIndex = 8;
            // 
            // lbFixLightDirectionZ
            // 
            this.lbFixLightDirectionZ.AutoSize = true;
            this.lbFixLightDirectionZ.Location = new System.Drawing.Point(374, 108);
            this.lbFixLightDirectionZ.Name = "lbFixLightDirectionZ";
            this.lbFixLightDirectionZ.Size = new System.Drawing.Size(17, 17);
            this.lbFixLightDirectionZ.TabIndex = 15;
            this.lbFixLightDirectionZ.Text = "Z";
            // 
            // txtSceneLightDirectionY
            // 
            this.txtSceneLightDirectionY.Location = new System.Drawing.Point(268, 106);
            this.txtSceneLightDirectionY.Name = "txtSceneLightDirectionY";
            this.txtSceneLightDirectionY.Size = new System.Drawing.Size(100, 22);
            this.txtSceneLightDirectionY.TabIndex = 7;
            // 
            // txtSceneLightDirectionX
            // 
            this.txtSceneLightDirectionX.Location = new System.Drawing.Point(139, 106);
            this.txtSceneLightDirectionX.Name = "txtSceneLightDirectionX";
            this.txtSceneLightDirectionX.Size = new System.Drawing.Size(100, 22);
            this.txtSceneLightDirectionX.TabIndex = 6;
            // 
            // lbFixLightDirectionY
            // 
            this.lbFixLightDirectionY.AutoSize = true;
            this.lbFixLightDirectionY.Location = new System.Drawing.Point(245, 109);
            this.lbFixLightDirectionY.Name = "lbFixLightDirectionY";
            this.lbFixLightDirectionY.Size = new System.Drawing.Size(17, 17);
            this.lbFixLightDirectionY.TabIndex = 12;
            this.lbFixLightDirectionY.Text = "Y";
            // 
            // txtSceneLightPositionZ
            // 
            this.txtSceneLightPositionZ.Location = new System.Drawing.Point(397, 74);
            this.txtSceneLightPositionZ.Name = "txtSceneLightPositionZ";
            this.txtSceneLightPositionZ.Size = new System.Drawing.Size(100, 22);
            this.txtSceneLightPositionZ.TabIndex = 5;
            // 
            // lbFixSceneLigthtPositionZ
            // 
            this.lbFixSceneLigthtPositionZ.AutoSize = true;
            this.lbFixSceneLigthtPositionZ.Location = new System.Drawing.Point(374, 77);
            this.lbFixSceneLigthtPositionZ.Name = "lbFixSceneLigthtPositionZ";
            this.lbFixSceneLigthtPositionZ.Size = new System.Drawing.Size(17, 17);
            this.lbFixSceneLigthtPositionZ.TabIndex = 10;
            this.lbFixSceneLigthtPositionZ.Text = "Z";
            // 
            // txtSceneLightPositionY
            // 
            this.txtSceneLightPositionY.Location = new System.Drawing.Point(268, 75);
            this.txtSceneLightPositionY.Name = "txtSceneLightPositionY";
            this.txtSceneLightPositionY.Size = new System.Drawing.Size(100, 22);
            this.txtSceneLightPositionY.TabIndex = 4;
            // 
            // txtSceneLightPositionX
            // 
            this.txtSceneLightPositionX.Location = new System.Drawing.Point(139, 75);
            this.txtSceneLightPositionX.Name = "txtSceneLightPositionX";
            this.txtSceneLightPositionX.Size = new System.Drawing.Size(100, 22);
            this.txtSceneLightPositionX.TabIndex = 3;
            // 
            // txtSceneCanvasHeight
            // 
            this.txtSceneCanvasHeight.Location = new System.Drawing.Point(139, 45);
            this.txtSceneCanvasHeight.Name = "txtSceneCanvasHeight";
            this.txtSceneCanvasHeight.Size = new System.Drawing.Size(100, 22);
            this.txtSceneCanvasHeight.TabIndex = 2;
            // 
            // txtSceneCanvasWidth
            // 
            this.txtSceneCanvasWidth.Location = new System.Drawing.Point(139, 17);
            this.txtSceneCanvasWidth.Name = "txtSceneCanvasWidth";
            this.txtSceneCanvasWidth.Size = new System.Drawing.Size(100, 22);
            this.txtSceneCanvasWidth.TabIndex = 1;
            // 
            // lbFixSceneLightDirection
            // 
            this.lbFixSceneLightDirection.AutoSize = true;
            this.lbFixSceneLightDirection.Location = new System.Drawing.Point(19, 109);
            this.lbFixSceneLightDirection.Name = "lbFixSceneLightDirection";
            this.lbFixSceneLightDirection.Size = new System.Drawing.Size(116, 17);
            this.lbFixSceneLightDirection.TabIndex = 4;
            this.lbFixSceneLightDirection.Text = "Light Direction  X";
            // 
            // lbFixSceneLigthtPositionY
            // 
            this.lbFixSceneLigthtPositionY.AutoSize = true;
            this.lbFixSceneLigthtPositionY.Location = new System.Drawing.Point(245, 78);
            this.lbFixSceneLigthtPositionY.Name = "lbFixSceneLigthtPositionY";
            this.lbFixSceneLigthtPositionY.Size = new System.Drawing.Size(17, 17);
            this.lbFixSceneLigthtPositionY.TabIndex = 3;
            this.lbFixSceneLigthtPositionY.Text = "Y";
            // 
            // lbFixSceneLightPosition
            // 
            this.lbFixSceneLightPosition.AutoSize = true;
            this.lbFixSceneLightPosition.Location = new System.Drawing.Point(21, 78);
            this.lbFixSceneLightPosition.Name = "lbFixSceneLightPosition";
            this.lbFixSceneLightPosition.Size = new System.Drawing.Size(114, 17);
            this.lbFixSceneLightPosition.TabIndex = 2;
            this.lbFixSceneLightPosition.Text = "Light Position   X";
            // 
            // lbFixSceneCanvasHeight
            // 
            this.lbFixSceneCanvasHeight.AutoSize = true;
            this.lbFixSceneCanvasHeight.Location = new System.Drawing.Point(32, 48);
            this.lbFixSceneCanvasHeight.Name = "lbFixSceneCanvasHeight";
            this.lbFixSceneCanvasHeight.Size = new System.Drawing.Size(100, 17);
            this.lbFixSceneCanvasHeight.TabIndex = 1;
            this.lbFixSceneCanvasHeight.Text = "Canvas Height";
            // 
            // lbFixSceneCanvasWidth
            // 
            this.lbFixSceneCanvasWidth.AutoSize = true;
            this.lbFixSceneCanvasWidth.Location = new System.Drawing.Point(30, 22);
            this.lbFixSceneCanvasWidth.Name = "lbFixSceneCanvasWidth";
            this.lbFixSceneCanvasWidth.Size = new System.Drawing.Size(103, 17);
            this.lbFixSceneCanvasWidth.TabIndex = 0;
            this.lbFixSceneCanvasWidth.Text = "Canvas   Width";
            // 
            // pnlScene
            // 
            this.pnlScene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScene.AutoScroll = true;
            this.pnlScene.Controls.Add(this.picScene);
            this.pnlScene.Location = new System.Drawing.Point(6, 24);
            this.pnlScene.Name = "pnlScene";
            this.pnlScene.Size = new System.Drawing.Size(518, 359);
            this.pnlScene.TabIndex = 21;
            // 
            // grbRayTracing
            // 
            this.grbRayTracing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRayTracing.Controls.Add(this.pnlScene);
            this.grbRayTracing.Controls.Add(this.cmdStopRayTracing);
            this.grbRayTracing.Controls.Add(this.cmdStartRayTracing);
            this.grbRayTracing.Location = new System.Drawing.Point(2, 12);
            this.grbRayTracing.Name = "grbRayTracing";
            this.grbRayTracing.Size = new System.Drawing.Size(547, 492);
            this.grbRayTracing.TabIndex = 22;
            this.grbRayTracing.TabStop = false;
            this.grbRayTracing.Text = "Ray Traced Scene";
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdClose.Location = new System.Drawing.Point(1196, 474);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(130, 30);
            this.cmdClose.TabIndex = 23;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdLoadSceneDefaults
            // 
            this.cmdLoadSceneDefaults.Location = new System.Drawing.Point(641, 128);
            this.cmdLoadSceneDefaults.Name = "cmdLoadSceneDefaults";
            this.cmdLoadSceneDefaults.Size = new System.Drawing.Size(130, 30);
            this.cmdLoadSceneDefaults.TabIndex = 24;
            this.cmdLoadSceneDefaults.Text = "Load Default";
            this.cmdLoadSceneDefaults.UseVisualStyleBackColor = true;
            this.cmdLoadSceneDefaults.Click += new System.EventHandler(this.cmdLoadSceneDefaults_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(1354, 516);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.grbRayTracing);
            this.Controls.Add(this.grbSceneSettings);
            this.Controls.Add(this.grbSphereSettings);
            this.Name = "frmMain";
            this.Text = "Ray Tracer";
            ((System.ComponentModel.ISupportInitialize)(this.picScene)).EndInit();
            this.grbSphereSettings.ResumeLayout(false);
            this.grbSphereSettings.PerformLayout();
            this.grbSceneSettings.ResumeLayout(false);
            this.grbSceneSettings.PerformLayout();
            this.pnlScene.ResumeLayout(false);
            this.grbRayTracing.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button cmdColorSphere;
        private System.Windows.Forms.Button cmdStartRayTracing;
        private System.Windows.Forms.Button cmdStopRayTracing;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.ListBox lstSphere;
        private System.Windows.Forms.Button cmdDeleteSphere;
        private System.Windows.Forms.GroupBox grbSphereSettings;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button cmdEditSphere;
        private System.Windows.Forms.GroupBox grbSceneSettings;
        private System.Windows.Forms.TextBox txtSceneCanvasWidth;
        private System.Windows.Forms.Label lbFixSceneLightDirection;
        private System.Windows.Forms.Label lbFixSceneLigthtPositionY;
        private System.Windows.Forms.Label lbFixSceneLightPosition;
        private System.Windows.Forms.Label lbFixSceneCanvasHeight;
        private System.Windows.Forms.Label lbFixSceneCanvasWidth;
        private System.Windows.Forms.TextBox txtSceneCanvasHeight;
        private System.Windows.Forms.TextBox txtSceneLightPositionZ;
        private System.Windows.Forms.Label lbFixSceneLigthtPositionZ;
        private System.Windows.Forms.TextBox txtSceneLightPositionY;
        private System.Windows.Forms.TextBox txtSceneLightPositionX;
        private System.Windows.Forms.TextBox txtSceneLightDirectionZ;
        private System.Windows.Forms.Label lbFixLightDirectionZ;
        private System.Windows.Forms.TextBox txtSceneLightDirectionY;
        private System.Windows.Forms.TextBox txtSceneLightDirectionX;
        private System.Windows.Forms.Label lbFixLightDirectionY;
        private System.Windows.Forms.TextBox txtSceneCameraZ;
        private System.Windows.Forms.Label lbFixSceneCamerPositionZ;
        private System.Windows.Forms.TextBox txtSceneCameraY;
        private System.Windows.Forms.TextBox txtSceneCameraX;
        private System.Windows.Forms.Label lbFixSceneCamerPositionY;
        private System.Windows.Forms.Label lbFixSceneCameraPosition;
        private System.Windows.Forms.Button cmdSaveSceneSettings;
        private System.Windows.Forms.Panel pnlScene;
        private System.Windows.Forms.GroupBox grbRayTracing;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdLoadSceneDefaults;
    }
}

