namespace FoxFinder
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.foxfinder = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.videos = new System.Windows.Forms.Button();
            this.books = new System.Windows.Forms.Button();
            this.games = new System.Windows.Forms.Button();
            this.fav = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foxfinder)).BeginInit();
            this.SuspendLayout();
            // 
            // foxfinder
            // 
            this.foxfinder.BackColor = System.Drawing.Color.Transparent;
            this.foxfinder.Image = ((System.Drawing.Image)(resources.GetObject("foxfinder.Image")));
            this.foxfinder.ImageLocation = "";
            this.foxfinder.InitialImage = null;
            this.foxfinder.Location = new System.Drawing.Point(1, -1);
            this.foxfinder.Name = "foxfinder";
            this.foxfinder.Size = new System.Drawing.Size(125, 125);
            this.foxfinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foxfinder.TabIndex = 5;
            this.foxfinder.TabStop = false;
            this.foxfinder.Click += new System.EventHandler(this.foxfinder_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(125, 921);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // videos
            // 
            this.videos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videos.Location = new System.Drawing.Point(1, 244);
            this.videos.Name = "videos";
            this.videos.Size = new System.Drawing.Size(125, 68);
            this.videos.TabIndex = 7;
            this.videos.Text = "Video\'s";
            this.videos.UseVisualStyleBackColor = true;
            this.videos.Click += new System.EventHandler(this.videos_Click);
            // 
            // books
            // 
            this.books.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.books.Location = new System.Drawing.Point(1, 356);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(125, 68);
            this.books.TabIndex = 8;
            this.books.Text = "Books";
            this.books.UseVisualStyleBackColor = true;
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // games
            // 
            this.games.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.games.Location = new System.Drawing.Point(1, 461);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(125, 68);
            this.games.TabIndex = 9;
            this.games.Text = "Games";
            this.games.UseVisualStyleBackColor = true;
            this.games.Click += new System.EventHandler(this.games_Click);
            // 
            // fav
            // 
            this.fav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fav.Location = new System.Drawing.Point(1, 570);
            this.fav.Name = "fav";
            this.fav.Size = new System.Drawing.Size(125, 68);
            this.fav.TabIndex = 10;
            this.fav.Text = "Favs";
            this.fav.UseVisualStyleBackColor = true;
            this.fav.Click += new System.EventHandler(this.fav_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(1, 677);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 68);
            this.add.TabIndex = 11;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.foxfinder);
            this.Controls.Add(this.add);
            this.Controls.Add(this.fav);
            this.Controls.Add(this.games);
            this.Controls.Add(this.books);
            this.Controls.Add(this.videos);
            this.Controls.Add(this.listView1);
            this.Name = "Index";
            this.Text = "video";
            ((System.ComponentModel.ISupportInitialize)(this.foxfinder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox foxfinder;
        private ListView listView1;
        private Button videos;
        private Button books;
        private Button games;
        private Button fav;
        private Button add;
    }
}