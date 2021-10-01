
namespace NotificationsTest
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ShowButton = new Guna.UI2.WinForms.Guna2Button();
            this.Card1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.HideButton = new Guna.UI2.WinForms.Guna2Button();
            this.Card2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Card3 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.ShowNotificationButton = new Guna.UI2.WinForms.Guna2Button();
            this.Card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.Card2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            this.Card3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Animated = true;
            this.ShowButton.BorderRadius = 18;
            this.ShowButton.CheckedState.Parent = this.ShowButton;
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.CustomImages.Parent = this.ShowButton;
            this.ShowButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.ShowButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ShowButton.ForeColor = System.Drawing.Color.White;
            this.ShowButton.HoverState.Parent = this.ShowButton;
            this.ShowButton.Location = new System.Drawing.Point(19, 504);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.ShadowDecoration.Parent = this.ShowButton;
            this.ShowButton.Size = new System.Drawing.Size(120, 44);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show cards";
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Card1
            // 
            this.Card1.BackColor = System.Drawing.Color.Transparent;
            this.Card1.BorderRadius = 12;
            this.Card1.Controls.Add(this.gunaPictureBox1);
            this.Card1.Controls.Add(this.gunaLabel2);
            this.Card1.Controls.Add(this.guna2Button1);
            this.Card1.FillColor = System.Drawing.Color.MediumPurple;
            this.Card1.Location = new System.Drawing.Point(19, 19);
            this.Card1.Margin = new System.Windows.Forms.Padding(10);
            this.Card1.Name = "Card1";
            this.Card1.Padding = new System.Windows.Forms.Padding(10);
            this.Card1.ShadowDecoration.Parent = this.Card1;
            this.Card1.Size = new System.Drawing.Size(286, 144);
            this.Card1.TabIndex = 7;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(13, 13);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 10;
            this.gunaPictureBox1.Size = new System.Drawing.Size(80, 80);
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel2.Location = new System.Drawing.Point(99, 13);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(178, 121);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = resources.GetString("gunaLabel2.Text");
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.MediumPurple;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 106);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(81, 28);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Lavandula";
            // 
            // HideButton
            // 
            this.HideButton.Animated = true;
            this.HideButton.BorderRadius = 18;
            this.HideButton.CheckedState.Parent = this.HideButton;
            this.HideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideButton.CustomImages.Parent = this.HideButton;
            this.HideButton.FillColor = System.Drawing.Color.IndianRed;
            this.HideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.HideButton.ForeColor = System.Drawing.Color.White;
            this.HideButton.HoverState.Parent = this.HideButton;
            this.HideButton.Location = new System.Drawing.Point(192, 504);
            this.HideButton.Name = "HideButton";
            this.HideButton.ShadowDecoration.Parent = this.HideButton;
            this.HideButton.Size = new System.Drawing.Size(120, 44);
            this.HideButton.TabIndex = 12;
            this.HideButton.Text = "Hide cards";
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // Card2
            // 
            this.Card2.BackColor = System.Drawing.Color.Transparent;
            this.Card2.BorderRadius = 12;
            this.Card2.Controls.Add(this.gunaPictureBox3);
            this.Card2.Controls.Add(this.gunaLabel3);
            this.Card2.Controls.Add(this.guna2Button3);
            this.Card2.FillColor = System.Drawing.Color.SlateBlue;
            this.Card2.Location = new System.Drawing.Point(19, 183);
            this.Card2.Margin = new System.Windows.Forms.Padding(10);
            this.Card2.Name = "Card2";
            this.Card2.Padding = new System.Windows.Forms.Padding(10);
            this.Card2.ShadowDecoration.Parent = this.Card2;
            this.Card2.Size = new System.Drawing.Size(286, 144);
            this.Card2.TabIndex = 8;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(13, 13);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Radius = 10;
            this.gunaPictureBox3.Size = new System.Drawing.Size(80, 80);
            this.gunaPictureBox3.TabIndex = 7;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel3.Location = new System.Drawing.Point(99, 13);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(178, 121);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = resources.GetString("gunaLabel3.Text");
            this.gunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 12;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.MediumPurple;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(12, 106);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(81, 28);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "Lavandula";
            // 
            // Card3
            // 
            this.Card3.BackColor = System.Drawing.Color.Transparent;
            this.Card3.BorderRadius = 12;
            this.Card3.Controls.Add(this.gunaPictureBox2);
            this.Card3.Controls.Add(this.gunaLabel1);
            this.Card3.Controls.Add(this.guna2Button2);
            this.Card3.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Card3.Location = new System.Drawing.Point(19, 347);
            this.Card3.Margin = new System.Windows.Forms.Padding(10);
            this.Card3.Name = "Card3";
            this.Card3.Padding = new System.Windows.Forms.Padding(10);
            this.Card3.ShadowDecoration.Parent = this.Card3;
            this.Card3.Size = new System.Drawing.Size(286, 144);
            this.Card3.TabIndex = 13;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(13, 13);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Radius = 10;
            this.gunaPictureBox2.Size = new System.Drawing.Size(80, 80);
            this.gunaPictureBox2.TabIndex = 7;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel1.Location = new System.Drawing.Point(99, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(178, 121);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = resources.GetString("gunaLabel1.Text");
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 12;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.MediumPurple;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(12, 106);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(81, 28);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Lavandula";
            // 
            // ShowNotificationButton
            // 
            this.ShowNotificationButton.Animated = true;
            this.ShowNotificationButton.BorderRadius = 18;
            this.ShowNotificationButton.CheckedState.Parent = this.ShowNotificationButton;
            this.ShowNotificationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowNotificationButton.CustomImages.Parent = this.ShowNotificationButton;
            this.ShowNotificationButton.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.ShowNotificationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ShowNotificationButton.ForeColor = System.Drawing.Color.White;
            this.ShowNotificationButton.HoverState.Parent = this.ShowNotificationButton;
            this.ShowNotificationButton.Location = new System.Drawing.Point(76, 557);
            this.ShowNotificationButton.Name = "ShowNotificationButton";
            this.ShowNotificationButton.ShadowDecoration.Parent = this.ShowNotificationButton;
            this.ShowNotificationButton.Size = new System.Drawing.Size(165, 44);
            this.ShowNotificationButton.TabIndex = 14;
            this.ShowNotificationButton.Text = "Show notification";
            this.ShowNotificationButton.Click += new System.EventHandler(this.ShowNotificationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 613);
            this.Controls.Add(this.ShowNotificationButton);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.ShowButton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Transitions";
            this.Card1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.Card2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            this.Card3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ShowButton;
        private Guna.UI2.WinForms.Guna2Panel Card1;
        private Guna.UI2.WinForms.Guna2Button HideButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2Panel Card2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Panel Card3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button ShowNotificationButton;
    }
}

