
namespace ClothingShop.Views
{
    partial class ProviderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderForm));
            this.AddProviderButton = new MaterialSkin.Controls.MaterialButton();
            this.RemoveProviderButton = new MaterialSkin.Controls.MaterialButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProviderListView = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // AddProviderButton
            // 
            this.AddProviderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddProviderButton.AutoSize = false;
            this.AddProviderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddProviderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddProviderButton.Depth = 0;
            this.AddProviderButton.HighEmphasis = true;
            this.AddProviderButton.Icon = null;
            this.AddProviderButton.Location = new System.Drawing.Point(228, 651);
            this.AddProviderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddProviderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddProviderButton.Name = "AddProviderButton";
            this.AddProviderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddProviderButton.Size = new System.Drawing.Size(305, 66);
            this.AddProviderButton.TabIndex = 1;
            this.AddProviderButton.Text = "Добавить";
            this.AddProviderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddProviderButton.UseAccentColor = false;
            this.AddProviderButton.UseVisualStyleBackColor = true;
            this.AddProviderButton.Click += new System.EventHandler(this.AddProviderButton_Click);
            // 
            // RemoveProviderButton
            // 
            this.RemoveProviderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveProviderButton.AutoSize = false;
            this.RemoveProviderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveProviderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RemoveProviderButton.Depth = 0;
            this.RemoveProviderButton.HighEmphasis = true;
            this.RemoveProviderButton.Icon = null;
            this.RemoveProviderButton.Location = new System.Drawing.Point(918, 651);
            this.RemoveProviderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveProviderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveProviderButton.Name = "RemoveProviderButton";
            this.RemoveProviderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RemoveProviderButton.Size = new System.Drawing.Size(305, 66);
            this.RemoveProviderButton.TabIndex = 2;
            this.RemoveProviderButton.Text = "Удалить";
            this.RemoveProviderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RemoveProviderButton.UseAccentColor = false;
            this.RemoveProviderButton.UseVisualStyleBackColor = true;
            this.RemoveProviderButton.Click += new System.EventHandler(this.RemoveProviderButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Фамилия";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название компании";
            this.columnHeader3.Width = 308;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Номер телефона";
            this.columnHeader4.Width = 273;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "E-mail";
            this.columnHeader5.Width = 167;
            // 
            // ProviderListView
            // 
            this.ProviderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderListView.AutoSizeTable = false;
            this.ProviderListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProviderListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ProviderListView.Depth = 0;
            this.ProviderListView.FullRowSelect = true;
            this.ProviderListView.HideSelection = false;
            this.ProviderListView.Location = new System.Drawing.Point(70, 100);
            this.ProviderListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.ProviderListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProviderListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ProviderListView.Name = "ProviderListView";
            this.ProviderListView.OwnerDraw = true;
            this.ProviderListView.Size = new System.Drawing.Size(1384, 490);
            this.ProviderListView.TabIndex = 0;
            this.ProviderListView.UseCompatibleStateImageBehavior = false;
            this.ProviderListView.View = System.Windows.Forms.View.Details;
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 795);
            this.Controls.Add(this.RemoveProviderButton);
            this.Controls.Add(this.AddProviderButton);
            this.Controls.Add(this.ProviderListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1486, 795);
            this.Name = "ProviderForm";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.ProviderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton AddProviderButton;
        private MaterialSkin.Controls.MaterialButton RemoveProviderButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialListView ProviderListView;
    }
}