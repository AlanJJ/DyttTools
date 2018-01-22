using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace dytt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str_url = text_url.Text;
            if (string.IsNullOrWhiteSpace(str_url))
            {
                IDataObject iData = Clipboard.GetDataObject();
                // Determines whether the data is in a format you can use.
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    // Yes it is, so display it in a text box.
                    text_url.Text = (String)iData.GetData(DataFormats.Text);
                    str_url = text_url.Text;
                }
            }

            var rgx = @"(https?|http)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]";
            MatchCollection mc = Regex.Matches(str_url, rgx);
            if (mc.Count == 0)
            {
                text_url.Text = "";
                return;
            }
          
            var html = SimpleHttpHelper.Get(str_url).Data.ToString();
            var doc = new HtmlAgilityPack.HtmlDocument();
            // var trs = doc.DocumentNode.SelectNodes(@"");
            HtmlNode node = null;
            HtmlNodeCollection nodes = null;
            HtmlAttribute atr = null;
            //获取所有数据节点tr
            var index = 0;
            List<string> list = new List<string>();
            while (index < html.Length)
            {
                var index1 = html.IndexOf("ftp://", index);
                var index2 = html.IndexOf(".rmvb", index);
                var index3 = html.IndexOf(".mkv", index);
                if (index1 == -1)
                {
                    break;
                }
                if (index2!=-1)
                {
                    var item = (html.Substring(index1, index2 + ".rmvb".Length - index1));
                    index = index2 + ".rmvb".Length;
                    list.Add(item);
                    continue;
                }
                if (index3!=-1)
                {
                    var item = (html.Substring(index1, index3 + ".mkv".Length - index1));
                    index = index3 + ".mkv".Length;
                    list.Add(item);
                    continue;
                }
            }
            var str = "";
            foreach (var item in list.Distinct())
            {
                str = str + item + "\n";
            }
            show.Text = str;
            text_url.Text = "";
            Clipboard.SetDataObject(str);
        }
    }
}
