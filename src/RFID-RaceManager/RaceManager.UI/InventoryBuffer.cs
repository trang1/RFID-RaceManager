using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace RaceManager.UI
{
    class InventoryBuffer
    {
        public byte btRepeat;
        public byte btSession;
        public byte btTarget;
        public List<byte> lAntenna;
        public bool bLoopInventory;
        public int nIndexAntenna;
        public int nCommond;
        public bool bLoopInventoryReal;
        public bool bLoopCustomizedSession;
        
        public int nTagCount;
        public int nDataCount; //The returned record number of tags when executing a command
        public int nCommandDuration;
        public int nReadRate;
        public int nCurrentAnt;
        public List<int> lTotalRead;
        public DateTime dtStartInventory;
        public DateTime dtEndInventory;
        public int nMaxRSSI;
        public int nMinRSSI;
        public DataTable dtTagTable;
        public DataTable dtTagDetailTable;
        public DataRow drLastTag; // Last read tag

        public InventoryBuffer()
        {
            btRepeat = 0x00;
            lAntenna = new List<byte>();
            bLoopInventory = false;
            nIndexAntenna = 0;
            nCommond = 0;
            bLoopInventoryReal = false;

            nTagCount = 0;
            nReadRate = 0;
            lTotalRead = new List<int>();
            dtStartInventory = DateTime.Now;
            dtEndInventory = DateTime.Now;
            nMaxRSSI = 0;
            nMinRSSI = 0;

            dtTagTable = new DataTable();
            dtTagTable.Columns.Add("COLPC", typeof(string));
            dtTagTable.Columns.Add("COLCRC", typeof(string));
            dtTagTable.Columns.Add("COLEPC", typeof(string));
            dtTagTable.Columns.Add("COLANT", typeof(string));
            dtTagTable.Columns.Add("COLRSSI", typeof(string));
            dtTagTable.Columns.Add("COLINVCNT", typeof(string));
            dtTagTable.Columns.Add("COLFREQ", typeof(string));
            dtTagTable.Columns.Add("COLANT1", typeof(string));
            dtTagTable.Columns.Add("COLANT2", typeof(string));
            dtTagTable.Columns.Add("COLANT3", typeof(string));
            dtTagTable.Columns.Add("COLANT4", typeof(string));

            dtTagDetailTable = new DataTable();
            dtTagDetailTable.Columns.Add("COLEPC", typeof(string));
            dtTagDetailTable.Columns.Add("COLRSSI", typeof(string));
            dtTagDetailTable.Columns.Add("COLANT", typeof(string));
            dtTagDetailTable.Columns.Add("COLFRE", typeof(string));
        }

        public void ClearInventoryPar()
        {
            btRepeat = 0x00;
            lAntenna.Clear();
            //bLoopInventory = false;
            nIndexAntenna = 0;
            nCommond = 0;
            bLoopInventoryReal = false;
        }

        public void ClearInventoryResult()
        {
            nTagCount = 0;
            nReadRate = 0;
            lTotalRead.Clear();
            dtStartInventory = DateTime.Now;
            dtEndInventory = DateTime.Now;
            nMaxRSSI = 0;
            nMinRSSI = 0;
            dtTagTable.Rows.Clear();
            drLastTag = null;
        }

        public void ClearInventoryRealResult()
        {
            nTagCount = 0;
            nReadRate = 0;
            lTotalRead.Clear();
            dtStartInventory = DateTime.Now;
            dtEndInventory = DateTime.Now;
            nMaxRSSI = 0;
            nMinRSSI = 0;
            dtTagTable.Rows.Clear();
            dtTagDetailTable.Clear();
            drLastTag = null;
        }
    }
}
