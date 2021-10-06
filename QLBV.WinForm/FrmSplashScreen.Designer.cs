
namespace QLBV.WinForm
{
    partial class FrmSplashScreen
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
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Version = new System.Windows.Forms.Label();
            this.MainLayoutPanel.SuspendLayout();
            this.DetailsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 0);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(480, 264);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // DetailsLayoutPanel
            // 
            this.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.DetailsLayoutPanel.ColumnCount = 1;
            this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 247F));
            this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 142F));
            this.DetailsLayoutPanel.Controls.Add(this.Version, 0, 0);
            this.DetailsLayoutPanel.Location = new System.Drawing.Point(246, 69);
            this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
            this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.DetailsLayoutPanel.Size = new System.Drawing.Size(231, 79);
            this.DetailsLayoutPanel.TabIndex = 0;
            // 
            // Version
            // 
            this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(65, 32);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(101, 15);
            this.Version.TabIndex = 1;
            this.Version.Text = "Version {0}.{1:00}";
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 264);
            this.ControlBox = false;
            this.Controls.Add(this.MainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplashScreen";
            this.MainLayoutPanel.ResumeLayout(false);
            this.DetailsLayoutPanel.ResumeLayout(false);
            this.DetailsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel DetailsLayoutPanel;
        private System.Windows.Forms.Label Version;
    }
}