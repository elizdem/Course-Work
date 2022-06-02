
namespace ClothingShop.Views
{
    partial class AdminProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProductForm));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ProductListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddProductButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteProductButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ProductListView
            // 
            this.ProductListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.ProductListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductListView.FullRowSelect = true;
            this.ProductListView.HideSelection = false;
            this.ProductListView.Location = new System.Drawing.Point(6, 85);
            this.ProductListView.MaximumSize = new System.Drawing.Size(1500, 600);
            this.ProductListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.ProductListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProductListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.OwnerDraw = true;
            this.ProductListView.Size = new System.Drawing.Size(1500, 576);
            this.ProductListView.TabIndex = 0;
            this.ProductListView.UseCompatibleStateImageBehavior = false;
            this.ProductListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Артикул";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Стоимость";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Бренд";
            this.columnHeader5.Width = 220;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Размер";
            this.columnHeader6.Width = 150;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddProductButton.AutoSize = false;
            this.AddProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddProductButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddProductButton.Depth = 0;
            this.AddProductButton.HighEmphasis = true;
            this.AddProductButton.Icon = null;
            this.AddProductButton.Location = new System.Drawing.Point(231, 711);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddProductButton.Size = new System.Drawing.Size(305, 66);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Добавить товар";
            this.AddProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddProductButton.UseAccentColor = false;
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductButton.AutoSize = false;
            this.DeleteProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteProductButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteProductButton.Depth = 0;
            this.DeleteProductButton.HighEmphasis = true;
            this.DeleteProductButton.Icon = null;
            this.DeleteProductButton.Location = new System.Drawing.Point(927, 711);
            this.DeleteProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteProductButton.Size = new System.Drawing.Size(305, 66);
            this.DeleteProductButton.TabIndex = 2;
            this.DeleteProductButton.Text = "Удалить товар";
            this.DeleteProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteProductButton.UseAccentColor = false;
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // AdminProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 842);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ProductListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1236, 753);
            this.Name = "AdminProductForm";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.AdminProductForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private MaterialSkin.Controls.MaterialListView ProductListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialButton AddProductButton;
        private MaterialSkin.Controls.MaterialButton DeleteProductButton;
    }
}

