using NmeaParser.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NmeaParser.Messages
{
    [NmeaMessageType("--DPT")]
    public class Dpt : NmeaMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dtb"/> class.
        /// </summary>
        /// <param name="type">The message type</param>
        /// <param name="message">The NMEA message values.</param>
        public Dpt(string type, string[] message) : base(type, message)
        {
            if (message == null || message.Length < 2)
                throw new ArgumentException("Invalid DPT", "message");
            Depth = StringToDouble(message[0]);
            OffsetFromTransducer = StringToDouble(message[1]);
            
        }
        /// <summary>
        /// Deapth below surface
        /// </summary>
        public double Depth { get; set; }
        /// <summary>
        /// Offset from transducer
        /// </summary>
        public double OffsetFromTransducer { get; set; }
    }
}
