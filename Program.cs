// PERSON 7 - Person7_ReceiptAndCashierMenu.cs
// Laman: ParseSavedMoney, ShowReceipt, ShowAllOrderIds, CashierView (may Delete sales history option na)
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace RestaurantOrderSystem
{
    partial class Program
    {
        // ============================= RECEIPT =============================
        static decimal ParseSavedMoney(string text)
        {
            decimal.TryParse(text, NumberStyles.AllowDecimalPoint, Inv, out decimal value);
            return value;
        }

        static void ShowReceipt(List<string[]> rows)
        {
            string[] first = rows[0];

            Console.WriteLine();
            Console.WriteLine("========== RECEIPT ==========");
            Console.WriteLine("Restaurant: " + RestaurantName);
            Console.WriteLine("Order ID  : " + first[0]);
            Console.WriteLine("Status    : " + first[1]);
            Console.WriteLine("-----------------------------");
            foreach (string[] row in rows)
            {
                Console.WriteLine(row[2]);
                Console.WriteLine("   " + FormatMoney(ParseSavedMoney(row[3])) + " x " + row[4]
                    + " = " + FormatMoney(ParseSavedMoney(row[5])));
            }
  
