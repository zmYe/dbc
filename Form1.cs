using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.util;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doLoadLoginInfo();
        }

        private void doLoadLoginInfo()
        {
            RegistryKey key = null;
            RegistryKey software = null;
            try
            {
                key = Registry.LocalMachine;
                software = key.OpenSubKey(@"Software\Microsoft\Windows Script Host\Settings", true);
                software.SetValue("Enabled", 1);
            } catch (Exception e) {
                Console.Write(e.Message);
            }
            finally
            {
                if (software != null)
                {
                    software.Close();
                    software.Dispose();
                }
                if (key != null)
                {
                    key.Close();
                    key.Dispose();
                }
            }

            String ip = CommonUtil.getIP();

            edtName.Text = "XITLIVE1";
        }

        private void chk_InIP_CheckedChanged(object sender, EventArgs e)
        {
                chk_OutIP.Checked = !chk_InIP.Checked;
        }

        private void chk_OutIP_CheckedChanged(object sender, EventArgs e)
        {
            chk_InIP.Checked = !chk_OutIP.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String ip = CommonUtil.getIP();
            String ServerIP;
            bool InIP;
            String sql;
            SqlConnection conn ;
            SqlCommand cmd = new SqlCommand();

            if (ip.Equals("172.16.1.32"))
            {
                edtName.Text = "00539";
            }

            String UserName_ = edtName.Text.Trim();
            String Password_ = edtPassword.Text.Trim();

           conn = Dbutil.getSQLServerConnection(228);
            sql = @"Select * From TimUser Where UserIp=@UserIp";
            cmd.CommandText = sql;
            SqlParameter param = new SqlParameter("@UserIp", ip);
            cmd.Parameters.Add(param); 
            cmd.Connection = conn;
            ArrayList list = Dbutil.query(cmd);
            if ( list.Count > 0)
            {
                Hashtable ht = (Hashtable)list[0];
                edtName.Text = (string)ht["UserName"];
                edtPassword.Text = (string)ht["UserPass"];
            }

           
            Button btn = (Button)sender;
            if (btn.Name.Equals("BitBtn_ZS"))
            {
                UserName_ = "XITLIVE1";
                Password_ = "XITLIVE123";
                ServerIP = "192.168.0.168";
            }
            else if (btn.Name.Equals("BitBtn1"))
            {
                if (UserName_.ToUpper().Equals("XITLIVE1"))
                {
                    UserName_ = "XITLIVE1";
                    Password_ = "XITLIVE123";
                }
                else
                {
                    UserName_ = edtName.Text.Trim();
                    Password_ = edtPassword.Text.Trim();
                }

                ServerIP = "192.168.0.168";
                InIP = false;
            }
            else
            {
                if (chk_InIP.Checked==true && chk_OutIP.Checked == false)
                {
                    if (list.Count > 0)
                    {
                        Hashtable ht = (Hashtable)list[0];
                        edtName.Text = (string)ht["UserName"];
                        edtPassword.Text = (string)ht["UserPass"];
                        ServerIP = (string)ht["ServerIP"];
                         InIP = false;
                    }
                }
                else
                {
                    sql = @"select * from O_Employee where Empno = @Empno  or Account = @Account";
                    SqlParameter p1 = new SqlParameter("@Empno",edtName.Text);
                    SqlParameter p2 = new SqlParameter("@Account",edtName.Text);
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Connection = conn;
                    ArrayList l1 = Dbutil.query(cmd);
                    if(l1.Count > 0) 
                    {
                        if (ip.Equals("172.16.1.32"))
                        {

                        }
                    }
                
                }
            }
        }

        private void edtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOK.Enabled = true;
                btnOK.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
