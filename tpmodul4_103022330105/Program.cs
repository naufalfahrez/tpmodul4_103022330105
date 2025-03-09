// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class KodePos
{
    private static readonly Dictionary<string, string> kodePosMap = new Dictionary<string, string>
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

    public static string GetKodePos(string kelurahan)
    {
        return kodePosMap.TryGetValue(kelurahan, out string kodePos) ? kodePos : "Kode pos tidak ditemukan";
    }

    class DoorMachine
    {
        enum State
        {
            LOCKED,
            UNLOCKED,
            OPEN
        }

        private State currentState;

        public DoorMachine()
        {
            currentState = State.LOCKED;
        }

        public void Unlock()
        {
            if (currentState == State.LOCKED)
            {
                currentState = State.UNLOCKED;
                Console.WriteLine("Pintu telah tidak terkunci.");
            }
            else
            {
                Console.WriteLine("Pintu sudah dalam keadaan tidak terkunci.");
            }
        }

        public void Open()
        {
            if (currentState == State.UNLOCKED)
            {
                currentState = State.OPEN;
                Console.WriteLine("Pintu terbuka.");
            }
            else if (currentState == State.LOCKED)
            {
                Console.WriteLine("Pintu masih terkunci! Tidak bisa dibuka.");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka.");
            }
        }

        public void Close()
        {
            if (currentState == State.OPEN)
            {
                currentState = State.UNLOCKED;
                Console.WriteLine("Pintu ditutup.");
            }
            else
            {
                Console.WriteLine("Pintu sudah dalam keadaan tertutup.");
            }
        }

        public void Lock()
        {
            if (currentState == State.UNLOCKED)
            {
                currentState = State.LOCKED;
                Console.WriteLine("Pintu dikunci.");
            }
            else if (currentState == State.OPEN)
            {
                Console.WriteLine("Tutup pintu terlebih dahulu sebelum mengunci.");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci.");
            }
        }
    }
        public static void Main()
    {
        Console.WriteLine("Kode Pos Batununggal: " + GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari: " + GetKodePos("Kujangsari"));
        Console.WriteLine("Kode Pos Mengger: " + GetKodePos("Mengger"));
        Console.WriteLine("Kode Pos Wates: " + GetKodePos("Wates"));
        Console.WriteLine("Kode Pos Cijarua: " + GetKodePos("Cijaura"));
        Console.WriteLine("Kode Pos Jatisari: " + GetKodePos("Jatisari"));
        Console.WriteLine("Kode Pos Margasari: " + GetKodePos("Margasari"));
        Console.WriteLine("Kode Pos Sekejati: " + GetKodePos("Sekejati"));
        Console.WriteLine("Kode Pos Kebonwaru: " + GetKodePos("Kebonwaru"));
        Console.WriteLine("Kode Pos Maleer: " + GetKodePos("Maleer"));
        Console.WriteLine("Kode Pos Samoja: " + GetKodePos("Samoja"));

        DoorMachine door = new DoorMachine();
        door.Unlock();
        door.Open();
        door.Close();
        door.Lock();
        }
}
