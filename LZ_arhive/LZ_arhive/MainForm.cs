using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZ_arhive
{
    public partial class MainForm : Form
    {
        private Stream _stream;

        private OpenFileDialog _openFileDialog;

        private readonly string _path;

        public MainForm()
        {
            InitializeComponent();
            _path = Directory.GetCurrentDirectory();
            PathLabel.Text = @"Path : " + _path;
        }

        /// <summary>
        /// Открваем файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileButton(object sender, EventArgs e)
        {
            
            _openFileDialog = new OpenFileDialog
            {
                Filter =@"Microsoft databases (*.mdb)|*.mdb|Microsoft document (*.doc)|*.doc",
                InitialDirectory = _path,
                
            };

            if (_openFileDialog.ShowDialog() != DialogResult.OK) return;

            var filename = _openFileDialog.SafeFileName;
            NameBox1.Text = filename;
            PathLabel.Text = @"Path : " + _openFileDialog.FileName;
            StartButton.Enabled = true;

        }

        /// <summary>
        /// Начинаем обработку по кнопке старт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((_stream = _openFileDialog.OpenFile()) != null)
                {
                    using (_stream)
                    {
                       var byteFile =  _stream.ReadByte();
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: Could't read file from disk.");
            }

        }

        /// <summary>
        /// Выходим
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Действия при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_stream == null) return;
            _stream.Close();
            _stream.Dispose();
        }

        private void OpenUnzipButton_Click(object sender, EventArgs e)
        {
            var _openFileDialog = new OpenFileDialog
            {
                Filter = @"Archive files (*.nikast)|*.nikastdoc",
                InitialDirectory = _path,

            };

            if (_openFileDialog.ShowDialog() != DialogResult.OK) return;

            var filename = _openFileDialog.SafeFileName;
            NameBox1.Text = filename;
            PathLabel.Text = @"Path : " + _openFileDialog.FileName;
        }


    }
}
