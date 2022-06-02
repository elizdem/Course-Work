
namespace ClothingShop.Views
{
    partial class SellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.MakeOrderButton = new MaterialSkin.Controls.MaterialButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.ProductListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchListBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // MakeOrderButton
            // 
            this.MakeOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MakeOrderButton.AutoSize = false;
            this.MakeOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MakeOrderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MakeOrderButton.Depth = 0;
            this.MakeOrderButton.HighEmphasis = true;
            this.MakeOrderButton.Icon = null;
            this.MakeOrderButton.Location = new System.Drawing.Point(28, 270);
            this.MakeOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MakeOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MakeOrderButton.Name = "MakeOrderButton";
            this.MakeOrderButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MakeOrderButton.Size = new System.Drawing.Size(186, 78);
            this.MakeOrderButton.TabIndex = 0;
            this.MakeOrderButton.Text = "ОФОРМЛЕНИЕ ЗАКАЗА";
            this.MakeOrderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MakeOrderButton.UseAccentColor = false;
            this.MakeOrderButton.UseVisualStyleBackColor = true;
            this.MakeOrderButton.Click += new System.EventHandler(this.MakeOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExitButton.AutoSize = false;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExitButton.Depth = 0;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(28, 553);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExitButton.Size = new System.Drawing.Size(186, 78);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "ВЫХОД";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ProductListView
            // 
            this.ProductListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductListView.AutoSizeTable = false;
            this.ProductListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ProductListView.Depth = 0;
            this.ProductListView.FullRowSelect = true;
            this.ProductListView.HideSelection = false;
            this.ProductListView.Location = new System.Drawing.Point(235, 224);
            this.ProductListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.ProductListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProductListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.OwnerDraw = true;
            this.ProductListView.Size = new System.Drawing.Size(1068, 529);
            this.ProductListView.TabIndex = 3;
            this.ProductListView.UseCompatibleStateImageBehavior = false;
            this.ProductListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Артикул";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Стоимость";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Бренд";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Размер";
            this.columnHeader6.Width = 90;
            // 
            // searchListBox
            // 
            this.searchListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchListBox.AnimateReadOnly = false;
            this.searchListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchListBox.Depth = 0;
            this.searchListBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchListBox.LeadingIcon = null;
            this.searchListBox.Location = new System.Drawing.Point(245, 149);
            this.searchListBox.MaxLength = 50;
            this.searchListBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchListBox.Multiline = false;
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(439, 50);
            this.searchListBox.TabIndex = 4;
            this.searchListBox.Text = "";
            this.searchListBox.TrailingIcon = null;
            this.searchListBox.TextChanged += new System.EventHandler(this.searchListBox_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(242, 118);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Поиск ";
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 794);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.searchListBox);
            this.Controls.Add(this.ProductListView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MakeOrderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton MakeOrderButton;
        private MaterialSkin.Controls.MaterialButton ExitButton;
        private MaterialSkin.Controls.MaterialListView ProductListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialTextBox searchListBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}