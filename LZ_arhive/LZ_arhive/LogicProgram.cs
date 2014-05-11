using System;
using System.IO;

namespace LZ_arhive
{

    /// <summary>
    /// Класс описывающий логику программы.
    /// </summary>
    public class LogicProgram
    {
        private const int BUFFERSIZE = 256;

        private Stream _stream;

        private int[] _buffer; 

        public LogicProgram(Stream stream)
        {
            _stream = stream;
            _buffer = new int[BUFFERSIZE];
            Logic();
        }

        /// <summary>
        /// Метод логики программы
        /// </summary>
        private void Logic()
        {
            while (ReadFileOnByte())
            {

            }

        }

        /// <summary>
        /// Побайтовое чтение файла.
        /// </summary>
        private bool ReadFileOnByte()
        {
            var count = 0;
                do
                {
                    _buffer[count] = _stream.ReadByte();
                    count++;
                    if (_buffer[count - 1] > -1)
                        return false;
                } while (count - 1 != BUFFERSIZE);

            return true;
        }

    }
}