using RecipeRover.Util;

namespace RecipeRover
{
    partial class HomeForm
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
            components = new System.ComponentModel.Container();
            roundedPictureBox1 = new RoundedPictureBox();
            tb_search = new TextBox();
            panel1 = new Panel();
            btn_news = new Button();
            btn_open_new_recipes = new Button();
            btn_about = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2 = new Panel();
            btn_clean = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            tb_youtube_url = new TextBox();
            tb_image_url = new TextBox();
            tb_Instr = new TextBox();
            tb_ingredients = new TextBox();
            tb_prep_time = new TextBox();
            lbl_youtube = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tb_name = new TextBox();
            label2 = new Label();
            pb_recipe_image = new RoundedPictureBox();
            listView = new ListView();
            ID = new ColumnHeader();
            Name = new ColumnHeader();
            Time = new ColumnHeader();
            Date = new ColumnHeader();
            Instruction = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_recipe_image).BeginInit();
            SuspendLayout();
            // 
            // roundedPictureBox1
            // 
            roundedPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPictureBox1.BackColor = SystemColors.ButtonHighlight;
            roundedPictureBox1.BorderRadius = 10;
            roundedPictureBox1.Image = Properties.Resources.salat;
            roundedPictureBox1.Location = new Point(11, 93);
            roundedPictureBox1.Name = "roundedPictureBox1";
            roundedPictureBox1.Size = new Size(1734, 133);
            roundedPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox1.TabIndex = 1;
            roundedPictureBox1.TabStop = false;
            roundedPictureBox1.Click += roundedPictureBox1_Click;
            // 
            // tb_search
            // 
            tb_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_search.ImeMode = ImeMode.On;
            tb_search.Location = new Point(1437, 252);
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Search for Recipe";
            tb_search.Size = new Size(307, 27);
            tb_search.TabIndex = 2;
            tb_search.TabStop = false;
            tb_search.Tag = "";
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(btn_news);
            panel1.Controls.Add(btn_open_new_recipes);
            panel1.Controls.Add(btn_about);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1758, 71);
            panel1.TabIndex = 3;
            // 
            // btn_news
            // 
            btn_news.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_news.FlatAppearance.BorderSize = 0;
            btn_news.FlatStyle = FlatStyle.Flat;
            btn_news.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_news.ForeColor = SystemColors.ButtonHighlight;
            btn_news.Location = new Point(1408, 21);
            btn_news.Name = "btn_news";
            btn_news.Size = new Size(106, 33);
            btn_news.TabIndex = 3;
            btn_news.Text = "News";
            btn_news.UseVisualStyleBackColor = true;
            btn_news.Click += btn_news_Click;
            // 
            // btn_open_new_recipes
            // 
            btn_open_new_recipes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_open_new_recipes.FlatAppearance.BorderSize = 0;
            btn_open_new_recipes.FlatStyle = FlatStyle.Flat;
            btn_open_new_recipes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_open_new_recipes.ForeColor = SystemColors.ButtonHighlight;
            btn_open_new_recipes.Location = new Point(1511, 21);
            btn_open_new_recipes.Name = "btn_open_new_recipes";
            btn_open_new_recipes.Size = new Size(136, 33);
            btn_open_new_recipes.TabIndex = 2;
            btn_open_new_recipes.Text = "Website";
            btn_open_new_recipes.UseVisualStyleBackColor = true;
            btn_open_new_recipes.Click += btn_open_new_recipes_Click;
            // 
            // btn_about
            // 
            btn_about.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_about.FlatAppearance.BorderSize = 0;
            btn_about.FlatStyle = FlatStyle.Flat;
            btn_about.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_about.ForeColor = SystemColors.ButtonHighlight;
            btn_about.Location = new Point(1640, 20);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(94, 33);
            btn_about.TabIndex = 1;
            btn_about.Text = "About";
            btn_about.UseVisualStyleBackColor = true;
            btn_about.Click += btn_about_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(11, 20);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 0;
            label1.Text = "Recipe Rover";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(btn_clean);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(tb_youtube_url);
            panel2.Controls.Add(tb_image_url);
            panel2.Controls.Add(tb_Instr);
            panel2.Controls.Add(tb_ingredients);
            panel2.Controls.Add(tb_prep_time);
            panel2.Controls.Add(lbl_youtube);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tb_name);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pb_recipe_image);
            panel2.Location = new Point(1059, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 724);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // btn_clean
            // 
            btn_clean.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_clean.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clean.ForeColor = Color.Orange;
            btn_clean.Location = new Point(578, 500);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(95, 35);
            btn_clean.TabIndex = 16;
            btn_clean.Text = "Clean";
            btn_clean.UseVisualStyleBackColor = true;
            btn_clean.Click += btn_clean_Click;
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_delete.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.Crimson;
            btn_delete.Location = new Point(578, 556);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(95, 35);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_update.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(461, 556);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(95, 35);
            btn_update.TabIndex = 14;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(461, 500);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(95, 35);
            btn_add.TabIndex = 13;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // tb_youtube_url
            // 
            tb_youtube_url.Location = new Point(182, 449);
            tb_youtube_url.Margin = new Padding(3, 4, 3, 4);
            tb_youtube_url.Name = "tb_youtube_url";
            tb_youtube_url.PlaceholderText = "www.youtube.com/9RTb432";
            tb_youtube_url.Size = new Size(491, 27);
            tb_youtube_url.TabIndex = 12;
            // 
            // tb_image_url
            // 
            tb_image_url.Location = new Point(183, 396);
            tb_image_url.Margin = new Padding(3, 4, 3, 4);
            tb_image_url.Name = "tb_image_url";
            tb_image_url.PlaceholderText = "www.flaticon.com/pasta.jpg";
            tb_image_url.Size = new Size(490, 27);
            tb_image_url.TabIndex = 11;
            // 
            // tb_Instr
            // 
            tb_Instr.Location = new Point(183, 248);
            tb_Instr.Margin = new Padding(3, 4, 3, 4);
            tb_Instr.Multiline = true;
            tb_Instr.Name = "tb_Instr";
            tb_Instr.PlaceholderText = "Bring a large pot of salted water to a boil; cook linguine in...";
            tb_Instr.ScrollBars = ScrollBars.Vertical;
            tb_Instr.Size = new Size(491, 119);
            tb_Instr.TabIndex = 10;
            // 
            // tb_ingredients
            // 
            tb_ingredients.Location = new Point(183, 133);
            tb_ingredients.Margin = new Padding(3, 4, 3, 4);
            tb_ingredients.Multiline = true;
            tb_ingredients.Name = "tb_ingredients";
            tb_ingredients.PlaceholderText = "Spaghetti, garlic, tomato...";
            tb_ingredients.ScrollBars = ScrollBars.Vertical;
            tb_ingredients.Size = new Size(491, 92);
            tb_ingredients.TabIndex = 9;
            // 
            // tb_prep_time
            // 
            tb_prep_time.Location = new Point(183, 80);
            tb_prep_time.Margin = new Padding(3, 4, 3, 4);
            tb_prep_time.Name = "tb_prep_time";
            tb_prep_time.PlaceholderText = "30 Mins";
            tb_prep_time.Size = new Size(491, 27);
            tb_prep_time.TabIndex = 8;
            // 
            // lbl_youtube
            // 
            lbl_youtube.AutoSize = true;
            lbl_youtube.BorderStyle = BorderStyle.Fixed3D;
            lbl_youtube.FlatStyle = FlatStyle.Popup;
            lbl_youtube.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_youtube.ForeColor = Color.White;
            lbl_youtube.Location = new Point(27, 453);
            lbl_youtube.Name = "lbl_youtube";
            lbl_youtube.Size = new Size(119, 22);
            lbl_youtube.TabIndex = 7;
            lbl_youtube.Text = "Youtube Url :";
            lbl_youtube.Click += lbl_youtube_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 400);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 6;
            label6.Text = "Image Url :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 252);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 5;
            label5.Text = "Instruction :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 128);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 4;
            label4.Text = "Ingredients :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 80);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 3;
            label3.Text = "Prep. Time :";
            label3.Click += label3_Click;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(183, 27);
            tb_name.Margin = new Padding(3, 4, 3, 4);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "Pasta";
            tb_name.Size = new Size(491, 27);
            tb_name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 31);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // pb_recipe_image
            // 
            pb_recipe_image.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pb_recipe_image.BackColor = SystemColors.HighlightText;
            pb_recipe_image.BorderRadius = 10;
            pb_recipe_image.Image = Properties.Resources.no_image;
            pb_recipe_image.Location = new Point(27, 500);
            pb_recipe_image.Margin = new Padding(3, 4, 3, 4);
            pb_recipe_image.Name = "pb_recipe_image";
            pb_recipe_image.Size = new Size(180, 180);
            pb_recipe_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_recipe_image.TabIndex = 0;
            pb_recipe_image.TabStop = false;
            pb_recipe_image.Click += pb_recipe_image_Click;
            // 
            // listView
            // 
            listView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView.Columns.AddRange(new ColumnHeader[] { ID, Name, Time, Date, Instruction });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(11, 304);
            listView.Name = "listView";
            listView.Size = new Size(914, 724);
            listView.TabIndex = 6;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 40;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 200;
            // 
            // Time
            // 
            Time.Text = "Time";
            Time.Width = 75;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 100;
            // 
            // Instruction
            // 
            Instruction.Text = "Instruction";
            Instruction.Width = 410;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1758, 1055);
            Controls.Add(listView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tb_search);
            Controls.Add(roundedPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            //Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_recipe_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedPictureBox roundedPictureBox1;
        private TextBox tb_search;
        private Panel panel1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_about;
        private Button btn_open_new_recipes;
        private Button btn_news;
        private Panel panel2;
        private ListView listView;
        private ColumnHeader ID;
        private ColumnHeader Name;
        private ColumnHeader Time;
        private ColumnHeader Date;
        private ColumnHeader columnHeader1;
        private ColumnHeader Youtube;
        private ColumnHeader Instruction;
        private RoundedPictureBox roundedPictureBox2;
        private TextBox tb_name;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox tb_ingredients;
        private TextBox tb_prep_time;
        private TextBox tb_youtube_url;
        private TextBox tb_image_url;
        private TextBox tb_Instr;
        private RoundedPictureBox pb_recipe_image;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Label lbl_youtube;
        private Button btn_clean;
    }
}