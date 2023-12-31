﻿using CustomControls;

namespace PBL3
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.swapWordAnim = new System.Windows.Forms.Timer(this.components);
            this.sugWordLeftAnim = new System.Windows.Forms.Timer(this.components);
            this.sugWordRightAnim = new System.Windows.Forms.Timer(this.components);
            this.rjPanel5 = new CustomControls.RJPanel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.txtWord = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rjPanel2 = new CustomControls.RJPanel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.txtHour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjPanel3 = new CustomControls.RJPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.Label();
            this.rjPanel8 = new CustomControls.RJPanel();
            this.iconPercent = new FontAwesome.Sharp.IconButton();
            this.btnSetGoal = new FontAwesome.Sharp.IconButton();
            this.rjPanel9 = new CustomControls.RJPanel();
            this.lblGoal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.rjPanel6 = new CustomControls.RJPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSugWord = new CustomControls.RJButton();
            this.btnBackward = new FontAwesome.Sharp.IconButton();
            this.btnForward = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rjPanel1 = new CustomControls.RJPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelNotebook = new System.Windows.Forms.FlowLayoutPanel();
            this.rjButton1 = new CustomControls.RJButton();
            this.rjButton2 = new CustomControls.RJButton();
            this.rjButton3 = new CustomControls.RJButton();
            this.rjButton5 = new CustomControls.RJButton();
            this.rjButton4 = new CustomControls.RJButton();
            this.rjButton7 = new CustomControls.RJButton();
            this.rjButton8 = new CustomControls.RJButton();
            this.rjButton9 = new CustomControls.RJButton();
            this.rjButton6 = new CustomControls.RJButton();
            this.updateGoalTick = new System.Windows.Forms.Timer(this.components);
            this.rjPanel5.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            this.rjPanel3.SuspendLayout();
            this.rjPanel8.SuspendLayout();
            this.rjPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.panelNotebook.SuspendLayout();
            this.SuspendLayout();
            // 
            // swapWordAnim
            // 
            this.swapWordAnim.Enabled = true;
            this.swapWordAnim.Interval = 10000;
            this.swapWordAnim.Tick += new System.EventHandler(this.swapWordAnim_Tick);
            // 
            // sugWordLeftAnim
            // 
            this.sugWordLeftAnim.Interval = 1;
            this.sugWordLeftAnim.Tick += new System.EventHandler(this.sugWordLeftAnim_Tick);
            // 
            // sugWordRightAnim
            // 
            this.sugWordRightAnim.Interval = 1;
            this.sugWordRightAnim.Tick += new System.EventHandler(this.sugWordRightAnim_Tick);
            // 
            // rjPanel5
            // 
            this.rjPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rjPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel5.BorderRadius = 30;
            this.rjPanel5.Controls.Add(this.iconButton7);
            this.rjPanel5.Controls.Add(this.txtWord);
            this.rjPanel5.Controls.Add(this.label5);
            this.rjPanel5.ForeColor = System.Drawing.Color.Black;
            this.rjPanel5.GradientAngle = 45F;
            this.rjPanel5.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel5.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel5.Location = new System.Drawing.Point(423, 17);
            this.rjPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel5.Name = "rjPanel5";
            this.rjPanel5.Size = new System.Drawing.Size(175, 121);
            this.rjPanel5.TabIndex = 35;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.Transparent;
            this.iconButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton7.IconSize = 50;
            this.iconButton7.Location = new System.Drawing.Point(8, 28);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(64, 70);
            this.iconButton7.TabIndex = 8;
            this.iconButton7.TabStop = false;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // txtWord
            // 
            this.txtWord.AutoSize = true;
            this.txtWord.BackColor = System.Drawing.Color.Transparent;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.txtWord.Location = new System.Drawing.Point(64, 62);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(69, 36);
            this.txtWord.TabIndex = 7;
            this.txtWord.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(67, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Từ Đã Học";
            // 
            // rjPanel2
            // 
            this.rjPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel2.BorderRadius = 30;
            this.rjPanel2.Controls.Add(this.iconButton6);
            this.rjPanel2.Controls.Add(this.txtHour);
            this.rjPanel2.Controls.Add(this.label1);
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.GradientAngle = 45F;
            this.rjPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel2.Location = new System.Drawing.Point(228, 17);
            this.rjPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(175, 121);
            this.rjPanel2.TabIndex = 34;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.Transparent;
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton6.IconSize = 50;
            this.iconButton6.Location = new System.Drawing.Point(11, 28);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(64, 70);
            this.iconButton6.TabIndex = 8;
            this.iconButton6.TabStop = false;
            this.iconButton6.Text = "`";
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // txtHour
            // 
            this.txtHour.AutoSize = true;
            this.txtHour.BackColor = System.Drawing.Color.Transparent;
            this.txtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.txtHour.Location = new System.Drawing.Point(67, 62);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(51, 36);
            this.txtHour.TabIndex = 7;
            this.txtHour.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(69, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số Giờ Học";
            // 
            // rjPanel3
            // 
            this.rjPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rjPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel3.BorderRadius = 30;
            this.rjPanel3.Controls.Add(this.iconButton1);
            this.rjPanel3.Controls.Add(this.label9);
            this.rjPanel3.Controls.Add(this.txtDay);
            this.rjPanel3.ForeColor = System.Drawing.Color.Black;
            this.rjPanel3.GradientAngle = 45F;
            this.rjPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel3.Location = new System.Drawing.Point(29, 17);
            this.rjPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(175, 121);
            this.rjPanel3.TabIndex = 33;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 50;
            this.iconButton1.Location = new System.Drawing.Point(5, 34);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(59, 57);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.TabStop = false;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label9.Location = new System.Drawing.Point(71, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 48);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số Ngày Học\r\nLiên Tiếp";
            // 
            // txtDay
            // 
            this.txtDay.AutoSize = true;
            this.txtDay.BackColor = System.Drawing.Color.Transparent;
            this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.txtDay.Location = new System.Drawing.Point(68, 62);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(33, 36);
            this.txtDay.TabIndex = 4;
            this.txtDay.Text = "1";
            // 
            // rjPanel8
            // 
            this.rjPanel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rjPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel8.BorderRadius = 30;
            this.rjPanel8.Controls.Add(this.iconPercent);
            this.rjPanel8.Controls.Add(this.btnSetGoal);
            this.rjPanel8.Controls.Add(this.rjPanel9);
            this.rjPanel8.Controls.Add(this.lblGoal);
            this.rjPanel8.Controls.Add(this.label17);
            this.rjPanel8.Controls.Add(this.label22);
            this.rjPanel8.Controls.Add(this.label19);
            this.rjPanel8.Controls.Add(this.lblCurrent);
            this.rjPanel8.Controls.Add(this.label20);
            this.rjPanel8.Controls.Add(this.progressBar);
            this.rjPanel8.ForeColor = System.Drawing.Color.Black;
            this.rjPanel8.GradientAngle = 90F;
            this.rjPanel8.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel8.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel8.Location = new System.Drawing.Point(619, 215);
            this.rjPanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel8.Name = "rjPanel8";
            this.rjPanel8.Size = new System.Drawing.Size(415, 241);
            this.rjPanel8.TabIndex = 33;
            // 
            // iconPercent
            // 
            this.iconPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconPercent.FlatAppearance.BorderSize = 0;
            this.iconPercent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconPercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPercent.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.iconPercent.IconChar = FontAwesome.Sharp.IconChar.Fire;
            this.iconPercent.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.iconPercent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPercent.Location = new System.Drawing.Point(71, 78);
            this.iconPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPercent.Name = "iconPercent";
            this.iconPercent.Size = new System.Drawing.Size(109, 94);
            this.iconPercent.TabIndex = 43;
            this.iconPercent.Text = "75%";
            this.iconPercent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconPercent.UseVisualStyleBackColor = false;
            // 
            // btnSetGoal
            // 
            this.btnSetGoal.BackColor = System.Drawing.Color.Transparent;
            this.btnSetGoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetGoal.FlatAppearance.BorderSize = 0;
            this.btnSetGoal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetGoal.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.btnSetGoal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSetGoal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSetGoal.IconSize = 30;
            this.btnSetGoal.Location = new System.Drawing.Point(359, 25);
            this.btnSetGoal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetGoal.Name = "btnSetGoal";
            this.btnSetGoal.Size = new System.Drawing.Size(35, 31);
            this.btnSetGoal.TabIndex = 33;
            this.btnSetGoal.TabStop = false;
            this.btnSetGoal.UseVisualStyleBackColor = false;
            this.btnSetGoal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSetGoal_MouseClick);
            // 
            // rjPanel9
            // 
            this.rjPanel9.BackColor = System.Drawing.Color.White;
            this.rjPanel9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjPanel9.BorderRadius = 10;
            this.rjPanel9.ForeColor = System.Drawing.Color.Black;
            this.rjPanel9.GradientAngle = 0F;
            this.rjPanel9.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel9.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.rjPanel9.Location = new System.Drawing.Point(249, 127);
            this.rjPanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel9.Name = "rjPanel9";
            this.rjPanel9.Size = new System.Drawing.Size(96, 10);
            this.rjPanel9.TabIndex = 14;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.BackColor = System.Drawing.Color.Transparent;
            this.lblGoal.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.lblGoal.Location = new System.Drawing.Point(243, 176);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(57, 36);
            this.lblGoal.TabIndex = 40;
            this.lblGoal.Text = "120";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label17.Location = new System.Drawing.Point(316, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 24);
            this.label17.TabIndex = 41;
            this.label17.Text = "Phút";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label22.Location = new System.Drawing.Point(245, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 24);
            this.label22.TabIndex = 36;
            this.label22.Text = "Đã Học Được:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label19.Location = new System.Drawing.Point(245, 153);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 24);
            this.label19.TabIndex = 39;
            this.label19.Text = "Mục Tiêu:";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.lblCurrent.Location = new System.Drawing.Point(243, 78);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(47, 36);
            this.lblCurrent.TabIndex = 35;
            this.lblCurrent.Text = "90";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label20.Location = new System.Drawing.Point(316, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 24);
            this.label20.TabIndex = 38;
            this.label20.Text = "Phút";
            // 
            // progressBar
            // 
            this.progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.progressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.progressBar.InnerMargin = 2;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(21, 25);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.progressBar.OuterMargin = -20;
            this.progressBar.OuterWidth = 20;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.progressBar.ProgressWidth = 20;
            this.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBar.Size = new System.Drawing.Size(200, 199);
            this.progressBar.StartAngle = 270;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar.SubscriptText = ".23";
            this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "°C";
            this.progressBar.TabIndex = 37;
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBar.Value = 75;
            // 
            // rjPanel6
            // 
            this.rjPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rjPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel6.BorderRadius = 30;
            this.rjPanel6.Controls.Add(this.panel1);
            this.rjPanel6.Controls.Add(this.btnBackward);
            this.rjPanel6.Controls.Add(this.btnForward);
            this.rjPanel6.Controls.Add(this.label8);
            this.rjPanel6.ForeColor = System.Drawing.Color.Black;
            this.rjPanel6.GradientAngle = 90F;
            this.rjPanel6.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel6.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel6.Location = new System.Drawing.Point(619, 17);
            this.rjPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel6.Name = "rjPanel6";
            this.rjPanel6.Size = new System.Drawing.Size(415, 176);
            this.rjPanel6.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.btnSugWord);
            this.panel1.Location = new System.Drawing.Point(19, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 103);
            this.panel1.TabIndex = 33;
            // 
            // btnSugWord
            // 
            this.btnSugWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.btnSugWord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.btnSugWord.BackgroundImage = global::PBL3.Properties.Resources.Theme4;
            this.btnSugWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSugWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.btnSugWord.BorderRadius = 20;
            this.btnSugWord.BorderSize = 0;
            this.btnSugWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSugWord.FlatAppearance.BorderSize = 0;
            this.btnSugWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSugWord.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSugWord.ForeColor = System.Drawing.Color.White;
            this.btnSugWord.Location = new System.Drawing.Point(0, 0);
            this.btnSugWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSugWord.Name = "btnSugWord";
            this.btnSugWord.Size = new System.Drawing.Size(377, 103);
            this.btnSugWord.TabIndex = 31;
            this.btnSugWord.TabStop = false;
            this.btnSugWord.Text = "SIMULTANEOUS\r\n";
            this.btnSugWord.TextColor = System.Drawing.Color.White;
            this.btnSugWord.UseVisualStyleBackColor = false;
            this.btnSugWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSugWord_MouseClick);
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.Color.Transparent;
            this.btnBackward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackward.FlatAppearance.BorderSize = 0;
            this.btnBackward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackward.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnBackward.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnBackward.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBackward.IconSize = 30;
            this.btnBackward.Location = new System.Drawing.Point(320, 26);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(35, 31);
            this.btnBackward.TabIndex = 32;
            this.btnBackward.TabStop = false;
            this.btnBackward.UseVisualStyleBackColor = false;
            this.btnBackward.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBackward_MouseClick);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnForward.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnForward.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnForward.IconSize = 30;
            this.btnForward.Location = new System.Drawing.Point(359, 26);
            this.btnForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(35, 31);
            this.btnForward.TabIndex = 29;
            this.btnForward.TabStop = false;
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label8.Location = new System.Drawing.Point(25, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "TỪ VỰNG HẰNG NGÀY";
            // 
            // rjPanel1
            // 
            this.rjPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.label7);
            this.rjPanel1.Controls.Add(this.panelNotebook);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 0F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel1.Location = new System.Drawing.Point(29, 158);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(569, 298);
            this.rjPanel1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label7.Location = new System.Drawing.Point(28, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "ÔN TẬP TỪ VỰNG";
            // 
            // panelNotebook
            // 
            this.panelNotebook.AutoScroll = true;
            this.panelNotebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panelNotebook.Controls.Add(this.rjButton1);
            this.panelNotebook.Controls.Add(this.rjButton2);
            this.panelNotebook.Controls.Add(this.rjButton3);
            this.panelNotebook.Controls.Add(this.rjButton5);
            this.panelNotebook.Controls.Add(this.rjButton4);
            this.panelNotebook.Controls.Add(this.rjButton7);
            this.panelNotebook.Controls.Add(this.rjButton8);
            this.panelNotebook.Controls.Add(this.rjButton9);
            this.panelNotebook.Controls.Add(this.rjButton6);
            this.panelNotebook.Location = new System.Drawing.Point(29, 54);
            this.panelNotebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNotebook.Name = "panelNotebook";
            this.panelNotebook.Size = new System.Drawing.Size(511, 222);
            this.panelNotebook.TabIndex = 15;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton1.BackgroundImage")));
            this.rjButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton1.Location = new System.Drawing.Point(3, 2);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(149, 100);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.TabStop = false;
            this.rjButton1.Text = "Word";
            this.rjButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton2.BackgroundImage")));
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton2.Location = new System.Drawing.Point(158, 2);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(149, 100);
            this.rjButton2.TabIndex = 1;
            this.rjButton2.TabStop = false;
            this.rjButton2.Text = "Word";
            this.rjButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton3.BackgroundImage")));
            this.rjButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton3.Location = new System.Drawing.Point(313, 2);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(149, 100);
            this.rjButton3.TabIndex = 2;
            this.rjButton3.TabStop = false;
            this.rjButton3.Text = "Word";
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton5.BackgroundImage")));
            this.rjButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 20;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton5.Location = new System.Drawing.Point(3, 106);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(149, 100);
            this.rjButton5.TabIndex = 4;
            this.rjButton5.TabStop = false;
            this.rjButton5.Text = "Word";
            this.rjButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton5.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton4.BackgroundImage")));
            this.rjButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 20;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton4.Location = new System.Drawing.Point(158, 106);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(149, 100);
            this.rjButton4.TabIndex = 3;
            this.rjButton4.TabStop = false;
            this.rjButton4.Text = "Word";
            this.rjButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton7
            // 
            this.rjButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton7.BackgroundImage")));
            this.rjButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton7.BorderRadius = 20;
            this.rjButton7.BorderSize = 0;
            this.rjButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton7.FlatAppearance.BorderSize = 0;
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton7.Location = new System.Drawing.Point(313, 106);
            this.rjButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(149, 100);
            this.rjButton7.TabIndex = 6;
            this.rjButton7.TabStop = false;
            this.rjButton7.Text = "Word";
            this.rjButton7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton7.UseVisualStyleBackColor = false;
            // 
            // rjButton8
            // 
            this.rjButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton8.BackgroundImage")));
            this.rjButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton8.BorderRadius = 20;
            this.rjButton8.BorderSize = 0;
            this.rjButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton8.FlatAppearance.BorderSize = 0;
            this.rjButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton8.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton8.Location = new System.Drawing.Point(3, 210);
            this.rjButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Size = new System.Drawing.Size(149, 100);
            this.rjButton8.TabIndex = 7;
            this.rjButton8.TabStop = false;
            this.rjButton8.Text = "Word";
            this.rjButton8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton8.UseVisualStyleBackColor = false;
            // 
            // rjButton9
            // 
            this.rjButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton9.BackgroundImage")));
            this.rjButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton9.BorderRadius = 20;
            this.rjButton9.BorderSize = 0;
            this.rjButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton9.FlatAppearance.BorderSize = 0;
            this.rjButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton9.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton9.Location = new System.Drawing.Point(158, 210);
            this.rjButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton9.Name = "rjButton9";
            this.rjButton9.Size = new System.Drawing.Size(149, 100);
            this.rjButton9.TabIndex = 8;
            this.rjButton9.TabStop = false;
            this.rjButton9.Text = "Word";
            this.rjButton9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton9.UseVisualStyleBackColor = false;
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.rjButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton6.BackgroundImage")));
            this.rjButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 20;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton6.Location = new System.Drawing.Point(313, 210);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(149, 100);
            this.rjButton6.TabIndex = 5;
            this.rjButton6.TabStop = false;
            this.rjButton6.Text = "Word";
            this.rjButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton6.UseVisualStyleBackColor = false;
            // 
            // updateGoalTick
            // 
            this.updateGoalTick.Enabled = true;
            this.updateGoalTick.Interval = 60000;
            this.updateGoalTick.Tick += new System.EventHandler(this.updateGoalTick_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.rjPanel5);
            this.Controls.Add(this.rjPanel2);
            this.Controls.Add(this.rjPanel3);
            this.Controls.Add(this.rjPanel8);
            this.Controls.Add(this.rjPanel6);
            this.Controls.Add(this.rjPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.VisibleChanged += new System.EventHandler(this.FormHome_VisibleChanged);
            this.rjPanel5.ResumeLayout(false);
            this.rjPanel5.PerformLayout();
            this.rjPanel2.ResumeLayout(false);
            this.rjPanel2.PerformLayout();
            this.rjPanel3.ResumeLayout(false);
            this.rjPanel3.PerformLayout();
            this.rjPanel8.ResumeLayout(false);
            this.rjPanel8.PerformLayout();
            this.rjPanel6.ResumeLayout(false);
            this.rjPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.panelNotebook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RJPanel rjPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelNotebook;
        private RJPanel rjPanel6;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJButton rjButton1;
        private CustomControls.RJButton rjButton2;
        private CustomControls.RJButton rjButton3;
        private CustomControls.RJButton rjButton4;
        private CustomControls.RJButton rjButton5;
        private CustomControls.RJButton rjButton6;
        private CustomControls.RJButton rjButton7;
        private CustomControls.RJButton rjButton8;
        private CustomControls.RJButton rjButton9;
        private CustomControls.RJButton btnSugWord;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnBackward;
        private FontAwesome.Sharp.IconButton btnForward;
        private RJPanel rjPanel8;
        private RJPanel rjPanel9;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label label17;
        private CircularProgressBar.CircularProgressBar progressBar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label label20;
        private RJPanel rjPanel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtDay;
        private RJPanel rjPanel2;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Label txtHour;
        private System.Windows.Forms.Label label1;
        private RJPanel rjPanel5;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.Label txtWord;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnSetGoal;
        private System.Windows.Forms.Timer swapWordAnim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer sugWordLeftAnim;
        private System.Windows.Forms.Timer sugWordRightAnim;
        private FontAwesome.Sharp.IconButton iconPercent;
        private System.Windows.Forms.Timer updateGoalTick;
    }
}