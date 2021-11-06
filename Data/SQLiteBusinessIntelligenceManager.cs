﻿using PanaderiaIkigai.Models.BI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Data
{
    public class SQLiteBusinessIntelligenceManager
    {
        public string GetConnectionString(string name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<ClientSpending> GetTopClientByAmountSpent(string pType, DateTime pStartDate, DateTime pEndDate)
        {

            try
            {
                var list = new List<ClientSpending>();
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    string commandText = "";
                    if(pType.Equals("HIGHEST"))
                        commandText = "SELECT CLIENT_CODE, CLIENT_NAME, TOTAL(ORDER_TOTAL) AS TOTAL_AMOUNT FROM CLIENT_ORDER_HISTORY " +
                            "WHERE ORDER_PURCHASE_DATE BETWEEN $pStartDate AND $pEndDate GROUP BY CLIENT_CODE, CLIENT_NAME ORDER BY TOTAL(ORDER_TOTAL) DESC LIMIT 10";
                    else
                        commandText = "SELECT CLIENT_CODE, CLIENT_NAME, TOTAL(ORDER_TOTAL) FROM CLIENT_ORDER_HISTORY " +
                            "WHERE ORDER_PURCHASE_DATE BETWEEN $pStartDate AND $pEndDate GROUP BY CLIENT_CODE, CLIENT_NAME ORDER BY TOTAL(ORDER_TOTAL) ASC LIMIT 10";
                    command.CommandText = commandText;
                    command.Parameters.AddWithValue("pStartDate", pStartDate.Date);
                    command.Parameters.AddWithValue("pEndDate", pEndDate.Date);
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ClientSpending(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2)));
                    }
                    return list;
                }
            }
            catch(SQLiteException sqlEx)
            {
                throw sqlEx;
            }
        }

        public List<ClientSpending> GetTopClientByUnitsPurchased(string pType, DateTime pStartDate, DateTime pEndDate)
        {

            try
            {
                var list = new List<ClientSpending>();
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    string commandText = "";
                    if (pType.Equals("HIGHEST"))
                        commandText = "SELECT CLIENT_CODE, CLIENT_NAME, TOTAL(UNITS_PURCHASED) AS TOTAL_AMOUNT FROM CLIENT_ORDER_HISTORY " +
                            "WHERE ORDER_PURCHASE_DATE BETWEEN $pStartDate AND $pEndDate GROUP BY CLIENT_CODE, CLIENT_NAME ORDER BY TOTAL(UNITS_PURCHASED) DESC LIMIT 10";
                    else
                        commandText = "SELECT CLIENT_CODE, CLIENT_NAME, TOTAL(UNITS_PURCHASED) FROM CLIENT_ORDER_HISTORY " +
                            "WHERE ORDER_PURCHASE_DATE BETWEEN $pStartDate AND $pEndDate GROUP BY CLIENT_CODE, CLIENT_NAME ORDER BY TOTAL(UNITS_PURCHASED) ASC LIMIT 10";
                    command.CommandText = commandText;
                    command.Parameters.AddWithValue("pStartDate", pStartDate.Date);
                    command.Parameters.AddWithValue("pEndDate", pEndDate.Date);
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ClientSpending(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2)));
                    }
                    return list;
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
        }

        public List<ProductPopularity> GetProductPopularity(string pMode, string pCriteria, DateTime pStartDate, DateTime pEndDate)
        {
            try
            {
                var list = new List<ProductPopularity>();
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    var criteria = pCriteria.Equals("REVENUE") ? "TOTAL(UNITS_PURCHASED) AS TOTAL_AMOUNT FROM CLIENT_ORDER_HISTORY " : "COUNT(*) AS TOTAL_AMOUNT FROM CLIENT_ORDER_HISTORY ";
                    string commandText = "";
                    if (pMode.Equals("HIGHEST"))
                        
                        commandText = "SELECT RECIPE_NAME, " + criteria +
                            " WHERE ORDER_PURCHASE_DATE BETWEEN $pStartDate AND $pEndDate GROUP BY RECIPE_NAME ORDER BY TOTAL_AMOUNT DESC LIMIT 10";
                    else
                        commandText = "SELECT RECIPE_NAME, " + criteria +
                            " WHERE ORDER_PURCHASE_DATE BETWEEN $pStartDate AND $pEndDate GROUP BY RECIPE_NAME ORDER BY TOTAL_AMOUNT ASC LIMIT 10";
                    command.CommandText = commandText;
                    command.Parameters.AddWithValue("pStartDate", pStartDate.Date);
                    command.Parameters.AddWithValue("pEndDate", pEndDate.Date);
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ProductPopularity(reader.GetString(0), reader.GetDecimal(1)));
                    }
                    return list;
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
        }

        public List<ProductPopularity> GetProductEvolution(DateTime pStartDate, DateTime pEndDate)
        {
            try
            {
                var list = new List<ProductPopularity>();

                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    var commandText = "SELECT A.NAME AS RECIPE_NAME, C.ORDER_DATE, SUM(B.UNITS_IN_ITEM) FROM RECIPE A INNER JOIN ORDER_ITEM B ON A.CODE = B.RECIPE_CODE INNER JOIN ORDER_BASE C ON B.ORDER_CODE = C.CODE WHERE C.ORDER_DATE BETWEEN '2021-01-01' AND '2021-12-31' AND RECIPE_NAME IN(SELECT DISTINCT RECI_NAME FROM (SELECT X.NAME AS RECI_NAME, SUM(Y.UNITS_IN_ITEM) AS UNITS_SOLD FROM RECIPE X INNER JOIN ORDER_ITEM Y ON X.CODE = Y.RECIPE_CODE GROUP BY X.NAME ORDER BY UNITS_SOLD DESC) Z) GROUP BY RECIPE_NAME, C.ORDER_DATE ORDER BY C.ORDER_DATE ASC; "; 


                    command.CommandText = commandText;
                    command.Parameters.AddWithValue("pStartDate", pStartDate.Date);
                    command.Parameters.AddWithValue("pEndDate", pEndDate.Date);
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ProductPopularity(reader.GetString(0), reader.GetDecimal(2), reader.GetDateTime(1).Date));
                    }
                    return list;
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
        }

        public List<ProductPopularity> GetOrderTotal(DateTime pStartDate, DateTime pEndDate)
        {
            try
            {
                var list = new List<ProductPopularity>();
                
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    var commandText = "SELECT ORDER_CODE, ORDER_PURCHASE_DATE, TOTAL(ORDER_TOTAL) " +
                        "FROM CLIENT_ORDER_HISTORY WHERE ORDER_PURCHASE_DATE BETWEEN $pStartDate AND $pEndDate GROUP BY ORDER_CODE, ORDER_PURCHASE_DATE ORDER BY ORDER_PURCHASE_DATE ASC LIMIT 10";
                    command.CommandText = commandText;
                    command.Parameters.AddWithValue("pStartDate", pStartDate.Date);
                    command.Parameters.AddWithValue("pEndDate", pEndDate.Date);
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ProductPopularity(reader.GetInt32(0), reader.GetDateTime(1).Date, reader.GetDecimal(2)));
                    }
                    return list;
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
        }
    }
}
