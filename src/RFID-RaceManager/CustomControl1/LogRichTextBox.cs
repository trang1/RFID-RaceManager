using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class LogRichTextBox : RichTextBox
    {
        public LogRichTextBox()
        {
            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            Select(TextLength, 0);
            ScrollToCaret();
        }

        public void AppendTextEx(string strText, Color clAppend)
        {
            int nLen = TextLength;

            if (nLen != 0)
            {
                AppendText(Environment.NewLine + System.DateTime.Now.ToString() + " " + strText);
            }
            else
            {
                AppendText(System.DateTime.Now.ToString() + " " + strText);
            }

            Select(nLen, TextLength - nLen);
            SelectionColor = clAppend;
        }
    }
}
