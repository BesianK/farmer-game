namespace FarmerGameGUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNorthBank = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.radBtnFox = new System.Windows.Forms.RadioButton();
            this.radBtnChicken = new System.Windows.Forms.RadioButton();
            this.radBtnGrain = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnNothing = new System.Windows.Forms.RadioButton();
            this.picFarmerNorth = new System.Windows.Forms.PictureBox();
            this.picChickenNorthPic = new System.Windows.Forms.PictureBox();
            this.picFoxNorth = new System.Windows.Forms.PictureBox();
            this.picGrainNorth = new System.Windows.Forms.PictureBox();
            this.picFarmerSouth = new System.Windows.Forms.PictureBox();
            this.picChickenSouth = new System.Windows.Forms.PictureBox();
            this.picGrainSouth = new System.Windows.Forms.PictureBox();
            this.picFoxSouth = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFarmerNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChickenNorthPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoxNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrainNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFarmerSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChickenSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrainSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoxSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instructionsToolStripMenuItem.Text = "&Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.InstructionsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "I&nfo";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // lblNorthBank
            // 
            this.lblNorthBank.AutoSize = true;
            this.lblNorthBank.BackColor = System.Drawing.Color.Transparent;
            this.lblNorthBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorthBank.ForeColor = System.Drawing.Color.White;
            this.lblNorthBank.Location = new System.Drawing.Point(202, 32);
            this.lblNorthBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNorthBank.Name = "lblNorthBank";
            this.lblNorthBank.Size = new System.Drawing.Size(119, 25);
            this.lblNorthBank.TabIndex = 0;
            this.lblNorthBank.Text = "North Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "South Bank";
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Transparent;
            this.btnMove.Location = new System.Drawing.Point(222, 218);
            this.btnMove.Margin = new System.Windows.Forms.Padding(2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(78, 27);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "&MOVE IT";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // radBtnFox
            // 
            this.radBtnFox.AutoSize = true;
            this.radBtnFox.Location = new System.Drawing.Point(10, 21);
            this.radBtnFox.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnFox.Name = "radBtnFox";
            this.radBtnFox.Size = new System.Drawing.Size(42, 17);
            this.radBtnFox.TabIndex = 2;
            this.radBtnFox.TabStop = true;
            this.radBtnFox.Text = "Fox";
            this.radBtnFox.UseVisualStyleBackColor = true;
            // 
            // radBtnChicken
            // 
            this.radBtnChicken.AutoSize = true;
            this.radBtnChicken.Location = new System.Drawing.Point(52, 21);
            this.radBtnChicken.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnChicken.Name = "radBtnChicken";
            this.radBtnChicken.Size = new System.Drawing.Size(64, 17);
            this.radBtnChicken.TabIndex = 3;
            this.radBtnChicken.TabStop = true;
            this.radBtnChicken.Text = "Chicken";
            this.radBtnChicken.UseVisualStyleBackColor = true;
            // 
            // radBtnGrain
            // 
            this.radBtnGrain.AutoSize = true;
            this.radBtnGrain.Location = new System.Drawing.Point(116, 21);
            this.radBtnGrain.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnGrain.Name = "radBtnGrain";
            this.radBtnGrain.Size = new System.Drawing.Size(50, 17);
            this.radBtnGrain.TabIndex = 4;
            this.radBtnGrain.TabStop = true;
            this.radBtnGrain.Text = "Grain";
            this.radBtnGrain.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radBtnNothing);
            this.groupBox1.Controls.Add(this.radBtnFox);
            this.groupBox1.Controls.Add(this.radBtnChicken);
            this.groupBox1.Controls.Add(this.radBtnGrain);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(144, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(232, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select to Move";
            // 
            // radBtnNothing
            // 
            this.radBtnNothing.AutoSize = true;
            this.radBtnNothing.Location = new System.Drawing.Point(166, 21);
            this.radBtnNothing.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnNothing.Name = "radBtnNothing";
            this.radBtnNothing.Size = new System.Drawing.Size(62, 17);
            this.radBtnNothing.TabIndex = 5;
            this.radBtnNothing.TabStop = true;
            this.radBtnNothing.Text = "Nothing";
            this.radBtnNothing.UseVisualStyleBackColor = true;
            // 
            // picFarmerNorth
            // 
            this.picFarmerNorth.BackColor = System.Drawing.Color.Transparent;
            this.picFarmerNorth.Image = ((System.Drawing.Image)(resources.GetObject("picFarmerNorth.Image")));
            this.picFarmerNorth.Location = new System.Drawing.Point(196, 44);
            this.picFarmerNorth.Margin = new System.Windows.Forms.Padding(2);
            this.picFarmerNorth.Name = "picFarmerNorth";
            this.picFarmerNorth.Size = new System.Drawing.Size(87, 96);
            this.picFarmerNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFarmerNorth.TabIndex = 15;
            this.picFarmerNorth.TabStop = false;
            // 
            // picChickenNorthPic
            // 
            this.picChickenNorthPic.BackColor = System.Drawing.Color.Transparent;
            this.picChickenNorthPic.Image = ((System.Drawing.Image)(resources.GetObject("picChickenNorthPic.Image")));
            this.picChickenNorthPic.Location = new System.Drawing.Point(136, 48);
            this.picChickenNorthPic.Margin = new System.Windows.Forms.Padding(2);
            this.picChickenNorthPic.Name = "picChickenNorthPic";
            this.picChickenNorthPic.Size = new System.Drawing.Size(56, 58);
            this.picChickenNorthPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChickenNorthPic.TabIndex = 16;
            this.picChickenNorthPic.TabStop = false;
            // 
            // picFoxNorth
            // 
            this.picFoxNorth.BackColor = System.Drawing.Color.Transparent;
            this.picFoxNorth.Image = ((System.Drawing.Image)(resources.GetObject("picFoxNorth.Image")));
            this.picFoxNorth.Location = new System.Drawing.Point(286, 84);
            this.picFoxNorth.Margin = new System.Windows.Forms.Padding(2);
            this.picFoxNorth.Name = "picFoxNorth";
            this.picFoxNorth.Size = new System.Drawing.Size(62, 57);
            this.picFoxNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoxNorth.TabIndex = 17;
            this.picFoxNorth.TabStop = false;
            // 
            // picGrainNorth
            // 
            this.picGrainNorth.BackColor = System.Drawing.Color.Transparent;
            this.picGrainNorth.Image = ((System.Drawing.Image)(resources.GetObject("picGrainNorth.Image")));
            this.picGrainNorth.Location = new System.Drawing.Point(351, 110);
            this.picGrainNorth.Margin = new System.Windows.Forms.Padding(2);
            this.picGrainNorth.Name = "picGrainNorth";
            this.picGrainNorth.Size = new System.Drawing.Size(50, 53);
            this.picGrainNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrainNorth.TabIndex = 18;
            this.picGrainNorth.TabStop = false;
            // 
            // picFarmerSouth
            // 
            this.picFarmerSouth.BackColor = System.Drawing.Color.Transparent;
            this.picFarmerSouth.Image = ((System.Drawing.Image)(resources.GetObject("picFarmerSouth.Image")));
            this.picFarmerSouth.Location = new System.Drawing.Point(185, 248);
            this.picFarmerSouth.Margin = new System.Windows.Forms.Padding(2);
            this.picFarmerSouth.Name = "picFarmerSouth";
            this.picFarmerSouth.Size = new System.Drawing.Size(87, 96);
            this.picFarmerSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFarmerSouth.TabIndex = 19;
            this.picFarmerSouth.TabStop = false;
            // 
            // picChickenSouth
            // 
            this.picChickenSouth.BackColor = System.Drawing.Color.Transparent;
            this.picChickenSouth.Image = ((System.Drawing.Image)(resources.GetObject("picChickenSouth.Image")));
            this.picChickenSouth.Location = new System.Drawing.Point(326, 312);
            this.picChickenSouth.Margin = new System.Windows.Forms.Padding(2);
            this.picChickenSouth.Name = "picChickenSouth";
            this.picChickenSouth.Size = new System.Drawing.Size(56, 58);
            this.picChickenSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChickenSouth.TabIndex = 20;
            this.picChickenSouth.TabStop = false;
            // 
            // picGrainSouth
            // 
            this.picGrainSouth.BackColor = System.Drawing.Color.Transparent;
            this.picGrainSouth.Image = ((System.Drawing.Image)(resources.GetObject("picGrainSouth.Image")));
            this.picGrainSouth.Location = new System.Drawing.Point(122, 311);
            this.picGrainSouth.Margin = new System.Windows.Forms.Padding(2);
            this.picGrainSouth.Name = "picGrainSouth";
            this.picGrainSouth.Size = new System.Drawing.Size(50, 53);
            this.picGrainSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrainSouth.TabIndex = 21;
            this.picGrainSouth.TabStop = false;
            // 
            // picFoxSouth
            // 
            this.picFoxSouth.BackColor = System.Drawing.Color.Transparent;
            this.picFoxSouth.Image = ((System.Drawing.Image)(resources.GetObject("picFoxSouth.Image")));
            this.picFoxSouth.Location = new System.Drawing.Point(48, 243);
            this.picFoxSouth.Margin = new System.Windows.Forms.Padding(2);
            this.picFoxSouth.Name = "picFoxSouth";
            this.picFoxSouth.Size = new System.Drawing.Size(62, 57);
            this.picFoxSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoxSouth.TabIndex = 22;
            this.picFoxSouth.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(222, 218);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 27);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "&RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 413);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "BESIAN\'S FARM SIMULATOR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(122, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 57);
            this.button1.TabIndex = 26;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NewGame);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(122, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 57);
            this.button2.TabIndex = 27;
            this.button2.Text = "Info";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.MenuInfo);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(122, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 57);
            this.button3.TabIndex = 28;
            this.button3.Text = "Game Instructions";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.MenuInstructions);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 410);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picFoxSouth);
            this.Controls.Add(this.picGrainSouth);
            this.Controls.Add(this.picChickenSouth);
            this.Controls.Add(this.picFarmerSouth);
            this.Controls.Add(this.picGrainNorth);
            this.Controls.Add(this.picFoxNorth);
            this.Controls.Add(this.picChickenNorthPic);
            this.Controls.Add(this.picFarmerNorth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNorthBank);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(540, 449);
            this.MinimumSize = new System.Drawing.Size(540, 449);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Besian\'s Farmer Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFarmerNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChickenNorthPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoxNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrainNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFarmerSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChickenSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrainSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoxSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label lblNorthBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.RadioButton radBtnFox;
        private System.Windows.Forms.RadioButton radBtnChicken;
        private System.Windows.Forms.RadioButton radBtnGrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnNothing;
        private System.Windows.Forms.PictureBox picFarmerNorth;
        private System.Windows.Forms.PictureBox picChickenNorthPic;
        private System.Windows.Forms.PictureBox picFoxNorth;
        private System.Windows.Forms.PictureBox picGrainNorth;
        private System.Windows.Forms.PictureBox picFarmerSouth;
        private System.Windows.Forms.PictureBox picChickenSouth;
        private System.Windows.Forms.PictureBox picGrainSouth;
        private System.Windows.Forms.PictureBox picFoxSouth;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

