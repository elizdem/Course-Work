
namespace ClothingShop.Views
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.SoldProductListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.StatButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // SoldProductListView
            // 
            this.SoldProductListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoldProductListView.AutoSizeTable = false;
            this.SoldProductListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SoldProductListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SoldProductListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SoldProductListView.Depth = 0;
            this.SoldProductListView.FullRowSelect = true;
            this.SoldProductListView.HideSelection = false;
            this.SoldProductListView.Location = new System.Drawing.Point(125, 198);
            this.SoldProductListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.SoldProductListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SoldProductListView.MouseState = MaterialSkin.MouseState.OUT;
            this.SoldProductListView.Name = "SoldProductListView";
            this.SoldProductListView.OwnerDraw = true;
            this.SoldProductListView.Size = new System.Drawing.Size(698, 402);
            this.SoldProductListView.TabIndex = 1;
            this.SoldProductListView.UseCompatibleStateImageBehavior = false;
            this.SoldProductListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Сумма";
            this.columnHeader1.Width = 312;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата";
            this.columnHeader2.Width = 205;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AnimateReadOnly = false;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Depth = 0;
            this.SearchTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTextBox.LeadingIcon = null;
            this.SearchTextBox.Location = new System.Drawing.Point(125, 115);
            this.SearchTextBox.MaxLength = 50;
            this.SearchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SearchTextBox.Multiline = false;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(400, 50);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.Text = "";
            this.SearchTextBox.TrailingIcon = null;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // StatButton
            // 
            this.StatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatButton.AutoSize = false;
            this.StatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StatButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StatButton.Depth = 0;
            this.StatButton.HighEmphasis = true;
            this.StatButton.Icon = null;
            this.StatButton.Location = new System.Drawing.Point(648, 115);
            this.StatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StatButton.Name = "StatButton";
            this.StatButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StatButton.Size = new System.Drawing.Size(175, 50);
            this.StatButton.TabIndex = 6;
            this.StatButton.Text = "Отчет";
            this.StatButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StatButton.UseAccentColor = false;
            this.StatButton.UseVisualStyleBackColor = true;
            this.StatButton.Click += new System.EventHandler(this.StatButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(122, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Поиск по дате";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 688);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.StatButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SoldProductListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(954, 688);
            this.Name = "StatisticForm";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView SoldProductListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialTextBox SearchTextBox;
        private MaterialSkin.Controls.MaterialButton StatButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}