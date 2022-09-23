namespace Game_Racing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xePlayer = new System.Windows.Forms.PictureBox();
            this.xeComputer = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn = new System.Windows.Forms.Button();
            this.bom = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bom)).BeginInit();
            this.SuspendLayout();
            // 
            // xePlayer
            // 
            this.xePlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xePlayer.BackgroundImage")));
            this.xePlayer.Location = new System.Drawing.Point(335, 186);
            this.xePlayer.Name = "xePlayer";
            this.xePlayer.Size = new System.Drawing.Size(78, 149);
            this.xePlayer.TabIndex = 0;
            this.xePlayer.TabStop = false;
            this.xePlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xePlayer_MouseDown);
            this.xePlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.xePlayer_MouseMove);
            this.xePlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.xePlayer_MouseUp);
            // 
            // xeComputer
            // 
            this.xeComputer.Image = ((System.Drawing.Image)(resources.GetObject("xeComputer.Image")));
            this.xeComputer.Location = new System.Drawing.Point(96, 206);
            this.xeComputer.Name = "xeComputer";
            this.xeComputer.Size = new System.Drawing.Size(74, 152);
            this.xeComputer.TabIndex = 1;
            this.xeComputer.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn
            // 
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.Location = new System.Drawing.Point(646, 49);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(42, 44);
            this.btn.TabIndex = 2;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // bom
            // 
            this.bom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bom.BackgroundImage")));
            this.bom.Location = new System.Drawing.Point(525, 306);
            this.bom.Name = "bom";
            this.bom.Size = new System.Drawing.Size(152, 149);
            this.bom.TabIndex = 3;
            this.bom.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(53, 49);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(105, 38);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(755, 598);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.bom);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.xeComputer);
            this.Controls.Add(this.xePlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox xePlayer;
        private PictureBox xeComputer;
        private System.Windows.Forms.Timer timer;
        private Button btn;
        private PictureBox bom;
        private Label lbl;
    }
}