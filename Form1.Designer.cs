namespace Minecraft_Add_On_Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.forge = new System.Windows.Forms.Button();
            this.java = new System.Windows.Forms.Button();
            this.badlion = new System.Windows.Forms.Button();
            this.lunar = new System.Windows.Forms.Button();
            this.curseforge = new System.Windows.Forms.Button();
            this.closePanel = new System.Windows.Forms.Button();
            this.optifine = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // forge
            // 
            this.forge.BackColor = System.Drawing.Color.White;
            this.forge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forge.Location = new System.Drawing.Point(44, 236);
            this.forge.Name = "forge";
            this.forge.Size = new System.Drawing.Size(330, 29);
            this.forge.TabIndex = 0;
            this.forge.Text = "Install Forge 1.12.2";
            this.forge.UseVisualStyleBackColor = false;
            this.forge.Click += new System.EventHandler(this.forge_Click_1);
            // 
            // java
            // 
            this.java.BackColor = System.Drawing.Color.White;
            this.java.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.java.Location = new System.Drawing.Point(44, 207);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(330, 29);
            this.java.TabIndex = 1;
            this.java.Text = "Install Java 17 SDK";
            this.java.UseVisualStyleBackColor = false;
            this.java.Click += new System.EventHandler(this.java_Click_1);
            // 
            // badlion
            // 
            this.badlion.BackColor = System.Drawing.Color.White;
            this.badlion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badlion.Location = new System.Drawing.Point(44, 352);
            this.badlion.Name = "badlion";
            this.badlion.Size = new System.Drawing.Size(330, 29);
            this.badlion.TabIndex = 2;
            this.badlion.Text = "Install Badlion";
            this.badlion.UseVisualStyleBackColor = false;
            this.badlion.Click += new System.EventHandler(this.badlion_Click_1);
            // 
            // lunar
            // 
            this.lunar.BackColor = System.Drawing.Color.White;
            this.lunar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lunar.Location = new System.Drawing.Point(44, 294);
            this.lunar.Name = "lunar";
            this.lunar.Size = new System.Drawing.Size(330, 29);
            this.lunar.TabIndex = 3;
            this.lunar.Text = "Install Lunar";
            this.lunar.UseVisualStyleBackColor = false;
            this.lunar.Click += new System.EventHandler(this.lunar_Click_1);
            // 
            // curseforge
            // 
            this.curseforge.BackColor = System.Drawing.Color.White;
            this.curseforge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curseforge.Location = new System.Drawing.Point(44, 323);
            this.curseforge.Name = "curseforge";
            this.curseforge.Size = new System.Drawing.Size(330, 29);
            this.curseforge.TabIndex = 4;
            this.curseforge.Text = "Install Curseforge Client";
            this.curseforge.UseVisualStyleBackColor = false;
            this.curseforge.Click += new System.EventHandler(this.curseforge_Click_1);
            // 
            // closePanel
            // 
            this.closePanel.BackColor = System.Drawing.Color.Transparent;
            this.closePanel.FlatAppearance.BorderSize = 0;
            this.closePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closePanel.Location = new System.Drawing.Point(378, -3);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(52, 27);
            this.closePanel.TabIndex = 6;
            this.closePanel.UseVisualStyleBackColor = false;
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            // 
            // optifine
            // 
            this.optifine.BackColor = System.Drawing.Color.White;
            this.optifine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optifine.Location = new System.Drawing.Point(44, 265);
            this.optifine.Name = "optifine";
            this.optifine.Size = new System.Drawing.Size(330, 29);
            this.optifine.TabIndex = 8;
            this.optifine.Text = "Install Optifine 1.12.2";
            this.optifine.UseVisualStyleBackColor = false;
            this.optifine.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(433, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.optifine);
            this.Controls.Add(this.closePanel);
            this.Controls.Add(this.curseforge);
            this.Controls.Add(this.lunar);
            this.Controls.Add(this.badlion);
            this.Controls.Add(this.java);
            this.Controls.Add(this.forge);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private Button forge;
        private Button java;
        private Button badlion;
        private Button lunar;
        private Button curseforge;
        private Button closePanel;
        private Button optifine;
        private PictureBox pictureBox1;
    }
}