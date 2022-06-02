
namespace ClothingShop.Views
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.okButton = new MaterialSkin.Controls.MaterialButton();
            this.nameText = new MaterialSkin.Controls.MaterialTextBox();
            this.articleText = new MaterialSkin.Controls.MaterialTextBox();
            this.costText = new MaterialSkin.Controls.MaterialTextBox();
            this.brandText = new MaterialSkin.Controls.MaterialTextBox();
            this.sizeText = new MaterialSkin.Controls.MaterialTextBox();
            this.typeText = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.CancelAddButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.AutoSize = false;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.okButton.Depth = 0;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.HighEmphasis = true;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(126, 580);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.okButton.Size = new System.Drawing.Size(222, 66);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Добавить";
            this.okButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.okButton.UseAccentColor = false;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nameText
            // 
            this.nameText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameText.AnimateReadOnly = false;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameText.Depth = 0;
            this.nameText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameText.LeadingIcon = null;
            this.nameText.Location = new System.Drawing.Point(293, 113);
            this.nameText.MaxLength = 50;
            this.nameText.MouseState = MaterialSkin.MouseState.OUT;
            this.nameText.Multiline = false;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(635, 50);
            this.nameText.TabIndex = 1;
            this.nameText.Text = "";
            this.nameText.TrailingIcon = null;
            // 
            // articleText
            // 
            this.articleText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.articleText.AnimateReadOnly = false;
            this.articleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.articleText.Depth = 0;
            this.articleText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.articleText.LeadingIcon = null;
            this.articleText.Location = new System.Drawing.Point(293, 255);
            this.articleText.MaxLength = 50;
            this.articleText.MouseState = MaterialSkin.MouseState.OUT;
            this.articleText.Multiline = false;
            this.articleText.Name = "articleText";
            this.articleText.Size = new System.Drawing.Size(635, 50);
            this.articleText.TabIndex = 2;
            this.articleText.Text = "";
            this.articleText.TrailingIcon = null;
            // 
            // costText
            // 
            this.costText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.costText.AnimateReadOnly = false;
            this.costText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costText.Depth = 0;
            this.costText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costText.LeadingIcon = null;
            this.costText.Location = new System.Drawing.Point(293, 332);
            this.costText.MaxLength = 50;
            this.costText.MouseState = MaterialSkin.MouseState.OUT;
            this.costText.Multiline = false;
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(635, 50);
            this.costText.TabIndex = 3;
            this.costText.Text = "";
            this.costText.TrailingIcon = null;
            // 
            // brandText
            // 
            this.brandText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.brandText.AnimateReadOnly = false;
            this.brandText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brandText.Depth = 0;
            this.brandText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.brandText.LeadingIcon = null;
            this.brandText.Location = new System.Drawing.Point(293, 406);
            this.brandText.MaxLength = 50;
            this.brandText.MouseState = MaterialSkin.MouseState.OUT;
            this.brandText.Multiline = false;
            this.brandText.Name = "brandText";
            this.brandText.Size = new System.Drawing.Size(635, 50);
            this.brandText.TabIndex = 4;
            this.brandText.Text = "";
            this.brandText.TrailingIcon = null;
            // 
            // sizeText
            // 
            this.sizeText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sizeText.AnimateReadOnly = false;
            this.sizeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sizeText.Depth = 0;
            this.sizeText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sizeText.LeadingIcon = null;
            this.sizeText.Location = new System.Drawing.Point(293, 485);
            this.sizeText.MaxLength = 50;
            this.sizeText.MouseState = MaterialSkin.MouseState.OUT;
            this.sizeText.Multiline = false;
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(635, 50);
            this.sizeText.TabIndex = 5;
            this.sizeText.Text = "";
            this.sizeText.TrailingIcon = null;
            // 
            // typeText
            // 
            this.typeText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.typeText.AnimateReadOnly = false;
            this.typeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeText.Depth = 0;
            this.typeText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.typeText.LeadingIcon = null;
            this.typeText.Location = new System.Drawing.Point(293, 180);
            this.typeText.MaxLength = 50;
            this.typeText.MouseState = MaterialSkin.MouseState.OUT;
            this.typeText.Multiline = false;
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(635, 50);
            this.typeText.TabIndex = 6;
            this.typeText.Text = "";
            this.typeText.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(64, 109);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(140, 24);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Наименование";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(64, 180);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(35, 24);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Тип";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(64, 255);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 24);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Артикул";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(64, 332);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(103, 24);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Стоимость";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(64, 406);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 24);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Бренд";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(64, 485);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(72, 24);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Размер";
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelAddButton.AutoSize = false;
            this.CancelAddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelAddButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CancelAddButton.Depth = 0;
            this.CancelAddButton.HighEmphasis = true;
            this.CancelAddButton.Icon = null;
            this.CancelAddButton.Location = new System.Drawing.Point(593, 580);
            this.CancelAddButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelAddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CancelAddButton.Size = new System.Drawing.Size(222, 66);
            this.CancelAddButton.TabIndex = 13;
            this.CancelAddButton.Text = "Отмена";
            this.CancelAddButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelAddButton.UseAccentColor = false;
            this.CancelAddButton.UseVisualStyleBackColor = true;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 684);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.brandText);
            this.Controls.Add(this.costText);
            this.Controls.Add(this.articleText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.Text = "Добавить товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton okButton;
        private MaterialSkin.Controls.MaterialTextBox nameText;
        private MaterialSkin.Controls.MaterialTextBox articleText;
        private MaterialSkin.Controls.MaterialTextBox costText;
        private MaterialSkin.Controls.MaterialTextBox brandText;
        private MaterialSkin.Controls.MaterialTextBox sizeText;
        private MaterialSkin.Controls.MaterialTextBox typeText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton CancelAddButton;
    }
}