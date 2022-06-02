
namespace ClothingShop.Views
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.soldProductButton = new MaterialSkin.Controls.MaterialButton();
            this.productButton = new MaterialSkin.Controls.MaterialButton();
            this.ProviderButton = new MaterialSkin.Controls.MaterialButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // soldProductButton
            // 
            this.soldProductButton.AutoSize = false;
            this.soldProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.soldProductButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soldProductButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.soldProductButton.Depth = 0;
            this.soldProductButton.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldProductButton.HighEmphasis = true;
            this.soldProductButton.Icon = null;
            this.soldProductButton.Location = new System.Drawing.Point(24, 106);
            this.soldProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.soldProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.soldProductButton.Name = "soldProductButton";
            this.soldProductButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.soldProductButton.Size = new System.Drawing.Size(187, 78);
            this.soldProductButton.TabIndex = 0;
            this.soldProductButton.Text = "ПРОДАЖИ";
            this.soldProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.soldProductButton.UseAccentColor = false;
            this.soldProductButton.UseVisualStyleBackColor = true;
            this.soldProductButton.Click += new System.EventHandler(this.soldProductButton_Click);
            // 
            // productButton
            // 
            this.productButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productButton.AutoSize = false;
            this.productButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.productButton.Depth = 0;
            this.productButton.HighEmphasis = true;
            this.productButton.Icon = null;
            this.productButton.Location = new System.Drawing.Point(24, 373);
            this.productButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.productButton.Name = "productButton";
            this.productButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.productButton.Size = new System.Drawing.Size(187, 78);
            this.productButton.TabIndex = 1;
            this.productButton.Text = "ТОВАРЫ";
            this.productButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.productButton.UseAccentColor = false;
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // ProviderButton
            // 
            this.ProviderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderButton.AutoSize = false;
            this.ProviderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProviderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ProviderButton.Depth = 0;
            this.ProviderButton.HighEmphasis = true;
            this.ProviderButton.Icon = null;
            this.ProviderButton.Location = new System.Drawing.Point(823, 106);
            this.ProviderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProviderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProviderButton.Name = "ProviderButton";
            this.ProviderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ProviderButton.Size = new System.Drawing.Size(187, 78);
            this.ProviderButton.TabIndex = 2;
            this.ProviderButton.Text = "ПОСТАВЩИКИ";
            this.ProviderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProviderButton.UseAccentColor = false;
            this.ProviderButton.UseVisualStyleBackColor = true;
            this.ProviderButton.Click += new System.EventHandler(this.ProviderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = false;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExitButton.Depth = 0;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(823, 373);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExitButton.Size = new System.Drawing.Size(187, 78);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "ВЫХОД";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ClothingShop.Properties.Resources.headpic1;
            this.pictureBox1.Location = new System.Drawing.Point(235, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 513);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProviderButton);
            this.Controls.Add(this.productButton);
            this.Controls.Add(this.soldProductButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1063, 605);
            this.Name = "AdminForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton soldProductButton;
        private MaterialSkin.Controls.MaterialButton productButton;
        private MaterialSkin.Controls.MaterialButton ProviderButton;
        private MaterialSkin.Controls.MaterialButton ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}