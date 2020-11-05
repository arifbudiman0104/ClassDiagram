using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Transaksi
    {
        public int id_transaksi
        {
            get => default;
            set
            {
            }
        }

        public int id_customer
        {
            get => default;
            set
            {
            }
        }

        public int id_produk
        {
            get => default;
            set
            {
            }
        }

        public int id_admin
        {
            get => default;
            set
            {
            }
        }

        public int total_transaksi
        {
            get => default;
            set
            {
            }
        }

        public Admin Admin
        {
            get => default;
            set
            {
            }
        }

        public Customer Customer
        {
            get => default;
            set
            {
            }
        }

        public Produk Produk
        {
            get => default;
            set
            {
            }
        }

        public void insert_transaksi()
        {
            throw new System.NotImplementedException();
        }

        public void delete_transaksi()
        {
            throw new System.NotImplementedException();
        }

        public void edit_transaksi()
        {
            throw new System.NotImplementedException();
        }

        public void view_transaksi()
        {
            throw new System.NotImplementedException();
        }
    }
}