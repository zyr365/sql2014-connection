using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApplication9
{
    public partial class test1 : Form
    {
        public test1()
        {
            InitializeComponent();
        }
       //public SqlConnection conn = new SqlConnection(SqlHelper.conStr);
        // string str = "server=DESKTOP-3UCF97E\\SQLEXPRESS;database=db_15;uid=sa;pwd=a123456.";
        string str = "server=192.168.0.102;database=mysql;uid=sa;pwd=a123456";
        private void Form1_Load(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(str);
            // conn = new SqlConnection(str);
            conn.Open();


            if (conn.State == ConnectionState.Open)
                label1.Text = "数据库连接\n状态：成功";
            else
                label1.Text = "数据库连接\n状态：失败";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hello world");
        }
    }
}
