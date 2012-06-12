using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;


namespace leihao.PCPC.Interface
{
    [Serializable()]
    public class ProcessList //: IXmlSerializable
    {
        public ProcessList()
        {
            string Caption;
            int CreatingProcessID;
            string Description;
            int ElapsedTime;
            int Frequency_Object;
            int Frequency_PerfTime;
            int Frequency_Sys100NS;
            int HandleCount;
            int IDProcess;
            int IODataBytesPerSec;
            int IODataOperationsPerSec;
            int IOOtherBytesPerSec;
            int IOOtherOperationsPerSec;
            int IOReadBytesPerSec;
            int IOReadOperationsPerSec;
            int IOWriteBytesPerSec;
            int IOWriteOperationsPerSec;
            string Name;
            int PageFaultsPerSec;
            int PageFileBytes;
            int PageFileBytesPeak;
            int PercentPrivilegedTime;
            int PercentProcessorTime;
            int PercentUserTime;
            int PoolNonpagedBytes;
            int PoolPagedBytes;
            int PriorityBase;
            int PrivateBytes;
            int ThreadCount;
            int Timestamp_Object;
            int Timestamp_PerfTime;
            int Timestamp_Sys100NS;
            int VirtualBytes;
            int VirtualBytesPeak;
            int WorkingSet;
            int WorkingSetPeak;
        }
    }
}
