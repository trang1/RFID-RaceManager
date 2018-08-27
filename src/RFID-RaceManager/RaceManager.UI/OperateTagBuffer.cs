using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace RaceManager.UI
{
    class OperateTagBuffer
    {
        public string strAccessEpcMatch;
        public DataTable dtTagTable;

        public OperateTagBuffer()
        {
            strAccessEpcMatch = string.Empty;
            dtTagTable = new DataTable();
            dtTagTable.Columns.Add("COLPC", typeof(string));
            dtTagTable.Columns.Add("COLCRC", typeof(string));
            dtTagTable.Columns.Add("COLEPC", typeof(string));
            dtTagTable.Columns.Add("COLDATA", typeof(string));
            dtTagTable.Columns.Add("COLDATALENGTH", typeof(string));
            dtTagTable.Columns.Add("COLANT", typeof(string));
            dtTagTable.Columns.Add("COLINVCNT", typeof(string)); 
        }
    }
}
