using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        private readonly StringBuilder _stringBuilder;

        /// <summary>
        /// Словарь
        /// </summary>
        private readonly Dictionary<string, int> _dictionary;

        public LzCoder(string input)
        {
            _codeLength = 8;
            _inString = input;
            _stringBuilder = new StringBuilder();
            _dictionary = new Dictionary<string, int>();
             for (var i = 0; i < 256; i++)
                 _dictionary.Add(System.Text.Encoding.Default.GetString(new byte[1] { Convert.ToByte(i) }), i);
        }

        /// <summary>
        /// Процесс сжатия данных по алгоритму LZ
        /// </summary>
        /// <returns></returns>
        public List<byte> ProcessZip()
        {
            _stringBuilder.Clear();
            
            var counter = 0;

            while (counter < _inString.Length)
            {
                var w = _inString[counter].ToString();
                counter++;

                while (_dictionary.ContainsKey(w) && counter < _inString.Length)
                {
                    w += _inString[counter];
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
