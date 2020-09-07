using C1.Win.C1Tile;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ImageGalleryv1._0._1
{
    public partial class ImageGallery : Form
    {
        DataFetcher datafetch = new DataFetcher();// an instance of DataFechter class
        List<ImageItem> imagesList;// a list of ImageItem class
        int checkedItems = 0;//variable to keep a count of the checked tiles. This counter will be used to show or hide the export button
        int imagessearch = 0;//variable to custom search images
        bool isbuttonclicked = false;// boolean variable to ensure custom search
        int Noofsearches = 0;//variable to provide search limit functionality to app.
        int searchlimit = 3;//we can set searchLimit on our own

        //a dictionary to store already searched strings
        Dictionary<String, List<ImageItem>> cache = new Dictionary<string, List<ImageItem>>();
        public ImageGallery()
        {
            InitializeComponent();
        }

        private async void _search_Click(object sender, EventArgs e)
        {
                if ((Noofsearches < searchlimit))
                {
                initialsetup();
                try
                {
                    //custom number of images code
                    if (!isbuttonclicked)// if button not click tells custom search On
                    {
                        String get = customTextBoxSearch.Text;
                        while (get.Equals(""))
                        {
                            
                            MessageBox.Show("Please enter something in the CustomInputBox");
                            greetuser.Visible = true;
                            customTextBoxSearch.Visible = true;
                            //initialsetup();
                            return; // return because we don't want to
                            // run normal code of buton click
                        }
                        imagessearch = Int32.Parse(get);
                        
                        
                    }
                }
                catch
                {
                    MessageBox.Show("Dear User,Please Provide Valid Input");
                }

                // to handle Alike Searches
                //e.g GrapeCity ,grapecity,GRAPECITY,graPeCITY all means same.
                String input = _searchBox.Text.ToLower();
                    input = input.Replace(" ", "");

                while (input.Equals(""))//to verify null string isnot entered
                {
                    MessageBox.Show("Please enter something in the SearchBox");
                    return; // return because we don't want to run normal code of buton click
                }
                ProgressBar();//circularProgressBar
                if (!cache.ContainsKey(input))//checking in our dictionory whether searched text 
                    //is already there or not
                    {
                        imagesList = await datafetch.GetImageData(input, imagessearch);
                        cache.Add(input, imagesList);
                    }
                    else
                    {
                        MessageBox.Show("Dear User, I think you searched Same Result Earlier");
                        List<ImageItem> tempList = cache[input];
                        imagesList = tempList;
                    }
                    AddTiles(imagesList);

                finalsetup();

                }
                else
                {
                    MessageBox.Show("Dear User,Search Limit Exceeded App is Closing");
                    Application.Exit();
                }
           }
        private void initialsetup()
        {       
        _imageTileControl.Groups[0].Tiles.Clear();
            option_4Button.Visible = false;
            Option_8Button.Visible = false;
            greetuser.Visible = false;
            customTextBoxSearch.Visible = false;
            _export.Visible = false;
        }
        private void finalsetup()
        {
            circularProgressBar1.Visible = false;
            statusStrip1.Visible = false;
            Noofsearches++;
            searchesleftlabel.Text = $"Attempts Left:" + (searchlimit - Noofsearches).ToString();
        }
        private void ProgressBar()
        {//function for circular loader
            try
            {
                circularProgressBar1.Visible = true;
               for (int i = 1; i <= 60; i++)
                {
                   Thread.Sleep(2);
                   circularProgressBar1.Value = i;
                    circularProgressBar1.Update();
                }
            }
            catch
            {
                MessageBox.Show("Unexpected Error,We are restarting the App");
                System.Diagnostics.Process.
                    Start(Application.ExecutablePath); // to start new instance of application
                this.Close(); //to turn off current app
            }
            statusStrip1.Visible = true;
        }


        private void AddTiles(List<ImageItem> imageList)
        { //This method takes a list of images, 
                //loops through each image and add tile for each image
                _imageTileControl.Groups[0].Tiles.Clear();
                for (int i = 0; i < imageList.Count; i++)
                {
                    var imageitem = imageList[i];
                    Tile tile = new Tile();
                    tile.HorizontalSize = 2;
                    tile.VerticalSize = 2;
                    _imageTileControl.Groups[0].Tiles.Add(tile);

                    //converts the base64 encoding to the 
                    //corresponding image using MemoryStream class.
                    Image img = Image.FromStream(new MemoryStream(imageitem.Base64));
                    Template tl = new Template();
                    ImageElement ie = new ImageElement();
                    ie.ImageLayout = ForeImageLayout.Stretch;
                    tl.Elements.Add(ie);
                    tile.Template = tl;
                    tile.Image = img;
                }
        }

        private void _imageTileControl_TileChecked(object sender, TileEventArgs e)
        {
            checkedItems++;//increment the counter if tile is clicked
            _export.Visible = true;
        }

        private void _imageTileControl_TileUnchecked(object sender, TileEventArgs e)
        {
            checkedItems--;//decrement the counter if tile is clicked
            _export.Visible = checkedItems > 0;    //if the counter is zero, hide the export button:  
        }

        private void _export_Click(object sender, EventArgs e)
        {
            // method iterates through all the tiles, gets its image and 
            //convert this list of images to pdf using
            // ConvertToPdf method
                List<Image> images = new List<Image>();
                foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
                {
                    if (tile.Checked)
                    {
                        images.Add(tile.Image);
                    }
                }
                ConvertToPdf(images);
                //Attachment attachment = imagePdfDocument;

                //            Attachment a = new Attachment(imagePdfDocument, "application/pdf");
                //          sender.SendMail("a@a.com", "a@a.com", "subject", "Body", a);


                //After converting to PDF, it opens a SaveFileDialog to save the image
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "pdf";
                saveFile.Filter = "PDF files (*.pdf)|*.pdf*";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
  imagePdfDocument.Save(saveFile.FileName);
                }            
        }
    
        private void ConvertToPdf(List<Image> images)
        {
        imagePdfDocument = new C1.C1Pdf.C1PdfDocument();
                //This method creates a page for each image 
                //and draws the image using DrawImage method
                RectangleF rect = imagePdfDocument.PageRectangle;
                bool firstPage = true;
                foreach (var selectedimg in images)
                {
                    if (!firstPage)
                    {
                        imagePdfDocument.NewPage();
                    }
                    firstPage = false;
                    rect.Inflate(-72, -72);
                    imagePdfDocument.DrawImage(selectedimg, rect);
                }
            }
            
       
        private void _imageTileControl_Paint(object sender, PaintEventArgs e)
        {
            //used to draw a separator
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 43, 800, 43);
        }


        private void _export_Paint(object sender, PaintEventArgs e)
        {
            //drawing a grey border for export to pdf button
            Rectangle r = new Rectangle(_export.Location.X, _export.Location.Y, _export.Width, _export.Height);
            r.X -= 29;
            r.Y -= 3;
            r.Width--;
            r.Height--;
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
            e.Graphics.DrawLine(p, new Point(0, 43), new
           Point(this.Width, 43));
        }

        private void close_Click(object sender, EventArgs e)
        { //to close the App
            Application.Exit();
        }
        
        private void _search_Paint(object sender, PaintEventArgs e)
        {
            //  to add a grey border to the search box

            Rectangle r = _searchBox.Bounds;
            r.Inflate(3, 3);
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
        }
        //function for some load Animations
        private void ImageGallery_Load(object sender, EventArgs e)
        {
            winAPI.AnimateWindow(this.Handle, 2000, winAPI.VER_POSITIVE);
        }
        //function for Option Selected4
        private void Option4Button(object sender, EventArgs e)
        {imagessearch = 4;
            circularButtonHelper(1);  
        }
        //function for Option Selected8

        private void Option8Button(object sender, EventArgs e)
        {
            imagessearch = 8; 
            circularButtonHelper(2);
        }
        //function for Helping Options Button to set Properties
        private void circularButtonHelper(int index)
        {
            if (index == 1)
            {
                Option_8Button.Visible = false;

            }
            else if (index == 2)
            {
                option_4Button.Visible = false;
            }
            customTextBoxSearch.Visible = false;
            _search.Visible = true;
            isbuttonclicked = true;
            _searchBox.Visible = true;
        }


        //makes some UI transitions after user enters value in CustomSearchBox
        private void customSearchBoxTextChanged(object sender, EventArgs e)
        {
            _searchBox.Visible = true;
            _search.Visible = true;
            option_4Button.Visible = false;
            Option_8Button.Visible = false;
        }

        //Restarts App
        private void RestartButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            this.Close(); //to turn off current app

        }
        //Makes inside Text Disappear when Custom Search Box is Clicked
        private void customTextBoxSearch_Click(object sender, EventArgs e)
        {
            customTextBoxSearch.Text = "";
        }
        //Makes indide Text Disappear when Search Box is Clicked
        private void _searchBox_Click(object sender, EventArgs e)
        {
            _searchBox.Text = "";

        }
        //changes background color of Panel1 And Panel2
        private void backgroundcolorchange(object sender, EventArgs e)
        {  try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                { 
                    _imageTileControl.BackColor = colorDialog1.Color;
                    tableLayoutPanel1.BackColor = colorDialog1.Color;
                    searchesleftlabel.BackColor = colorDialog1.Color;
                }
            }
            catch
            {
                throw;
            }
        }
       //Doesn't allows Anything Other value then Integer in CustomTextBox
        private void customTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        //Enable Search on Press Enter
        private void _searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _search_Click(this, new EventArgs());
            }
        }
    }
}
