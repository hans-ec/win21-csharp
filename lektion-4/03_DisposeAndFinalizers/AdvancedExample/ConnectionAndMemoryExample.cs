using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_DisposeAndFinalizers.AdvancedExample
{
    internal class ConnectionAndMemoryExample : IDisposable
    {
        private static readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\EC\WIN21\csharp\lektion-4\03_DisposeAndFinalizers\Data\db.mdf;Integrated Security=True";
        public static long TotalFreeMemory {get; set;}
        public static long TotalAllocatedMemory { get; set; }

        SqlConnection conn;
        IntPtr chunkHandle;
        int chunkSize;
        bool isFreed;

        public ConnectionAndMemoryExample(int chunkSize)
        {
            conn = new SqlConnection(_connectionString);
            conn.Open();

            this.chunkSize = chunkSize;
            chunkHandle = Marshal.AllocHGlobal(chunkSize);
            TotalAllocatedMemory += chunkSize;
        }

        //Finalizer
        ~ConnectionAndMemoryExample()
        {
            Dispose(false);
        }


        public void DoWork()
        {
            Console.WriteLine("Doing some work...");
        }

        private void FreeChunk()
        {
            if (isFreed)
                return;

            Marshal.FreeHGlobal(chunkHandle);
            TotalFreeMemory += chunkSize;
            isFreed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                //conn.Close();
                conn.Dispose();
                conn = null;
            }

            FreeChunk();
        }
    }
}
