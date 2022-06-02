
namespace ClothingShop.Views
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.loginTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.userComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.AutorizeButton = new MaterialSkin.Controls.MaterialButton();
            this.exitButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginTextBox.AnimateReadOnly = false;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Depth = 0;
            this.loginTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTextBox.LeadingIcon = null;
            this.loginTextBox.Location = new System.Drawing.Point(325, 226);
            this.loginTextBox.MaxLength = 50;
            this.loginTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.loginTextBox.Multiline = false;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(496, 50);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.Text = "";
            this.loginTextBox.TrailingIcon = null;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Location = new System.Drawing.Point(325, 326);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Password = true;
            this.passwordTextBox.Size = new System.Drawing.Size(496, 50);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.TrailingIcon = null;
            // 
            // userComboBox
            // 
            this.userComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userComboBox.AutoResize = false;
            this.userComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userComboBox.Depth = 0;
            this.userComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.userComboBox.DropDownHeight = 174;
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.DropDownWidth = 121;
            this.userComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.userComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.IntegralHeight = false;
            this.userComboBox.ItemHeight = 43;
            this.userComboBox.Items.AddRange(new object[] {
            "Администратор",
            "Продавец-консультант"});
            this.userComboBox.Location = new System.Drawing.Point(325, 108);
            this.userComboBox.MaxDropDownItems = 4;
            this.userComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(399, 49);
            this.userComboBox.StartIndex = 0;
            this.userComboBox.TabIndex = 2;
            // 
            // AutorizeButton
            // 
            this.AutorizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutorizeButton.AutoSize = false;
            this.AutorizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutorizeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AutorizeButton.Depth = 0;
            this.AutorizeButton.HighEmphasis = true;
            this.AutorizeButton.Icon = null;
            this.AutorizeButton.Location = new System.Drawing.Point(99, 484);
            this.AutorizeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AutorizeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutorizeButton.Name = "AutorizeButton";
            this.AutorizeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AutorizeButton.Size = new System.Drawing.Size(225, 60);
            this.AutorizeButton.TabIndex = 3;
            this.AutorizeButton.Text = "Войти";
            this.AutorizeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AutorizeButton.UseAccentColor = false;
            this.AutorizeButton.UseVisualStyleBackColor = true;
            this.AutorizeButton.Click += new System.EventHandler(this.AutorizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.AutoSize = false;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = true;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(519, 484);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitButton.Size = new System.Drawing.Size(225, 60);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitButton.UseAccentColor = false;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(35, 222);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Логин";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(35, 326);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Пароль";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(35, 108);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(172, 24);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Тип пользователя";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 607);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.AutorizeButton);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(855, 607);
            this.Name = "AuthorizationForm";
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox loginTextBox;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialComboBox userComboBox;
        private MaterialSkin.Controls.MaterialButton AutorizeButton;
        private MaterialSkin.Controls.MaterialButton exitButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}