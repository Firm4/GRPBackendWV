﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPBackendWV
{
    public class RMCPacketResponseSkillsService_Method4 : RMCPacketReply
    {
        public override byte[] ToBuffer()
        {
            MemoryStream m = new MemoryStream();
            return m.ToArray();
        }

        public override string ToString()
        {
            return "[RMCPacketResponseSkillsService_Method4]";
        }
    }
}
