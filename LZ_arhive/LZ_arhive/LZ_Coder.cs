using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LZ_arhive
{
    /// <summary>
    /// Класс отвечает за кодирование информации.
    /// </summary>
    internal class LzCoder
    {
        /// <summary>
        /// Входящая строка
        /// </summary>
        private readonly string _inString;

        /// <summary>
        /// Длина двочного кода
        /// </summary>
        private int _codeLength;

        /// <summary>
        /// Билдер строк
        /// </summary>
        private readonly StringBuilder _stringBuilder;

        /// <summary>
        /// Бар
        /// </summary>
        private readonly ProgressBar _progressBar;

        /// <summary>
        /// Словарь
        /// </summary>
        private readonly Dictionary<string, int> _dictionary;

        public LzCoder(string input, ProgressBar bar)
        {
            _progressBar = bar;
            _codeLength = 8;
            _inString = input;
            _stringBuilder = new StringBuilder();
            _dictionary = new Dictionary<string, int>();
             for (var i = 0; i < 256; i++)
                 _dictionary.Add(System.Text.ASCIIEncoding.Default.GetString(new byte[1] { Convert.ToByte(i) }), i);
        }

        /// <summary>
        /// Процесс сжатия данных по алгоритму LZ
        /// </summary>
        /// <returns></returns>
        public List<byte> ProcessZip()
        {
            _stringBuilder.Clear();

            _progressBar.Minimum = 0;

            _progressBar.Maximum = _inString.Length;
           
            _progressBar.Step = 1;
            
            var counter = 0;

            while (counter < _inString.Length)
            {
               

                var w = _inString[counter].ToString();
                _progressBar.PerformStep();
                counter++;

                while (_dictionary.ContainsKey(w) && counter < _inString.Length)
                {
                    w += _inString[counter];
                    _progressBar.PerformStep();
                    counter++;
                }

                if (_dictionary.ContainsKey(w) == false)
                {
                    var matchKey = w.Substring(0, w.Length - 1);

                    _stringBuilder.Append(Convert.ToString(_dictionary[matchKey], 2).Zero(_codeLength));

                    if (Convert.ToString(_dictionary.Count, 2).Length > _codeLength)
                        _codeLength++;

                    _dictionary.Add(w, _dictionary.Count);
                    counter--;
                }
                else
                {
                    _stringBuilder.Append(Convert.ToString(_dictionary[w], 2).Zero(_codeLength));

                    if (Convert.ToString(_dictionary.Count, 2).Length > _codeLength)
                        _codeLength++;
                }
            }

            return _stringBuilder.ToString().ToByteArray();
        }
    }
}
