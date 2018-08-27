using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace RaceManager.UI
{
    class OperateTagISO18000Buffer
    {
        public DataTable dtTagTable;
        public byte btAntId;
        public int nTagCnt;
        public string strReadData;
        public byte btWriteLength;
        public byte btStatus;

        public OperateTagISO18000Buffer()
        {
            btAntId = 0xFF;
            nTagCnt = 0;
            strReadData = string.Empty;
            btWriteLength = 0x00;
            btStatus = 0x00;

            dtTagTable = new DataTable();
            dtTagTable.Columns.Add("ANTID", typeof(string));
            dtTagTable.Columns.Add("UID", typeof(string));
            dtTagTable.Columns.Add("TOTAL", typeof(string));
            dtTagTable.Columns.Add("STARTADD", typeof(string));
            dtTagTable.Columns.Add("LENGTH", typeof(string));
            dtTagTable.Columns.Add("DATA", typeof(string));
            dtTagTable.Columns.Add("STATUS", typeof(string));
        }

        public void ClearBuffer()
        {
            btAntId = 0xFF;
            nTagCnt = 0;
            strReadData = string.Empty;
            btWriteLength = 0x00;
            btStatus = 0x00;

            dtTagTable.Clear();
        }
    }
}
