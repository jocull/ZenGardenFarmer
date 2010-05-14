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
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        this.btnStart = new System.Windows.Forms.Button();
        this.lblGotWindow = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.tmrZenTimer = new System.Windows.Forms.Timer(this.components);
        this.btnExit = new System.Windows.Forms.Button();
        this.lblOptions = new System.Windows.Forms.Label();
        this.chkWaterPlants = new System.Windows.Forms.CheckBox();
        this.chkWakeUpSnail = new System.Windows.Forms.CheckBox();
        this.chkPickupCoins = new System.Windows.Forms.CheckBox();
        this.chkPlayMusic = new System.Windows.Forms.CheckBox();
        this.lblSimulate = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.tmrWhackAZombie = new System.Windows.Forms.Timer(this.components);
        this.btnWhackAZombie = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // btnStart
        // 
        this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnStart.Location = new System.Drawing.Point(289, 140);
        this.btnStart.Name = "btnStart";
        this.btnStart.Size = new System.Drawing.Size(99, 23);
        this.btnStart.TabIndex = 0;
        this.btnStart.Text = "Farm my Garden";
        this.btnStart.UseVisualStyleBackColor = true;
        this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
        // 
        // lblGotWindow
        // 
        this.lblGotWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.lblGotWindow.AutoSize = true;
        this.lblGotWindow.ForeColor = System.Drawing.Color.Red;
        this.lblGotWindow.Location = new System.Drawing.Point(109, 145);
        this.lblGotWindow.Name = "lblGotWindow";
        this.lblGotWindow.Size = new System.Drawing.Size(21, 13);
        this.lblGotWindow.TabIndex = 1;
        this.lblGotWindow.Text = "No";
        // 
        // label1
        // 
        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(14, 145);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(89, 13);
        this.label1.TabIndex = 2;
        this.label1.Text = "PVZ Running?";
        // 
        // tmrZenTimer
        // 
        this.tmrZenTimer.Interval = 5;
        this.tmrZenTimer.Tick += new System.EventHandler(this.tmrSnailTimer_Tick);
        // 
        // btnExit
        // 
        this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnExit.Location = new System.Drawing.Point(394, 140);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 3;
        this.btnExit.Text = "Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // lblOptions
        // 
        this.lblOptions.AutoSize = true;
        this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblOptions.Location = new System.Drawing.Point(13, 13);
        this.lblOptions.Name = "lblOptions";
        this.lblOptions.Size = new System.Drawing.Size(82, 24);
        this.lblOptions.TabIndex = 4;
        this.lblOptions.Text = "Options";
        // 
        // chkWaterPlants
        // 
        this.chkWaterPlants.AutoSize = true;
        this.chkWaterPlants.Checked = true;
        this.chkWaterPlants.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkWaterPlants.Location = new System.Drawing.Point(17, 41);
        this.chkWaterPlants.Name = "chkWaterPlants";
        this.chkWaterPlants.Size = new System.Drawing.Size(103, 17);
        this.chkWaterPlants.TabIndex = 5;
        this.chkWaterPlants.Text = "Water my Plants";
        this.chkWaterPlants.UseVisualStyleBackColor = true;
        // 
        // chkWakeUpSnail
        // 
        this.chkWakeUpSnail.AutoSize = true;
        this.chkWakeUpSnail.Checked = true;
        this.chkWakeUpSnail.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkWakeUpSnail.Location = new System.Drawing.Point(17, 65);
        this.chkWakeUpSnail.Name = "chkWakeUpSnail";
        this.chkWakeUpSnail.Size = new System.Drawing.Size(114, 17);
        this.chkWakeUpSnail.TabIndex = 6;
        this.chkWakeUpSnail.Text = "Wake up the Snail";
        this.chkWakeUpSnail.UseVisualStyleBackColor = true;
        // 
        // chkPickupCoins
        // 
        this.chkPickupCoins.AutoSize = true;
        this.chkPickupCoins.Checked = true;
        this.chkPickupCoins.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkPickupCoins.Location = new System.Drawing.Point(17, 112);
        this.chkPickupCoins.Name = "chkPickupCoins";
        this.chkPickupCoins.Size = new System.Drawing.Size(158, 17);
        this.chkPickupCoins.TabIndex = 7;
        this.chkPickupCoins.Text = "Attempt to Pick up Rewards";
        this.chkPickupCoins.UseVisualStyleBackColor = true;
        // 
        // chkPlayMusic
        // 
        this.chkPlayMusic.AutoSize = true;
        this.chkPlayMusic.Location = new System.Drawing.Point(17, 89);
        this.chkPlayMusic.Name = "chkPlayMusic";
        this.chkPlayMusic.Size = new System.Drawing.Size(454, 17);
        this.chkPlayMusic.TabIndex = 8;
        this.chkPlayMusic.Text = "Play Music for my Plants (DO NOT USE without Phonograph. It could SELL all your p" +
            "lants!)";
        this.chkPlayMusic.UseVisualStyleBackColor = true;
        // 
        // lblSimulate
        // 
        this.lblSimulate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblSimulate.Cursor = System.Windows.Forms.Cursors.Hand;
        this.lblSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblSimulate.ForeColor = System.Drawing.Color.Green;
        this.lblSimulate.Location = new System.Drawing.Point(237, 9);
        this.lblSimulate.Name = "lblSimulate";
        this.lblSimulate.Size = new System.Drawing.Size(237, 15);
        this.lblSimulate.TabIndex = 9;
        this.lblSimulate.Text = "Simulate is ON! No clicks for you!";
        this.lblSimulate.TextAlign = System.Drawing.ContentAlignment.TopRight;
        this.lblSimulate.Click += new System.EventHandler(this.lblSimulate_Click);
        // 
        // label2
        // 
        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(147, 24);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(327, 13);
        this.label2.TabIndex = 10;
        this.label2.Text = "Have the game running in windowed mode and your zen garden up!";
        // 
        // label3
        // 
        this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(242, 37);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(232, 13);
        this.label3.TabIndex = 11;
        this.label3.Text = "Moving the mouse will stop the farming process!";
        // 
        // tmrWhackAZombie
        // 
        this.tmrWhackAZombie.Interval = 5;
        this.tmrWhackAZombie.Tick += new System.EventHandler(this.tmrWhackAZombie_Tick);
        // 
        // btnWhackAZombie
        // 
        this.btnWhackAZombie.Location = new System.Drawing.Point(180, 140);
        this.btnWhackAZombie.Name = "btnWhackAZombie";
        this.btnWhackAZombie.Size = new System.Drawing.Size(103, 23);
        this.btnWhackAZombie.TabIndex = 12;
        this.btnWhackAZombie.Text = "Whack-a-Zombie!";
        this.btnWhackAZombie.UseVisualStyleBackColor = true;
        this.btnWhackAZombie.Click += new System.EventHandler(this.btnWhackAZombie_Click);
        // 
        // frmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(481, 175);
        this.Controls.Add(this.btnWhackAZombie);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.lblSimulate);
        this.Controls.Add(this.chkPlayMusic);
        this.Controls.Add(this.chkPickupCoins);
        this.Controls.Add(this.chkWakeUpSnail);
        this.Controls.Add(this.chkWaterPlants);
        this.Controls.Add(this.lblOptions);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.lblGotWindow);
        this.Controls.Add(this.btnStart);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.Name = "frmMain";
        this.Text = "AppTitle - AppVersion";
        this.Activated += new System.EventHandler(this.frmMain_Activated);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Label lblGotWindow;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Timer tmrZenTimer;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label lblOptions;
    private System.Windows.Forms.CheckBox chkWaterPlants;
    private System.Windows.Forms.CheckBox chkWakeUpSnail;
    private System.Windows.Forms.CheckBox chkPickupCoins;
    private System.Windows.Forms.CheckBox chkPlayMusic;
    private System.Windows.Forms.Label lblSimulate;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Timer tmrWhackAZombie;
    private System.Windows.Forms.Button btnWhackAZombie;
}