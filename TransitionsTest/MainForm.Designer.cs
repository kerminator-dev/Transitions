
namespace TransitionsTest
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
            this.QuadrObject = new System.Windows.Forms.Panel();
            this.QuadrPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ElasticPanel = new System.Windows.Forms.Panel();
            this.ElasticObject = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BouncePanel = new System.Windows.Forms.Panel();
            this.BounceObject = new System.Windows.Forms.Panel();
            this.FpsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DurationUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpPanel = new System.Windows.Forms.Panel();
            this.ExpObject = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SinPanel = new System.Windows.Forms.Panel();
            this.SinObject = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CircularPanel = new System.Windows.Forms.Panel();
            this.CircularObject = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.BackObject = new System.Windows.Forms.Panel();
            this.LocationXLabel = new System.Windows.Forms.Label();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.QuadrPanel.SuspendLayout();
            this.ElasticPanel.SuspendLayout();
            this.BouncePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FpsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationUpDown)).BeginInit();
            this.ExpPanel.SuspendLayout();
            this.SinPanel.SuspendLayout();
            this.CircularPanel.SuspendLayout();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuadrObject
            // 
            this.QuadrObject.BackColor = System.Drawing.Color.DimGray;
            this.QuadrObject.Location = new System.Drawing.Point(3, 3);
            this.QuadrObject.Name = "QuadrObject";
            this.QuadrObject.Size = new System.Drawing.Size(30, 30);
            this.QuadrObject.TabIndex = 0;
            // 
            // QuadrPanel
            // 
            this.QuadrPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuadrPanel.BackColor = System.Drawing.Color.Silver;
            this.QuadrPanel.Controls.Add(this.QuadrObject);
            this.QuadrPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuadrPanel.Location = new System.Drawing.Point(12, 160);
            this.QuadrPanel.Name = "QuadrPanel";
            this.QuadrPanel.Size = new System.Drawing.Size(651, 36);
            this.QuadrPanel.TabIndex = 1;
            this.QuadrPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuadrPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quadratic in/out transition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elastic  in/out transition";
            // 
            // ElasticPanel
            // 
            this.ElasticPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElasticPanel.BackColor = System.Drawing.Color.Silver;
            this.ElasticPanel.Controls.Add(this.ElasticObject);
            this.ElasticPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ElasticPanel.Location = new System.Drawing.Point(12, 229);
            this.ElasticPanel.Name = "ElasticPanel";
            this.ElasticPanel.Size = new System.Drawing.Size(649, 36);
            this.ElasticPanel.TabIndex = 4;
            this.ElasticPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ElasticPanel_MouseDown);
            // 
            // ElasticObject
            // 
            this.ElasticObject.BackColor = System.Drawing.Color.IndianRed;
            this.ElasticObject.Location = new System.Drawing.Point(3, 3);
            this.ElasticObject.Name = "ElasticObject";
            this.ElasticObject.Size = new System.Drawing.Size(30, 30);
            this.ElasticObject.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bounce  in/out transition";
            // 
            // BouncePanel
            // 
            this.BouncePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BouncePanel.BackColor = System.Drawing.Color.Silver;
            this.BouncePanel.Controls.Add(this.BounceObject);
            this.BouncePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouncePanel.Location = new System.Drawing.Point(12, 299);
            this.BouncePanel.Name = "BouncePanel";
            this.BouncePanel.Size = new System.Drawing.Size(649, 36);
            this.BouncePanel.TabIndex = 6;
            this.BouncePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BouncePanel_MouseDown);
            // 
            // BounceObject
            // 
            this.BounceObject.BackColor = System.Drawing.Color.SlateBlue;
            this.BounceObject.Location = new System.Drawing.Point(3, 3);
            this.BounceObject.Name = "BounceObject";
            this.BounceObject.Size = new System.Drawing.Size(30, 30);
            this.BounceObject.TabIndex = 0;
            // 
            // FpsUpDown
            // 
            this.FpsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FpsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FpsUpDown.Location = new System.Drawing.Point(67, 13);
            this.FpsUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.FpsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FpsUpDown.Name = "FpsUpDown";
            this.FpsUpDown.Size = new System.Drawing.Size(124, 22);
            this.FpsUpDown.TabIndex = 0;
            this.FpsUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "FPS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Duration:";
            // 
            // DurationUpDown
            // 
            this.DurationUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DurationUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationUpDown.Location = new System.Drawing.Point(109, 52);
            this.DurationUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DurationUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DurationUpDown.Name = "DurationUpDown";
            this.DurationUpDown.Size = new System.Drawing.Size(83, 22);
            this.DurationUpDown.TabIndex = 2;
            this.DurationUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Exponential  in/out transition";
            // 
            // ExpPanel
            // 
            this.ExpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpPanel.BackColor = System.Drawing.Color.Silver;
            this.ExpPanel.Controls.Add(this.ExpObject);
            this.ExpPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpPanel.Location = new System.Drawing.Point(14, 366);
            this.ExpPanel.Name = "ExpPanel";
            this.ExpPanel.Size = new System.Drawing.Size(649, 36);
            this.ExpPanel.TabIndex = 9;
            this.ExpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExpPanel_MouseDown);
            // 
            // ExpObject
            // 
            this.ExpObject.BackColor = System.Drawing.Color.SeaGreen;
            this.ExpObject.Location = new System.Drawing.Point(3, 3);
            this.ExpObject.Name = "ExpObject";
            this.ExpObject.Size = new System.Drawing.Size(30, 30);
            this.ExpObject.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 413);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sinusoidal  in/out transition";
            // 
            // SinPanel
            // 
            this.SinPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SinPanel.BackColor = System.Drawing.Color.Silver;
            this.SinPanel.Controls.Add(this.SinObject);
            this.SinPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SinPanel.Location = new System.Drawing.Point(15, 436);
            this.SinPanel.Name = "SinPanel";
            this.SinPanel.Size = new System.Drawing.Size(648, 36);
            this.SinPanel.TabIndex = 11;
            this.SinPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SinPanel_MouseDown);
            // 
            // SinObject
            // 
            this.SinObject.BackColor = System.Drawing.Color.SandyBrown;
            this.SinObject.Location = new System.Drawing.Point(3, 3);
            this.SinObject.Name = "SinObject";
            this.SinObject.Size = new System.Drawing.Size(30, 30);
            this.SinObject.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 480);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Circular in/out transition";
            // 
            // CircularPanel
            // 
            this.CircularPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CircularPanel.BackColor = System.Drawing.Color.Silver;
            this.CircularPanel.Controls.Add(this.CircularObject);
            this.CircularPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CircularPanel.Location = new System.Drawing.Point(13, 503);
            this.CircularPanel.Name = "CircularPanel";
            this.CircularPanel.Size = new System.Drawing.Size(650, 36);
            this.CircularPanel.TabIndex = 13;
            this.CircularPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CircularPanel_MouseDown);
            // 
            // CircularObject
            // 
            this.CircularObject.BackColor = System.Drawing.Color.RoyalBlue;
            this.CircularObject.Location = new System.Drawing.Point(3, 3);
            this.CircularObject.Name = "CircularObject";
            this.CircularObject.Size = new System.Drawing.Size(30, 30);
            this.CircularObject.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 547);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Back in/out transition";
            // 
            // BackPanel
            // 
            this.BackPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackPanel.BackColor = System.Drawing.Color.Silver;
            this.BackPanel.Controls.Add(this.BackObject);
            this.BackPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPanel.Location = new System.Drawing.Point(15, 570);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(648, 36);
            this.BackPanel.TabIndex = 15;
            this.BackPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseDown);
            // 
            // BackObject
            // 
            this.BackObject.BackColor = System.Drawing.Color.Salmon;
            this.BackObject.Location = new System.Drawing.Point(3, 3);
            this.BackObject.Name = "BackObject";
            this.BackObject.Size = new System.Drawing.Size(30, 30);
            this.BackObject.TabIndex = 0;
            // 
            // LocationXLabel
            // 
            this.LocationXLabel.AutoSize = true;
            this.LocationXLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationXLabel.Location = new System.Drawing.Point(21, 94);
            this.LocationXLabel.Name = "LocationXLabel";
            this.LocationXLabel.Size = new System.Drawing.Size(59, 20);
            this.LocationXLabel.TabIndex = 18;
            this.LocationXLabel.Text = "Value:";
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LinePanel.Location = new System.Drawing.Point(12, 12);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(3, 108);
            this.LinePanel.TabIndex = 19;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(675, 619);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LocationXLabel);
            this.Controls.Add(this.DurationUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FpsUpDown);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CircularPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SinPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExpPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BouncePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ElasticPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuadrPanel);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Transitions";
            this.QuadrPanel.ResumeLayout(false);
            this.ElasticPanel.ResumeLayout(false);
            this.BouncePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FpsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationUpDown)).EndInit();
            this.ExpPanel.ResumeLayout(false);
            this.SinPanel.ResumeLayout(false);
            this.CircularPanel.ResumeLayout(false);
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel QuadrObject;
        private System.Windows.Forms.Panel QuadrPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ElasticPanel;
        private System.Windows.Forms.Panel ElasticObject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BouncePanel;
        private System.Windows.Forms.Panel BounceObject;
        private System.Windows.Forms.NumericUpDown FpsUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DurationUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel ExpPanel;
        private System.Windows.Forms.Panel ExpObject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel SinPanel;
        private System.Windows.Forms.Panel SinObject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel CircularPanel;
        private System.Windows.Forms.Panel CircularObject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Panel BackObject;
        private System.Windows.Forms.Label LocationXLabel;
        private System.Windows.Forms.Panel LinePanel;
    }
}

