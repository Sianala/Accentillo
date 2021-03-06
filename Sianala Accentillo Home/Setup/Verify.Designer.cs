
namespace Setup
{
    partial class Verify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verify));
            this.TextRules = new System.Windows.Forms.Label();
            this.InstallClick = new System.Windows.Forms.Button();
            this.CancelClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextRules
            // 
            this.TextRules.AutoSize = true;
            this.TextRules.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TextRules.Location = new System.Drawing.Point(12, 19);
            this.TextRules.Name = "TextRules";
            this.TextRules.Size = new System.Drawing.Size(434, 65);
            this.TextRules.TabIndex = 0;
            this.TextRules.Text = "You are opened a setup of Sianala Accentillo. If you click to Install, you are ve" +
    "rifing a rules.\r\nIt is a setup of free version. Signed by Sianala, LLC.\r\nAre you" +
    " sure?\r\n\r\n(C) Sianala, LLC - 2021.";
            // 
            // InstallClick
            // 
            this.InstallClick.Location = new System.Drawing.Point(703, 349);
            this.InstallClick.Name = "InstallClick";
            this.InstallClick.Size = new System.Drawing.Size(103, 36);
            this.InstallClick.TabIndex = 1;
            this.InstallClick.Text = "Install";
            this.InstallClick.UseVisualStyleBackColor = true;
            this.InstallClick.Click += new System.EventHandler(this.InstallClick_Click);
            // 
            // CancelClick
            // 
            this.CancelClick.Location = new System.Drawing.Point(578, 349);
            this.CancelClick.Name = "CancelClick";
            this.CancelClick.Size = new System.Drawing.Size(103, 36);
            this.CancelClick.TabIndex = 2;
            this.CancelClick.Text = "Cancel";
            this.CancelClick.UseVisualStyleBackColor = true;
            this.CancelClick.Click += new System.EventHandler(this.CancelClick_Click);
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 397);
            this.Controls.Add(this.CancelClick);
            this.Controls.Add(this.InstallClick);
            this.Controls.Add(this.TextRules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Verify";
            this.Text = "Sianala Accentillo Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextRules;
        private System.Windows.Forms.Button InstallClick;
        private System.Windows.Forms.Button CancelClick;
    }
}

