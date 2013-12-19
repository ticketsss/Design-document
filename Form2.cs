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
    public partial class Form2 : Form
    {
        public Form2()
        {
           
            InitializeComponent();
        }
        
        private void dengru_Click(object sender, EventArgs e)
        {
            SQLDataBase sqlBase = new SQLDataBase();
            SqlConnection conn = sqlBase.GetCon();
            try
            {
                if (user.Text.ToString() != "")
                {
                    
                    string sql = "insert into 购票表(用户姓名,电话号码,班车车次) values('" + user.Text.ToString() + "','" + tel.Text.ToString() + "','" + times.Text.ToString() + "')";
                   
                    
                    sqlBase.GetExecute(sql);
                }
                
                conn.Close();
               
                

            }
            catch
            {
                MessageBox.Show("您输入的信息有误");
            }
            finally
            { 
               Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
