﻿//MIT 2015, brezza27, EngineKit and contributors

using System;
using System.Collections.Generic;
using SharpConnect.MySql;

namespace MySqlTest
{


    public class TestSet3_AsyncSocket : MySqlTestSet
    {
        [Test]
        public static void T_AsyncSocket1()
        {
            var connStr = GetMySqlConnString();
            var conn = new MySqlConnectionAsync(connStr);
            conn.Open(() =>
            {

                //do something 
                //close
                conn.Close(() =>
                {


                });
            });
        }
    }
}