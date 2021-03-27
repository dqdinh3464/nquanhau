using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NQuanHau1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnResetSetting = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.numberNQueen = new System.Windows.Forms.NumericUpDown();
            this.grBAnswer = new System.Windows.Forms.GroupBox();
            this.rtxtAnswer = new System.Windows.Forms.RichTextBox();
            this.btnInputNQueen = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fpnlChess = new System.Windows.Forms.FlowLayoutPanel();
            this.pB11 = new System.Windows.Forms.PictureBox();
            this.pB12 = new System.Windows.Forms.PictureBox();
            this.pB13 = new System.Windows.Forms.PictureBox();
            this.pB14 = new System.Windows.Forms.PictureBox();
            this.pB15 = new System.Windows.Forms.PictureBox();
            this.pB16 = new System.Windows.Forms.PictureBox();
            this.pB17 = new System.Windows.Forms.PictureBox();
            this.pB18 = new System.Windows.Forms.PictureBox();
            this.pB21 = new System.Windows.Forms.PictureBox();
            this.pB22 = new System.Windows.Forms.PictureBox();
            this.pB23 = new System.Windows.Forms.PictureBox();
            this.pB24 = new System.Windows.Forms.PictureBox();
            this.pB25 = new System.Windows.Forms.PictureBox();
            this.pB26 = new System.Windows.Forms.PictureBox();
            this.pB27 = new System.Windows.Forms.PictureBox();
            this.pB28 = new System.Windows.Forms.PictureBox();
            this.pB31 = new System.Windows.Forms.PictureBox();
            this.pB32 = new System.Windows.Forms.PictureBox();
            this.pB33 = new System.Windows.Forms.PictureBox();
            this.pB34 = new System.Windows.Forms.PictureBox();
            this.pB35 = new System.Windows.Forms.PictureBox();
            this.pB36 = new System.Windows.Forms.PictureBox();
            this.pB37 = new System.Windows.Forms.PictureBox();
            this.pB38 = new System.Windows.Forms.PictureBox();
            this.pB41 = new System.Windows.Forms.PictureBox();
            this.pB42 = new System.Windows.Forms.PictureBox();
            this.pB43 = new System.Windows.Forms.PictureBox();
            this.pB44 = new System.Windows.Forms.PictureBox();
            this.pB45 = new System.Windows.Forms.PictureBox();
            this.pB46 = new System.Windows.Forms.PictureBox();
            this.pB47 = new System.Windows.Forms.PictureBox();
            this.pB48 = new System.Windows.Forms.PictureBox();
            this.pB51 = new System.Windows.Forms.PictureBox();
            this.pB52 = new System.Windows.Forms.PictureBox();
            this.pB53 = new System.Windows.Forms.PictureBox();
            this.pB54 = new System.Windows.Forms.PictureBox();
            this.pB55 = new System.Windows.Forms.PictureBox();
            this.pB56 = new System.Windows.Forms.PictureBox();
            this.pB57 = new System.Windows.Forms.PictureBox();
            this.pB58 = new System.Windows.Forms.PictureBox();
            this.pB61 = new System.Windows.Forms.PictureBox();
            this.pB62 = new System.Windows.Forms.PictureBox();
            this.pB63 = new System.Windows.Forms.PictureBox();
            this.pB64 = new System.Windows.Forms.PictureBox();
            this.pB65 = new System.Windows.Forms.PictureBox();
            this.pB66 = new System.Windows.Forms.PictureBox();
            this.pB67 = new System.Windows.Forms.PictureBox();
            this.pB68 = new System.Windows.Forms.PictureBox();
            this.pB71 = new System.Windows.Forms.PictureBox();
            this.pB72 = new System.Windows.Forms.PictureBox();
            this.pB73 = new System.Windows.Forms.PictureBox();
            this.pB74 = new System.Windows.Forms.PictureBox();
            this.pB75 = new System.Windows.Forms.PictureBox();
            this.pB76 = new System.Windows.Forms.PictureBox();
            this.pB77 = new System.Windows.Forms.PictureBox();
            this.pB78 = new System.Windows.Forms.PictureBox();
            this.pB81 = new System.Windows.Forms.PictureBox();
            this.pB82 = new System.Windows.Forms.PictureBox();
            this.pB83 = new System.Windows.Forms.PictureBox();
            this.pB84 = new System.Windows.Forms.PictureBox();
            this.pB85 = new System.Windows.Forms.PictureBox();
            this.pB86 = new System.Windows.Forms.PictureBox();
            this.pB87 = new System.Windows.Forms.PictureBox();
            this.pB88 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbX1 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.lbX3 = new System.Windows.Forms.Label();
            this.lbX4 = new System.Windows.Forms.Label();
            this.lbX5 = new System.Windows.Forms.Label();
            this.lbX6 = new System.Windows.Forms.Label();
            this.lbX7 = new System.Windows.Forms.Label();
            this.lbX8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbY1 = new System.Windows.Forms.Label();
            this.lbY2 = new System.Windows.Forms.Label();
            this.lbY3 = new System.Windows.Forms.Label();
            this.lbY4 = new System.Windows.Forms.Label();
            this.lbY5 = new System.Windows.Forms.Label();
            this.lbY6 = new System.Windows.Forms.Label();
            this.lbY7 = new System.Windows.Forms.Label();
            this.lbY8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberNQueen)).BeginInit();
            this.grBAnswer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.fpnlChess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB88)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(394, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "N QUÂN HẬU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(12, 49);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(91, 24);
            this.lbSpeed.TabIndex = 1;
            this.lbSpeed.Text = "Tốc độ: 5";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(12, 87);
            this.trackBarSpeed.Maximum = 100;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSpeed.Size = new System.Drawing.Size(45, 109);
            this.trackBarSpeed.TabIndex = 2;
            this.trackBarSpeed.Value = 5;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 750);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flowLayoutPanel4);
            this.panel5.Controls.Add(this.numberNQueen);
            this.panel5.Controls.Add(this.grBAnswer);
            this.panel5.Controls.Add(this.btnInputNQueen);
            this.panel5.Location = new System.Drawing.Point(784, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 626);
            this.panel5.TabIndex = 6;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnStart);
            this.flowLayoutPanel4.Controls.Add(this.btnResetSetting);
            this.flowLayoutPanel4.Controls.Add(this.btnExit);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(7, 426);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(319, 69);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 60);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Chạy";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnResetSetting
            // 
            this.btnResetSetting.Enabled = false;
            this.btnResetSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnResetSetting.Location = new System.Drawing.Point(109, 3);
            this.btnResetSetting.Name = "btnResetSetting";
            this.btnResetSetting.Size = new System.Drawing.Size(100, 60);
            this.btnResetSetting.TabIndex = 3;
            this.btnResetSetting.Text = "Thiết lập lại";
            this.btnResetSetting.UseVisualStyleBackColor = true;
            this.btnResetSetting.Click += new System.EventHandler(this.btnResetSetting_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExit.Location = new System.Drawing.Point(215, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 60);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // numberNQueen
            // 
            this.numberNQueen.Location = new System.Drawing.Point(7, 13);
            this.numberNQueen.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numberNQueen.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberNQueen.Name = "numberNQueen";
            this.numberNQueen.Size = new System.Drawing.Size(133, 29);
            this.numberNQueen.TabIndex = 7;
            this.numberNQueen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // grBAnswer
            // 
            this.grBAnswer.Controls.Add(this.rtxtAnswer);
            this.grBAnswer.Location = new System.Drawing.Point(1, 49);
            this.grBAnswer.Name = "grBAnswer";
            this.grBAnswer.Size = new System.Drawing.Size(318, 341);
            this.grBAnswer.TabIndex = 2;
            this.grBAnswer.TabStop = false;
            this.grBAnswer.Text = "Số lời giải: ";
            // 
            // rtxtAnswer
            // 
            this.rtxtAnswer.AutoWordSelection = true;
            this.rtxtAnswer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtxtAnswer.EnableAutoDragDrop = true;
            this.rtxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rtxtAnswer.Location = new System.Drawing.Point(6, 28);
            this.rtxtAnswer.Name = "rtxtAnswer";
            this.rtxtAnswer.ReadOnly = true;
            this.rtxtAnswer.Size = new System.Drawing.Size(306, 301);
            this.rtxtAnswer.TabIndex = 0;
            this.rtxtAnswer.Text = "";
            // 
            // btnInputNQueen
            // 
            this.btnInputNQueen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnInputNQueen.Location = new System.Drawing.Point(233, 14);
            this.btnInputNQueen.Name = "btnInputNQueen";
            this.btnInputNQueen.Size = new System.Drawing.Size(86, 30);
            this.btnInputNQueen.TabIndex = 1;
            this.btnInputNQueen.Text = "Nhập";
            this.btnInputNQueen.UseVisualStyleBackColor = true;
            this.btnInputNQueen.Click += new System.EventHandler(this.btnInputNQueen_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbSpeed);
            this.panel3.Controls.Add(this.trackBarSpeed);
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 310);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 720);
            this.panel2.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(12, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1092, 62);
            this.panel6.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fpnlChess);
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Location = new System.Drawing.Point(121, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 626);
            this.panel4.TabIndex = 5;
            // 
            // fpnlChess
            // 
            this.fpnlChess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fpnlChess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlChess.Controls.Add(this.pB11);
            this.fpnlChess.Controls.Add(this.pB12);
            this.fpnlChess.Controls.Add(this.pB13);
            this.fpnlChess.Controls.Add(this.pB14);
            this.fpnlChess.Controls.Add(this.pB15);
            this.fpnlChess.Controls.Add(this.pB16);
            this.fpnlChess.Controls.Add(this.pB17);
            this.fpnlChess.Controls.Add(this.pB18);
            this.fpnlChess.Controls.Add(this.pB21);
            this.fpnlChess.Controls.Add(this.pB22);
            this.fpnlChess.Controls.Add(this.pB23);
            this.fpnlChess.Controls.Add(this.pB24);
            this.fpnlChess.Controls.Add(this.pB25);
            this.fpnlChess.Controls.Add(this.pB26);
            this.fpnlChess.Controls.Add(this.pB27);
            this.fpnlChess.Controls.Add(this.pB28);
            this.fpnlChess.Controls.Add(this.pB31);
            this.fpnlChess.Controls.Add(this.pB32);
            this.fpnlChess.Controls.Add(this.pB33);
            this.fpnlChess.Controls.Add(this.pB34);
            this.fpnlChess.Controls.Add(this.pB35);
            this.fpnlChess.Controls.Add(this.pB36);
            this.fpnlChess.Controls.Add(this.pB37);
            this.fpnlChess.Controls.Add(this.pB38);
            this.fpnlChess.Controls.Add(this.pB41);
            this.fpnlChess.Controls.Add(this.pB42);
            this.fpnlChess.Controls.Add(this.pB43);
            this.fpnlChess.Controls.Add(this.pB44);
            this.fpnlChess.Controls.Add(this.pB45);
            this.fpnlChess.Controls.Add(this.pB46);
            this.fpnlChess.Controls.Add(this.pB47);
            this.fpnlChess.Controls.Add(this.pB48);
            this.fpnlChess.Controls.Add(this.pB51);
            this.fpnlChess.Controls.Add(this.pB52);
            this.fpnlChess.Controls.Add(this.pB53);
            this.fpnlChess.Controls.Add(this.pB54);
            this.fpnlChess.Controls.Add(this.pB55);
            this.fpnlChess.Controls.Add(this.pB56);
            this.fpnlChess.Controls.Add(this.pB57);
            this.fpnlChess.Controls.Add(this.pB58);
            this.fpnlChess.Controls.Add(this.pB61);
            this.fpnlChess.Controls.Add(this.pB62);
            this.fpnlChess.Controls.Add(this.pB63);
            this.fpnlChess.Controls.Add(this.pB64);
            this.fpnlChess.Controls.Add(this.pB65);
            this.fpnlChess.Controls.Add(this.pB66);
            this.fpnlChess.Controls.Add(this.pB67);
            this.fpnlChess.Controls.Add(this.pB68);
            this.fpnlChess.Controls.Add(this.pB71);
            this.fpnlChess.Controls.Add(this.pB72);
            this.fpnlChess.Controls.Add(this.pB73);
            this.fpnlChess.Controls.Add(this.pB74);
            this.fpnlChess.Controls.Add(this.pB75);
            this.fpnlChess.Controls.Add(this.pB76);
            this.fpnlChess.Controls.Add(this.pB77);
            this.fpnlChess.Controls.Add(this.pB78);
            this.fpnlChess.Controls.Add(this.pB81);
            this.fpnlChess.Controls.Add(this.pB82);
            this.fpnlChess.Controls.Add(this.pB83);
            this.fpnlChess.Controls.Add(this.pB84);
            this.fpnlChess.Controls.Add(this.pB85);
            this.fpnlChess.Controls.Add(this.pB86);
            this.fpnlChess.Controls.Add(this.pB87);
            this.fpnlChess.Controls.Add(this.pB88);
            this.fpnlChess.Controls.Add(this.flowLayoutPanel5);
            this.fpnlChess.Location = new System.Drawing.Point(68, 63);
            this.fpnlChess.Name = "fpnlChess";
            this.fpnlChess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpnlChess.Size = new System.Drawing.Size(538, 538);
            this.fpnlChess.TabIndex = 2;
            // 
            // pB11
            // 
            this.pB11.Image = global::NQuanHau1.Properties.Resources.White_C_3;
            this.pB11.Location = new System.Drawing.Point(1, 1);
            this.pB11.Margin = new System.Windows.Forms.Padding(1);
            this.pB11.Name = "pB11";
            this.pB11.Size = new System.Drawing.Size(65, 65);
            this.pB11.TabIndex = 0;
            this.pB11.TabStop = false;
            // 
            // pB12
            // 
            this.pB12.Location = new System.Drawing.Point(68, 1);
            this.pB12.Margin = new System.Windows.Forms.Padding(1);
            this.pB12.Name = "pB12";
            this.pB12.Size = new System.Drawing.Size(65, 65);
            this.pB12.TabIndex = 0;
            this.pB12.TabStop = false;
            // 
            // pB13
            // 
            this.pB13.Location = new System.Drawing.Point(135, 1);
            this.pB13.Margin = new System.Windows.Forms.Padding(1);
            this.pB13.Name = "pB13";
            this.pB13.Size = new System.Drawing.Size(65, 65);
            this.pB13.TabIndex = 0;
            this.pB13.TabStop = false;
            // 
            // pB14
            // 
            this.pB14.Location = new System.Drawing.Point(202, 1);
            this.pB14.Margin = new System.Windows.Forms.Padding(1);
            this.pB14.Name = "pB14";
            this.pB14.Size = new System.Drawing.Size(65, 65);
            this.pB14.TabIndex = 0;
            this.pB14.TabStop = false;
            // 
            // pB15
            // 
            this.pB15.Location = new System.Drawing.Point(269, 1);
            this.pB15.Margin = new System.Windows.Forms.Padding(1);
            this.pB15.Name = "pB15";
            this.pB15.Size = new System.Drawing.Size(65, 65);
            this.pB15.TabIndex = 0;
            this.pB15.TabStop = false;
            // 
            // pB16
            // 
            this.pB16.Location = new System.Drawing.Point(336, 1);
            this.pB16.Margin = new System.Windows.Forms.Padding(1);
            this.pB16.Name = "pB16";
            this.pB16.Size = new System.Drawing.Size(65, 65);
            this.pB16.TabIndex = 0;
            this.pB16.TabStop = false;
            // 
            // pB17
            // 
            this.pB17.Location = new System.Drawing.Point(403, 1);
            this.pB17.Margin = new System.Windows.Forms.Padding(1);
            this.pB17.Name = "pB17";
            this.pB17.Size = new System.Drawing.Size(65, 65);
            this.pB17.TabIndex = 0;
            this.pB17.TabStop = false;
            // 
            // pB18
            // 
            this.pB18.Location = new System.Drawing.Point(470, 1);
            this.pB18.Margin = new System.Windows.Forms.Padding(1);
            this.pB18.Name = "pB18";
            this.pB18.Size = new System.Drawing.Size(65, 65);
            this.pB18.TabIndex = 0;
            this.pB18.TabStop = false;
            // 
            // pB21
            // 
            this.pB21.Location = new System.Drawing.Point(1, 68);
            this.pB21.Margin = new System.Windows.Forms.Padding(1);
            this.pB21.Name = "pB21";
            this.pB21.Size = new System.Drawing.Size(65, 65);
            this.pB21.TabIndex = 0;
            this.pB21.TabStop = false;
            // 
            // pB22
            // 
            this.pB22.Location = new System.Drawing.Point(68, 68);
            this.pB22.Margin = new System.Windows.Forms.Padding(1);
            this.pB22.Name = "pB22";
            this.pB22.Size = new System.Drawing.Size(65, 65);
            this.pB22.TabIndex = 0;
            this.pB22.TabStop = false;
            // 
            // pB23
            // 
            this.pB23.Location = new System.Drawing.Point(135, 68);
            this.pB23.Margin = new System.Windows.Forms.Padding(1);
            this.pB23.Name = "pB23";
            this.pB23.Size = new System.Drawing.Size(65, 65);
            this.pB23.TabIndex = 0;
            this.pB23.TabStop = false;
            // 
            // pB24
            // 
            this.pB24.Location = new System.Drawing.Point(202, 68);
            this.pB24.Margin = new System.Windows.Forms.Padding(1);
            this.pB24.Name = "pB24";
            this.pB24.Size = new System.Drawing.Size(65, 65);
            this.pB24.TabIndex = 0;
            this.pB24.TabStop = false;
            // 
            // pB25
            // 
            this.pB25.Location = new System.Drawing.Point(269, 68);
            this.pB25.Margin = new System.Windows.Forms.Padding(1);
            this.pB25.Name = "pB25";
            this.pB25.Size = new System.Drawing.Size(65, 65);
            this.pB25.TabIndex = 0;
            this.pB25.TabStop = false;
            // 
            // pB26
            // 
            this.pB26.Location = new System.Drawing.Point(336, 68);
            this.pB26.Margin = new System.Windows.Forms.Padding(1);
            this.pB26.Name = "pB26";
            this.pB26.Size = new System.Drawing.Size(65, 65);
            this.pB26.TabIndex = 0;
            this.pB26.TabStop = false;
            // 
            // pB27
            // 
            this.pB27.Location = new System.Drawing.Point(403, 68);
            this.pB27.Margin = new System.Windows.Forms.Padding(1);
            this.pB27.Name = "pB27";
            this.pB27.Size = new System.Drawing.Size(65, 65);
            this.pB27.TabIndex = 0;
            this.pB27.TabStop = false;
            // 
            // pB28
            // 
            this.pB28.Location = new System.Drawing.Point(470, 68);
            this.pB28.Margin = new System.Windows.Forms.Padding(1);
            this.pB28.Name = "pB28";
            this.pB28.Size = new System.Drawing.Size(65, 65);
            this.pB28.TabIndex = 0;
            this.pB28.TabStop = false;
            // 
            // pB31
            // 
            this.pB31.Enabled = false;
            this.pB31.Location = new System.Drawing.Point(1, 135);
            this.pB31.Margin = new System.Windows.Forms.Padding(1);
            this.pB31.Name = "pB31";
            this.pB31.Size = new System.Drawing.Size(65, 65);
            this.pB31.TabIndex = 0;
            this.pB31.TabStop = false;
            // 
            // pB32
            // 
            this.pB32.Enabled = false;
            this.pB32.Location = new System.Drawing.Point(68, 135);
            this.pB32.Margin = new System.Windows.Forms.Padding(1);
            this.pB32.Name = "pB32";
            this.pB32.Size = new System.Drawing.Size(65, 65);
            this.pB32.TabIndex = 0;
            this.pB32.TabStop = false;
            // 
            // pB33
            // 
            this.pB33.Enabled = false;
            this.pB33.Location = new System.Drawing.Point(135, 135);
            this.pB33.Margin = new System.Windows.Forms.Padding(1);
            this.pB33.Name = "pB33";
            this.pB33.Size = new System.Drawing.Size(65, 65);
            this.pB33.TabIndex = 0;
            this.pB33.TabStop = false;
            // 
            // pB34
            // 
            this.pB34.Enabled = false;
            this.pB34.Location = new System.Drawing.Point(202, 135);
            this.pB34.Margin = new System.Windows.Forms.Padding(1);
            this.pB34.Name = "pB34";
            this.pB34.Size = new System.Drawing.Size(65, 65);
            this.pB34.TabIndex = 0;
            this.pB34.TabStop = false;
            // 
            // pB35
            // 
            this.pB35.Enabled = false;
            this.pB35.Location = new System.Drawing.Point(269, 135);
            this.pB35.Margin = new System.Windows.Forms.Padding(1);
            this.pB35.Name = "pB35";
            this.pB35.Size = new System.Drawing.Size(65, 65);
            this.pB35.TabIndex = 0;
            this.pB35.TabStop = false;
            // 
            // pB36
            // 
            this.pB36.Enabled = false;
            this.pB36.Location = new System.Drawing.Point(336, 135);
            this.pB36.Margin = new System.Windows.Forms.Padding(1);
            this.pB36.Name = "pB36";
            this.pB36.Size = new System.Drawing.Size(65, 65);
            this.pB36.TabIndex = 0;
            this.pB36.TabStop = false;
            // 
            // pB37
            // 
            this.pB37.Enabled = false;
            this.pB37.Location = new System.Drawing.Point(403, 135);
            this.pB37.Margin = new System.Windows.Forms.Padding(1);
            this.pB37.Name = "pB37";
            this.pB37.Size = new System.Drawing.Size(65, 65);
            this.pB37.TabIndex = 0;
            this.pB37.TabStop = false;
            // 
            // pB38
            // 
            this.pB38.Location = new System.Drawing.Point(470, 135);
            this.pB38.Margin = new System.Windows.Forms.Padding(1);
            this.pB38.Name = "pB38";
            this.pB38.Size = new System.Drawing.Size(65, 65);
            this.pB38.TabIndex = 0;
            this.pB38.TabStop = false;
            // 
            // pB41
            // 
            this.pB41.Location = new System.Drawing.Point(1, 202);
            this.pB41.Margin = new System.Windows.Forms.Padding(1);
            this.pB41.Name = "pB41";
            this.pB41.Size = new System.Drawing.Size(65, 65);
            this.pB41.TabIndex = 0;
            this.pB41.TabStop = false;
            // 
            // pB42
            // 
            this.pB42.Location = new System.Drawing.Point(68, 202);
            this.pB42.Margin = new System.Windows.Forms.Padding(1);
            this.pB42.Name = "pB42";
            this.pB42.Size = new System.Drawing.Size(65, 65);
            this.pB42.TabIndex = 0;
            this.pB42.TabStop = false;
            // 
            // pB43
            // 
            this.pB43.Location = new System.Drawing.Point(135, 202);
            this.pB43.Margin = new System.Windows.Forms.Padding(1);
            this.pB43.Name = "pB43";
            this.pB43.Size = new System.Drawing.Size(65, 65);
            this.pB43.TabIndex = 0;
            this.pB43.TabStop = false;
            // 
            // pB44
            // 
            this.pB44.Location = new System.Drawing.Point(202, 202);
            this.pB44.Margin = new System.Windows.Forms.Padding(1);
            this.pB44.Name = "pB44";
            this.pB44.Size = new System.Drawing.Size(65, 65);
            this.pB44.TabIndex = 0;
            this.pB44.TabStop = false;
            // 
            // pB45
            // 
            this.pB45.Location = new System.Drawing.Point(269, 202);
            this.pB45.Margin = new System.Windows.Forms.Padding(1);
            this.pB45.Name = "pB45";
            this.pB45.Size = new System.Drawing.Size(65, 65);
            this.pB45.TabIndex = 0;
            this.pB45.TabStop = false;
            // 
            // pB46
            // 
            this.pB46.Location = new System.Drawing.Point(336, 202);
            this.pB46.Margin = new System.Windows.Forms.Padding(1);
            this.pB46.Name = "pB46";
            this.pB46.Size = new System.Drawing.Size(65, 65);
            this.pB46.TabIndex = 0;
            this.pB46.TabStop = false;
            // 
            // pB47
            // 
            this.pB47.Location = new System.Drawing.Point(403, 202);
            this.pB47.Margin = new System.Windows.Forms.Padding(1);
            this.pB47.Name = "pB47";
            this.pB47.Size = new System.Drawing.Size(65, 65);
            this.pB47.TabIndex = 0;
            this.pB47.TabStop = false;
            // 
            // pB48
            // 
            this.pB48.Location = new System.Drawing.Point(470, 202);
            this.pB48.Margin = new System.Windows.Forms.Padding(1);
            this.pB48.Name = "pB48";
            this.pB48.Size = new System.Drawing.Size(65, 65);
            this.pB48.TabIndex = 0;
            this.pB48.TabStop = false;
            // 
            // pB51
            // 
            this.pB51.Location = new System.Drawing.Point(1, 269);
            this.pB51.Margin = new System.Windows.Forms.Padding(1);
            this.pB51.Name = "pB51";
            this.pB51.Size = new System.Drawing.Size(65, 65);
            this.pB51.TabIndex = 0;
            this.pB51.TabStop = false;
            // 
            // pB52
            // 
            this.pB52.Location = new System.Drawing.Point(68, 269);
            this.pB52.Margin = new System.Windows.Forms.Padding(1);
            this.pB52.Name = "pB52";
            this.pB52.Size = new System.Drawing.Size(65, 65);
            this.pB52.TabIndex = 0;
            this.pB52.TabStop = false;
            // 
            // pB53
            // 
            this.pB53.Location = new System.Drawing.Point(135, 269);
            this.pB53.Margin = new System.Windows.Forms.Padding(1);
            this.pB53.Name = "pB53";
            this.pB53.Size = new System.Drawing.Size(65, 65);
            this.pB53.TabIndex = 0;
            this.pB53.TabStop = false;
            // 
            // pB54
            // 
            this.pB54.Location = new System.Drawing.Point(202, 269);
            this.pB54.Margin = new System.Windows.Forms.Padding(1);
            this.pB54.Name = "pB54";
            this.pB54.Size = new System.Drawing.Size(65, 65);
            this.pB54.TabIndex = 0;
            this.pB54.TabStop = false;
            // 
            // pB55
            // 
            this.pB55.Location = new System.Drawing.Point(269, 269);
            this.pB55.Margin = new System.Windows.Forms.Padding(1);
            this.pB55.Name = "pB55";
            this.pB55.Size = new System.Drawing.Size(65, 65);
            this.pB55.TabIndex = 0;
            this.pB55.TabStop = false;
            // 
            // pB56
            // 
            this.pB56.Location = new System.Drawing.Point(336, 269);
            this.pB56.Margin = new System.Windows.Forms.Padding(1);
            this.pB56.Name = "pB56";
            this.pB56.Size = new System.Drawing.Size(65, 65);
            this.pB56.TabIndex = 0;
            this.pB56.TabStop = false;
            // 
            // pB57
            // 
            this.pB57.Location = new System.Drawing.Point(403, 269);
            this.pB57.Margin = new System.Windows.Forms.Padding(1);
            this.pB57.Name = "pB57";
            this.pB57.Size = new System.Drawing.Size(65, 65);
            this.pB57.TabIndex = 0;
            this.pB57.TabStop = false;
            // 
            // pB58
            // 
            this.pB58.Location = new System.Drawing.Point(470, 269);
            this.pB58.Margin = new System.Windows.Forms.Padding(1);
            this.pB58.Name = "pB58";
            this.pB58.Size = new System.Drawing.Size(65, 65);
            this.pB58.TabIndex = 0;
            this.pB58.TabStop = false;
            // 
            // pB61
            // 
            this.pB61.Location = new System.Drawing.Point(1, 336);
            this.pB61.Margin = new System.Windows.Forms.Padding(1);
            this.pB61.Name = "pB61";
            this.pB61.Size = new System.Drawing.Size(65, 65);
            this.pB61.TabIndex = 0;
            this.pB61.TabStop = false;
            // 
            // pB62
            // 
            this.pB62.Location = new System.Drawing.Point(68, 336);
            this.pB62.Margin = new System.Windows.Forms.Padding(1);
            this.pB62.Name = "pB62";
            this.pB62.Size = new System.Drawing.Size(65, 65);
            this.pB62.TabIndex = 0;
            this.pB62.TabStop = false;
            // 
            // pB63
            // 
            this.pB63.Location = new System.Drawing.Point(135, 336);
            this.pB63.Margin = new System.Windows.Forms.Padding(1);
            this.pB63.Name = "pB63";
            this.pB63.Size = new System.Drawing.Size(65, 65);
            this.pB63.TabIndex = 0;
            this.pB63.TabStop = false;
            // 
            // pB64
            // 
            this.pB64.Location = new System.Drawing.Point(202, 336);
            this.pB64.Margin = new System.Windows.Forms.Padding(1);
            this.pB64.Name = "pB64";
            this.pB64.Size = new System.Drawing.Size(65, 65);
            this.pB64.TabIndex = 0;
            this.pB64.TabStop = false;
            // 
            // pB65
            // 
            this.pB65.Location = new System.Drawing.Point(269, 336);
            this.pB65.Margin = new System.Windows.Forms.Padding(1);
            this.pB65.Name = "pB65";
            this.pB65.Size = new System.Drawing.Size(65, 65);
            this.pB65.TabIndex = 0;
            this.pB65.TabStop = false;
            // 
            // pB66
            // 
            this.pB66.Location = new System.Drawing.Point(336, 336);
            this.pB66.Margin = new System.Windows.Forms.Padding(1);
            this.pB66.Name = "pB66";
            this.pB66.Size = new System.Drawing.Size(65, 65);
            this.pB66.TabIndex = 0;
            this.pB66.TabStop = false;
            // 
            // pB67
            // 
            this.pB67.Location = new System.Drawing.Point(403, 336);
            this.pB67.Margin = new System.Windows.Forms.Padding(1);
            this.pB67.Name = "pB67";
            this.pB67.Size = new System.Drawing.Size(65, 65);
            this.pB67.TabIndex = 0;
            this.pB67.TabStop = false;
            // 
            // pB68
            // 
            this.pB68.Location = new System.Drawing.Point(470, 336);
            this.pB68.Margin = new System.Windows.Forms.Padding(1);
            this.pB68.Name = "pB68";
            this.pB68.Size = new System.Drawing.Size(65, 65);
            this.pB68.TabIndex = 0;
            this.pB68.TabStop = false;
            // 
            // pB71
            // 
            this.pB71.Location = new System.Drawing.Point(1, 403);
            this.pB71.Margin = new System.Windows.Forms.Padding(1);
            this.pB71.Name = "pB71";
            this.pB71.Size = new System.Drawing.Size(65, 65);
            this.pB71.TabIndex = 0;
            this.pB71.TabStop = false;
            // 
            // pB72
            // 
            this.pB72.Location = new System.Drawing.Point(68, 403);
            this.pB72.Margin = new System.Windows.Forms.Padding(1);
            this.pB72.Name = "pB72";
            this.pB72.Size = new System.Drawing.Size(65, 65);
            this.pB72.TabIndex = 0;
            this.pB72.TabStop = false;
            // 
            // pB73
            // 
            this.pB73.Location = new System.Drawing.Point(135, 403);
            this.pB73.Margin = new System.Windows.Forms.Padding(1);
            this.pB73.Name = "pB73";
            this.pB73.Size = new System.Drawing.Size(65, 65);
            this.pB73.TabIndex = 0;
            this.pB73.TabStop = false;
            // 
            // pB74
            // 
            this.pB74.Location = new System.Drawing.Point(202, 403);
            this.pB74.Margin = new System.Windows.Forms.Padding(1);
            this.pB74.Name = "pB74";
            this.pB74.Size = new System.Drawing.Size(65, 65);
            this.pB74.TabIndex = 0;
            this.pB74.TabStop = false;
            // 
            // pB75
            // 
            this.pB75.Location = new System.Drawing.Point(269, 403);
            this.pB75.Margin = new System.Windows.Forms.Padding(1);
            this.pB75.Name = "pB75";
            this.pB75.Size = new System.Drawing.Size(65, 65);
            this.pB75.TabIndex = 0;
            this.pB75.TabStop = false;
            // 
            // pB76
            // 
            this.pB76.Location = new System.Drawing.Point(336, 403);
            this.pB76.Margin = new System.Windows.Forms.Padding(1);
            this.pB76.Name = "pB76";
            this.pB76.Size = new System.Drawing.Size(65, 65);
            this.pB76.TabIndex = 0;
            this.pB76.TabStop = false;
            // 
            // pB77
            // 
            this.pB77.Location = new System.Drawing.Point(403, 403);
            this.pB77.Margin = new System.Windows.Forms.Padding(1);
            this.pB77.Name = "pB77";
            this.pB77.Size = new System.Drawing.Size(65, 65);
            this.pB77.TabIndex = 0;
            this.pB77.TabStop = false;
            // 
            // pB78
            // 
            this.pB78.Location = new System.Drawing.Point(470, 403);
            this.pB78.Margin = new System.Windows.Forms.Padding(1);
            this.pB78.Name = "pB78";
            this.pB78.Size = new System.Drawing.Size(65, 65);
            this.pB78.TabIndex = 0;
            this.pB78.TabStop = false;
            // 
            // pB81
            // 
            this.pB81.Location = new System.Drawing.Point(1, 470);
            this.pB81.Margin = new System.Windows.Forms.Padding(1);
            this.pB81.Name = "pB81";
            this.pB81.Size = new System.Drawing.Size(65, 65);
            this.pB81.TabIndex = 0;
            this.pB81.TabStop = false;
            // 
            // pB82
            // 
            this.pB82.Location = new System.Drawing.Point(68, 470);
            this.pB82.Margin = new System.Windows.Forms.Padding(1);
            this.pB82.Name = "pB82";
            this.pB82.Size = new System.Drawing.Size(65, 65);
            this.pB82.TabIndex = 0;
            this.pB82.TabStop = false;
            // 
            // pB83
            // 
            this.pB83.Location = new System.Drawing.Point(135, 470);
            this.pB83.Margin = new System.Windows.Forms.Padding(1);
            this.pB83.Name = "pB83";
            this.pB83.Size = new System.Drawing.Size(65, 65);
            this.pB83.TabIndex = 0;
            this.pB83.TabStop = false;
            // 
            // pB84
            // 
            this.pB84.Location = new System.Drawing.Point(202, 470);
            this.pB84.Margin = new System.Windows.Forms.Padding(1);
            this.pB84.Name = "pB84";
            this.pB84.Size = new System.Drawing.Size(65, 65);
            this.pB84.TabIndex = 0;
            this.pB84.TabStop = false;
            // 
            // pB85
            // 
            this.pB85.Location = new System.Drawing.Point(269, 470);
            this.pB85.Margin = new System.Windows.Forms.Padding(1);
            this.pB85.Name = "pB85";
            this.pB85.Size = new System.Drawing.Size(65, 65);
            this.pB85.TabIndex = 0;
            this.pB85.TabStop = false;
            // 
            // pB86
            // 
            this.pB86.Location = new System.Drawing.Point(336, 470);
            this.pB86.Margin = new System.Windows.Forms.Padding(1);
            this.pB86.Name = "pB86";
            this.pB86.Size = new System.Drawing.Size(65, 65);
            this.pB86.TabIndex = 0;
            this.pB86.TabStop = false;
            // 
            // pB87
            // 
            this.pB87.Location = new System.Drawing.Point(403, 470);
            this.pB87.Margin = new System.Windows.Forms.Padding(1);
            this.pB87.Name = "pB87";
            this.pB87.Size = new System.Drawing.Size(65, 65);
            this.pB87.TabIndex = 0;
            this.pB87.TabStop = false;
            // 
            // pB88
            // 
            this.pB88.Location = new System.Drawing.Point(470, 470);
            this.pB88.Margin = new System.Windows.Forms.Padding(1);
            this.pB88.Name = "pB88";
            this.pB88.Size = new System.Drawing.Size(65, 65);
            this.pB88.TabIndex = 0;
            this.pB88.TabStop = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 539);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel5.Size = new System.Drawing.Size(538, 0);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.lbX1);
            this.flowLayoutPanel2.Controls.Add(this.lbX2);
            this.flowLayoutPanel2.Controls.Add(this.lbX3);
            this.flowLayoutPanel2.Controls.Add(this.lbX4);
            this.flowLayoutPanel2.Controls.Add(this.lbX5);
            this.flowLayoutPanel2.Controls.Add(this.lbX6);
            this.flowLayoutPanel2.Controls.Add(this.lbX7);
            this.flowLayoutPanel2.Controls.Add(this.lbX8);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(99, 38);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(478, 18);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.BackColor = System.Drawing.Color.Black;
            this.lbX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbX1.ForeColor = System.Drawing.Color.White;
            this.lbX1.Location = new System.Drawing.Point(0, 0);
            this.lbX1.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(16, 18);
            this.lbX1.TabIndex = 0;
            this.lbX1.Text = "1";
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.BackColor = System.Drawing.Color.Black;
            this.lbX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbX2.ForeColor = System.Drawing.Color.White;
            this.lbX2.Location = new System.Drawing.Point(66, 0);
            this.lbX2.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(16, 18);
            this.lbX2.TabIndex = 0;
            this.lbX2.Text = "2";
            // 
            // lbX3
            // 
            this.lbX3.AutoSize = true;
            this.lbX3.BackColor = System.Drawing.Color.Black;
            this.lbX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbX3.ForeColor = System.Drawing.Color.White;
            this.lbX3.Location = new System.Drawing.Point(132, 0);
            this.lbX3.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lbX3.Name = "lbX3";
            this.lbX3.Size = new System.Drawing.Size(16, 18);
            this.lbX3.TabIndex = 0;
            this.lbX3.Text = "3";
            // 
            // lbX4
            // 
            this.lbX4.AutoSize = true;
            this.lbX4.BackColor = System.Drawing.Color.Black;
            this.lbX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbX4.ForeColor = System.Drawing.Color.White;
            this.lbX4.Location = new System.Drawing.Point(198, 0);
            this.lbX4.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lbX4.Name = "lbX4";
            this.lbX4.Size = new System.Drawing.Size(16, 18);
            this.lbX4.TabIndex = 0;
            this.lbX4.Text = "4";
            // 
            // lbX5
            // 
            this.lbX5.AutoSize = true;
            this.lbX5.BackColor = System.Drawing.Color.Black;
            this.lbX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbX5.ForeColor = System.Drawing.Color.White;
            this.lbX5.Location = new System.Drawing.Point(264, 0);
            this.lbX5.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lbX5.Name = "lbX5";
            this.lbX5.Size = new System.Drawing.Size(16, 18);
            this.lbX5.TabIndex = 0;
            this.lbX5.Text = "5";
            // 
            // lbX6
            // 
            this.lbX6.AutoSize = true;
            this.lbX6.BackColor = System.Drawing.Color.Black;
            this.lbX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbX6.ForeColor = System.Drawing.Color.White;
            this.lbX6.Location = new System.Drawing.Point(330, 0);
            this.lbX6.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lbX6.Name = "lbX6";
            this.lbX6.Size = new System.Drawing.Size(16, 18);
            this.lbX6.TabIndex = 0;
            this.lbX6.Text = "6";
            // 
            // lbX7
            // 
            this.lbX7.AutoSize = true;
            this.lbX7.BackColor = System.Drawing.Color.Black;
            this.lbX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbX7.ForeColor = System.Drawing.Color.White;
            this.lbX7.Location = new System.Drawing.Point(396, 0);
            this.lbX7.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lbX7.Name = "lbX7";
            this.lbX7.Size = new System.Drawing.Size(16, 18);
            this.lbX7.TabIndex = 0;
            this.lbX7.Text = "7";
            // 
            // lbX8
            // 
            this.lbX8.AutoSize = true;
            this.lbX8.BackColor = System.Drawing.Color.Black;
            this.lbX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbX8.ForeColor = System.Drawing.Color.White;
            this.lbX8.Location = new System.Drawing.Point(462, 0);
            this.lbX8.Margin = new System.Windows.Forms.Padding(0);
            this.lbX8.Name = "lbX8";
            this.lbX8.Size = new System.Drawing.Size(16, 18);
            this.lbX8.TabIndex = 0;
            this.lbX8.Text = "8";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lbY1);
            this.flowLayoutPanel1.Controls.Add(this.lbY2);
            this.flowLayoutPanel1.Controls.Add(this.lbY3);
            this.flowLayoutPanel1.Controls.Add(this.lbY4);
            this.flowLayoutPanel1.Controls.Add(this.lbY5);
            this.flowLayoutPanel1.Controls.Add(this.lbY6);
            this.flowLayoutPanel1.Controls.Add(this.lbY7);
            this.flowLayoutPanel1.Controls.Add(this.lbY8);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(16, 494);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lbY1
            // 
            this.lbY1.AutoSize = true;
            this.lbY1.BackColor = System.Drawing.Color.Black;
            this.lbY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbY1.ForeColor = System.Drawing.Color.White;
            this.lbY1.Location = new System.Drawing.Point(0, 0);
            this.lbY1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lbY1.Name = "lbY1";
            this.lbY1.Size = new System.Drawing.Size(16, 18);
            this.lbY1.TabIndex = 0;
            this.lbY1.Text = "1";
            // 
            // lbY2
            // 
            this.lbY2.AutoSize = true;
            this.lbY2.BackColor = System.Drawing.Color.Black;
            this.lbY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbY2.ForeColor = System.Drawing.Color.White;
            this.lbY2.Location = new System.Drawing.Point(0, 68);
            this.lbY2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lbY2.Name = "lbY2";
            this.lbY2.Size = new System.Drawing.Size(16, 18);
            this.lbY2.TabIndex = 0;
            this.lbY2.Text = "2";
            // 
            // lbY3
            // 
            this.lbY3.AutoSize = true;
            this.lbY3.BackColor = System.Drawing.Color.Black;
            this.lbY3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbY3.ForeColor = System.Drawing.Color.White;
            this.lbY3.Location = new System.Drawing.Point(0, 136);
            this.lbY3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lbY3.Name = "lbY3";
            this.lbY3.Size = new System.Drawing.Size(16, 18);
            this.lbY3.TabIndex = 0;
            this.lbY3.Text = "3";
            // 
            // lbY4
            // 
            this.lbY4.AutoSize = true;
            this.lbY4.BackColor = System.Drawing.Color.Black;
            this.lbY4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbY4.ForeColor = System.Drawing.Color.White;
            this.lbY4.Location = new System.Drawing.Point(0, 204);
            this.lbY4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lbY4.Name = "lbY4";
            this.lbY4.Size = new System.Drawing.Size(16, 18);
            this.lbY4.TabIndex = 0;
            this.lbY4.Text = "4";
            // 
            // lbY5
            // 
            this.lbY5.AutoSize = true;
            this.lbY5.BackColor = System.Drawing.Color.Black;
            this.lbY5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbY5.ForeColor = System.Drawing.Color.White;
            this.lbY5.Location = new System.Drawing.Point(0, 272);
            this.lbY5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lbY5.Name = "lbY5";
            this.lbY5.Size = new System.Drawing.Size(16, 18);
            this.lbY5.TabIndex = 0;
            this.lbY5.Text = "5";
            // 
            // lbY6
            // 
            this.lbY6.AutoSize = true;
            this.lbY6.BackColor = System.Drawing.Color.Black;
            this.lbY6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbY6.ForeColor = System.Drawing.Color.White;
            this.lbY6.Location = new System.Drawing.Point(0, 340);
            this.lbY6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lbY6.Name = "lbY6";
            this.lbY6.Size = new System.Drawing.Size(16, 18);
            this.lbY6.TabIndex = 0;
            this.lbY6.Text = "6";
            // 
            // lbY7
            // 
            this.lbY7.AutoSize = true;
            this.lbY7.BackColor = System.Drawing.Color.Black;
            this.lbY7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbY7.ForeColor = System.Drawing.Color.White;
            this.lbY7.Location = new System.Drawing.Point(0, 408);
            this.lbY7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lbY7.Name = "lbY7";
            this.lbY7.Size = new System.Drawing.Size(16, 18);
            this.lbY7.TabIndex = 0;
            this.lbY7.Text = "7";
            // 
            // lbY8
            // 
            this.lbY8.AutoSize = true;
            this.lbY8.BackColor = System.Drawing.Color.Black;
            this.lbY8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbY8.ForeColor = System.Drawing.Color.White;
            this.lbY8.Location = new System.Drawing.Point(0, 476);
            this.lbY8.Margin = new System.Windows.Forms.Padding(0);
            this.lbY8.Name = "lbY8";
            this.lbY8.Size = new System.Drawing.Size(16, 18);
            this.lbY8.TabIndex = 0;
            this.lbY8.Text = "8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(403, 208);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(336, 208);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(269, 208);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 65);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(202, 208);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 65);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(135, 208);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 65);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Location = new System.Drawing.Point(68, 208);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(65, 65);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Location = new System.Drawing.Point(1, 208);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(65, 65);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1134, 711);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N Quân Hậu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberNQueen)).EndInit();
            this.grBAnswer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.fpnlChess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB88)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private GroupBox grBAnswer;
        private RichTextBox rtxtAnswer;
        private Button btnInputNQueen;
        private Button btnExit;
        private Button btnStart;
        private Button btnResetSetting;
        private Panel panel6;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;

        private FlowLayoutPanel flowLayoutPanel4;
        private NumericUpDown numberNQueen;

        private FlowLayoutPanel fpnlChess;

        private Label lbX1;
        private Label lbX2;
        private Label lbX3;
        private Label lbX4;
        private Label lbX5;
        private Label lbX6;
        private Label lbX7;
        private Label lbX8;
        private Label lbY1;
        private Label lbY2;
        private Label lbY3;
        private Label lbY4;
        private Label lbY5;
        private Label lbY6;
        private Label lbY7;
        private Label lbY8;


        private PictureBox pB11;
        private PictureBox pB12;
        private PictureBox pB13;
        private PictureBox pB14;
        private PictureBox pB15;
        private PictureBox pB16;
        private PictureBox pB17;
        private PictureBox pB18;

        private PictureBox pB21;
        private PictureBox pB22;
        private PictureBox pB23;
        private PictureBox pB24;
        private PictureBox pB25;
        private PictureBox pB26;
        private PictureBox pB27;
        private PictureBox pB28;

        private PictureBox pB31;
        private PictureBox pB32;
        private PictureBox pB33;
        private PictureBox pB34;
        private PictureBox pB35;
        private PictureBox pB36;
        private PictureBox pB37;
        private PictureBox pB38;

        private PictureBox pB41;
        private PictureBox pB42;
        private PictureBox pB43;
        private PictureBox pB44;
        private PictureBox pB45;
        private PictureBox pB46;
        private PictureBox pB47;
        private PictureBox pB48;

        private PictureBox pB51;
        private PictureBox pB52;
        private PictureBox pB53;
        private PictureBox pB54;
        private PictureBox pB55;
        private PictureBox pB56;
        private PictureBox pB57;
        private PictureBox pB58;

        private PictureBox pB61;
        private PictureBox pB62;
        private PictureBox pB63;
        private PictureBox pB64;
        private PictureBox pB65;
        private PictureBox pB66;
        private PictureBox pB67;
        private PictureBox pB68;

        private PictureBox pB71;
        private PictureBox pB72;
        private PictureBox pB73;
        private PictureBox pB74;
        private PictureBox pB75;
        private PictureBox pB76;
        private PictureBox pB77;
        private PictureBox pB78;

        private PictureBox pB81;
        private PictureBox pB82;
        private PictureBox pB83;
        private PictureBox pB84;
        private PictureBox pB85;
        private PictureBox pB86;
        private PictureBox pB87;
        private PictureBox pB88;
        private FlowLayoutPanel flowLayoutPanel5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}



