﻿using System;
using System.Net.Sockets;

namespace ProgLib.Network.Tcp
{
    public class TcpReceiverEventArgs : EventArgs
    {
        public TcpReceiverEventArgs(Socket Socket, Byte[] Buffer, Int32 Length)
        {
            this.Socket = Socket;
            this.Buffer = Buffer;
            this.Length = Length;
        }

        /// <summary>
        /// Клиентский Socket
        /// </summary>
        public Socket Socket { get; }

        /// <summary>
        /// Переданные байты
        /// </summary>
        public Byte[] Buffer { get; }

        /// <summary>
        /// Количество переданных байт
        /// </summary>
        public Int32 Length { get; }
    }
}
