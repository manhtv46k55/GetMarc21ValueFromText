using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMarc21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Chuỗi đầu vào dạng: $aH:$bBrandeis University, USA,$c2002$2Rtvskfsdfsffsdf$xOpfkjwefjwef
            string input = rtbInput.Text;
            Dictionary<char, string> result = GetValuesFromInput(input);
            string strResulr = "";
            foreach (var item in result)
            {
                strResulr += $"${item.Key} = {item.Value}" + "\n";
            }
            rtbResult.Text = strResulr;
        }

        /// <summary>
        /// Hàm lấy giá trị của Marc21. Xác định Subfield và lấy giá trị trong chuỗi.
        /// </summary>
        /// <param name="input">Chuỗi đầu vào dạng: $aH:$bBrandeis University, USA,$c2002$2Rtvskfsdfsffsdf$xOpfkjwefjwef</param>
        /// <returns>Kết quả trả về là Dictionary: Key - Value</returns>
        /// For Dic ra để lấy Key - Value
        public static Dictionary<char, string> GetValuesFromInput(string input)
        {
            Dictionary<char, string> values = new Dictionary<char, string>();
            Regex regex = new Regex(@"\$([a-zA-Z0-9])([^$]*)");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                char key = match.Groups[1].Value[0];
                string value = match.Groups[2].Value;

                string newValue = $"{value}";
                values[key] = newValue;
            }

            return values;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<string> input = new List<string>()
        {
            "$aHoàng Mạnh",
            "$aVăn Mạnh",
            "$aMinh Quang",
            "$eTác giả",
            "$e Chủ biên",
            "$hKKK",
            "$gôpd"
        };
            string strResult = "";
            List<string> output = GetFormattedLines(input);

            for (int i = 0; i < output.Count; i++)
            {
                strResult += output[i] + "\n";
            }
            rtbResult2.Text = strResult;
        }

        public static List<string> GetFormattedLines(List<string> input)
        {
            List<string> lines = new List<string>();

            Dictionary<char, string> keyValues = new Dictionary<char, string>()
        {
            {'a', ""},
            {'e', ""},
            {'h', ""},
            {'g', ""}
        };

            foreach (string fragment in input)
            {
                if (fragment.Length >= 2 && fragment[0] == '$')
                {
                    char key = fragment[1];
                    string value = fragment.Substring(2);

                    if (keyValues.ContainsKey(key))
                    {
                        keyValues[key] += value;
                    }
                    else
                    {
                        keyValues.Add(key, value);
                    }
                }
            }

            var sortedKeyValues = keyValues.OrderBy(kv => kv.Key);

            string line = "";
            foreach (KeyValuePair<char, string> pair in sortedKeyValues)
            {
                string fragment = $"${pair.Key}{pair.Value}";
                line += fragment + " ";
            }

            lines.Add(line.Trim());

            foreach (string fragment in input)
            {
                if (fragment.Length >= 1 && fragment[0] == '$' && !keyValues.ContainsKey(fragment[1]))
                {
                    lines.Add(fragment);
                }
            }

            return lines;
        }
    }
}
