﻿// Copyright © Jason Curl 2012-2021
// Sources at https://github.com/jcurl/SerialPortStream
// Licensed under the Microsoft Public License (Ms-PL)

namespace RJCP.IO.Ports
{
    using Diagnostics.Trace;

    internal static class Log
    {
        public const string SerialPortStream = "RJCP.IO.Ports.SerialPortStream";

        public static readonly LogSource Serial = new LogSource(SerialPortStream);
    }
}
