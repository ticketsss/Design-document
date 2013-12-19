using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 汽车车票查询系统
{
    public partial class tuipiao : Form
    {
        public tuipiao()
        {
            InitializeComponent();
        }

        private void dengru_Click(object sender, EventArgs e)
        {
            try
            {
                SQLDataBase salbase = new SQLDataBase();
                //string ss = "server=LENOVO-BF57670C;database=购票;Integrated Security=True";
                string sql = "DELETE  FROM 购票表 WHERE 用户姓名=('" + user.Text.ToString() + "')and 电话号码=('" + tel.Text.ToString() + "')and 班车车次=('" + times.Text.ToString() + "')";
                SqlConnection conn = salbase.GetCon();
                SqlCommand cmd = new SqlCommand(sql, conn);

                 exist= (int)cmd.ExecuteNonQuery();
                conn.Close();
                if (exist != 0)
                {
                }
                else
                {
                    MessageBox.Show("没有制定此票！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {

                Close();
            }
           
        }

        private void tuipiao_Load(object sender, EventArgs e)
        {

        }
    }
}
