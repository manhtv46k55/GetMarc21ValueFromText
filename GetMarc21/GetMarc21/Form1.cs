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
    }
}
