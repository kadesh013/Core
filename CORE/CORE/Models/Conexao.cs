﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.CompilerServices;

namespace CORE.Models
{
    internal class Conexao
    {
        public void connect()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;database=db_core; password=");

        }





    }

}

