using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoImporter.Serializers;

namespace MongoImporter
{
    public partial class MainWindow : Form
    {
        private string _path = "";
        private Importer _importer;
        private readonly BindingList<string> _fieldNames;
        private bool _importing = false;

        public MainWindow()
        {
            _fieldNames = new BindingList<string>();
            InitializeComponent();
            fieldsListBox.DataSource = _fieldNames;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _importer = new Importer(new MongoClient());
            batchSizeBox.Text = 100.ToString();
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            _path = openFileDialog.FileName;
            filePathLbl.Text = _path;
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            if (_importing) return;
            _importer.SetDatabase(databaseBox.Text);
            _importer.SetCollection(collectionBox.Text);
            _importer.Serializer = new DelimiterSerializer(delimiterBox.Text[0], _fieldNames);
            _importer.InputFile = filePathLbl.Text;
            _importer.BatchSize = Convert.ToInt32(batchSizeBox.Text);
            _importing = true;
            Task.Factory.StartNew(() => _importer.ReadFromFile())
                .ContinueWith((Task t) =>
                {
                    _importing = false;
                    Debug.WriteLine("Done importing");
                });

        }

        private void addFieldBtn_Click(object sender, EventArgs e)
        {
            _fieldNames.Add(fieldNameBox.Text);
            fieldNameBox.Text = string.Empty;
        }

        private void fieldNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addFieldBtn_Click(this, new EventArgs());
            }
        }
    }
}
