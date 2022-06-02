
namespace ClothingShop.Views
{
    partial class MakeOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeOrderForm));
            this.ArticleTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.AddToListBoxButton = new MaterialSkin.Controls.MaterialButton();
            this.MakeOrderListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResultButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ArticleTextBox
            // 
            this.ArticleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ArticleTextBox.AnimateReadOnly = false;
            this.ArticleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArticleTextBox.Depth = 0;
            this.ArticleTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ArticleTextBox.LeadingIcon = null;
            this.ArticleTextBox.Location = new System.Drawing.Point(60, 122);
            this.ArticleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArticleTextBox.MaxLength = 50;
            this.ArticleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ArticleTextBox.Multiline = false;
            this.ArticleTextBox.Name = "ArticleTextBox";
            this.ArticleTextBox.Size = new System.Drawing.Size(760, 50);
            this.ArticleTextBox.TabIndex = 1;
            this.ArticleTextBox.Text = "";
            this.ArticleTextBox.TrailingIcon = null;
            // 
            // AddToListBoxButton
            // 
            this.AddToListBoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToListBoxButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddToListBoxButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddToListBoxButton.Depth = 0;
            this.AddToListBoxButton.HighEmphasis = true;
            this.AddToListBoxButton.Icon = null;
            this.AddToListBoxButton.Location = new System.Drawing.Point(867, 122);
            this.AddToListBoxButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddToListBoxButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddToListBoxButton.Name = "AddToListBoxButton";
            this.AddToListBoxButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddToListBoxButton.Size = new System.Drawing.Size(100, 36);
            this.AddToListBoxButton.TabIndex = 4;
            this.AddToListBoxButton.Text = "Добавить";
            this.AddToListBoxButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddToListBoxButton.UseAccentColor = false;
            this.AddToListBoxButton.UseVisualStyleBackColor = true;
            this.AddToListBoxButton.Click += new System.EventHandler(this.AddToListBoxButton_Click);
            // 
            // MakeOrderListView
            // 
            this.MakeOrderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeOrderListView.AutoSizeTable = false;
            this.MakeOrderListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MakeOrderListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MakeOrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.MakeOrderListView.Depth = 0;
            this.MakeOrderListView.FullRowSelect = true;
            this.MakeOrderListView.HideSelection = false;
            this.MakeOrderListView.Location = new System.Drawing.Point(60, 216);
            this.MakeOrderListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.MakeOrderListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MakeOrderListView.MouseState = MaterialSkin.MouseState.OUT;
            this.MakeOrderListView.Name = "MakeOrderListView";
            this.MakeOrderListView.OwnerDraw = true;
            this.MakeOrderListView.Size = new System.Drawing.Size(866, 294);
            this.MakeOrderListView.TabIndex = 5;
            this.MakeOrderListView.UseCompatibleStateImageBehavior = false;
            this.MakeOrderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Артикул";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование";
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Стоимость";
            // 
            // ResultButton
            // 
            this.ResultButton.AutoSize = false;
            this.ResultButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResultButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ResultButton.Depth = 0;
            this.ResultButton.HighEmphasis = true;
            this.ResultButton.Icon = null;
            this.ResultButton.Location = new System.Drawing.Point(429, 550);
            this.ResultButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ResultButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ResultButton.Size = new System.Drawing.Size(176, 74);
            this.ResultButton.TabIndex = 6;
            this.ResultButton.Text = "ЧЕК";
            this.ResultButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ResultButton.UseAccentColor = false;
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // MakeOrderForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1063, 688);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.MakeOrderListView);
            this.Controls.Add(this.AddToListBoxButton);
            this.Controls.Add(this.ArticleTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MakeOrderForm";
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.MakeOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox ArticleTextBox;
        private MaterialSkin.Controls.MaterialButton AddToListBoxButton;
        private MaterialSkin.Controls.MaterialListView MakeOrderListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialButton ResultButton;
    }
}