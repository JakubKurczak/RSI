using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace cw7
{
    public partial class Form1 : Form
    {
        TextBox id;
        TextBox title;
        TextBox author;
        TextBox year;
        TextBox price;
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Form form = new Form
            {
                Text = "Dodaj książkę",
                Width = 500,
                Height = 500,
            };
             id = new TextBox();
             title = new TextBox();
             author = new TextBox();
             year = new TextBox();
             price = new TextBox();
            Button send = new Button();
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            id.Dock = System.Windows.Forms.DockStyle.Fill;
            id.Name = "id";
            id.Size = new System.Drawing.Size(72, 40);
            id.Text = "5";

            title.Dock = System.Windows.Forms.DockStyle.Fill;
            title.Name = "title";
            title.Size = new System.Drawing.Size(72, 40);
            title.Text = "test";


            author.Dock = System.Windows.Forms.DockStyle.Fill;
            author.Name = "author";
            author.Size = new System.Drawing.Size(72, 40);
            author.Text = "test";

            year.Dock = System.Windows.Forms.DockStyle.Fill;
            year.Name = "year";
            year.Size = new System.Drawing.Size(72, 40);
            year.Text = "2003";

            price.Dock = System.Windows.Forms.DockStyle.Fill;
            price.Name = "price";
            price.Size = new System.Drawing.Size(72, 40);
            price.Text = "23,23";

            send.Dock = System.Windows.Forms.DockStyle.Fill;
            send.Name = "send";
            send.Size = new System.Drawing.Size(72, 72);
            send.Text = "Dodaj książkę";
            send.Click += new EventHandler(this.sendBook);

            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel.Controls.Add(id, 0, 0);
            tableLayoutPanel.Controls.Add(title, 0, 1);
            tableLayoutPanel.Controls.Add(author, 0, 2);
            tableLayoutPanel.Controls.Add(year, 0, 3);
            tableLayoutPanel.Controls.Add(price, 0, 4);
            tableLayoutPanel.Controls.Add(send, 0, 5);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 7;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel.Size = new System.Drawing.Size(500, 500);
            tableLayoutPanel.TabIndex = 6;

            form.Controls.Add(tableLayoutPanel);
            // show form in dialog box
            form.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Form form = new Form
            {
                Text = "Zaktualizuj książkę",
                Width = 500,
                Height = 500,
            };
            id = new TextBox();
            title = new TextBox();
            author = new TextBox();
            year = new TextBox();
            price = new TextBox();
            Button send = new Button();
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            id.Dock = System.Windows.Forms.DockStyle.Fill;
            id.Name = "id";
            id.Size = new System.Drawing.Size(72, 40);
            id.Text = "5";

            title.Dock = System.Windows.Forms.DockStyle.Fill;
            title.Name = "title";
            title.Size = new System.Drawing.Size(72, 40);
            title.Text = "test";


            author.Dock = System.Windows.Forms.DockStyle.Fill;
            author.Name = "author";
            author.Size = new System.Drawing.Size(72, 40);
            author.Text = "test";

            year.Dock = System.Windows.Forms.DockStyle.Fill;
            year.Name = "year";
            year.Size = new System.Drawing.Size(72, 40);
            year.Text = "2003";

            price.Dock = System.Windows.Forms.DockStyle.Fill;
            price.Name = "price";
            price.Size = new System.Drawing.Size(72, 40);
            price.Text = "23,23";

            send.Dock = System.Windows.Forms.DockStyle.Fill;
            send.Name = "send";
            send.Size = new System.Drawing.Size(72, 72);
            send.Text = "Zaktualizuj książkę";
            send.Click += new EventHandler(this.updateBook);

            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel.Controls.Add(id, 0, 0);
            tableLayoutPanel.Controls.Add(title, 0, 1);
            tableLayoutPanel.Controls.Add(author, 0, 2);
            tableLayoutPanel.Controls.Add(year, 0, 3);
            tableLayoutPanel.Controls.Add(price, 0, 4);
            tableLayoutPanel.Controls.Add(send, 0, 5);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 7;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel.Size = new System.Drawing.Size(500, 500);
            tableLayoutPanel.TabIndex = 6;

            form.Controls.Add(tableLayoutPanel);
            // show form in dialog box
            form.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Form form = new Form
            {
                Text = "Usuń książkę",
                Width = 500,
                Height = 500,
            };
            id = new TextBox();
            Button delete = new Button();
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            id.Dock = System.Windows.Forms.DockStyle.Fill;
            id.Name = "id";
            id.Size = new System.Drawing.Size(72, 40);
            id.Text = "wpisz id";

            delete.Dock = System.Windows.Forms.DockStyle.Fill;
            delete.Name = "delete";
            delete.Size = new System.Drawing.Size(72, 72);
            delete.Text = "Usuń książkę";
            delete.Click += new EventHandler(this.deleteBook);

            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel.Controls.Add(id, 0, 0);
            tableLayoutPanel.Controls.Add(delete, 0, 1);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 7;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel.Size = new System.Drawing.Size(500, 500);
            tableLayoutPanel.TabIndex = 6;

            form.Controls.Add(tableLayoutPanel);
            // show form in dialog box
            form.ShowDialog();
        }


        private void showButton_Click(object sender, EventArgs e)
        {
            string format = this.format.Text;

            HttpWebRequest req;
            if (format == "XML")
            {
                req = WebRequest.Create("http://rsi01.wega0.net.ii.pwr.wroc.pl/Service1.svc/Books") as HttpWebRequest;
                req.ContentType = "text/xml";
            }
            else 
            {
                req = WebRequest.Create("http://rsi01.wega0.net.ii.pwr.wroc.pl/Service1.svc/Json/Books") as HttpWebRequest;
                req.ContentType = "application/json";
            }
            req.KeepAlive = false;
            req.Method = "GET";

            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            //przekodowanie tekstu odpowiedzi: 
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Encoding enc = System.Text.Encoding.GetEncoding(1252);
            StreamReader responseStream = new StreamReader(resp.GetResponseStream(), enc);
            string responseString = responseStream.ReadToEnd();
            responseStream.Close();
            resp.Close();



            Form form = new Form
            {
                Text = "Pokaż książki",
                Width = 500,
                Height = 500,
            };

            TextBox books = new TextBox();

            
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            books.Dock = System.Windows.Forms.DockStyle.Fill;
            books.Name = "id";
            books.Size = new System.Drawing.Size(72, 40);
            XDocument formatter = XDocument.Parse(responseString);
            books.Text = formatter.ToString();
            books.Multiline = true;
            books.ScrollBars = ScrollBars.Vertical;

            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel.Controls.Add(books, 0, 0);

            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel.Size = new System.Drawing.Size(500, 500);
            tableLayoutPanel.TabIndex = 6;

            form.Controls.Add(tableLayoutPanel);
            // show form in dialog box
            form.ShowDialog();
        }


        public void sendBook(object sender, EventArgs e)
        {
            string format = this.format.Text;


            HttpWebRequest req;
            Stream postData;

            Book book = new Book(Int32.Parse(this.id.Text), this.title.Text, this.author.Text, Int32.Parse(this.year.Text), Double.Parse(this.price.Text));

            if (format == "XML")
            {
                req = WebRequest.Create("http://rsi01.wega0.net.ii.pwr.wroc.pl/Service1.svc/Books") as HttpWebRequest;
                req.KeepAlive = false;
                req.Method = "POST";
                postData = req.GetRequestStream();
                req.ContentType = "text/xml";
                XmlSerializer ser = new XmlSerializer(typeof(Book), "http://schemas.datacontract.org/2004/07/MyWebService");
                ser.Serialize(postData, book);
            }
            else
            {
                req = WebRequest.Create("http://rsi01.wega0.net.ii.pwr.wroc.pl/Service1.svc/Json/Books") as HttpWebRequest;
                req.KeepAlive = false;
                req.Method = "POST";
                postData = req.GetRequestStream();
                req.ContentType = "application/json";
                var stringBook = JsonSerializer.Serialize(book);
                byte[] bufor = Encoding.UTF8.GetBytes(stringBook);
                req.ContentLength = bufor.Length;
                postData.Write(bufor, 0, bufor.Length);
            }

            postData.Close();
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            //przekodowanie tekstu odpowiedzi: 
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Encoding enc = System.Text.Encoding.GetEncoding(1252);
            StreamReader responseStream = new StreamReader(resp.GetResponseStream(), enc);
            string responseString = responseStream.ReadToEnd();
            responseStream.Close();
            resp.Close();
            MessageBox.Show(responseString);
        }

        public void updateBook(object sender, EventArgs e)
        {
            string format = this.format.Text;


            HttpWebRequest req;
            Stream postData;

            Book book = new Book(Int32.Parse(this.id.Text), this.title.Text, this.author.Text, Int32.Parse(this.year.Text), Double.Parse(this.price.Text));

            if (format == "XML")
            {
                req = WebRequest.Create("http://rsi01.wega0.net.ii.pwr.wroc.pl/Service1.svc/Books/" + this.id.Text) as HttpWebRequest;
                req.KeepAlive = false;
                req.Method = "PUT";
                postData = req.GetRequestStream();
                req.ContentType = "text/xml";
                XmlSerializer ser = new XmlSerializer(typeof(Book), "http://schemas.datacontract.org/2004/07/MyWebService/");
                ser.Serialize(postData, book);
            }
            else
            {
                req = WebRequest.Create("http://rsi01.wega0.net.ii.pwr.wroc.pl/Service1.svc/Json/Books/" + this.id.Text) as HttpWebRequest;
                req.KeepAlive = false;
                req.Method = "PUT";
                postData = req.GetRequestStream();
                req.ContentType = "application/json";
                var stringBook = JsonSerializer.Serialize(book);
                byte[] bufor = Encoding.UTF8.GetBytes(stringBook);
                req.ContentLength = bufor.Length;
                postData.Write(bufor, 0, bufor.Length);
            }

            postData.Close();
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            //przekodowanie tekstu odpowiedzi: 
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Encoding enc = System.Text.Encoding.GetEncoding(1252);
            StreamReader responseStream = new StreamReader(resp.GetResponseStream(), enc);
            string responseString = responseStream.ReadToEnd();
            responseStream.Close();
            resp.Close();
            MessageBox.Show(responseString);
        }

        public void deleteBook(object sender, EventArgs e)
        {
            string format = this.format.Text;

            HttpWebRequest req;
            if (format == "XML")
            {
                req = WebRequest.Create("http://rsi01.wega0.net.ii.pwr.wroc.pl/Service1.svc/Books/" + this.id.Text) as HttpWebRequest;
                req.KeepAlive = false;
                req.Method = "DELETE";
                req.ContentType = "text/xml";
            }
            else
            {
                req = WebRequest.Create("http://rsi01.wega0.net.ii.pwr.wroc.pl/Service1.svc/Json/Books/" + this.id.Text) as HttpWebRequest;
                req.KeepAlive = false;
                req.Method = "DELETE";
                req.ContentType = "application/json";
            }

            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            //przekodowanie tekstu odpowiedzi: 
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Encoding enc = System.Text.Encoding.GetEncoding(1252);
            StreamReader responseStream = new StreamReader(resp.GetResponseStream(), enc);
            string responseString = responseStream.ReadToEnd();
            responseStream.Close();
            resp.Close();
            MessageBox.Show(responseString);
        }

    }
    
}
