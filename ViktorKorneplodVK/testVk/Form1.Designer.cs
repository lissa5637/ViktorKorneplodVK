﻿
namespace testVk
{
    partial class MainForm
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
            this.StartWebBrowser = new System.Windows.Forms.WebBrowser();
            this.AccessTokenTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FantekriBotHelper = new System.Windows.Forms.Button();
            this.buttonPostOnStrangeWall = new System.Windows.Forms.Button();
            this.DeletingBannedBlockedFriends = new System.Windows.Forms.Button();
            this.LikePhotoFriend = new System.Windows.Forms.Button();
            this.buttonLikePostOnPeoplesWall = new System.Windows.Forms.Button();
            this.Likebutton = new System.Windows.Forms.Button();
            this.ViktorPictureBox = new System.Windows.Forms.PictureBox();
            this.friendsSuggestions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViktorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartWebBrowser
            // 
            this.StartWebBrowser.Location = new System.Drawing.Point(640, 15);
            this.StartWebBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.StartWebBrowser.Name = "StartWebBrowser";
            this.StartWebBrowser.Size = new System.Drawing.Size(143, 271);
            this.StartWebBrowser.TabIndex = 2;
            this.StartWebBrowser.Url = new System.Uri("https://oauth.vk.com/authorize?client_id=8104769&display=page&redirect_uri=https:" +
        "//oauth.vk.com/blank.html&scope=friends+stories+photos+wall&response_type=token&" +
        "v=5.131&state=123456", System.UriKind.Absolute);
            this.StartWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // AccessTokenTextBox
            // 
            this.AccessTokenTextBox.Location = new System.Drawing.Point(16, 439);
            this.AccessTokenTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccessTokenTextBox.Name = "AccessTokenTextBox";
            this.AccessTokenTextBox.Size = new System.Drawing.Size(791, 22);
            this.AccessTokenTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(31, 38);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(109, 39);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "label1";
            this.LastNameLabel.Click += new System.EventHandler(this.LastNameLabel_Click);
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Location = new System.Drawing.Point(399, 38);
            this.AvatarPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(183, 172);
            this.AvatarPictureBox.TabIndex = 5;
            this.AvatarPictureBox.TabStop = false;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(31, 94);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(109, 39);
            this.FirstNameLabel.TabIndex = 6;
            this.FirstNameLabel.Text = "label1";
            this.FirstNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // FantekriBotHelper
            // 
            this.FantekriBotHelper.Location = new System.Drawing.Point(269, 383);
            this.FantekriBotHelper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FantekriBotHelper.Name = "FantekriBotHelper";
            this.FantekriBotHelper.Size = new System.Drawing.Size(207, 49);
            this.FantekriBotHelper.TabIndex = 7;
            this.FantekriBotHelper.Text = "Советчик";
            this.FantekriBotHelper.UseVisualStyleBackColor = true;
            this.FantekriBotHelper.Click += new System.EventHandler(this.FantekriBotHelper_Click);
            // 
            // buttonPostOnStrangeWall
            // 
            this.buttonPostOnStrangeWall.Location = new System.Drawing.Point(16, 238);
            this.buttonPostOnStrangeWall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPostOnStrangeWall.Name = "buttonPostOnStrangeWall";
            this.buttonPostOnStrangeWall.Size = new System.Drawing.Size(233, 68);
            this.buttonPostOnStrangeWall.TabIndex = 8;
            this.buttonPostOnStrangeWall.Text = "Комментарии к постам в сообществах";
            this.buttonPostOnStrangeWall.UseVisualStyleBackColor = true;
            this.buttonPostOnStrangeWall.Click += new System.EventHandler(this.buttonPostOnStrangeWall_Click);
            // 
            // DeletingBannedBlockedFriends
            // 
            this.DeletingBannedBlockedFriends.Location = new System.Drawing.Point(15, 313);
            this.DeletingBannedBlockedFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeletingBannedBlockedFriends.Name = "DeletingBannedBlockedFriends";
            this.DeletingBannedBlockedFriends.Size = new System.Drawing.Size(235, 64);
            this.DeletingBannedBlockedFriends.TabIndex = 7;
            this.DeletingBannedBlockedFriends.Text = "удаление из друзей заблокированных/забанненых";
            this.DeletingBannedBlockedFriends.UseVisualStyleBackColor = true;
            this.DeletingBannedBlockedFriends.Click += new System.EventHandler(this.DeletingBannedBlockedFriends_Click);
            // 
            // LikePhotoFriend
            // 
            this.LikePhotoFriend.Location = new System.Drawing.Point(16, 383);
            this.LikePhotoFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LikePhotoFriend.Name = "LikePhotoFriend";
            this.LikePhotoFriend.Size = new System.Drawing.Size(233, 49);
            this.LikePhotoFriend.TabIndex = 8;
            this.LikePhotoFriend.Text = "лайкать фотографии друга";
            this.LikePhotoFriend.UseVisualStyleBackColor = true;
            this.LikePhotoFriend.Click += new System.EventHandler(this.LikePhotoFriend_Click);
            // 
            // buttonLikePostOnPeoplesWall
            // 
            this.buttonLikePostOnPeoplesWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLikePostOnPeoplesWall.Location = new System.Drawing.Point(269, 313);
            this.buttonLikePostOnPeoplesWall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLikePostOnPeoplesWall.Name = "buttonLikePostOnPeoplesWall";
            this.buttonLikePostOnPeoplesWall.Size = new System.Drawing.Size(207, 64);
            this.buttonLikePostOnPeoplesWall.TabIndex = 7;
            this.buttonLikePostOnPeoplesWall.Text = "лайкер постов на стене человека";
            this.buttonLikePostOnPeoplesWall.UseVisualStyleBackColor = true;
            this.buttonLikePostOnPeoplesWall.Click += new System.EventHandler(this.buttonLikePostOnPeoplesWall_Click);
            // 
            // Likebutton
            // 
            this.Likebutton.Location = new System.Drawing.Point(16, 171);
            this.Likebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Likebutton.Name = "Likebutton";
            this.Likebutton.Size = new System.Drawing.Size(233, 59);
            this.Likebutton.TabIndex = 7;
            this.Likebutton.Text = "лайкер фото на стене сообщества";
            this.Likebutton.UseVisualStyleBackColor = true;
            this.Likebutton.Click += new System.EventHandler(this.Likebutton_Click);
            // 
            // ViktorPictureBox
            // 
            this.ViktorPictureBox.Image = global::testVk.Properties.Resources.ВК;
            this.ViktorPictureBox.Location = new System.Drawing.Point(640, 293);
            this.ViktorPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViktorPictureBox.Name = "ViktorPictureBox";
            this.ViktorPictureBox.Size = new System.Drawing.Size(811, 502);
            this.ViktorPictureBox.TabIndex = 9;
            this.ViktorPictureBox.TabStop = false;
            // 
            // friendsSuggestions
            // 
            this.friendsSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friendsSuggestions.Location = new System.Drawing.Point(269, 240);
            this.friendsSuggestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsSuggestions.Name = "friendsSuggestions";
            this.friendsSuggestions.Size = new System.Drawing.Size(207, 64);
            this.friendsSuggestions.TabIndex = 10;
            this.friendsSuggestions.Text = "добавляю рекомендованных друзей";
            this.friendsSuggestions.UseVisualStyleBackColor = true;
            this.friendsSuggestions.Click += new System.EventHandler(this.friendsSuggestions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 498);
            this.Controls.Add(this.friendsSuggestions);
            this.Controls.Add(this.ViktorPictureBox);
            this.Controls.Add(this.LikePhotoFriend);
            this.Controls.Add(this.DeletingBannedBlockedFriends);
            this.Controls.Add(this.buttonPostOnStrangeWall);
            this.Controls.Add(this.FantekriBotHelper);
            this.Controls.Add(this.buttonLikePostOnPeoplesWall);
            this.Controls.Add(this.Likebutton);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.AccessTokenTextBox);
            this.Controls.Add(this.StartWebBrowser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Виктор Корнеплод VK";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViktorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser StartWebBrowser;
        private System.Windows.Forms.TextBox AccessTokenTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button FantekriBotHelper;
        private System.Windows.Forms.Button buttonPostOnStrangeWall;
        private System.Windows.Forms.Button DeletingBannedBlockedFriends;
        private System.Windows.Forms.Button LikePhotoFriend;
        private System.Windows.Forms.Button buttonLikePostOnPeoplesWall;
        private System.Windows.Forms.Button Likebutton;
        private System.Windows.Forms.PictureBox ViktorPictureBox;
        private System.Windows.Forms.Button friendsSuggestions;
    }
}

