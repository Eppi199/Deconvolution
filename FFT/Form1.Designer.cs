namespace FFT
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btFFTNormal = new System.Windows.Forms.Button();
            this.pbFourierPhase = new System.Windows.Forms.PictureBox();
            this.pbFourierMag = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.btFFTDeconv = new System.Windows.Forms.Button();
            this.btDeconvolutionBlur = new System.Windows.Forms.Button();
            this.SmoothBlur = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EdgeValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.RadiusBlur = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btDeconvolutionGauss = new System.Windows.Forms.Button();
            this.SmoothGaussian = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.RadiusGaussian = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.HWvalue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btDeconvolutionMotion = new System.Windows.Forms.Button();
            this.SmoothMoution = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AngleMoution = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.LengthMoution = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourierPhase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourierMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothBlur)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusBlur)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothGaussian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusGaussian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HWvalue)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothMoution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleMoution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthMoution)).BeginInit();
            this.SuspendLayout();
            // 
            // btFFTNormal
            // 
            this.btFFTNormal.Location = new System.Drawing.Point(124, 588);
            this.btFFTNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFFTNormal.Name = "btFFTNormal";
            this.btFFTNormal.Size = new System.Drawing.Size(80, 49);
            this.btFFTNormal.TabIndex = 0;
            this.btFFTNormal.Text = "FFT Normal";
            this.btFFTNormal.UseVisualStyleBackColor = true;
            this.btFFTNormal.Click += new System.EventHandler(this.btFFTNormal_Click);
            // 
            // pbFourierPhase
            // 
            this.pbFourierPhase.Location = new System.Drawing.Point(535, 271);
            this.pbFourierPhase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFourierPhase.Name = "pbFourierPhase";
            this.pbFourierPhase.Size = new System.Drawing.Size(256, 256);
            this.pbFourierPhase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFourierPhase.TabIndex = 3;
            this.pbFourierPhase.TabStop = false;
            // 
            // pbFourierMag
            // 
            this.pbFourierMag.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbFourierMag.Location = new System.Drawing.Point(535, 11);
            this.pbFourierMag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFourierMag.Name = "pbFourierMag";
            this.pbFourierMag.Size = new System.Drawing.Size(256, 256);
            this.pbFourierMag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFourierMag.TabIndex = 4;
            this.pbFourierMag.TabStop = false;
            this.pbFourierMag.WaitOnLoad = true;
            // 
            // pbResult
            // 
            this.pbResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbResult.Location = new System.Drawing.Point(797, 11);
            this.pbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(512, 512);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 5;
            this.pbResult.TabStop = false;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 532);
            this.btOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(106, 106);
            this.btOpen.TabIndex = 7;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Smooth";
            // 
            // pbSource
            // 
            this.pbSource.Location = new System.Drawing.Point(12, 11);
            this.pbSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(517, 517);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSource.TabIndex = 10;
            this.pbSource.TabStop = false;
            // 
            // btFFTDeconv
            // 
            this.btFFTDeconv.Location = new System.Drawing.Point(124, 531);
            this.btFFTDeconv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFFTDeconv.Name = "btFFTDeconv";
            this.btFFTDeconv.Size = new System.Drawing.Size(80, 48);
            this.btFFTDeconv.TabIndex = 11;
            this.btFFTDeconv.Text = "FFT Deconv";
            this.btFFTDeconv.UseVisualStyleBackColor = true;
            this.btFFTDeconv.Click += new System.EventHandler(this.btFFTDeconv_Click);
            // 
            // btDeconvolutionBlur
            // 
            this.btDeconvolutionBlur.Location = new System.Drawing.Point(727, 15);
            this.btDeconvolutionBlur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeconvolutionBlur.Name = "btDeconvolutionBlur";
            this.btDeconvolutionBlur.Size = new System.Drawing.Size(278, 51);
            this.btDeconvolutionBlur.TabIndex = 12;
            this.btDeconvolutionBlur.Text = "Deconvolution Out of focus";
            this.btDeconvolutionBlur.UseVisualStyleBackColor = true;
            this.btDeconvolutionBlur.Click += new System.EventHandler(this.btDeconvolution_Click);
            // 
            // SmoothBlur
            // 
            this.SmoothBlur.DecimalPlaces = 5;
            this.SmoothBlur.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SmoothBlur.Increment = new decimal(new int[] {
            3,
            0,
            0,
            327680});
            this.SmoothBlur.Location = new System.Drawing.Point(449, 21);
            this.SmoothBlur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SmoothBlur.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SmoothBlur.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.SmoothBlur.Name = "SmoothBlur";
            this.SmoothBlur.Size = new System.Drawing.Size(249, 45);
            this.SmoothBlur.TabIndex = 29;
            this.SmoothBlur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SmoothBlur.Value = new decimal(new int[] {
            51,
            0,
            0,
            327680});
            this.SmoothBlur.ValueChanged += new System.EventHandler(this.SmoothValue_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(281, 532);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 106);
            this.tabControl1.TabIndex = 37;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPage1.Controls.Add(this.btDeconvolutionBlur);
            this.tabPage1.Controls.Add(this.EdgeValue);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.SmoothBlur);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.RadiusBlur);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 77);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Out of focus Blur";
            // 
            // EdgeValue
            // 
            this.EdgeValue.DecimalPlaces = 1;
            this.EdgeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EdgeValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.EdgeValue.Location = new System.Drawing.Point(52, 21);
            this.EdgeValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.EdgeValue.Name = "EdgeValue";
            this.EdgeValue.Size = new System.Drawing.Size(134, 45);
            this.EdgeValue.TabIndex = 43;
            this.EdgeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EdgeValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "edge";
            // 
            // RadiusBlur
            // 
            this.RadiusBlur.DecimalPlaces = 1;
            this.RadiusBlur.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadiusBlur.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.RadiusBlur.Location = new System.Drawing.Point(250, 21);
            this.RadiusBlur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadiusBlur.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RadiusBlur.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RadiusBlur.Name = "RadiusBlur";
            this.RadiusBlur.Size = new System.Drawing.Size(131, 45);
            this.RadiusBlur.TabIndex = 39;
            this.RadiusBlur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RadiusBlur.Value = new decimal(new int[] {
            137,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Radius";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPage2.Controls.Add(this.btDeconvolutionGauss);
            this.tabPage2.Controls.Add(this.SmoothGaussian);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.RadiusGaussian);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.HWvalue);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1020, 77);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GaussianBlur";
            // 
            // btDeconvolutionGauss
            // 
            this.btDeconvolutionGauss.Location = new System.Drawing.Point(701, 18);
            this.btDeconvolutionGauss.Name = "btDeconvolutionGauss";
            this.btDeconvolutionGauss.Size = new System.Drawing.Size(300, 45);
            this.btDeconvolutionGauss.TabIndex = 46;
            this.btDeconvolutionGauss.Text = "Deconvolution Gauss";
            this.btDeconvolutionGauss.UseVisualStyleBackColor = true;
            this.btDeconvolutionGauss.Click += new System.EventHandler(this.btDeconvolutionGauss_Click);
            // 
            // SmoothGaussian
            // 
            this.SmoothGaussian.DecimalPlaces = 5;
            this.SmoothGaussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SmoothGaussian.Increment = new decimal(new int[] {
            2,
            0,
            0,
            327680});
            this.SmoothGaussian.Location = new System.Drawing.Point(435, 18);
            this.SmoothGaussian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SmoothGaussian.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SmoothGaussian.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            327680});
            this.SmoothGaussian.Name = "SmoothGaussian";
            this.SmoothGaussian.Size = new System.Drawing.Size(220, 45);
            this.SmoothGaussian.TabIndex = 45;
            this.SmoothGaussian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SmoothGaussian.Value = new decimal(new int[] {
            51,
            0,
            0,
            327680});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Smooth: ";
            // 
            // RadiusGaussian
            // 
            this.RadiusGaussian.DecimalPlaces = 1;
            this.RadiusGaussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadiusGaussian.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.RadiusGaussian.Location = new System.Drawing.Point(217, 18);
            this.RadiusGaussian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadiusGaussian.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.RadiusGaussian.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RadiusGaussian.Name = "RadiusGaussian";
            this.RadiusGaussian.Size = new System.Drawing.Size(137, 45);
            this.RadiusGaussian.TabIndex = 43;
            this.RadiusGaussian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RadiusGaussian.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Radius: ";
            // 
            // HWvalue
            // 
            this.HWvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HWvalue.Location = new System.Drawing.Point(51, 18);
            this.HWvalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HWvalue.Name = "HWvalue";
            this.HWvalue.Size = new System.Drawing.Size(92, 45);
            this.HWvalue.TabIndex = 41;
            this.HWvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HWvalue.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Half";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage3.Controls.Add(this.btDeconvolutionMotion);
            this.tabPage3.Controls.Add(this.SmoothMoution);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.AngleMoution);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.LengthMoution);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1020, 77);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Motion blur";
            // 
            // btDeconvolutionMotion
            // 
            this.btDeconvolutionMotion.Location = new System.Drawing.Point(691, 18);
            this.btDeconvolutionMotion.Name = "btDeconvolutionMotion";
            this.btDeconvolutionMotion.Size = new System.Drawing.Size(307, 45);
            this.btDeconvolutionMotion.TabIndex = 53;
            this.btDeconvolutionMotion.Text = "Motion Deconvolution ";
            this.btDeconvolutionMotion.UseVisualStyleBackColor = true;
            this.btDeconvolutionMotion.Click += new System.EventHandler(this.btDeconvolutionMoution_Click);
            // 
            // SmoothMoution
            // 
            this.SmoothMoution.DecimalPlaces = 5;
            this.SmoothMoution.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SmoothMoution.Increment = new decimal(new int[] {
            2,
            0,
            0,
            327680});
            this.SmoothMoution.Location = new System.Drawing.Point(446, 18);
            this.SmoothMoution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SmoothMoution.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SmoothMoution.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            327680});
            this.SmoothMoution.Name = "SmoothMoution";
            this.SmoothMoution.Size = new System.Drawing.Size(220, 45);
            this.SmoothMoution.TabIndex = 52;
            this.SmoothMoution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SmoothMoution.Value = new decimal(new int[] {
            51,
            0,
            0,
            327680});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Angle: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Smooth: ";
            // 
            // AngleMoution
            // 
            this.AngleMoution.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AngleMoution.Location = new System.Drawing.Point(63, 18);
            this.AngleMoution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AngleMoution.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.AngleMoution.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.AngleMoution.Name = "AngleMoution";
            this.AngleMoution.Size = new System.Drawing.Size(92, 45);
            this.AngleMoution.TabIndex = 48;
            this.AngleMoution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Length: ";
            // 
            // LengthMoution
            // 
            this.LengthMoution.DecimalPlaces = 1;
            this.LengthMoution.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthMoution.Location = new System.Drawing.Point(227, 18);
            this.LengthMoution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LengthMoution.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.LengthMoution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LengthMoution.Name = "LengthMoution";
            this.LengthMoution.Size = new System.Drawing.Size(137, 45);
            this.LengthMoution.TabIndex = 50;
            this.LengthMoution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LengthMoution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 104);
            this.button1.TabIndex = 38;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btFFTDeconv);
            this.Controls.Add(this.pbSource);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.pbFourierMag);
            this.Controls.Add(this.pbFourierPhase);
            this.Controls.Add(this.btFFTNormal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wiener filter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFourierPhase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourierMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothBlur)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusBlur)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothGaussian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusGaussian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HWvalue)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothMoution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleMoution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthMoution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFFTNormal;
        private System.Windows.Forms.PictureBox pbFourierPhase;
        private System.Windows.Forms.PictureBox pbFourierMag;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.Button btFFTDeconv;
        private System.Windows.Forms.Button btDeconvolutionBlur;
        private System.Windows.Forms.NumericUpDown SmoothBlur;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown EdgeValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown RadiusBlur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown SmoothGaussian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown RadiusGaussian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDeconvolutionGauss;
        private System.Windows.Forms.Button btDeconvolutionMotion;
        private System.Windows.Forms.NumericUpDown SmoothMoution;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown AngleMoution;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown LengthMoution;
        private System.Windows.Forms.NumericUpDown HWvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

