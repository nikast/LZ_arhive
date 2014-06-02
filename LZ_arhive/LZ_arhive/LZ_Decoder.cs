using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LZ_arhive
{
    /// <summary>
    /// Класс для декомпрессии.
    /// </summary>
    public class LzDecoder
    {
        /// <summary>
        /// Входяшая строка
        /// </summary>
        private readonly string _inString;

        /// <summary>
        /// Длина двоичного кода
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

        public LzDecoder(IEnumerable<byte> input, ProgressBar bar)
        {
            _progressBar = bar;
            _codeLength = 8;
            var sb = new StringBuilder();
            _stringBuilder = new StringBuilder();
            _dictionary = new Dictionary<string, int>();
            
            foreach (var item in input)
                sb.Append(Convert.ToString(item, 2).Zero(_codeLength) );
            
            _inString = sb.ToString();

            for (var i = 0; i < 256; i++)
                _dictionary.Add(System.Text.ASCIIEncoding.Default.GetString(new byte[1] { Convert.ToByte(i) }), i);

        }

        /// <summary>
        /// Метод декодирования.
        /// </summary>
        /// <returns></returns>
        public string Decoder()
        {
            _progressBar.Minimum = 0;

            _progressBar.Maximum = _inString.Length;

            _progressBar.Step = _codeLength;

            var counter = 0;

            var prevValue = -1;

            while (counter < _inString.Length)
            {
                _progressBar.Step = _codeLength;
                _progressBar.PerformStep();
                var w = "";
                if (counter + 8 + _codeLength <= _inString.Length)
                {
                    w = _inString.Substring(counter, _codeLength);
                }
                else if (counter + _codeLength <= _inString.Length)
                {
                    var encodedLen = counter + _codeLength;
                    var trimBitsLen = _inString.Length - encodedLen;
                    w = _inString.Substring(counter, _codeLength - (8 - trimBitsLen)) + _inString.Substring(_inString.Length - (8 - trimBitsLen), (8 - trimBitsLen));
                }
                else
                {
                    break;
                }
                counter += _codeLength;
                var value = Convert.ToInt32(w, 2);
                var key = _dictionary.FindKey(value);
                var prevKey = _dictionary.FindKey(prevValue) ?? "";
                if (key == null)
                {
                    key = prevKey;
                    _stringBuilder.Append(prevKey + key.Substring(0, 1));
                }
                else
                {
                    _stringBuilder.Append(key);
                }
                var finalKey = prevKey + key.Substring(0, 1);

                if (_dictionary.ContainsKey(finalKey) == false)
                {
                    _dictionary[finalKey] = _dictionary.Count;
                }
                if (Convert.ToString(_dictionary.Count, 2).Length > _codeLength)
                    _codeLength++;

                prevValue = value;
            }
            return _stringBuilder.ToString();
        }

    }
}
