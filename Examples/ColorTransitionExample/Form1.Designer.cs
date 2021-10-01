
namespace ColorTransitionExample
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
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(288, 246);
            this.ColorPanel.TabIndex = 0;
            this.ColorPanel.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 246);
            this.Controls.Add(this.ColorPanel);
            this.Name = "MainForm";
            this.Text = "Color Transition Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ColorPanel;
    }
}

