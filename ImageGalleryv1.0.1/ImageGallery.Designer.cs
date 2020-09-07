namespace ImageGalleryv1._0._1
{
    partial class ImageGallery
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
        //defines all required Controls here
        #region Windows Form Designer generated code
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _searchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox _search;
        private C1.Win.C1Tile.C1TileControl _imageTileControl;
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tile1;
        private C1.Win.C1Tile.Tile tile2;
        private C1.Win.C1Tile.Tile tile3;
        private C1.C1Pdf.C1PdfDocument imagePdfDocument;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.PictureBox _export;
        private System.Windows.Forms.TextBox greetuser;
        private CircularButton option_4Button;
        private System.Windows.Forms.Button close;
        private CircularButton Option_8Button;
        private CircularTextBox customTextBoxSearch;
        private CircularButton RestartButton;
        private System.Windows.Forms.Label searchesleftlabel;
        private System.Windows.Forms.Button backcolorchange;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGallery));
            C1.Win.C1Tile.PanelElement panelElement1 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement1 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement1 = new C1.Win.C1Tile.TextElement();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._searchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._search = new System.Windows.Forms.PictureBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this._export = new System.Windows.Forms.PictureBox();
            this.backcolorchange = new System.Windows.Forms.Button();
            this.searchesleftlabel = new System.Windows.Forms.Label();
            this.RestartButton = new ImageGalleryv1._0._1.CircularButton();
            this.customTextBoxSearch = new ImageGalleryv1._0._1.CircularTextBox();
            this.Option_8Button = new ImageGalleryv1._0._1.CircularButton();
            this.option_4Button = new ImageGalleryv1._0._1.CircularButton();
            this.close = new System.Windows.Forms.Button();
            this.greetuser = new System.Windows.Forms.TextBox();
            this._imageTileControl = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.tile2 = new C1.Win.C1Tile.Tile();
            this.tile3 = new C1.Win.C1Tile.Tile();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.imagePdfDocument = new C1.C1Pdf.C1PdfDocument();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._export)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.circularProgressBar1);
            this.splitContainer1.Panel2.Controls.Add(this._export);
            this.splitContainer1.Panel2.Controls.Add(this.backcolorchange);
            this.splitContainer1.Panel2.Controls.Add(this.searchesleftlabel);
            this.splitContainer1.Panel2.Controls.Add(this.RestartButton);
            this.splitContainer1.Panel2.Controls.Add(this.customTextBoxSearch);
            this.splitContainer1.Panel2.Controls.Add(this.Option_8Button);
            this.splitContainer1.Panel2.Controls.Add(this.option_4Button);
            this.splitContainer1.Panel2.Controls.Add(this.close);
            this.splitContainer1.Panel2.Controls.Add(this.greetuser);
            this.splitContainer1.Panel2.Controls.Add(this._imageTileControl);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(972, 814);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(197, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 34);
            this.panel1.TabIndex = 0;
            // 
            // _searchBox
            // 
            this._searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._searchBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._searchBox.Location = new System.Drawing.Point(0, 0);
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(382, 30);
            this._searchBox.TabIndex = 0;
            this._searchBox.Text = "Search Image";
            this._searchBox.Visible = false;
            this._searchBox.Click += new System.EventHandler(this._searchBox_Click);
            this._searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._searchBox_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._search);
            this.panel2.Location = new System.Drawing.Point(584, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 12, 45, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 16);
            this.panel2.TabIndex = 1;
            // 
            // _search
            // 
            this._search.BackColor = System.Drawing.Color.GhostWhite;
            this._search.Image = ((System.Drawing.Image)(resources.GetObject("_search.Image")));
            this._search.Location = new System.Drawing.Point(-2, -12);
            this._search.Margin = new System.Windows.Forms.Padding(0);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(35, 40);
            this._search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._search.TabIndex = 0;
            this._search.TabStop = false;
            this._search.Visible = false;
            this._search.Click += new System.EventHandler(this._search_Click);
            this._search.Paint += new System.Windows.Forms.PaintEventHandler(this._search_Paint);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.circularProgressBar1.AnimationSpeed = 390;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.MistyRose;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(422, 231);
            this.circularProgressBar1.MarqueeAnimationSpeed = 1000;
            this.circularProgressBar1.Maximum = 80;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 1;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Beige;
            this.circularProgressBar1.ProgressWidth = 13;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(99, 84);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 17;
            this.circularProgressBar1.Text = "Please Wait";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Visible = false;
            // 
            // _export
            // 
            this._export.BackColor = System.Drawing.Color.LavenderBlush;
            this._export.Image = ((System.Drawing.Image)(resources.GetObject("_export.Image")));
            this._export.InitialImage = null;
            this._export.Location = new System.Drawing.Point(3, 3);
            this._export.Name = "_export";
            this._export.Size = new System.Drawing.Size(186, 61);
            this._export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._export.TabIndex = 3;
            this._export.TabStop = false;
            this._export.Tag = "2";
            this._export.Visible = false;
            this._export.Click += new System.EventHandler(this._export_Click);
            this._export.Paint += new System.Windows.Forms.PaintEventHandler(this._export_Paint);
            // 
            // backcolorchange
            // 
            this.backcolorchange.BackColor = System.Drawing.Color.MistyRose;
            this.backcolorchange.Font = new System.Drawing.Font("Sitka Display", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backcolorchange.Location = new System.Drawing.Point(43, 520);
            this.backcolorchange.Name = "backcolorchange";
            this.backcolorchange.Size = new System.Drawing.Size(110, 89);
            this.backcolorchange.TabIndex = 16;
            this.backcolorchange.Text = "Change Background ";
            this.backcolorchange.UseVisualStyleBackColor = false;
            this.backcolorchange.Click += new System.EventHandler(this.backgroundcolorchange);
            // 
            // searchesleftlabel
            // 
            this.searchesleftlabel.BackColor = System.Drawing.Color.White;
            this.searchesleftlabel.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchesleftlabel.ForeColor = System.Drawing.Color.Black;
            this.searchesleftlabel.Location = new System.Drawing.Point(235, 530);
            this.searchesleftlabel.Name = "searchesleftlabel";
            this.searchesleftlabel.Size = new System.Drawing.Size(218, 61);
            this.searchesleftlabel.TabIndex = 15;
            // 
            // RestartButton
            // 
            this.RestartButton.Image = ((System.Drawing.Image)(resources.GetObject("RestartButton.Image")));
            this.RestartButton.Location = new System.Drawing.Point(720, 520);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(101, 99);
            this.RestartButton.TabIndex = 14;
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // customTextBoxSearch
            // 
            this.customTextBoxSearch.BackColor = System.Drawing.Color.MistyRose;
            this.customTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customTextBoxSearch.Font = new System.Drawing.Font("Sitka Display", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBoxSearch.Location = new System.Drawing.Point(570, 300);
            this.customTextBoxSearch.Multiline = true;
            this.customTextBoxSearch.Name = "customTextBoxSearch";
            this.customTextBoxSearch.Size = new System.Drawing.Size(168, 127);
            this.customTextBoxSearch.TabIndex = 13;
            this.customTextBoxSearch.Text = "Custom Search";
            this.customTextBoxSearch.Click += new System.EventHandler(this.customTextBoxSearch_Click);
            this.customTextBoxSearch.TextChanged += new System.EventHandler(this.customSearchBoxTextChanged);
            this.customTextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customTextBoxSearch_KeyPress);
            // 
            // Option_8Button
            // 
            this.Option_8Button.BackColor = System.Drawing.Color.MistyRose;
            this.Option_8Button.Font = new System.Drawing.Font("Sitka Display", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_8Button.Location = new System.Drawing.Point(328, 300);
            this.Option_8Button.Name = "Option_8Button";
            this.Option_8Button.Size = new System.Drawing.Size(174, 127);
            this.Option_8Button.TabIndex = 11;
            this.Option_8Button.Text = "8";
            this.Option_8Button.UseVisualStyleBackColor = false;
            this.Option_8Button.Click += new System.EventHandler(this.Option8Button);
            // 
            // option_4Button
            // 
            this.option_4Button.BackColor = System.Drawing.Color.MistyRose;
            this.option_4Button.FlatAppearance.BorderSize = 0;
            this.option_4Button.Font = new System.Drawing.Font("Sitka Banner", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_4Button.Location = new System.Drawing.Point(121, 300);
            this.option_4Button.Name = "option_4Button";
            this.option_4Button.Size = new System.Drawing.Size(162, 127);
            this.option_4Button.TabIndex = 10;
            this.option_4Button.Text = "4";
            this.option_4Button.UseVisualStyleBackColor = false;
            this.option_4Button.Click += new System.EventHandler(this.Option4Button);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(840, 520);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(101, 99);
            this.close.TabIndex = 8;
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // greetuser
            // 
            this.greetuser.BackColor = System.Drawing.Color.White;
            this.greetuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.greetuser.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetuser.Location = new System.Drawing.Point(211, 70);
            this.greetuser.Multiline = true;
            this.greetuser.Name = "greetuser";
            this.greetuser.ReadOnly = true;
            this.greetuser.Size = new System.Drawing.Size(542, 155);
            this.greetuser.TabIndex = 4;
            this.greetuser.Text = "Hi there,How many Images do you want to see?";
            this.greetuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _imageTileControl
            // 
            this._imageTileControl.AllowChecking = true;
            this._imageTileControl.AllowRearranging = true;
            this._imageTileControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._imageTileControl.CellHeight = 78;
            this._imageTileControl.CellSpacing = 11;
            this._imageTileControl.CellWidth = 78;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this._imageTileControl.DefaultTemplate.Elements.Add(panelElement1);
            this._imageTileControl.Groups.Add(this.group1);
            this._imageTileControl.Location = new System.Drawing.Point(3, 70);
            this._imageTileControl.Name = "_imageTileControl";
            this._imageTileControl.Size = new System.Drawing.Size(969, 700);
            this._imageTileControl.SurfacePadding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this._imageTileControl.SwipeDistance = 20;
            this._imageTileControl.SwipeRearrangeDistance = 98;
            this._imageTileControl.TabIndex = 1;
            this._imageTileControl.TileBackColor = System.Drawing.Color.White;
            this._imageTileControl.TileChecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileChecked);
            this._imageTileControl.TileUnchecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileUnchecked);
            this._imageTileControl.Paint += new System.Windows.Forms.PaintEventHandler(this._imageTileControl_Paint);
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.DarkGray;
            this.tile1.Name = "tile1";
            this.tile1.Text = "Tile 1";
            this.tile1.Visible = false;
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Teal;
            this.tile2.Name = "tile2";
            this.tile2.Text = "Tile 2";
            this.tile2.Visible = false;
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.SteelBlue;
            this.tile3.Name = "tile3";
            this.tile3.Text = "Tile 3";
            this.tile3.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 28);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 20);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // imagePdfDocument
            // 
            this.imagePdfDocument.DocumentInfo.Author = "";
            this.imagePdfDocument.DocumentInfo.CreationDate = new System.DateTime(((long)(0)));
            this.imagePdfDocument.DocumentInfo.Creator = "";
            this.imagePdfDocument.DocumentInfo.Keywords = "";
            this.imagePdfDocument.DocumentInfo.Producer = "ComponentOne C1Pdf";
            this.imagePdfDocument.DocumentInfo.Subject = "";
            this.imagePdfDocument.DocumentInfo.Title = "";
            this.imagePdfDocument.MaxHeaderBookmarkLevel = 0;
            this.imagePdfDocument.PdfVersion = "1.3";
            this.imagePdfDocument.RefDC = null;
            this.imagePdfDocument.RotateAngle = 0F;
            this.imagePdfDocument.UseFastTextOut = true;
            this.imagePdfDocument.UseFontShaping = true;
            // 
            // ImageGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 816);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "ImageGallery";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery";
            this.Load += new System.EventHandler(this.ImageGallery_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._export)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

     
    
    }
}

