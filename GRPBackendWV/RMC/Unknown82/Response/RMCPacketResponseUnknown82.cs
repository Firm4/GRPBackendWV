﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPBackendWV
{
    public class RMCPacketResponseUnknown82 : RMCPacketReply
    {
        public override byte[] ToBuffer()
        {
            return new byte[0];
        }

        public override string ToString()
        {
            return "[RMCPacketResponseUnknown82]";
        }
    }
}
