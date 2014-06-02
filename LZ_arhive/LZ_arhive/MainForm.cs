using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LZ_arhive
{
    /// <summary>
    /// Основная форма программы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Диалог открытия файла
        /// </summary>
        private OpenFileDialog _openFile;

        /// <summary>
        /// Диалог открытия архива
        /// </summary>
        private OpenFileDialog _openFileZip;

        /// <summary>
        /// Путь
        /// </summary>
        private readonly string _path;

        public MainForm()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            _path = Directory.GetCurrentDirectory();
            PathLabel.Text = @"Path : " + _path;
            PathLabelUnzip.Text = @"Path : " + _path;
        }

        /// <summary>
        /// Открваем файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileButton(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "";
            _openFile = new OpenFileDialog
            {
                Filter = @"Microsoft databases (*.mdb)|*.mdb|Microsoft document (*.doc)|*.doc",
                InitialDirectory = _path,
            };
            if (_openFile.ShowDialog() != DialogResult.OK) return;
            var filename = _openFile.SafeFileName;
            NameBox1.Text = filename;
            PathLabel.Text = @"Path : " + _openFile.FileName;
            StartButton.Enabled = true;

        }

        /// <summary>
        /// Кликнули по кнопке сжать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = new StreamReader(_openFile.FileName);

                var list = new List<byte>();

                using (reader)
                {
                    var currentByte = reader.BaseStream.ReadByte();
                    while (currentByte > -1)
                    {
                        list.Add((byte)currentByte);
                        currentByte = reader.BaseStream.ReadByte();
                    }
                }

                var encoder = new LzCoder(File.ReadAllText(_openFile.FileName, System.Text.ASCIIEncoding.Default), ZipBar);

                File.WriteAllBytes(_openFile.FileName + ".nikast", encoder.ProcessZip().ToArray());

                this.toolStripStatusLabel1.Text = @"Сжатие выполнено...";

                StartButton.Enabled = false;

                NameBox1.Text = "";

                ZipBar.Value = 0;
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = @"В процессе выполнения обнаружены ошибки.";
                MessageBox.Show(@"Processing error. Reason is : " + ex.Message);
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
            // Если понадобится что-то сделать при закрытии.
        }


        /// <summary>
        /// Диалог выбора файла для распаковки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenUnzipButton_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "";
            _openFileZip = new OpenFileDialog
            {
                Filter = @"Archive files (*.nikast)|*.nikast",
                InitialDirectory = _path,
            };
            if (_openFileZip.ShowDialog() != DialogResult.OK) return;
            var filename = _openFileZip.SafeFileName;
            NameBoxUnzip.Text = filename;
            PathLabelUnzip.Text = @"Path : " + _openFileZip.FileName;
            UnZip.Enabled = true;
        }

        /// <summary>
        /// Кнопка распаковать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnZip_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = new StreamReader(_openFileZip.FileName);

                var list = new List<byte>();

                using (reader)
                {
                    var currentByte = reader.BaseStream.ReadByte();
                    while (currentByte > -1)
                    {
                        list.Add((byte)currentByte);
                        currentByte = reader.BaseStream.ReadByte();
                    }
                }
                var decoder = new LzDecoder(list, UnzipBar);

                File.WriteAllText(_openFileZip.FileName.Replace(".nikast", ""), decoder.Decoder(), System.Text.Encoding.Default);

                this.toolStripStatusLabel1.Text = @"Распаковка выполнена...";

                UnZip.Enabled = false;

                NameBoxUnzip.Text = "";

                UnzipBar.Value = 0;
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = @"В процессе выполнения обнаружены ошибки.";
                MessageBox.Show(@"Processing error. Reason is : " + ex.Message);
            }
        }
    }
}
